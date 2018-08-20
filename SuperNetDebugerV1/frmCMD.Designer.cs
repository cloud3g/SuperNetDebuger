namespace LeafSoft
{
    partial class frmCMD
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MSI_Hex = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_ASCII = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_UTF8 = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_GB2312 = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Check = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CheckSum = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRC16 = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRCPoly = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRCPolyH = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRCPolyL = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.txtContent = new LeafSoft.LeafControl.BytesBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "命令内容：";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(244, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(325, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSI_Hex,
            this.MSI_ASCII,
            this.MSI_UTF8,
            this.MSI_GB2312,
            this.CM_Check,
            this.CM_Clear});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 158);
            // 
            // MSI_Hex
            // 
            this.MSI_Hex.Name = "MSI_Hex";
            this.MSI_Hex.Size = new System.Drawing.Size(152, 22);
            this.MSI_Hex.Text = "Hex";
            this.MSI_Hex.Click += new System.EventHandler(this.MSI_Hex_Click);
            // 
            // MSI_ASCII
            // 
            this.MSI_ASCII.Name = "MSI_ASCII";
            this.MSI_ASCII.Size = new System.Drawing.Size(152, 22);
            this.MSI_ASCII.Text = "ASCII";
            this.MSI_ASCII.Click += new System.EventHandler(this.MSI_ASCII_Click);
            // 
            // MSI_UTF8
            // 
            this.MSI_UTF8.Name = "MSI_UTF8";
            this.MSI_UTF8.Size = new System.Drawing.Size(152, 22);
            this.MSI_UTF8.Text = "UTF8";
            this.MSI_UTF8.Click += new System.EventHandler(this.MSI_UTF8_Click);
            // 
            // MSI_GB2312
            // 
            this.MSI_GB2312.Name = "MSI_GB2312";
            this.MSI_GB2312.Size = new System.Drawing.Size(152, 22);
            this.MSI_GB2312.Text = "GB2312";
            this.MSI_GB2312.Click += new System.EventHandler(this.MSI_GB2312_Click);
            // 
            // CM_Check
            // 
            this.CM_Check.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_CheckSum,
            this.MS_CRC16,
            this.MS_CRCPoly});
            this.CM_Check.Name = "CM_Check";
            this.CM_Check.Size = new System.Drawing.Size(152, 22);
            this.CM_Check.Text = "计算校验码";
            // 
            // MS_CheckSum
            // 
            this.MS_CheckSum.Name = "MS_CheckSum";
            this.MS_CheckSum.Size = new System.Drawing.Size(154, 22);
            this.MS_CheckSum.Text = "校验和";
            this.MS_CheckSum.Click += new System.EventHandler(this.MS_CheckSum_Click);
            // 
            // MS_CRC16
            // 
            this.MS_CRC16.Name = "MS_CRC16";
            this.MS_CRC16.Size = new System.Drawing.Size(154, 22);
            this.MS_CRC16.Text = "Modbus-RTU";
            this.MS_CRC16.Click += new System.EventHandler(this.MS_CRC16_Click);
            // 
            // MS_CRCPoly
            // 
            this.MS_CRCPoly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_CRCPolyH,
            this.MS_CRCPolyL});
            this.MS_CRCPoly.Name = "MS_CRCPoly";
            this.MS_CRCPoly.Size = new System.Drawing.Size(154, 22);
            this.MS_CRCPoly.Text = "CRC16多项式";
            // 
            // MS_CRCPolyH
            // 
            this.MS_CRCPolyH.Name = "MS_CRCPolyH";
            this.MS_CRCPolyH.Size = new System.Drawing.Size(124, 22);
            this.MS_CRCPolyH.Text = "高位在前";
            this.MS_CRCPolyH.Click += new System.EventHandler(this.MS_CRCPolyH_Click);
            // 
            // MS_CRCPolyL
            // 
            this.MS_CRCPolyL.Name = "MS_CRCPolyL";
            this.MS_CRCPolyL.Size = new System.Drawing.Size(124, 22);
            this.MS_CRCPolyL.Text = "低位在前";
            this.MS_CRCPolyL.Click += new System.EventHandler(this.MS_CRCPolyL_Click);
            // 
            // CM_Clear
            // 
            this.CM_Clear.Name = "CM_Clear";
            this.CM_Clear.Size = new System.Drawing.Size(152, 22);
            this.CM_Clear.Text = "清空";
            this.CM_Clear.Click += new System.EventHandler(this.CM_Clear_Click);
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.ContextMenuStrip = this.contextMenuStrip1;
            this.txtContent.EncodeType = LeafSoft.Lib.EnumType.DataEncode.Hex;
            this.txtContent.Location = new System.Drawing.Point(0, 24);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(400, 110);
            this.txtContent.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(2, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "提示：右键切换编码格式及计算校验码";
            // 
            // frmCMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 166);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCMD";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "命令配置";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LeafControl.BytesBox txtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MSI_ASCII;
        private System.Windows.Forms.ToolStripMenuItem CM_Check;
        private System.Windows.Forms.ToolStripMenuItem CM_Clear;
        private System.Windows.Forms.ToolStripMenuItem MS_CheckSum;
        private System.Windows.Forms.ToolStripMenuItem MS_CRC16;
        private System.Windows.Forms.ToolStripMenuItem MS_CRCPoly;
        private System.Windows.Forms.ToolStripMenuItem MS_CRCPolyH;
        private System.Windows.Forms.ToolStripMenuItem MS_CRCPolyL;
        private System.Windows.Forms.ToolStripMenuItem MSI_Hex;
        private System.Windows.Forms.ToolStripMenuItem MSI_UTF8;
        private System.Windows.Forms.ToolStripMenuItem MSI_GB2312;
        private System.Windows.Forms.Label label2;
    }
}