namespace LeafSoft
{
    partial class frmCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheck));
            this.txtContent = new LeafSoft.LeafControl.BytesBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CM_Check = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CheckSum = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRC16 = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRCPoly = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRCPolyH = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRCPolyL = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.ContextMenuStrip = this.contextMenuStrip1;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.IsHex = LeafSoft.Lib.EnumType.CMDType.Hex;
            this.txtContent.Location = new System.Drawing.Point(0, 0);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(379, 114);
            this.txtContent.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CM_Check,
            this.MS_Copy,
            this.CM_Clear});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 70);
            // 
            // CM_Check
            // 
            this.CM_Check.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_CheckSum,
            this.MS_CRC16,
            this.MS_CRCPoly});
            this.CM_Check.Name = "CM_Check";
            this.CM_Check.Size = new System.Drawing.Size(136, 22);
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
            // MS_Copy
            // 
            this.MS_Copy.Name = "MS_Copy";
            this.MS_Copy.Size = new System.Drawing.Size(136, 22);
            this.MS_Copy.Text = "复制";
            this.MS_Copy.Click += new System.EventHandler(this.MS_Copy_Click);
            // 
            // CM_Clear
            // 
            this.CM_Clear.Name = "CM_Clear";
            this.CM_Clear.Size = new System.Drawing.Size(136, 22);
            this.CM_Clear.Text = "清空";
            this.CM_Clear.Click += new System.EventHandler(this.CM_Clear_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 114);
            this.Controls.Add(this.txtContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "校验码计算器";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LeafControl.BytesBox txtContent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CM_Check;
        private System.Windows.Forms.ToolStripMenuItem MS_CheckSum;
        private System.Windows.Forms.ToolStripMenuItem MS_CRC16;
        private System.Windows.Forms.ToolStripMenuItem MS_CRCPoly;
        private System.Windows.Forms.ToolStripMenuItem MS_CRCPolyH;
        private System.Windows.Forms.ToolStripMenuItem MS_CRCPolyL;
        private System.Windows.Forms.ToolStripMenuItem CM_Clear;
        private System.Windows.Forms.ToolStripMenuItem MS_Copy;
    }
}