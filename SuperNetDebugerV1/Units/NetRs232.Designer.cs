namespace LeafSoft.Units
{
    partial class NetRs232
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
            this.label1 = new System.Windows.Forms.Label();
            this.drpComList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drpBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drpParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.drpDataBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drpStopBits = new System.Windows.Forms.ComboBox();
            this.btnCom = new System.Windows.Forms.Button();
            this.picComStatus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picComStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "串口";
            // 
            // drpComList
            // 
            this.drpComList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpComList.FormattingEnabled = true;
            this.drpComList.Location = new System.Drawing.Point(54, 3);
            this.drpComList.Name = "drpComList";
            this.drpComList.Size = new System.Drawing.Size(89, 20);
            this.drpComList.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "波特率";
            // 
            // drpBaudRate
            // 
            this.drpBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpBaudRate.FormattingEnabled = true;
            this.drpBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.drpBaudRate.Location = new System.Drawing.Point(54, 27);
            this.drpBaudRate.Name = "drpBaudRate";
            this.drpBaudRate.Size = new System.Drawing.Size(89, 20);
            this.drpBaudRate.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "校验位";
            // 
            // drpParity
            // 
            this.drpParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpParity.FormattingEnabled = true;
            this.drpParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.drpParity.Location = new System.Drawing.Point(54, 53);
            this.drpParity.Name = "drpParity";
            this.drpParity.Size = new System.Drawing.Size(89, 20);
            this.drpParity.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "数据位";
            // 
            // drpDataBits
            // 
            this.drpDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpDataBits.FormattingEnabled = true;
            this.drpDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.drpDataBits.Location = new System.Drawing.Point(54, 79);
            this.drpDataBits.Name = "drpDataBits";
            this.drpDataBits.Size = new System.Drawing.Size(89, 20);
            this.drpDataBits.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "停止位";
            // 
            // drpStopBits
            // 
            this.drpStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpStopBits.FormattingEnabled = true;
            this.drpStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.drpStopBits.Location = new System.Drawing.Point(54, 105);
            this.drpStopBits.Name = "drpStopBits";
            this.drpStopBits.Size = new System.Drawing.Size(89, 20);
            this.drpStopBits.TabIndex = 33;
            // 
            // btnCom
            // 
            this.btnCom.Enabled = false;
            this.btnCom.Location = new System.Drawing.Point(54, 131);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(89, 37);
            this.btnCom.TabIndex = 34;
            this.btnCom.Tag = "0";
            this.btnCom.Text = "打开串口";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // picComStatus
            // 
            this.picComStatus.BackgroundImage = global::LeafSoft.Properties.Resources.redlight;
            this.picComStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picComStatus.Location = new System.Drawing.Point(9, 131);
            this.picComStatus.Name = "picComStatus";
            this.picComStatus.Size = new System.Drawing.Size(39, 37);
            this.picComStatus.TabIndex = 35;
            this.picComStatus.TabStop = false;
            // 
            // ConnCOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drpComList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drpBaudRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drpParity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drpDataBits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drpStopBits);
            this.Controls.Add(this.picComStatus);
            this.Controls.Add(this.btnCom);
            this.Name = "ConnCOM";
            this.Size = new System.Drawing.Size(151, 175);
            ((System.ComponentModel.ISupportInitialize)(this.picComStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpComList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drpBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox drpParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox drpDataBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox drpStopBits;
        private System.Windows.Forms.PictureBox picComStatus;
        private System.Windows.Forms.Button btnCom;
    }
}
