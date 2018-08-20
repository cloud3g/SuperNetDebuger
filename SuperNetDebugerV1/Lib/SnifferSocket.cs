using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Net;

/*---------------作者：Maximus Ye----------------------*/
/*---------------时间：2013年9月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace LeafSoft.Lib
{
    /// <summary>
    /// Socket监视
    /// </summary>
    public class SnifferSocket
    {
        private Socket socket = null;
        /// <summary>
        /// 数据接收缓存
        /// </summary>
        private byte[] rec_buffer;
        /// <summary>
        /// 数据包捕获事件
        /// </summary>
        public event LeafEvent.PacketReceived RecPacket;
        /// <summary>
        /// 监视器状态
        /// </summary>
        public bool IsMonitor = false;

        #region 监视筛选条件
        public string Protocol;
        public string SourceIP;
        public int SourcePort = 0;
        public string TargetIP;
        public int TargetPort = 0;
        #endregion

        public SnifferSocket()
        {
            rec_buffer = new byte[2048];
        }

        /// <summary>
        /// 开始监视
        /// </summary>
        /// <param name="IP"></param>
        public bool Start(string IP)
        {
            IsMonitor = true;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP);
            socket.Blocking = false;
            socket.Bind(new IPEndPoint(IPAddress.Parse(IP), 0));
            socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, 1);
            if (SetSocketOption() == true)
            {
                Recevice();
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 停止监视
        /// </summary>
        public void Stop()
        {
            if (socket != null)
            {
                socket.Shutdown(SocketShutdown.Both);
            }
            IsMonitor = false;
        }
        /// <summary>
        /// 关闭
        /// </summary>
        public void Close()
        {
            socket = null;
        }
        /// <summary>
        /// 接收数据
        /// </summary>
        private void Recevice()
        {
            try
            {
                socket.BeginReceive(rec_buffer, 0, rec_buffer.Length, SocketFlags.None, new AsyncCallback(CallReceive), this);
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// 设置监视
        /// </summary>
        /// <returns></returns>
        private bool SetSocketOption() 
        {
            try
            {
                socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, 1);
                byte[] data_in = new byte[4] { 1, 0, 0, 0 };
                byte[] data_out = new byte[4];
                int ret_code = socket.IOControl(-1744830463, data_in, data_out);
                ret_code = data_out[0] + data_out[1] + data_out[2] + data_out[3];
                return ret_code == 0;
            }
            catch (SocketException)
            {
                return false;
            }
        }
        /// <summary>
        /// 接收到数据包
        /// </summary>
        /// <param name="ar">异步操作状态接口参数</param>
        private void CallReceive(IAsyncResult ar)
        {
            try
            {
                if (socket != null)
                {
                    int rec_count = socket.EndReceive(ar);
                    Model.IPPacket packet = new Model.IPPacket();
                    switch (rec_buffer[9])
                    {
                        case 1: packet.Protocol = "ICMP";
                            break;
                        case 2: packet.Protocol = "IGMP";
                            break;
                        case 6: packet.Protocol = "TCP";
                            break;
                        case 17: packet.Protocol = "UDP";
                            break;
                        default: packet.Protocol = "UNKNOWN";
                            break;
                    }
                    if (string.IsNullOrEmpty(this.Protocol) || this.Protocol == packet.Protocol)
                    {
                        int totalLength = BitConverter.ToInt32(new byte[4] { rec_buffer[3], rec_buffer[2], 0, 0 }, 0);

                        byte[] sourceAddress = new byte[4];
                        Array.Copy(rec_buffer, 12, sourceAddress, 0, 4);
                        packet.SourceIP = new IPAddress(sourceAddress).ToString();
                        byte[] targetAddress = new byte[4];
                        Array.Copy(rec_buffer, 16, targetAddress, 0, 4);
                        packet.TargetIP = new IPAddress(targetAddress).ToString();
                        packet.SourcePort = BitConverter.ToInt32(new byte[4] { rec_buffer[21], rec_buffer[20], 0, 0 }, 0);
                        packet.TargetPort = BitConverter.ToInt32(new byte[4] { rec_buffer[23], rec_buffer[22], 0, 0 }, 0);
                        if ((this.SourcePort == 0 || this.SourcePort == packet.SourcePort) &&
                            (this.TargetPort == 0 || this.TargetPort == packet.TargetPort))
                        {
                            packet.ReceiveBuffer = new byte[totalLength];
                            Array.Copy(rec_buffer, 20, packet.ReceiveBuffer, 0, totalLength);
                            if (RecPacket != null)
                            {
                                RecPacket(packet);
                            }
                        }
                    }
                    Recevice();
                }
            }
            catch (Exception)
            { }
        }
    }
}
