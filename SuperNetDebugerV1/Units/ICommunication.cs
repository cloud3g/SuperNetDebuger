using System;
using System.Collections.Generic;
using System.Text;
using LeafSoft.Lib;
/*---------------作者：Maximus Ye----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace LeafSoft.Units
{
    /// <summary>
    /// 通讯调试接口
    /// </summary>
    public interface ICommunication
    {
        /// <summary>
        /// 事件：接收数据
        /// </summary>
        event LeafEvent.DataReceivedHandler DataReceived;

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="data"></param>
        bool SendData(byte[] data);

        /// <summary>
        /// 清理通讯资源
        /// </summary>
        void ClearSelf();
    }
}
