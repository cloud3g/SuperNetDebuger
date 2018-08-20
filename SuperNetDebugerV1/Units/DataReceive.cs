using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
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
    /// 数据接收文本框
    /// </summary>
    public partial class DataReceive : UserControl
    {
        public DataReceive()
        {
            InitializeComponent();
        }

        #region 公有方法
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="data">字节数组</param>
        public void AddData(byte[] data)
        {
            switch(EncodeType)
            {
                case EnumType.DataEncode.Hex:
                    //16进制显示
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < data.Length; i++)
                    {
                        sb.AppendFormat("{0:x2}" + " ", data[i]);
                    }
                    AddContent(sb.ToString().ToUpper());
                    break;
                case EnumType.DataEncode.ASCII:
                    //ASCII码显示
                    AddContent(new ASCIIEncoding().GetString(data));
                    break;
                case EnumType.DataEncode.UTF8:
                    //UTF8显示
                    AddContent(new UTF8Encoding().GetString(data));
                    break;
                case EnumType.DataEncode.GB2312:
                    //GB2312显示
                    AddContent(Encoding.GetEncoding("GB2312").GetString(data));
                    break;
            }
            lblCount.Invoke(new MethodInvoker(delegate
            {
                lblCount.Text = (int.Parse(lblCount.Text) + data.Length).ToString();
            }));
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 添加文本内容
        /// </summary>
        /// <param name="content"></param>
        private void AddContent(string content)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                if (cbxAutoLine.Checked && txtData.Text.Length > 0)
                {
                    txtData.AppendText("\r\n");
                }
                txtData.AppendText(content);
            }));
        }
        private void lblCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblCount.Text = "0";
        }
        #endregion

        #region 数据编码格式
        private EnumType.DataEncode EncodeType = EnumType.DataEncode.Hex;

        private void rbtnUTF8_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUTF8.Checked)
            {
                EncodeType = EnumType.DataEncode.UTF8;
            }
        }

        private void rbtnGB2312_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGB2312.Checked)
            {
                EncodeType = EnumType.DataEncode.GB2312;
            }
        }

        private void rbtnASCII_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnASCII.Checked)
            {
                EncodeType = EnumType.DataEncode.ASCII;
            }
        }

        private void rbtnHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHex.Checked)
            {
                EncodeType = EnumType.DataEncode.Hex;
            }
        }
        #endregion

        #region 菜单事件
        private void MS_Clear_Click(object sender, EventArgs e)
        {
            txtData.Clear();
        }

        private void CMS_Main_VisibleChanged(object sender, EventArgs e)
        {
            if (CMS_Main.Visible == true)
            {//菜单被显示
                string[] SelectData = txtData.SelectedText.TrimEnd().TrimStart().Split(' ');//获取选中部分文本
                foreach (string data in SelectData)
                {
                    if (Regex.IsMatch(data, "^[0-9A-Fa-f]+$"))
                    {
                        continue;
                    }
                    else
                    {
                        MS_ToInt.Enabled = false;
                        MS_ToFloat.Enabled = false;
                        MS_ToDouble.Enabled = false;
                        return;
                    }
                }
                if (SelectData.Length == 2)
                {
                    MS_ToInt.Enabled = true;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = false;
                }
                else if (SelectData.Length == 4)
                {
                    MS_ToInt.Enabled = true;
                    MS_ToFloat.Enabled = true;
                    MS_ToDouble.Enabled = false;
                }
                else if (SelectData.Length == 8)
                {
                    MS_ToInt.Enabled = false;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = true;
                }
                else
                {
                    MS_ToInt.Enabled = false;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = false;
                }
            }
            else
            {
                MS_ToInt.Enabled = false;
                MS_ToFloat.Enabled = false;
                MS_ToDouble.Enabled = false;
            }
        }
        #endregion

        #region 数值转换
        /// <summary>
        /// 2字节或4字节转换为整数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_ToInt_Click(object sender, EventArgs e)
        {
            string[] SelectData = txtData.SelectedText.Trim().Split(' ');//获取选中部分文本
            byte[] IntByte = StringsToBytes(SelectData);
            if (IntByte.Length == 2)
            {
                MessageBox.Show(BitConverter.ToInt16(IntByte, 0).ToString(), "整数值");
            }
            else
            {
                MessageBox.Show(BitConverter.ToInt32(IntByte, 0).ToString(), "整数值");
            }
        }
        /// <summary>
        /// 4字节转换为单精度浮点数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_ToFloat_Click(object sender, EventArgs e)
        {
            string[] SelectData = txtData.SelectedText.Trim().Split(' ');//获取选中部分文本
            byte[] IntByte = StringsToBytes(SelectData);
            MessageBox.Show(BitConverter.ToSingle(IntByte, 0).ToString(), "单精度浮点数值");
        }
        /// <summary>
        /// 8字节转换为双精度浮点数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_ToDouble_Click(object sender, EventArgs e)
        {
            string[] SelectData = txtData.SelectedText.Trim().Split(' ');//获取选中部分文本
            byte[] IntByte = StringsToBytes(SelectData);
            MessageBox.Show(BitConverter.ToDouble(IntByte, 0).ToString(), "双精度浮点数值");
        }

        /// <summary>
        /// 16进制字符串数组转byte数组
        /// </summary>
        /// <param name="B"></param>
        /// <returns></returns>
        private byte[] StringsToBytes(string[] B)
        {
            byte[] BToInt32 = new byte[B.Length];
            for (int i = 0; i < B.Length; i++)
            {
                if (!string.IsNullOrEmpty(B[i]))
                {
                    BToInt32[i] = (byte)Convert.ToInt32(B[i], 16);
                }
            }
            return BToInt32;
        }
        #endregion
    }
}
