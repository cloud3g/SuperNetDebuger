using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
/*---------------作者：Maximus Ye----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace LeafSoft.Model
{
    public class LeafUDPClient
    {
        /// <summary>
        /// 名称
        /// </summary>
        private string _Name = "未定义";
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        IPEndPoint _ipLocalEndPoint;
        /// <summary>
        /// 本地终结点
        /// </summary>
        public IPEndPoint ipLocalEndPoint
        {
            get
            {
                return _ipLocalEndPoint;
            }
            set
            {
                _ipLocalEndPoint = value;
            }
        }

        /// <summary>
        /// UDP 客户端
        /// </summary>
        private UdpClient _NetWork = null;
        public UdpClient NetWork
        {
            get
            {
                return _NetWork;
            }
            set
            {
                _NetWork = value;
            }
        }

        /// <summary>
        /// 断开客户端连接
        /// </summary>
        public void Close()
        {
            try
            {
                if (_NetWork != null && _NetWork.Client.Connected)
                {
                    _NetWork.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
