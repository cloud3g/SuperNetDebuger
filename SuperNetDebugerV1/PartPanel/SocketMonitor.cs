using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Net;
/*---------------作者：Maximus Ye----------------------*/
/*---------------时间：2013年9月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace LeafSoft.PartPanel
{
    public partial class SocketMonitor : BasePanel
    {
        Lib.SnifferSocket sniffer = new Lib.SnifferSocket();
        BindingList<Model.IPPacket> lstRecPacket = new BindingList<Model.IPPacket>();

        /// <summary>
        /// Socket通讯监视器
        /// </summary>
        public SocketMonitor()
        {
            InitializeComponent();
            cbxProtocol.SelectedIndex = 0;
            IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in ipHostEntry.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {//筛选IPV4
                    cbxServerIP.Items.Add(ip.ToString());
                }
            }
            if(cbxServerIP.Items.Count > 0)
            {
                cbxServerIP.SelectedIndex = 0;
                btnMonitor.Enabled = true;
            }
            dgPacket.AutoGenerateColumns = false;
            dgPacket.DataSource = lstRecPacket;
            sniffer.RecPacket += new Lib.LeafEvent.PacketReceived(sniffer_RecPacket);

            cbxProtocol.SelectedIndex = 0;
        }

        void sniffer_RecPacket(Model.IPPacket packet)
        {
            dgPacket.Invoke(new MethodInvoker(delegate
            {
                lstRecPacket.Insert(0,packet);
            }));
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if (sniffer.IsMonitor == false)
            {
                if (sniffer.Start(cbxServerIP.SelectedItem.ToString()))
                {
                    btnMonitor.Text = "停止";
                }
            }
            else
            {
                sniffer.Stop();
                btnMonitor.Text = "监视";
            }
        }

        private void dgPacket_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPacket.SelectedRows.Count > 0)
            {
                Model.IPPacket packet = lstRecPacket[dgPacket.SelectedRows[0].Index];
                string strCMD = "";
                foreach (byte b in packet.ReceiveBuffer)
                {
                    strCMD += string.Format("{0:X2} ", b);
                }
                txtData.Text = strCMD;
            }
        }

        public override void ClearSelf()
        {
            sniffer.Close();
        }

        #region 筛选条件变更
        /// <summary>
        /// 协议类型变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProtocol.SelectedIndex == 0)
            {
                sniffer.Protocol = "";
            }
            else
            {
                sniffer.Protocol = cbxProtocol.SelectedItem.ToString();
            }
        }
        private void nmSourcePort_ValueChanged(object sender, EventArgs e)
        {
            sniffer.SourcePort = (int)nmSourcePort.Value;
        }

        private void nmTargetPort_ValueChanged(object sender, EventArgs e)
        {
            sniffer.TargetPort = (int)nmTargetPort.Value;
        }
        #endregion

        private void MS_Clear_Click(object sender, EventArgs e)
        {
            lstRecPacket.Clear();
        }
    }
}
