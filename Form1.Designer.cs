namespace steamDLnew
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnClose = new System.Windows.Forms.Button();
            this.panelBar = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.listBoxDetails = new System.Windows.Forms.ListBox();
            this.lblDebug = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ico = new System.Windows.Forms.PictureBox();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ico)).BeginInit();
            this.SuspendLayout();
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
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBar.Controls.Add(this.title);
            this.panelBar.Controls.Add(this.btnMin);
            this.panelBar.Controls.Add(this.btnClose);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(683, 57);
            this.panelBar.TabIndex = 2;
            this.panelBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBar_Paint);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Ebrima", 12.1F);
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(48, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(279, 30);
            this.title.TabIndex = 2;
            this.title.Text = "SteamDL Rusted Warfare 2.0";
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMin.Location = new System.Drawing.Point(498, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(87, 49);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "Minimize";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // textBoxLink
            // 
            this.textBoxLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.textBoxLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLink.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLink.ForeColor = System.Drawing.Color.White;
            this.textBoxLink.Location = new System.Drawing.Point(12, 88);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(659, 29);
            this.textBoxLink.TabIndex = 3;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLink.Location = new System.Drawing.Point(12, 60);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(219, 25);
            this.lblLink.TabIndex = 4;
            this.lblLink.Text = "Enter Link to Modification:";
            // 
            // listBoxDetails
            // 
            this.listBoxDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.listBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxDetails.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDetails.ForeColor = System.Drawing.Color.White;
            this.listBoxDetails.FormattingEnabled = true;
            this.listBoxDetails.ItemHeight = 22;
            this.listBoxDetails.Location = new System.Drawing.Point(12, 148);
            this.listBoxDetails.Name = "listBoxDetails";
            this.listBoxDetails.Size = new System.Drawing.Size(659, 90);
            this.listBoxDetails.TabIndex = 5;
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebug.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDebug.Location = new System.Drawing.Point(12, 120);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(70, 25);
            this.lblDebug.TabIndex = 4;
            this.lblDebug.Text = "Debug:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(12, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Download File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStatus.Location = new System.Drawing.Point(176, 244);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(65, 25);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status:";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.progressBar1.Location = new System.Drawing.Point(181, 272);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(490, 15);
            this.progressBar1.TabIndex = 7;
            // 
            // ico
            // 
            this.ico.Image = global::steamDLnew.Properties.Resources.steamdl;
            this.ico.Location = new System.Drawing.Point(12, 12);
            this.ico.Name = "ico";
            this.ico.Size = new System.Drawing.Size(30, 30);
            this.ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico.TabIndex = 2;
            this.ico.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(683, 299);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxDetails);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.ico);
            this.Controls.Add(this.panelBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.PictureBox ico;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.ListBox listBoxDetails;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

