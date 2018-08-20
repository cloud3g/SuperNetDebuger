namespace LeafSoft
{
    partial class frmPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLicense = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLicense
            // 
            this.lblLicense.BackColor = System.Drawing.Color.Green;
            this.lblLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLicense.ForeColor = System.Drawing.Color.White;
            this.lblLicense.Location = new System.Drawing.Point(0, 0);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(365, 87);
            this.lblLicense.TabIndex = 1;
            this.lblLicense.Text = "1.支持SQLITE数据库，能保存调试命令及最后使用的通信参数信息等\r\n2.调试命令的导入和导出\r\n3.可将接收的数据按指定编码格式直接写入指定的文件\r\n4.YM" +
                "odem协议的文件传输\r\n5.Zmodem协议的文件传输\r\n6.数据接收过滤器，转换器\r\n7.通信协议编辑器";
            // 
            // frmPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 87);
            this.Controls.Add(this.lblLicense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "开发计划";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLicense;
    }
}