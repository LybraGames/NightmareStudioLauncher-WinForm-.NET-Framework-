
namespace Launcher
{
    partial class Footer
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
            this.InstallButton = new System.Windows.Forms.Button();
            this.UnistallButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.GameVersionsComboBox = new System.Windows.Forms.ComboBox();
            this.SelectVersionLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.LibraryButton = new System.Windows.Forms.Button();
            this.DownloadBar = new System.Windows.Forms.ProgressBar();
            this.DownloadValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstallButton
            // 
            this.InstallButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.InstallButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InstallButton.FlatAppearance.BorderSize = 2;
            this.InstallButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.InstallButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.InstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallButton.Location = new System.Drawing.Point(800, 8);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(100, 35);
            this.InstallButton.TabIndex = 0;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = false;
            this.InstallButton.Visible = false;
            // 
            // UnistallButton
            // 
            this.UnistallButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UnistallButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnistallButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.UnistallButton.FlatAppearance.BorderSize = 2;
            this.UnistallButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.UnistallButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.UnistallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnistallButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnistallButton.Location = new System.Drawing.Point(800, 8);
            this.UnistallButton.Name = "UnistallButton";
            this.UnistallButton.Size = new System.Drawing.Size(100, 35);
            this.UnistallButton.TabIndex = 1;
            this.UnistallButton.Text = "Unistall";
            this.UnistallButton.UseVisualStyleBackColor = false;
            this.UnistallButton.Visible = false;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PlayButton.FlatAppearance.BorderSize = 2;
            this.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(694, 8);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(100, 35);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Visible = false;
            // 
            // GameVersionsComboBox
            // 
            this.GameVersionsComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.GameVersionsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameVersionsComboBox.DropDownHeight = 200;
            this.GameVersionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameVersionsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameVersionsComboBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameVersionsComboBox.FormattingEnabled = true;
            this.GameVersionsComboBox.IntegralHeight = false;
            this.GameVersionsComboBox.ItemHeight = 17;
            this.GameVersionsComboBox.Location = new System.Drawing.Point(1043, 14);
            this.GameVersionsComboBox.MaxDropDownItems = 99;
            this.GameVersionsComboBox.Name = "GameVersionsComboBox";
            this.GameVersionsComboBox.Size = new System.Drawing.Size(144, 25);
            this.GameVersionsComboBox.TabIndex = 3;
            this.GameVersionsComboBox.Visible = false;
            // 
            // SelectVersionLabel
            // 
            this.SelectVersionLabel.AutoSize = true;
            this.SelectVersionLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectVersionLabel.Location = new System.Drawing.Point(918, 16);
            this.SelectVersionLabel.Name = "SelectVersionLabel";
            this.SelectVersionLabel.Size = new System.Drawing.Size(119, 18);
            this.SelectVersionLabel.TabIndex = 4;
            this.SelectVersionLabel.Text = "Select a version";
            this.SelectVersionLabel.Visible = false;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HomeButton.FlatAppearance.BorderSize = 2;
            this.HomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Location = new System.Drawing.Point(3, 3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(100, 44);
            this.HomeButton.TabIndex = 5;
            this.HomeButton.Text = "HOME";
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // LibraryButton
            // 
            this.LibraryButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LibraryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LibraryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LibraryButton.FlatAppearance.BorderSize = 2;
            this.LibraryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.LibraryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.LibraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LibraryButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryButton.Location = new System.Drawing.Point(109, 3);
            this.LibraryButton.Name = "LibraryButton";
            this.LibraryButton.Size = new System.Drawing.Size(100, 44);
            this.LibraryButton.TabIndex = 6;
            this.LibraryButton.Text = "LIBRARY";
            this.LibraryButton.UseVisualStyleBackColor = false;
            // 
            // DownloadBar
            // 
            this.DownloadBar.BackColor = System.Drawing.Color.DarkGray;
            this.DownloadBar.Location = new System.Drawing.Point(188, 14);
            this.DownloadBar.Name = "DownloadBar";
            this.DownloadBar.Size = new System.Drawing.Size(233, 19);
            this.DownloadBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DownloadBar.TabIndex = 7;
            this.DownloadBar.Visible = false;
            // 
            // DownloadValue
            // 
            this.DownloadValue.AutoSize = true;
            this.DownloadValue.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadValue.Location = new System.Drawing.Point(13, 14);
            this.DownloadValue.Name = "DownloadValue";
            this.DownloadValue.Size = new System.Drawing.Size(140, 19);
            this.DownloadValue.TabIndex = 8;
            this.DownloadValue.Text = "Download: 100%";
            this.DownloadValue.Visible = false;
            // 
            // Footer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.DownloadValue);
            this.Controls.Add(this.DownloadBar);
            this.Controls.Add(this.SelectVersionLabel);
            this.Controls.Add(this.GameVersionsComboBox);
            this.Controls.Add(this.InstallButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.LibraryButton);
            this.Controls.Add(this.UnistallButton);
            this.Controls.Add(this.PlayButton);
            this.Name = "Footer";
            this.Size = new System.Drawing.Size(1200, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button InstallButton;
        public System.Windows.Forms.Button UnistallButton;
        public System.Windows.Forms.Button PlayButton;
        public System.Windows.Forms.ComboBox GameVersionsComboBox;
        public System.Windows.Forms.Label SelectVersionLabel;
        public System.Windows.Forms.Button HomeButton;
        public System.Windows.Forms.Button LibraryButton;
        public System.Windows.Forms.ProgressBar DownloadBar;
        public System.Windows.Forms.Label DownloadValue;
    }
}
