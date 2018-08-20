namespace LeafSoft.PartPanel
{
    partial class SocketMonitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxServerIP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxProtocol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nmTargetPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmSourcePort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSourceIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtData = new LeafSoft.LeafControl.BytesBox();
            this.txtTargetIP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgPacket = new System.Windows.Forms.DataGridView();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourcePort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTargetPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSourcePort)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacket)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxServerIP
            // 
            this.cbxServerIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServerIP.FormattingEnabled = true;
            this.cbxServerIP.Location = new System.Drawing.Point(621, 3);
            this.cbxServerIP.Name = "cbxServerIP";
            this.cbxServerIP.Size = new System.Drawing.Size(119, 20);
            this.cbxServerIP.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "本地";
            // 
            // btnMonitor
            // 
            this.btnMonitor.Enabled = false;
            this.btnMonitor.Location = new System.Drawing.Point(590, 26);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(150, 23);
            this.btnMonitor.TabIndex = 12;
            this.btnMonitor.Text = "监视";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Clear});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(76, 26);
            // 
            // MS_Clear
            // 
            this.MS_Clear.Name = "MS_Clear";
            this.MS_Clear.Size = new System.Drawing.Size(75, 22);
            this.MS_Clear.Text = "清空";
            this.MS_Clear.Click += new System.EventHandler(this.MS_Clear_Click);
            // 
            // cbxProtocol
            // 
            this.cbxProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProtocol.FormattingEnabled = true;
            this.cbxProtocol.Items.AddRange(new object[] {
            "ALL",
            "TCP",
            "UDP",
            "IGMP",
            "ICMP"});
            this.cbxProtocol.Location = new System.Drawing.Point(41, 20);
            this.cbxProtocol.Name = "cbxProtocol";
            this.cbxProtocol.Size = new System.Drawing.Size(45, 20);
            this.cbxProtocol.TabIndex = 15;
            this.cbxProtocol.SelectedIndexChanged += new System.EventHandler(this.cbxProtocol_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "协议";
            // 
            // nmTargetPort
            // 
            this.nmTargetPort.Location = new System.Drawing.Point(512, 18);
            this.nmTargetPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmTargetPort.Name = "nmTargetPort";
            this.nmTargetPort.Size = new System.Drawing.Size(56, 21);
            this.nmTargetPort.TabIndex = 26;
            this.nmTargetPort.ValueChanged += new System.EventHandler(this.nmTargetPort_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "目标端口";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "目标IP";
            // 
            // nmSourcePort
            // 
            this.nmSourcePort.Location = new System.Drawing.Point(259, 19);
            this.nmSourcePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmSourcePort.Name = "nmSourcePort";
            this.nmSourcePort.Size = new System.Drawing.Size(56, 21);
            this.nmSourcePort.TabIndex = 22;
            this.nmSourcePort.ValueChanged += new System.EventHandler(this.nmSourcePort_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "源端口";
            // 
            // txtSourceIP
            // 
            this.txtSourceIP.Location = new System.Drawing.Point(117, 20);
            this.txtSourceIP.Name = "txtSourceIP";
            this.txtSourceIP.Size = new System.Drawing.Size(98, 21);
            this.txtSourceIP.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "源IP";
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.EncodeType = LeafSoft.Lib.EnumType.DataEncode.Hex;
            this.txtData.Location = new System.Drawing.Point(3, 313);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(740, 170);
            this.txtData.TabIndex = 21;
            // 
            // txtTargetIP
            // 
            this.txtTargetIP.Location = new System.Drawing.Point(358, 18);
            this.txtTargetIP.Name = "txtTargetIP";
            this.txtTargetIP.Size = new System.Drawing.Size(98, 21);
            this.txtTargetIP.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxProtocol);
            this.groupBox1.Controls.Add(this.txtTargetIP);
            this.groupBox1.Controls.Add(this.txtSourceIP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nmSourcePort);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmTargetPort);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 49);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选条件";
            // 
            // dgPacket
            // 
            this.dgPacket.AllowUserToAddRows = false;
            this.dgPacket.AllowUserToDeleteRows = false;
            this.dgPacket.AllowUserToResizeRows = false;
            this.dgPacket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPacket.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgPacket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPacket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Protocol,
            this.SourceIP,
            this.SourcePort,
            this.TargetIP,
            this.TargetPort});
            this.dgPacket.ContextMenuStrip = this.contextMenuStrip1;
            this.dgPacket.Location = new System.Drawing.Point(2, 58);
            this.dgPacket.MultiSelect = false;
            this.dgPacket.Name = "dgPacket";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgPacket.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPacket.RowHeadersVisible = false;
            this.dgPacket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPacket.RowTemplate.Height = 23;
            this.dgPacket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPacket.Size = new System.Drawing.Size(740, 251);
            this.dgPacket.TabIndex = 32;
            this.dgPacket.SelectionChanged += new System.EventHandler(this.dgPacket_SelectionChanged);
            // 
            // Protocol
            // 
            this.Protocol.DataPropertyName = "Protocol";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Protocol.DefaultCellStyle = dataGridViewCellStyle2;
            this.Protocol.HeaderText = "协议";
            this.Protocol.Name = "Protocol";
            this.Protocol.ReadOnly = true;
            this.Protocol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Protocol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Protocol.Width = 60;
            // 
            // SourceIP
            // 
            this.SourceIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SourceIP.DataPropertyName = "SourceIP";
            this.SourceIP.HeaderText = "源IP";
            this.SourceIP.Name = "SourceIP";
            this.SourceIP.ReadOnly = true;
            // 
            // SourcePort
            // 
            this.SourcePort.DataPropertyName = "SourcePort";
            this.SourcePort.HeaderText = "源端口";
            this.SourcePort.Name = "SourcePort";
            this.SourcePort.ReadOnly = true;
            // 
            // TargetIP
            // 
            this.TargetIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TargetIP.DataPropertyName = "TargetIP";
            this.TargetIP.HeaderText = "目的IP";
            this.TargetIP.Name = "TargetIP";
            this.TargetIP.ReadOnly = true;
            // 
            // TargetPort
            // 
            this.TargetPort.DataPropertyName = "TargetPort";
            this.TargetPort.HeaderText = "目的端口";
            this.TargetPort.Name = "TargetPort";
            this.TargetPort.ReadOnly = true;
            // 
            // SocketMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgPacket);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cbxServerIP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMonitor);
            this.Name = "SocketMonitor";
            this.Size = new System.Drawing.Size(743, 486);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmTargetPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSourcePort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxServerIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.TextBox txtSourceIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmTargetPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmSourcePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxProtocol;
        private System.Windows.Forms.Label label6;
        private LeafControl.BytesBox txtData;
        private System.Windows.Forms.TextBox txtTargetIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Clear;
        private System.Windows.Forms.DataGridView dgPacket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourcePort;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetPort;
    }
}
