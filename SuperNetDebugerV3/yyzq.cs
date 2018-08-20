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
/*---------------作者：叶知秋----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/

namespace LeafSoft
{
    public partial class yyzq : Form
    {
        frmCheck fc = new frmCheck();
        frmBytes fb = new frmBytes();

        public yyzq()
        {
            InitializeComponent();
            fc.TopMost = true;
            fb.TopMost = true;
            this.Text = Lib.AppInfor.AssemblyTitle + "[v" + Lib.AppInfor.AssemblyVersion +"]["+ Lib.AppInfor.AssemblyCopyright + "][常州-Maximus]";
        }

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
            TCPServerPanel tp = new TCPServerPanel();
            tp.Dock = DockStyle.Fill;
            CreateNewTest(tp, "TCP Server[" + DateTime.Now.ToString("HHmmss") + "]",Properties.Resources.tcp);
        }

        private void MS_NewTCPClient_Click(object sender, EventArgs e)
        {
            TCPClientPanel tp = new TCPClientPanel();
            tp.Dock = DockStyle.Fill;
            CreateNewTest(tp, "TCP Client[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.tcp);
        }

        private void MS_NewUDPServer_Click(object sender, EventArgs e)
        {
            UDPServerPanel tp = new UDPServerPanel();
            tp.Dock = DockStyle.Fill;
            CreateNewTest(tp, "UDP Server[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.udp);
        }

        private void MS_NewUDPClient_Click(object sender, EventArgs e)
        {
            UDPClientPanel tp = new UDPClientPanel();
            tp.Dock = DockStyle.Fill;
            CreateNewTest(tp, "UDP Client[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.udp);
        }

        private void MS_NewRs232_Click(object sender, EventArgs e)
        {
            ComPanel tp = new ComPanel();
            tp.Dock = DockStyle.Fill;
            CreateNewTest(tp, "COM[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.com);
        }

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

        private void lklQQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string qq = "275623749";
                System.Diagnostics.Process.Start("tencent://message/?uin=" + qq + "&Site=yyzq.net&Menu=yes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lklEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void MS_AboutMe_Click(object sender, EventArgs e)
        {
            new AboutMe().ShowDialog();
        }

        private void lklBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
    }
}
