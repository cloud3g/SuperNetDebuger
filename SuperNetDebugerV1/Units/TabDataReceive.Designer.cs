namespace LeafSoft.Units
{
    partial class TabDataReceive
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
            this.CMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.tabData = new System.Windows.Forms.TabControl();
            this.MS_CloseALL = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CloseOthers = new System.Windows.Forms.ToolStripMenuItem();
            this.CMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMenu
            // 
            this.CMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Close,
            this.MS_CloseALL,
            this.MS_CloseOthers});
            this.CMenu.Name = "contextMenuStrip1";
            this.CMenu.ShowImageMargin = false;
            this.CMenu.Size = new System.Drawing.Size(148, 92);
            // 
            // MS_Close
            // 
            this.MS_Close.Name = "MS_Close";
            this.MS_Close.Size = new System.Drawing.Size(147, 22);
            this.MS_Close.Text = "关闭";
            this.MS_Close.Click += new System.EventHandler(this.MS_Close_Click);
            // 
            // tabData
            // 
            this.tabData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabData.Location = new System.Drawing.Point(0, 0);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(536, 322);
            this.tabData.TabIndex = 1;
            this.tabData.DoubleClick += new System.EventHandler(this.tabData_DoubleClick);
            // 
            // MS_CloseALL
            // 
            this.MS_CloseALL.Name = "MS_CloseALL";
            this.MS_CloseALL.Size = new System.Drawing.Size(147, 22);
            this.MS_CloseALL.Text = "全部关闭";
            this.MS_CloseALL.Click += new System.EventHandler(this.MS_CloseALL_Click);
            // 
            // MS_CloseOthers
            // 
            this.MS_CloseOthers.Name = "MS_CloseOthers";
            this.MS_CloseOthers.Size = new System.Drawing.Size(147, 22);
            this.MS_CloseOthers.Text = "除此之外全部关闭";
            this.MS_CloseOthers.Click += new System.EventHandler(this.MS_CloseOthers_Click);
            // 
            // TabDataReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabData);
            this.Name = "TabDataReceive";
            this.Size = new System.Drawing.Size(536, 322);
            this.CMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip CMenu;
        private System.Windows.Forms.ToolStripMenuItem MS_Close;
        private System.Windows.Forms.TabControl tabData;
        private System.Windows.Forms.ToolStripMenuItem MS_CloseALL;
        private System.Windows.Forms.ToolStripMenuItem MS_CloseOthers;
    }
}
