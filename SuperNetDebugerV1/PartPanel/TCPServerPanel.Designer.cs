﻿namespace LeafSoft.PartPanel
{
    partial class TCPServerPanel
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
            this.tabDataReceiver = new LeafSoft.Units.TabDataReceive();
            this.DataSender = new LeafSoft.Units.DataSend();
            this.Configer = new LeafSoft.Units.NetTCPServer();
            this.SuspendLayout();
            // 
            // tabDataReceiver
            // 
            this.tabDataReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDataReceiver.Location = new System.Drawing.Point(3, 223);
            this.tabDataReceiver.Name = "tabDataReceiver";
            this.tabDataReceiver.Size = new System.Drawing.Size(797, 277);
            this.tabDataReceiver.TabIndex = 7;
            // 
            // DataSender
            // 
            this.DataSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSender.Location = new System.Drawing.Point(181, 3);
            this.DataSender.Name = "DataSender";
            this.DataSender.Size = new System.Drawing.Size(613, 220);
            this.DataSender.TabIndex = 5;
            this.DataSender.EventDataSend += new LeafSoft.Lib.LeafEvent.DataSendHandler(this.DataSender_EventDataSend);
            // 
            // Configer
            // 
            this.Configer.Location = new System.Drawing.Point(3, 3);
            this.Configer.Name = "Configer";
            this.Configer.Size = new System.Drawing.Size(172, 220);
            this.Configer.TabIndex = 1;
            this.Configer.DataReceived += new LeafSoft.Lib.LeafEvent.DataReceivedHandler(this.Configer_DataReceived);
            // 
            // TCPServerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabDataReceiver);
            this.Controls.Add(this.DataSender);
            this.Controls.Add(this.Configer);
            this.Name = "TCPServerPanel";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private Units.NetTCPServer Configer;
        private Units.DataSend DataSender;
        private Units.TabDataReceive tabDataReceiver;
    }
}
