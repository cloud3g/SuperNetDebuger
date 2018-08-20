namespace LeafSoft
{
    partial class yyzq
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yyzq));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPing = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Check = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Bytes = new System.Windows.Forms.ToolStripMenuItem();
            this.新的调试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_NewRs232 = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_NewTCPServer = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_NewTCPClient = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_NewUDPServer = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_NewUDPClient = new System.Windows.Forms.ToolStripMenuItem();
            this.通信监视ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_COMMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_SocketMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_About = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_OpenSource = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_Blog = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_Web = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_QQ = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_Email = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_SupportMe = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_DevPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_License = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_AboutMe = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_QQGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.comPanel1 = new LeafSoft.PartPanel.ComPanel();
            this.tcpServerPanel1 = new LeafSoft.PartPanel.TCPServerPanel();
            this.tcpClientPanel1 = new LeafSoft.PartPanel.TCPClientPanel();
            this.udpServerPanel1 = new LeafSoft.PartPanel.UDPServerPanel();
            this.udpClientPanel1 = new LeafSoft.PartPanel.UDPClientPanel();
            this.pingPanel1 = new LeafSoft.PartPanel.PingPanel();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPing.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.udpServerPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(710, 467);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "UDP Server";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tcpServerPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TCP Server";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "串口";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPing
            // 
            this.tabPing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPing.Controls.Add(this.tabPage1);
            this.tabPing.Controls.Add(this.tabPage2);
            this.tabPing.Controls.Add(this.tabPage3);
            this.tabPing.Controls.Add(this.tabPage4);
            this.tabPing.Controls.Add(this.tabPage5);
            this.tabPing.Controls.Add(this.tabPage6);
            this.tabPing.Location = new System.Drawing.Point(0, 26);
            this.tabPing.Name = "tabPing";
            this.tabPing.SelectedIndex = 0;
            this.tabPing.Size = new System.Drawing.Size(718, 493);
            this.tabPing.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tcpClientPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(710, 467);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "TCP Client";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.udpClientPanel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(710, 467);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "UDP Client";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.pingPanel1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(710, 467);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Ping";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算器ToolStripMenuItem,
            this.新的调试ToolStripMenuItem,
            this.通信监视ToolStripMenuItem,
            this.MS_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 计算器ToolStripMenuItem
            // 
            this.计算器ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Check,
            this.MS_Bytes});
            this.计算器ToolStripMenuItem.Image = global::LeafSoft.Properties.Resources.hex;
            this.计算器ToolStripMenuItem.Name = "计算器ToolStripMenuItem";
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.计算器ToolStripMenuItem.Text = "计算器";
            // 
            // MS_Check
            // 
            this.MS_Check.Image = global::LeafSoft.Properties.Resources.hex;
            this.MS_Check.Name = "MS_Check";
            this.MS_Check.Size = new System.Drawing.Size(148, 22);
            this.MS_Check.Text = "校验码计算器";
            this.MS_Check.Click += new System.EventHandler(this.MS_Check_Click);
            // 
            // MS_Bytes
            // 
            this.MS_Bytes.Image = global::LeafSoft.Properties.Resources.calculator;
            this.MS_Bytes.Name = "MS_Bytes";
            this.MS_Bytes.Size = new System.Drawing.Size(148, 22);
            this.MS_Bytes.Text = "数值计算器";
            this.MS_Bytes.Click += new System.EventHandler(this.MS_Bytes_Click);
            // 
            // 新的调试ToolStripMenuItem
            // 
            this.新的调试ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_NewRs232,
            this.MS_NewTCPServer,
            this.MS_NewTCPClient,
            this.MS_NewUDPServer,
            this.MS_NewUDPClient});
            this.新的调试ToolStripMenuItem.Image = global::LeafSoft.Properties.Resources.ucom;
            this.新的调试ToolStripMenuItem.Name = "新的调试ToolStripMenuItem";
            this.新的调试ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.新的调试ToolStripMenuItem.Text = "新的调试";
            // 
            // MS_NewRs232
            // 
            this.MS_NewRs232.Image = global::LeafSoft.Properties.Resources.ucom;
            this.MS_NewRs232.Name = "MS_NewRs232";
            this.MS_NewRs232.Size = new System.Drawing.Size(142, 22);
            this.MS_NewRs232.Text = "串口";
            this.MS_NewRs232.Click += new System.EventHandler(this.MS_NewRs232_Click);
            // 
            // MS_NewTCPServer
            // 
            this.MS_NewTCPServer.Image = global::LeafSoft.Properties.Resources.ntcp;
            this.MS_NewTCPServer.Name = "MS_NewTCPServer";
            this.MS_NewTCPServer.Size = new System.Drawing.Size(142, 22);
            this.MS_NewTCPServer.Text = "TCP Server";
            this.MS_NewTCPServer.Click += new System.EventHandler(this.MS_NewTCPServer_Click);
            // 
            // MS_NewTCPClient
            // 
            this.MS_NewTCPClient.Image = global::LeafSoft.Properties.Resources.ntcp;
            this.MS_NewTCPClient.Name = "MS_NewTCPClient";
            this.MS_NewTCPClient.Size = new System.Drawing.Size(142, 22);
            this.MS_NewTCPClient.Text = "TCP Client";
            this.MS_NewTCPClient.Click += new System.EventHandler(this.MS_NewTCPClient_Click);
            // 
            // MS_NewUDPServer
            // 
            this.MS_NewUDPServer.Image = global::LeafSoft.Properties.Resources.nudp;
            this.MS_NewUDPServer.Name = "MS_NewUDPServer";
            this.MS_NewUDPServer.Size = new System.Drawing.Size(142, 22);
            this.MS_NewUDPServer.Text = "UDP Server";
            this.MS_NewUDPServer.Click += new System.EventHandler(this.MS_NewUDPServer_Click);
            // 
            // MS_NewUDPClient
            // 
            this.MS_NewUDPClient.Image = global::LeafSoft.Properties.Resources.nudp;
            this.MS_NewUDPClient.Name = "MS_NewUDPClient";
            this.MS_NewUDPClient.Size = new System.Drawing.Size(142, 22);
            this.MS_NewUDPClient.Text = "UDP Client";
            this.MS_NewUDPClient.Click += new System.EventHandler(this.MS_NewUDPClient_Click);
            // 
            // 通信监视ToolStripMenuItem
            // 
            this.通信监视ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_COMMonitor,
            this.MS_SocketMonitor});
            this.通信监视ToolStripMenuItem.Image = global::LeafSoft.Properties.Resources.monitor_com;
            this.通信监视ToolStripMenuItem.Name = "通信监视ToolStripMenuItem";
            this.通信监视ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.通信监视ToolStripMenuItem.Text = "通信监视";
            // 
            // MS_COMMonitor
            // 
            this.MS_COMMonitor.Enabled = false;
            this.MS_COMMonitor.Image = global::LeafSoft.Properties.Resources.monitor_com;
            this.MS_COMMonitor.Name = "MS_COMMonitor";
            this.MS_COMMonitor.Size = new System.Drawing.Size(163, 22);
            this.MS_COMMonitor.Text = "串口通信监视";
            this.MS_COMMonitor.Visible = false;
            this.MS_COMMonitor.Click += new System.EventHandler(this.MS_COMMonitor_Click);
            // 
            // MS_SocketMonitor
            // 
            this.MS_SocketMonitor.Image = global::LeafSoft.Properties.Resources.monitor_socket;
            this.MS_SocketMonitor.Name = "MS_SocketMonitor";
            this.MS_SocketMonitor.Size = new System.Drawing.Size(163, 22);
            this.MS_SocketMonitor.Text = "Socket通信监视";
            this.MS_SocketMonitor.Click += new System.EventHandler(this.MS_SocketMonitor_Click);
            // 
            // MS_About
            // 
            this.MS_About.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSI_QQGroup,
            this.MSI_OpenSource,
            this.MSI_Blog,
            this.MSI_Web,
            this.MSI_QQ,
            this.MSI_Email,
            this.MSI_SupportMe,
            this.MSI_DevPlan,
            this.MSI_License,
            this.MS_AboutMe});
            this.MS_About.Image = global::LeafSoft.Properties.Resources.leafsoft;
            this.MS_About.Name = "MS_About";
            this.MS_About.Size = new System.Drawing.Size(60, 21);
            this.MS_About.Text = "关于";
            // 
            // MSI_OpenSource
            // 
            this.MSI_OpenSource.Name = "MSI_OpenSource";
            this.MSI_OpenSource.Size = new System.Drawing.Size(254, 22);
            this.MSI_OpenSource.Text = "开源地址";
            this.MSI_OpenSource.Click += new System.EventHandler(this.MSI_OpenSource_Click);
            // 
            // MSI_Blog
            // 
            this.MSI_Blog.Name = "MSI_Blog";
            this.MSI_Blog.Size = new System.Drawing.Size(254, 22);
            this.MSI_Blog.Text = "我的博客";
            this.MSI_Blog.Click += new System.EventHandler(this.MSI_Blog_Click);
            // 
            // MSI_Web
            // 
            this.MSI_Web.Name = "MSI_Web";
            this.MSI_Web.Size = new System.Drawing.Size(254, 22);
            this.MSI_Web.Text = "我的网站";
            this.MSI_Web.Click += new System.EventHandler(this.MSI_Web_Click);
            // 
            // MSI_QQ
            // 
            this.MSI_QQ.Name = "MSI_QQ";
            this.MSI_QQ.Size = new System.Drawing.Size(254, 22);
            this.MSI_QQ.Text = "联系QQ";
            this.MSI_QQ.Click += new System.EventHandler(this.MSI_QQ_Click);
            // 
            // MSI_Email
            // 
            this.MSI_Email.Name = "MSI_Email";
            this.MSI_Email.Size = new System.Drawing.Size(254, 22);
            this.MSI_Email.Text = "联系Email";
            this.MSI_Email.Click += new System.EventHandler(this.MSI_Email_Click);
            // 
            // MSI_SupportMe
            // 
            this.MSI_SupportMe.Name = "MSI_SupportMe";
            this.MSI_SupportMe.Size = new System.Drawing.Size(254, 22);
            this.MSI_SupportMe.Text = "捐助[您的支持，是我开源的动力]";
            this.MSI_SupportMe.Click += new System.EventHandler(this.MSI_SupportMe_Click);
            // 
            // MSI_DevPlan
            // 
            this.MSI_DevPlan.Name = "MSI_DevPlan";
            this.MSI_DevPlan.Size = new System.Drawing.Size(254, 22);
            this.MSI_DevPlan.Text = "开发计划";
            this.MSI_DevPlan.Click += new System.EventHandler(this.MSI_DevPlan_Click);
            // 
            // MSI_License
            // 
            this.MSI_License.Image = global::LeafSoft.Properties.Resources.license;
            this.MSI_License.Name = "MSI_License";
            this.MSI_License.Size = new System.Drawing.Size(254, 22);
            this.MSI_License.Text = "License";
            this.MSI_License.Click += new System.EventHandler(this.MSI_License_Click);
            // 
            // MS_AboutMe
            // 
            this.MS_AboutMe.Image = global::LeafSoft.Properties.Resources.leafsoft;
            this.MS_AboutMe.Name = "MS_AboutMe";
            this.MS_AboutMe.Size = new System.Drawing.Size(254, 22);
            this.MS_AboutMe.Text = "关于";
            this.MS_AboutMe.Click += new System.EventHandler(this.MS_AboutMe_Click);
            // 
            // MSI_QQGroup
            // 
            this.MSI_QQGroup.Name = "MSI_QQGroup";
            this.MSI_QQGroup.Size = new System.Drawing.Size(254, 22);
            this.MSI_QQGroup.Text = "C#通信编程交流Q群：83868794";
            this.MSI_QQGroup.Click += new System.EventHandler(this.MSI_QQGroup_Click);
            // 
            // comPanel1
            // 
            this.comPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comPanel1.Location = new System.Drawing.Point(3, 3);
            this.comPanel1.Name = "comPanel1";
            this.comPanel1.Size = new System.Drawing.Size(704, 461);
            this.comPanel1.TabIndex = 0;
            // 
            // tcpServerPanel1
            // 
            this.tcpServerPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcpServerPanel1.Location = new System.Drawing.Point(3, 3);
            this.tcpServerPanel1.Name = "tcpServerPanel1";
            this.tcpServerPanel1.Size = new System.Drawing.Size(704, 461);
            this.tcpServerPanel1.TabIndex = 0;
            // 
            // tcpClientPanel1
            // 
            this.tcpClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcpClientPanel1.Location = new System.Drawing.Point(0, 0);
            this.tcpClientPanel1.Name = "tcpClientPanel1";
            this.tcpClientPanel1.Size = new System.Drawing.Size(710, 467);
            this.tcpClientPanel1.TabIndex = 0;
            // 
            // udpServerPanel1
            // 
            this.udpServerPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udpServerPanel1.Location = new System.Drawing.Point(0, 0);
            this.udpServerPanel1.Name = "udpServerPanel1";
            this.udpServerPanel1.Size = new System.Drawing.Size(710, 467);
            this.udpServerPanel1.TabIndex = 0;
            // 
            // udpClientPanel1
            // 
            this.udpClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udpClientPanel1.Location = new System.Drawing.Point(0, 0);
            this.udpClientPanel1.Name = "udpClientPanel1";
            this.udpClientPanel1.Size = new System.Drawing.Size(710, 467);
            this.udpClientPanel1.TabIndex = 0;
            // 
            // pingPanel1
            // 
            this.pingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pingPanel1.Location = new System.Drawing.Point(3, 3);
            this.pingPanel1.Name = "pingPanel1";
            this.pingPanel1.Size = new System.Drawing.Size(704, 461);
            this.pingPanel1.TabIndex = 0;
            // 
            // yyzq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 515);
            this.Controls.Add(this.tabPing);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "yyzq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPing.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private PartPanel.ComPanel comPanel1;
        private System.Windows.Forms.TabControl tabPing;
        private PartPanel.UDPServerPanel udpServerPanel1;
        private PartPanel.TCPServerPanel tcpServerPanel1;
        private System.Windows.Forms.TabPage tabPage3;
        private PartPanel.TCPClientPanel tcpClientPanel1;
        private System.Windows.Forms.TabPage tabPage5;
        private PartPanel.UDPClientPanel udpClientPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Bytes;
        private System.Windows.Forms.ToolStripMenuItem 计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MS_Check;
        private System.Windows.Forms.ToolStripMenuItem 新的调试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MS_NewTCPServer;
        private System.Windows.Forms.ToolStripMenuItem MS_NewTCPClient;
        private System.Windows.Forms.ToolStripMenuItem MS_NewUDPServer;
        private System.Windows.Forms.ToolStripMenuItem MS_NewUDPClient;
        private System.Windows.Forms.ToolStripMenuItem MS_About;
        private System.Windows.Forms.ToolStripMenuItem MS_NewRs232;
        private System.Windows.Forms.ToolStripMenuItem 通信监视ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MS_SocketMonitor;
        private System.Windows.Forms.ToolStripMenuItem MS_COMMonitor;
        private System.Windows.Forms.ToolStripMenuItem MS_AboutMe;
        private System.Windows.Forms.ToolStripMenuItem MSI_License;
        private System.Windows.Forms.TabPage tabPage6;
        private PartPanel.PingPanel pingPanel1;
        private System.Windows.Forms.ToolStripMenuItem MSI_OpenSource;
        private System.Windows.Forms.ToolStripMenuItem MSI_Blog;
        private System.Windows.Forms.ToolStripMenuItem MSI_Web;
        private System.Windows.Forms.ToolStripMenuItem MSI_QQ;
        private System.Windows.Forms.ToolStripMenuItem MSI_Email;
        private System.Windows.Forms.ToolStripMenuItem MSI_SupportMe;
        private System.Windows.Forms.ToolStripMenuItem MSI_DevPlan;
        private System.Windows.Forms.ToolStripMenuItem MSI_QQGroup;


    }
}

