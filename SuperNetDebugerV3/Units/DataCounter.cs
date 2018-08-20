using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
/*---------------作者：叶知秋----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace LeafSoft.Units
{
    public partial class DataCounter : UserControl
    {
        public DataCounter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 清空计数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblSendCount.Text = "0";
            lblReceiveCount.Text = "0";
        }

        /// <summary>
        /// 累计发送字节数
        /// </summary>
        /// <param name="count">累加数</param>
        public void PlusSend(int count)
        {
            lblSendCount.Invoke(new MethodInvoker(delegate
            {
                lblSendCount.Text = (int.Parse(lblSendCount.Text) + count).ToString();
            }));
        }

        /// <summary>
        /// 累计接收字节数
        /// </summary>
        /// <param name="count">累加数</param>
        public void PlusReceive(int count)
        {
            lblReceiveCount.Invoke(new MethodInvoker(delegate
            {
                lblReceiveCount.Text = (int.Parse(lblReceiveCount.Text) + count).ToString();
            }));
        }
    }
}
