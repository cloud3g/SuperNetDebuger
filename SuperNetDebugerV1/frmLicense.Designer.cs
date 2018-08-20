namespace LeafSoft
{
    partial class frmLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicense));
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
            this.lblLicense.Size = new System.Drawing.Size(816, 222);
            this.lblLicense.TabIndex = 0;
            this.lblLicense.Text = resources.GetString("lblLicense.Text");
            this.lblLicense.Click += new System.EventHandler(this.lblLicense_Click);
            // 
            // frmLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 222);
            this.Controls.Add(this.lblLicense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLicense;
    }
}