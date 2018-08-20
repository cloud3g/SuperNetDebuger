namespace LeafSoft
{
    partial class frmBytes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBytes));
            this.txtData = new LeafSoft.LeafControl.BytesBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.CMS_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToInt = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToFloat = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToDouble = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Value = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_ClearValue = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_IntToBytes = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_FloatToBytes = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_DoubleToBytes = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ShortToBytes = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Main.SuspendLayout();
            this.CMS_Value.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.ContextMenuStrip = this.CMS_Main;
            this.txtData.IsHex = LeafSoft.Lib.EnumType.CMDType.Hex;
            this.txtData.Location = new System.Drawing.Point(44, 11);
            this.txtData.MaxLength = 23;
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(150, 23);
            this.txtData.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "值：";
            // 
            // txtValue
            // 
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.ContextMenuStrip = this.CMS_Value;
            this.txtValue.Location = new System.Drawing.Point(44, 37);
            this.txtValue.MaxLength = 20;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(150, 21);
            this.txtValue.TabIndex = 5;
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
            // CMS_Value
            // 
            this.CMS_Value.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_ClearValue,
            this.MS_ShortToBytes,
            this.MS_IntToBytes,
            this.MS_FloatToBytes,
            this.MS_DoubleToBytes});
            this.CMS_Value.Name = "contextMenuStrip1";
            this.CMS_Value.ShowImageMargin = false;
            this.CMS_Value.Size = new System.Drawing.Size(174, 136);
            // 
            // MS_ClearValue
            // 
            this.MS_ClearValue.Name = "MS_ClearValue";
            this.MS_ClearValue.Size = new System.Drawing.Size(173, 22);
            this.MS_ClearValue.Text = "清空";
            this.MS_ClearValue.Click += new System.EventHandler(this.MS_ClearValue_Click);
            // 
            // MS_IntToBytes
            // 
            this.MS_IntToBytes.Name = "MS_IntToBytes";
            this.MS_IntToBytes.Size = new System.Drawing.Size(173, 22);
            this.MS_IntToBytes.Text = "整数(Int)转字节";
            this.MS_IntToBytes.Click += new System.EventHandler(this.MS_IntToBytes_Click);
            // 
            // MS_FloatToBytes
            // 
            this.MS_FloatToBytes.Name = "MS_FloatToBytes";
            this.MS_FloatToBytes.Size = new System.Drawing.Size(173, 22);
            this.MS_FloatToBytes.Text = "浮点数(Float)转字节";
            this.MS_FloatToBytes.Click += new System.EventHandler(this.MS_FloatToBytes_Click);
            // 
            // MS_DoubleToBytes
            // 
            this.MS_DoubleToBytes.Name = "MS_DoubleToBytes";
            this.MS_DoubleToBytes.Size = new System.Drawing.Size(173, 22);
            this.MS_DoubleToBytes.Text = "浮点数(Double)转字节";
            this.MS_DoubleToBytes.Click += new System.EventHandler(this.MS_DoubleToBytes_Click);
            // 
            // MS_ShortToBytes
            // 
            this.MS_ShortToBytes.Name = "MS_ShortToBytes";
            this.MS_ShortToBytes.Size = new System.Drawing.Size(173, 22);
            this.MS_ShortToBytes.Text = "整数(Short)转字节";
            this.MS_ShortToBytes.Click += new System.EventHandler(this.MS_ShortToBytes_Click);
            // 
            // frmBytes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 67);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBytes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字节数值计算器";
            this.CMS_Main.ResumeLayout(false);
            this.CMS_Value.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LeafControl.BytesBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ContextMenuStrip CMS_Main;
        private System.Windows.Forms.ToolStripMenuItem MS_Clear;
        private System.Windows.Forms.ToolStripMenuItem MS_ToInt;
        private System.Windows.Forms.ToolStripMenuItem MS_ToFloat;
        private System.Windows.Forms.ToolStripMenuItem MS_ToDouble;
        private System.Windows.Forms.ContextMenuStrip CMS_Value;
        private System.Windows.Forms.ToolStripMenuItem MS_ClearValue;
        private System.Windows.Forms.ToolStripMenuItem MS_IntToBytes;
        private System.Windows.Forms.ToolStripMenuItem MS_FloatToBytes;
        private System.Windows.Forms.ToolStripMenuItem MS_DoubleToBytes;
        private System.Windows.Forms.ToolStripMenuItem MS_ShortToBytes;
    }
}