namespace LeafSoft.PartPanel
{
    partial class ComPanel
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
            this.DataReceiver = new LeafSoft.Units.DataReceive();
            this.DataSender = new LeafSoft.Units.DataSend();
            this.Configer = new LeafSoft.Units.NetRs232();
            this.btnSuper = new System.Windows.Forms.Button();
            this.txtCmd = new LeafSoft.LeafControl.CMDTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_ClearCMD = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataReceiver
            // 
            this.DataReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataReceiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataReceiver.Location = new System.Drawing.Point(0, 209);
            this.DataReceiver.Name = "DataReceiver";
            this.DataReceiver.Size = new System.Drawing.Size(800, 288);
            this.DataReceiver.TabIndex = 4;
            // 
            // DataSender
            // 
            this.DataSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSender.Location = new System.Drawing.Point(148, 0);
            this.DataSender.Name = "DataSender";
            this.DataSender.Size = new System.Drawing.Size(652, 211);
            this.DataSender.TabIndex = 2;
            this.DataSender.EventDataSend += new LeafSoft.Lib.LeafEvent.DataSendHandler(this.DataSender_EventDataSend);
            // 
            // Configer
            // 
            this.Configer.Location = new System.Drawing.Point(0, 2);
            this.Configer.Name = "Configer";
            this.Configer.Size = new System.Drawing.Size(151, 175);
            this.Configer.TabIndex = 1;
            this.Configer.DataReceived += new LeafSoft.Lib.LeafEvent.DataReceivedHandler(this.Configer_DataReceived);
            // 
            // btnSuper
            // 
            this.btnSuper.Location = new System.Drawing.Point(4, 173);
            this.btnSuper.Name = "btnSuper";
            this.btnSuper.Size = new System.Drawing.Size(139, 31);
            this.btnSuper.TabIndex = 5;
            this.btnSuper.Text = "超级终端";
            this.btnSuper.UseVisualStyleBackColor = true;
            this.btnSuper.Click += new System.EventHandler(this.btnSuper_Click);
            // 
            // txtCmd
            // 
            this.txtCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCmd.BackColor = System.Drawing.Color.Black;
            this.txtCmd.ContextMenuStrip = this.contextMenuStrip1;
            this.txtCmd.ForeColor = System.Drawing.Color.White;
            this.txtCmd.Location = new System.Drawing.Point(0, 209);
            this.txtCmd.Multiline = true;
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCmd.Size = new System.Drawing.Size(800, 288);
            this.txtCmd.TabIndex = 7;
            this.txtCmd.Visible = false;
            this.txtCmd.DataSend += new Lib.LeafEvent.DataSendHandler(this.txtCmd_DataSend);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_ClearCMD});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // MS_ClearCMD
            // 
            this.MS_ClearCMD.Name = "MS_ClearCMD";
            this.MS_ClearCMD.Size = new System.Drawing.Size(127, 22);
            this.MS_ClearCMD.Text = "清空";
            this.MS_ClearCMD.Click += new System.EventHandler(this.MS_ClearCMD_Click);
            // 
            // ComPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCmd);
            this.Controls.Add(this.btnSuper);
            this.Controls.Add(this.DataReceiver);
            this.Controls.Add(this.DataSender);
            this.Controls.Add(this.Configer);
            this.Name = "ComPanel";
            this.Size = new System.Drawing.Size(800, 500);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Units.NetRs232 Configer;
        private Units.DataSend DataSender;
        private Units.DataReceive DataReceiver;
        private System.Windows.Forms.Button btnSuper;
        private LeafControl.CMDTextBox txtCmd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_ClearCMD;
    }
}
