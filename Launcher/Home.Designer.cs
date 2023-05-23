
namespace Launcher
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.NewsTextBox = new System.Windows.Forms.TextBox();
            this.NewsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(250, 250);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AboutLabel.Location = new System.Drawing.Point(772, 154);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(456, 96);
            this.AboutLabel.TabIndex = 1;
            this.AboutLabel.Text = "NightmareStudio Launcher is an application \r\nwith which you can download and inst" +
    "all all \r\ngames made by NightmareStudio\r\n\r\n";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NameLabel.Location = new System.Drawing.Point(729, 63);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(498, 44);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "NightmareStudio Launcher\r\n";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VersionLabel.Location = new System.Drawing.Point(1163, 25);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(79, 17);
            this.VersionLabel.TabIndex = 3;
            this.VersionLabel.Text = "version 1.3";
            // 
            // NewsTextBox
            // 
            this.NewsTextBox.BackColor = System.Drawing.Color.DimGray;
            this.NewsTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewsTextBox.ForeColor = System.Drawing.Color.White;
            this.NewsTextBox.Location = new System.Drawing.Point(737, 319);
            this.NewsTextBox.Multiline = true;
            this.NewsTextBox.Name = "NewsTextBox";
            this.NewsTextBox.ReadOnly = true;
            this.NewsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NewsTextBox.Size = new System.Drawing.Size(491, 172);
            this.NewsTextBox.TabIndex = 4;
            // 
            // NewsLabel
            // 
            this.NewsLabel.AutoSize = true;
            this.NewsLabel.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewsLabel.ForeColor = System.Drawing.Color.White;
            this.NewsLabel.Location = new System.Drawing.Point(733, 276);
            this.NewsLabel.Name = "NewsLabel";
            this.NewsLabel.Size = new System.Drawing.Size(73, 24);
            this.NewsLabel.TabIndex = 5;
            this.NewsLabel.Text = "NEWS";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.NewsLabel);
            this.Controls.Add(this.NewsTextBox);
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1280, 576);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label VersionLabel;
        public System.Windows.Forms.TextBox NewsTextBox;
        private System.Windows.Forms.Label NewsLabel;
    }
}
