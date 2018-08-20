using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft
{
    public partial class frmLicense : Form
    {
        public frmLicense()
        {
            InitializeComponent();
        }

        private void lblLicense_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
