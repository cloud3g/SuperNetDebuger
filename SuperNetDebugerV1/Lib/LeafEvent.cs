using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using LeafSoft.Model;
/*---------------作者：Maximus Ye----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace LeafSoft.Lib
{
    public class LeafEvent
    {
        /// <summary>
        /// 数据接收事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        public delegate void DataReceivedHandler(object sender,byte[] data);

        /// <summary>
        /// 发送数据事件
        /// </summary>
        /// <param name="data"></param>
        public delegate bool DataSendHandler(byte[] data);

        /// <summary>
        /// 捕获到IP数据包
        /// 作者：Maximus Ye
        /// 添加时间：2013年9月16日
        /// </summary>
        /// <param name="packet"></param>
        public delegate void PacketReceived(Model.IPPacket packet);
    }
}
