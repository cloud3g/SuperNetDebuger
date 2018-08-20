using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using LeafSoft.Lib;
/*---------------作者：叶知秋----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace LeafSoft.LeafControl
{
    /// <summary>
    /// Hex/ASCII输入文本框
    /// 作者：一叶知秋
    /// 日期：2013年7月11日
    /// 可输入Hex，ASCII
    /// 可切换显示Hex与ASCII的输入文本框
    /// Hex输入时可自动每2个字符之间添加空格
    /// </summary>
    public class BytesBox:TextBox
    {
        public BytesBox()
        {
        }

        #region 属性
        EnumType.CMDType _IsHex = EnumType.CMDType.Hex;
        [Description("可设置Hex,ASCII"), Category("输入格式设置")]
        public EnumType.CMDType IsHex
        {
            set {
                _IsHex = value;
                if (_IsHex == EnumType.CMDType.ASCII)
                {//切换到ASCII格式
                    if (this.Text.Length > 0)
                    {
                        string[] HexStr = this.Text.Trim().Split(' ');
                        byte[] data = new byte[HexStr.Length];
                        for (int i = 0; i < HexStr.Length; i++)
                        {
                            data[i] = (byte)(Convert.ToInt32(HexStr[i], 16));
                        }
                        this.Text = new ASCIIEncoding().GetString(data);
                    }
                }
                else
                {//切换到Hex格式
                    if (this.Text.Length > 0)
                    {
                        byte[] data = new ASCIIEncoding().GetBytes(this.Text.Trim());
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < data.Length; i++)
                        {
                            sb.AppendFormat("{0:x2}", data[i]);
                        }
                        this.Text = sb.ToString();
                    }
                }
                this.SelectionStart = this.Text.Length;
            }
            get {
                return _IsHex;
            }
        }
        #endregion

        #region 输入控制
        protected override void OnTextChanged(EventArgs e)
        {
            if (_IsHex == EnumType.CMDType.Hex)
            {//Hex输入
                string Content = this.Text.Replace(" ", "");//获取去除空格后的字符内容
                int SpaceCount = Content.Length / 2;
                int StartIndex = 2;
                for (int i = 0; i < SpaceCount; i++)
                {
                    Content = Content.Insert(StartIndex, " ");
                    StartIndex = StartIndex + 3;
                }
                this.Text = Content.TrimEnd().ToUpper();
                this.SelectionStart = this.Text.Length;
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x08//退格键
                || e.KeyChar == 0x03//拷贝
                || e.KeyChar == 0x18//剪切
                )
            { 
                 e.Handled = false;
                    return;
            }

            if (e.KeyChar == 0x16)//粘贴
            {//粘贴前数据格式检查
                if (CheckPaste())
                {
                    e.Handled = false;
                    return;
                }
            }

            if (_IsHex == EnumType.CMDType.Hex)
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '9')//数字0-9键   
                     || (e.KeyChar >= 'A' && e.KeyChar <= 'F')//字母A-F 
                     || (e.KeyChar >= 'a' && e.KeyChar <= 'f')//字母a-f 
                     )
                {
                    e.Handled = false;
                    return;
                }
            }
            else
            {
                if ((e.KeyChar >= 0x20 && e.KeyChar <= 0x7E)
                     || e.KeyChar == 0x0D)//回车键
                {
                    e.Handled = false;
                    return;
                }
            }
            e.Handled = true;
        }

        /// <summary>
        /// 粘贴数据格式检查
        /// </summary>
        /// <returns></returns>
        private bool CheckPaste()
        {
            try
            {
                char[] PasteChar = Clipboard.GetDataObject().GetData(DataFormats.Text).ToString().ToCharArray();
                if (_IsHex == EnumType.CMDType.Hex)
                {
                    foreach (char data in PasteChar)
                    {
                        if (!((data >= '0' && data <= '9')//数字0-9键   
                         || (data >= 'A' && data <= 'F')//字母A-F 
                         || (data >= 'a' && data <= 'f')//字母a-f
                         || data == 0x20))//空格
                        {
                            MessageBox.Show("粘贴数据含有非法字符，只能包含数字0-9,大写英文字母A-F,小写英文字母a-f以及空格！", "非法的粘贴", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                else
                {
                    foreach (char data in PasteChar)
                    {
                        if (!((data >= 0x20 && data <= 0x7E)
                         || data == 0x0A
                         || data == 0x0D))//回车键
                        {
                            MessageBox.Show("粘贴数据含有非法字符，只能包含ASCII码字符！", "非法的粘贴", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 获取命令对象
        /// </summary>
        /// <returns></returns>
        public Model.CMD GetCMD()
        {
            try
            {
                Model.CMD Cmd;
                if (this.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("不允许内容为空！");
                    return null;
                }
                if (_IsHex == EnumType.CMDType.Hex)
                {//Hex
                    string[] HexStr = this.Text.Trim().Split(' ');
                    byte[] data = new byte[HexStr.Length];
                    for (int i = 0; i < HexStr.Length; i++)
                    {
                        data[i] = (byte)(Convert.ToInt32(HexStr[i], 16));
                    }
                    Cmd = new Model.CMD(EnumType.CMDType.Hex, data);
                }
                else
                { //ASCII
                     byte[] data = new ASCIIEncoding().GetBytes(this.Text.Trim());
                     Cmd = new Model.CMD(EnumType.CMDType.ASCII, data);
                }
                return Cmd;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// 设置命令对象
        /// </summary>
        /// <param name="Cmd"></param>
        public void SetCMD(Model.CMD Cmd)
        {
            try
            {
                this.IsHex = Cmd.ContentType;
                this.Text = Cmd.Text;
                this.SelectionStart = this.Text.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
