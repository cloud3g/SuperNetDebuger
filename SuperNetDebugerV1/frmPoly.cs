using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LeafSoft.Lib;

namespace LeafSoft
{
    public partial class frmPoly : Form
    {
        public ushort Poly = 0;

        public frmPoly()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            HotKey.UnregisterHotKey(Handle, 100);
            Model.CMD cmd = txtPoly.GetCMD();
            if (cmd != null)
            {
                byte[] bpoly = cmd.Bytes;
                if (bpoly.Length > 1)
                {
                    Poly = BitConverter.ToUInt16(bpoly, 0);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("请输入2个字节的多项式值！");
                }
            }
            txtPoly.Focus();
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.None, Keys.Enter);
        }

        private void frmPoly_Activated(object sender, EventArgs e)
        {
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.None, Keys.Enter);
        }

        private void frmPoly_Leave(object sender, EventArgs e)
        {
            HotKey.UnregisterHotKey(Handle, 100);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;//如果m.Msg的值为0x0312那么表示用户按下了热键
            //按快捷键 
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    if (m.WParam.ToInt32() == 100)
                    {
                        btnOK_Click(null, null);
                    }
                    break;
            }
            base.WndProc(ref m);
        }
    }
}
