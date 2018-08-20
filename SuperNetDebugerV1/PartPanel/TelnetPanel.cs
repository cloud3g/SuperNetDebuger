using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using LeafSoft.Model;
using System.Net;
using System.Collections;

namespace LeafSoft.PartPanel
{
    public partial class TelnetPanel : UserControl
    {
        LeafTCPClient client = new LeafTCPClient();

        #region 一些telnet 的数据定义
        /// <summary>   
        /// 标志符,代表是一个TELNET 指令   
        /// </summary>   
        readonly Char IAC = Convert.ToChar(255);
        /// <summary>   
        /// 表示一方要求另一方使用，或者确认你希望另一方使用指定的选项。   
        /// </summary>   
        readonly Char DO = Convert.ToChar(253);
        /// <summary>   
        /// 表示一方要求另一方停止使用，或者确认你不再希望另一方使用指定的选项。   
        /// </summary>   
        readonly Char DONT = Convert.ToChar(254);
        /// <summary>   
        /// 表示希望开始使用或者确认所使用的是指定的选项。   
        /// </summary>   
        readonly Char WILL = Convert.ToChar(251);
        /// <summary>   
        /// 表示拒绝使用或者继续使用指定的选项。   
        /// </summary>   
        readonly Char WONT = Convert.ToChar(252);
        /// <summary>   
        /// 表示后面所跟的是对需要的选项的子谈判   
        /// </summary>   
        readonly Char SB = Convert.ToChar(250);
        /// <summary>   
        /// 子谈判参数的结束   
        /// </summary>   
        readonly Char SE = Convert.ToChar(240);
        const Char IS = '0';
        const Char SEND = '1';
        const Char INFO = '2';
        const Char VAR = '0';
        const Char VALUE = '1';
        const Char ESC = '2';
        const Char USERVAR = '3';
        /// <summary>   
        /// 流   
        /// </summary>   
        byte[] m_byBuff = new byte[100000];
        /// <summary>   
        /// 收到的控制信息   
        /// </summary>   
        private ArrayList m_ListOptions = new ArrayList();
        /// <summary>   
        /// 存储准备发送的信息   
        /// </summary>   
        string m_strResp;
        /// <summary>   
        /// 一个Socket 套接字   
        /// </summary>   
        private Socket s;
        #endregion   

        /// <summary>   
        /// 解析接收的数据,生成最终用户看到的有效文字,同时将附带的参数存储起来   
        /// </summary>   
        /// <param name="m_strLineToProcess">收到的处理后的数据</param>   
        /// <returns></returns>   
        private string ProcessOptions(byte[] m_strLineToProcess)
        {
            string m_DISPLAYTEXT = "";
            string m_strTemp = "";
            string m_strOption = "";
            string m_strNormalText = "";
            bool bScanDone = false;
            int ndx = 0;
            int ldx = 0;
            char ch;
            try
            {
                //把数据从byte[] 转化成string   
                for (int i = 0; i < m_strLineToProcess.Length; i++)
                {
                    Char ss = Convert.ToChar(m_strLineToProcess[i]);
                    m_strTemp = m_strTemp + Convert.ToString(ss);
                }
                //此处意义为,当没描完数据前,执行扫描   
                while (bScanDone != true)
                {
                    //获得长度   
                    int lensmk = m_strTemp.Length;
                    //之后开始分析指令,因为每条指令为255 开头,故可以用此来区分出每条指令   
                    ndx = m_strTemp.IndexOf(Convert.ToString(IAC));
                    //此处为出错判断,本无其他含义   
                    if (ndx > lensmk)
                        ndx = m_strTemp.Length;
                    //此处为,如果搜寻到IAC 标记的telnet 指令,则执行以下步骤   
                    if (ndx != -1)
                    {
                        #region 如果存在IAC 标志位
                        // 将标志位IAC 的字符赋值给最终显示文字   
                        m_DISPLAYTEXT += m_strTemp.Substring(0, ndx);
                        // 此处获得命令码   
                        ch = m_strTemp[ndx + 1];
                        //如果命令码是253(DO) 254(DONT) 521(WILL) 252(WONT) 的情况下   
                        if (ch == DO || ch == DONT || ch == WILL || ch == WONT)
                        {
                            //将以IAC 开头3个字符组成的整个命令存储起来   
                            m_strOption = m_strTemp.Substring(ndx, 3);
                            m_ListOptions.Add(m_strOption);
                            // 将标志位IAC 的字符赋值给最终显示文字   
                            m_DISPLAYTEXT += m_strTemp.Substring(0, ndx);
                            //将处理过的字符串删去   
                            string txt = m_strTemp.Substring(ndx + 3);
                            m_strTemp = txt;
                        }
                        //如果IAC 后面又跟了个IAC (255)   
                        else if (ch == IAC)
                        {
                            //则显示从输入的字符串头开始,到之前的IAC 结束   
                            m_DISPLAYTEXT = m_strTemp.Substring(0, ndx);
                            //之后将处理过的字符串排除出去   
                            m_strTemp = m_strTemp.Substring(ndx + 1);
                        }
                        //如果IAC 后面跟的是SB(250)   
                        else if (ch == SB)
                        {
                            m_DISPLAYTEXT = m_strTemp.Substring(0, ndx);
                            ldx = m_strTemp.IndexOf(Convert.ToString(SE));
                            m_strOption = m_strTemp.Substring(ndx, ldx);
                            m_ListOptions.Add(m_strOption);
                            m_strTemp = m_strTemp.Substring(ldx);
                        }
                        #endregion
                    }
                    //若字符串里已经没有IAC 标志位了   
                    else
                    {
                        //显示信息累加上m_strTemp 存储的字段   
                        m_DISPLAYTEXT = m_DISPLAYTEXT + m_strTemp;
                        bScanDone = true;
                    }
                }
                //输出人看到的信息   
                m_strNormalText = m_DISPLAYTEXT;
            }
            catch (Exception eP)
            {
                throw new Exception("解析传入的字符串错误:" + eP.Message);
            }
            return m_strNormalText;
        }  

        public TelnetPanel()
        {
            InitializeComponent();
            if (this.DesignMode == false)
            {
                IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in ipHostEntry.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {//筛选IPV4
                        txtServerIP.Text = ip.ToString();
                        break;
                    }
                }
            }
        }

        private bool txtCmd_DataSend(byte[] data)
        {
            try
            {
                client.NetWork.GetStream().Write(data, 0, data.Length);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            client.NetWork = new TcpClient();
            client.NetWork.Connect(txtServerIP.Text.Trim(), (int)nmServerPort.Value);//连接服务端
            client.NetWork.GetStream().BeginRead(client.buffer, 0, client.buffer.Length, new AsyncCallback(TCPCallBack), client);
        }

        /// <summary>
        /// 回调函数
        /// </summary>
        /// <param name="ar"></param>
        private void TCPCallBack(IAsyncResult ar)
        {
            LeafTCPClient client = (LeafTCPClient)ar.AsyncState;
            if (client.NetWork.Connected)
            {
                NetworkStream ns = client.NetWork.GetStream();
                byte[] recdata = new byte[ns.EndRead(ar)];
                Array.Copy(client.buffer, recdata, recdata.Length);
                if (recdata.Length > 0)
                {
                    txtCmd.Invoke(new MethodInvoker(delegate
                    {
                        txtCmd.AppendText(Encoding.GetEncoding("gb2312").GetString(recdata));
                    }));
                    ns.BeginRead(client.buffer, 0, client.buffer.Length, new AsyncCallback(TCPCallBack), client);
                }
                else
                {
                    client.DisConnect();
                }
            }
        }
    }
}
