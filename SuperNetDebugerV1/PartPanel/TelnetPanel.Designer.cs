namespace LeafSoft.PartPanel
{
    partial class TelnetPanel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.nmServerPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConn = new System.Windows.Forms.Button();
            this.txtCmd = new LeafSoft.LeafControl.CMDTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmServerPort)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(48, 3);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(111, 21);
            this.txtServerIP.TabIndex = 16;
            // 
            // nmServerPort
            // 
            this.nmServerPort.Location = new System.Drawing.Point(194, 3);
            this.nmServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmServerPort.Name = "nmServerPort";
            this.nmServerPort.Size = new System.Drawing.Size(56, 21);
            this.nmServerPort.TabIndex = 18;
            this.nmServerPort.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "服务端";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "端口";
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(257, 3);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 23);
            this.btnConn.TabIndex = 19;
            this.btnConn.Text = "连接";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // txtCmd
            // 
            this.txtCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCmd.BackColor = System.Drawing.Color.Black;
            this.txtCmd.ForeColor = System.Drawing.Color.White;
            this.txtCmd.Location = new System.Drawing.Point(3, 30);
            this.txtCmd.Multiline = true;
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCmd.Size = new System.Drawing.Size(702, 403);
            this.txtCmd.TabIndex = 20;
            this.txtCmd.DataSend += new LeafSoft.Lib.LeafEvent.DataSendHandler(this.txtCmd_DataSend);
            // 
            // TelnetPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCmd);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.nmServerPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "TelnetPanel";
            this.Size = new System.Drawing.Size(708, 436);
            ((System.ComponentModel.ISupportInitialize)(this.nmServerPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.NumericUpDown nmServerPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConn;
        private LeafControl.CMDTextBox txtCmd;
    }
}
