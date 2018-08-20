using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LeafSoft.Lib;
/*---------------作者：叶知秋----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace LeafSoft
{
    public partial class frmCMD : Form
    {
        public Model.CMD NewCMD = null;

        public frmCMD(Model.CMD cmd)
        {
            InitializeComponent();
            txtContent.SetCMD(cmd);
            if (txtContent.IsHex == EnumType.CMDType.ASCII)
            {
                CM_Type.Text = "切换到Hex";
                CM_Check.Visible = false;
            }
        }

        public frmCMD()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewCMD = txtContent.GetCMD();
            if (NewCMD != null)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #region 菜单操作
        /// <summary>
        /// 切换格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CM_Type_Click(object sender, EventArgs e)
        {
            if (txtContent.IsHex == EnumType.CMDType.ASCII)
            {
                txtContent.IsHex = EnumType.CMDType.Hex;
                CM_Type.Text = "切换到ASCII";
                CM_Check.Visible = true;
            }
            else
            {
                txtContent.IsHex = EnumType.CMDType.ASCII;
                CM_Type.Text = "切换到Hex";
                CM_Check.Visible = false;
            }
        }
        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CM_Clear_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
        }
        #endregion

        #region 校验码计算
        /// <summary>
        /// 校验和
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_CheckSum_Click(object sender, EventArgs e)
        {
            Model.CMD cmd=txtContent.GetCMD();
            if (cmd != null)
            {
                byte check = Lib.BytesCheck.GetXOR(cmd.Bytes);
                txtContent.AppendText(Convert.ToString(check, 16).PadLeft(2, '0'));
            }
        }

        /// <summary>
        /// Modbus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_CRC16_Click(object sender, EventArgs e)
        {
             Model.CMD cmd=txtContent.GetCMD();
             if (cmd != null)
             {
                 AppendToContent(Lib.BytesCheck.GetCRC16(cmd.Bytes, false));
             }
        }

        /// <summary>
        /// 多项式CRC16 高位在前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_CRCPolyH_Click(object sender, EventArgs e)
        {
            Model.CMD cmd=txtContent.GetCMD();
            if (cmd != null)
            {
                frmPoly fpoly = new frmPoly();
                if (fpoly.ShowDialog() == DialogResult.OK)
                {
                    AppendToContent(Lib.BytesCheck.GetCRC16ByPoly(cmd.Bytes,fpoly.Poly,true));
                }
            }
        }

        /// <summary>
        /// 多项式CRC16 低位在前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_CRCPolyL_Click(object sender, EventArgs e)
        {
             Model.CMD cmd=txtContent.GetCMD();
             if (cmd != null)
             {
                 frmPoly fpoly = new frmPoly();
                 if (fpoly.ShowDialog() == DialogResult.OK)
                 {
                     AppendToContent(Lib.BytesCheck.GetCRC16ByPoly(cmd.Bytes, fpoly.Poly, false));
                 }
             }
        }

        private void AppendToContent(byte[] check)
        {
            foreach (byte b in check)
            {
                txtContent.AppendText(string.Format("{0:X2}", b));
            }
        }
        #endregion
    }
}
