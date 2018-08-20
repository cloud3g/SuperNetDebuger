using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace LeafSoft.LeafControl
{

    public partial class CMDTextBox : TextBox
    {
        public event Lib.LeafEvent.DataSendHandler DataSend;

        public CMDTextBox()
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
        }

        //private bool _IsEnterSend = false;
        //[Description("是否回车输出"), Category("扩展")]
        //public bool IsEnterSend
        //{
        //    get { return _IsEnterSend; }
        //    set { _IsEnterSend = value; }
        //}

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!this.ReadOnly)
            {
                if (this.SelectionStart != this.Text.Length)
                {
                    this.SelectionStart = this.Text.Length;
                }
                if (DataSend(new UTF8Encoding().GetBytes(e.KeyChar.ToString())) == false)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
