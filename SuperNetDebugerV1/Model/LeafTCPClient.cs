using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net;
/*---------------作者：Maximus Ye----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace LeafSoft.Model
{
    public class LeafTCPClient
    {
        /// <summary>
        /// 当前客户端名称
        /// </summary>
        private string _Name = "未定义";
        public string Name
        {
            get {
                return _Name;
            }
        }

        public void SetName()
        {
            if (_NetWork.Connected)
            {
                IPEndPoint iepR = (IPEndPoint)_NetWork.Client.RemoteEndPoint;
                IPEndPoint iepL = (IPEndPoint)_NetWork.Client.LocalEndPoint;
                _Name = iepL.Port + "->" + iepR.ToString();
            }
        }

        /// <summary>
        /// TCP客户端
        /// </summary>
        private TcpClient _NetWork = null;
        public TcpClient NetWork
        {
            get
            {
                return _NetWork;
            }
            set
            {
                _NetWork = value;
                SetName();
            }
        }


        /// <summary>
        /// 数据接收缓存区
        /// </summary>
        public byte[] buffer = new byte[2048];

        /// <summary>
        /// 断开客户端连接
        /// </summary>
        public void DisConnect()
        {
            try
            {
                if (_NetWork != null && _NetWork.Connected)
                {
                    NetworkStream ns = _NetWork.GetStream();
                    ns.Close();
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
