namespace LeafSoft.Units
{
    partial class DataCounter
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
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSendCount = new System.Windows.Forms.Label();
            this.lblReceiveCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "计数清零";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "发送字节数：";
            // 
            // lblSendCount
            // 
            this.lblSendCount.AutoSize = true;
            this.lblSendCount.Location = new System.Drawing.Point(149, 5);
            this.lblSendCount.Name = "lblSendCount";
            this.lblSendCount.Size = new System.Drawing.Size(11, 12);
            this.lblSendCount.TabIndex = 2;
            this.lblSendCount.Text = "0";
            // 
            // lblReceiveCount
            // 
            this.lblReceiveCount.AutoSize = true;
            this.lblReceiveCount.Location = new System.Drawing.Point(270, 5);
            this.lblReceiveCount.Name = "lblReceiveCount";
            this.lblReceiveCount.Size = new System.Drawing.Size(11, 12);
            this.lblReceiveCount.TabIndex = 4;
            this.lblReceiveCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "接收字节数：";
            // 
            // DataCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblReceiveCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSendCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Name = "DataCounter";
            this.Size = new System.Drawing.Size(323, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSendCount;
        private System.Windows.Forms.Label lblReceiveCount;
        private System.Windows.Forms.Label label4;
    }
}
