namespace LeafSoft.PartPanel
{
    partial class PingPanel
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nmPingCount = new System.Windows.Forms.NumericUpDown();
            this.txtCmd = new LeafSoft.LeafControl.CMDTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MSI_Clear = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nmPingCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmInterval)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "目的IP";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(51, 4);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(117, 21);
            this.txtServerIP.TabIndex = 17;
            this.txtServerIP.Text = "www.yyzq.net";
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(408, 2);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 18;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ping次数";
            // 
            // nmPingCount
            // 
            this.nmPingCount.Location = new System.Drawing.Point(228, 3);
            this.nmPingCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmPingCount.Name = "nmPingCount";
            this.nmPingCount.Size = new System.Drawing.Size(41, 21);
            this.nmPingCount.TabIndex = 21;
            this.nmPingCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // txtCmd
            // 
            this.txtCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCmd.BackColor = System.Drawing.Color.Black;
            this.txtCmd.ContextMenuStrip = this.contextMenuStrip1;
            this.txtCmd.ForeColor = System.Drawing.Color.White;
            this.txtCmd.Location = new System.Drawing.Point(0, 28);
            this.txtCmd.Multiline = true;
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.ReadOnly = true;
            this.txtCmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCmd.Size = new System.Drawing.Size(704, 390);
            this.txtCmd.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ping间隔";
            // 
            // nmInterval
            // 
            this.nmInterval.Location = new System.Drawing.Point(330, 3);
            this.nmInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmInterval.Name = "nmInterval";
            this.nmInterval.Size = new System.Drawing.Size(54, 21);
            this.nmInterval.TabIndex = 23;
            this.nmInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "ms";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSI_Clear});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // MSI_Clear
            // 
            this.MSI_Clear.Name = "MSI_Clear";
            this.MSI_Clear.Size = new System.Drawing.Size(127, 22);
            this.MSI_Clear.Text = "清空";
            this.MSI_Clear.Click += new System.EventHandler(this.MSI_Clear_Click);
            // 
            // PingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmInterval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmPingCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCmd);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.label1);
            this.Name = "PingPanel";
            this.Size = new System.Drawing.Size(704, 421);
            ((System.ComponentModel.ISupportInitialize)(this.nmPingCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmInterval)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Button btnPing;
        private LeafControl.CMDTextBox txtCmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmPingCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MSI_Clear;
    }
}
