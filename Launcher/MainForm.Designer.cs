
namespace Launcher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Home = new Launcher.Home();
            this.Library = new Launcher.Library();
            this.Footer = new Launcher.Footer();
            this.EndlessFire = new Launcher.EndlessFire();
            this.TheBean = new Launcher.TheBean();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1280, 576);
            this.Home.TabIndex = 0;
            // 
            // Library
            // 
            this.Library.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Library.Location = new System.Drawing.Point(0, 0);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(1280, 576);
            this.Library.TabIndex = 2;
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.Gainsboro;
            this.Footer.Location = new System.Drawing.Point(35, 615);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(1200, 50);
            this.Footer.TabIndex = 1;
            // 
            // EndlessFire
            // 
            this.EndlessFire.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EndlessFire.Location = new System.Drawing.Point(0, 0);
            this.EndlessFire.Name = "EndlessFire";
            this.EndlessFire.Size = new System.Drawing.Size(1280, 576);
            this.EndlessFire.TabIndex = 3;
            // 
            // TheBean
            // 
            this.TheBean.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TheBean.Location = new System.Drawing.Point(0, 0);
            this.TheBean.Name = "TheBean";
            this.TheBean.Size = new System.Drawing.Size(1280, 576);
            this.TheBean.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Library);
            this.Controls.Add(this.EndlessFire);
            this.Controls.Add(this.TheBean);
            this.Controls.Add(this.Footer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "NightmareStudio Launcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Home Home;
        private Footer Footer;
        private Library Library;
        private EndlessFire EndlessFire;
        private TheBean TheBean;
    }
}

