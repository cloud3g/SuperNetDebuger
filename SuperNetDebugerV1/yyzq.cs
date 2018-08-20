using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LeafSoft.LeafControl;
using System.Net;
using System.Threading;
using LeafSoft.Model;
using LeafSoft.PartPanel;

namespace LeafSoft
{
    public partial class yyzq : Form
    {
        frmCheck fc = new frmCheck();
        frmBytes fb = new frmBytes();

        public yyzq()
        {
            InitializeComponent();
            int GID = Guid.NewGuid().ToString().Length;
            fc.TopMost = true;
            fb.TopMost = true;
            this.Text = Lib.AppInfor.AssemblyTitle + "[v" + Lib.AppInfor.AssemblyVersion +"]["+ Lib.AppInfor.AssemblyCopyright + "]["+Lib.AppInfor.AssemblyCompany+"]";
        }

        #region 调试窗口
        private void CreateNewTest(object p,string title,Icon icon)
        {
            Form frm = new Form();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Icon = icon;
            frm.Controls.Add((Control)p);
            frm.Width = 800;
            frm.Height = 500;
            frm.ShowIcon = true;
            frm.Text = title;
            frm.FormClosing += new FormClosingEventHandler(frm_FormClosing);
            frm.Show();
        }

        void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm=(Form)sender;
            PartPanel.BasePanel bp = (PartPanel.BasePanel)frm.Controls[0];
            bp.ClearSelf();
        }

        private void MS_NewTCPServer_Click(object sender, EventArgs e)
        {
            TCPServerPanel nwin = new TCPServerPanel();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "TCP Server[" + DateTime.Now.ToString("HHmmss") + "]",Properties.Resources.tcp);
        }

        private void MS_NewTCPClient_Click(object sender, EventArgs e)
        {
            TCPClientPanel nwin = new TCPClientPanel();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "TCP Client[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.tcp);
        }

        private void MS_NewUDPServer_Click(object sender, EventArgs e)
        {
            UDPServerPanel nwin = new UDPServerPanel();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "UDP Server[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.udp);
        }

        private void MS_NewUDPClient_Click(object sender, EventArgs e)
        {
            UDPClientPanel nwin = new UDPClientPanel();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "UDP Client[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.udp);
        }

        private void MS_NewRs232_Click(object sender, EventArgs e)
        {
            ComPanel tp = new ComPanel();
            tp.Dock = DockStyle.Fill;
            CreateNewTest(tp, "串口[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.com);
        }
        #endregion

        #region 通信监视
        private void MS_SocketMonitor_Click(object sender, EventArgs e)
        {
            SocketMonitor nwin = new SocketMonitor();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "Socket通信监视器[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.monitor_socket_icon);
        }

        private void MS_COMMonitor_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 计算器
        private void MS_Check_Click(object sender, EventArgs e)
        {
            if (fc.IsDisposed == true)
            {
                fc = new frmCheck();
                fc.TopMost = true;
            }
            fc.Show();
        }

        private void MS_Bytes_Click(object sender, EventArgs e)
        {
            if (fb.IsDisposed==true)
            {
                fb = new frmBytes();
                fb.TopMost = true;
            }
            fb.Show();
        }
        #endregion

        #region 关于
        private void MSI_QQGroup_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject("83868794");//复制群号到粘贴板
                MessageBox.Show("群号已复制");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MSI_OpenSource_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://code.csdn.net/yeqi3000/supernetdebuger");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MSI_Blog_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://blog.csdn.net/sqqyq");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MSI_Web_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("www.yyzq.net/Index");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MSI_QQ_Click(object sender, EventArgs e)
        {
            try
            {
                string qq = "275623749";
                System.Diagnostics.Process.Start("tencent://message/?uin=" + qq + "&Site=通信调试工具&Menu=yes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MSI_Email_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:yq@yyzq.net");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MSI_SupportMe_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            try
            {
                System.Diagnostics.Process.Start("https://me.alipay.com/yeqi6688");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MSI_DevPlan_Click(object sender, EventArgs e)
        {
            new frmPlan().ShowDialog();
        }
        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_AboutMe_Click(object sender, EventArgs e)
        {
            new AboutMe().ShowDialog();
        }

        /// <summary>
        /// License
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MSI_License_Click(object sender, EventArgs e)
        {
            new frmLicense().ShowDialog();
        }
        #endregion

       
    }
}
