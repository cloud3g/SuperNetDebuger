using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
/*---------------作者：Maximus Ye----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace LeafSoft.Units
{
    public class HexBox : TextBox
    {
        public HexBox()
        {
        }
        #region 输入控制
        protected override void OnTextChanged(EventArgs e)
        {
            this.Text = this.Text.TrimEnd().ToUpper();
            this.SelectionStart = this.Text.Length;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9')//数字0-9键   
                     || (e.KeyChar >= 'A' && e.KeyChar <= 'F')//字母A-F 
                     || (e.KeyChar >= 'a' && e.KeyChar <= 'f')//字母a-f 
                     || e.KeyChar == 0x08//退格键
                     || e.KeyChar == 0x03//拷贝
                     || e.KeyChar == 0x18)//剪切
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }
        #endregion
    }
}
