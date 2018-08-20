namespace LeafSoft.Units
{
    partial class DataReceive
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.CMS_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToInt = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToFloat = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToDouble = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxAutoLine = new System.Windows.Forms.CheckBox();
            this.rbtnHex = new System.Windows.Forms.RadioButton();
            this.rbtnASCII = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.LinkLabel();
            this.rbtnUTF8 = new System.Windows.Forms.RadioButton();
            this.rbtnGB2312 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CMS_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.ContextMenuStrip = this.CMS_Main;
            this.txtData.Location = new System.Drawing.Point(0, 16);
            this.txtData.MaxLength = 1;
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(523, 179);
            this.txtData.TabIndex = 1;
            // 
            // CMS_Main
            // 
            this.CMS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Clear,
            this.MS_ToInt,
            this.MS_ToFloat,
            this.MS_ToDouble});
            this.CMS_Main.Name = "contextMenuStrip1";
            this.CMS_Main.ShowImageMargin = false;
            this.CMS_Main.Size = new System.Drawing.Size(174, 92);
            this.CMS_Main.VisibleChanged += new System.EventHandler(this.CMS_Main_VisibleChanged);
            // 
            // MS_Clear
            // 
            this.MS_Clear.Name = "MS_Clear";
            this.MS_Clear.Size = new System.Drawing.Size(173, 22);
            this.MS_Clear.Text = "清空";
            this.MS_Clear.Click += new System.EventHandler(this.MS_Clear_Click);
            // 
            // MS_ToInt
            // 
            this.MS_ToInt.Name = "MS_ToInt";
            this.MS_ToInt.Size = new System.Drawing.Size(173, 22);
            this.MS_ToInt.Text = "转换为整数(Int)";
            this.MS_ToInt.Click += new System.EventHandler(this.MS_ToInt_Click);
            // 
            // MS_ToFloat
            // 
            this.MS_ToFloat.Name = "MS_ToFloat";
            this.MS_ToFloat.Size = new System.Drawing.Size(173, 22);
            this.MS_ToFloat.Text = "转换为浮点数(Float)";
            this.MS_ToFloat.Click += new System.EventHandler(this.MS_ToFloat_Click);
            // 
            // MS_ToDouble
            // 
            this.MS_ToDouble.Name = "MS_ToDouble";
            this.MS_ToDouble.Size = new System.Drawing.Size(173, 22);
            this.MS_ToDouble.Text = "转换为浮点数(Double)";
            this.MS_ToDouble.Click += new System.EventHandler(this.MS_ToDouble_Click);
            // 
            // cbxAutoLine
            // 
            this.cbxAutoLine.AutoSize = true;
            this.cbxAutoLine.Location = new System.Drawing.Point(0, 0);
            this.cbxAutoLine.Name = "cbxAutoLine";
            this.cbxAutoLine.Size = new System.Drawing.Size(72, 16);
            this.cbxAutoLine.TabIndex = 2;
            this.cbxAutoLine.Text = "自动换行";
            this.cbxAutoLine.UseVisualStyleBackColor = true;
            // 
            // rbtnHex
            // 
            this.rbtnHex.AutoSize = true;
            this.rbtnHex.Checked = true;
            this.rbtnHex.Location = new System.Drawing.Point(69, 0);
            this.rbtnHex.Name = "rbtnHex";
            this.rbtnHex.Size = new System.Drawing.Size(41, 16);
            this.rbtnHex.TabIndex = 3;
            this.rbtnHex.TabStop = true;
            this.rbtnHex.Text = "Hex";
            this.rbtnHex.UseVisualStyleBackColor = true;
            this.rbtnHex.CheckedChanged += new System.EventHandler(this.rbtnHex_CheckedChanged);
            // 
            // rbtnASCII
            // 
            this.rbtnASCII.AutoSize = true;
            this.rbtnASCII.Location = new System.Drawing.Point(116, 0);
            this.rbtnASCII.Name = "rbtnASCII";
            this.rbtnASCII.Size = new System.Drawing.Size(53, 16);
            this.rbtnASCII.TabIndex = 4;
            this.rbtnASCII.Text = "ASCII";
            this.rbtnASCII.UseVisualStyleBackColor = true;
            this.rbtnASCII.CheckedChanged += new System.EventHandler(this.rbtnASCII_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "接收字节数：";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(76, 197);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(11, 12);
            this.lblCount.TabIndex = 6;
            this.lblCount.TabStop = true;
            this.lblCount.Text = "0";
            this.lblCount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCount_LinkClicked);
            // 
            // rbtnUTF8
            // 
            this.rbtnUTF8.AutoSize = true;
            this.rbtnUTF8.Location = new System.Drawing.Point(175, 0);
            this.rbtnUTF8.Name = "rbtnUTF8";
            this.rbtnUTF8.Size = new System.Drawing.Size(47, 16);
            this.rbtnUTF8.TabIndex = 7;
            this.rbtnUTF8.Text = "UTF8";
            this.rbtnUTF8.UseVisualStyleBackColor = true;
            this.rbtnUTF8.CheckedChanged += new System.EventHandler(this.rbtnUTF8_CheckedChanged);
            // 
            // rbtnGB2312
            // 
            this.rbtnGB2312.AutoSize = true;
            this.rbtnGB2312.Location = new System.Drawing.Point(228, 0);
            this.rbtnGB2312.Name = "rbtnGB2312";
            this.rbtnGB2312.Size = new System.Drawing.Size(59, 16);
            this.rbtnGB2312.TabIndex = 8;
            this.rbtnGB2312.Text = "GB2312";
            this.rbtnGB2312.UseVisualStyleBackColor = true;
            this.rbtnGB2312.CheckedChanged += new System.EventHandler(this.rbtnGB2312_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(392, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "提示：右键Hex计算数值";
            // 
            // DataReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnGB2312);
            this.Controls.Add(this.rbtnUTF8);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.rbtnASCII);
            this.Controls.Add(this.rbtnHex);
            this.Controls.Add(this.cbxAutoLine);
            this.Name = "DataReceive";
            this.Size = new System.Drawing.Size(523, 210);
            this.CMS_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.CheckBox cbxAutoLine;
        private System.Windows.Forms.RadioButton rbtnHex;
        private System.Windows.Forms.RadioButton rbtnASCII;
        private System.Windows.Forms.ContextMenuStrip CMS_Main;
        private System.Windows.Forms.ToolStripMenuItem MS_Clear;
        private System.Windows.Forms.ToolStripMenuItem MS_ToInt;
        private System.Windows.Forms.ToolStripMenuItem MS_ToFloat;
        private System.Windows.Forms.ToolStripMenuItem MS_ToDouble;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lblCount;
        private System.Windows.Forms.RadioButton rbtnUTF8;
        private System.Windows.Forms.RadioButton rbtnGB2312;
        private System.Windows.Forms.Label label2;
    }
}
