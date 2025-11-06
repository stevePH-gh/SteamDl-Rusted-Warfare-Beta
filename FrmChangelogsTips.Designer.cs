namespace steamDLnew
{
    partial class FrmChangelogsTips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangelogsTips));
            this.panelBar = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDownloadcmd = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSeeFull = new System.Windows.Forms.Button();
            this.panelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBar.Controls.Add(this.btnDownloadcmd);
            this.panelBar.Controls.Add(this.title);
            this.panelBar.Controls.Add(this.btnClose);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(683, 57);
            this.panelBar.TabIndex = 3;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Ebrima", 12.1F);
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(13, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(147, 30);
            this.title.TabIndex = 2;
            this.title.Text = "CHANGELOGS";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(591, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 49);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDownloadcmd
            // 
            this.btnDownloadcmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadcmd.ForeColor = System.Drawing.Color.White;
            this.btnDownloadcmd.Location = new System.Drawing.Point(398, 3);
            this.btnDownloadcmd.Name = "btnDownloadcmd";
            this.btnDownloadcmd.Size = new System.Drawing.Size(187, 49);
            this.btnDownloadcmd.TabIndex = 3;
            this.btnDownloadcmd.Text = "Download SteamCMD";
            this.btnDownloadcmd.UseVisualStyleBackColor = true;
            this.btnDownloadcmd.Click += new System.EventHandler(this.btnDownloadcmd_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(659, 477);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnSeeFull
            // 
            this.btnSeeFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnSeeFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeFull.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeFull.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSeeFull.Location = new System.Drawing.Point(12, 509);
            this.btnSeeFull.Name = "btnSeeFull";
            this.btnSeeFull.Size = new System.Drawing.Size(659, 47);
            this.btnSeeFull.TabIndex = 5;
            this.btnSeeFull.Text = "See Full Changelog on GitHub";
            this.btnSeeFull.UseVisualStyleBackColor = false;
            // 
            // FrmChangelogsTips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(683, 568);
            this.ControlBox = false;
            this.Controls.Add(this.btnSeeFull);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panelBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangelogsTips";
            this.Text = "Change Logs";
            this.Load += new System.EventHandler(this.FrmChangelogsTips_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmChangelogsTips_MouseDown);
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDownloadcmd;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSeeFull;
    }
}