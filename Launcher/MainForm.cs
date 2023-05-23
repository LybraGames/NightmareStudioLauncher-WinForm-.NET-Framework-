using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO.Compression;
using System.IO;
using System.Diagnostics;

namespace Launcher
{
    enum GameSelected
    {
        ENDLESSFIRE,
        THEBEAN
    }

    public partial class MainForm : Form
    {
        static XmlDocument xmlDocument = new XmlDocument();
        static WebClient webClient;

        static Image[] endlessfireImages =
        {
            Properties.Resources.endlessfire2,
            Properties.Resources.endlessfire3,
            Properties.Resources.endlessfire4,
            Properties.Resources.endlessfire5,
            Properties.Resources.endlessfire6,
            Properties.Resources.endlessfire7,
            Properties.Resources.endlessfire8,
            Properties.Resources.endlessfire9,
            Properties.Resources.endlessfire10,
            Properties.Resources.endlessfire11,
            Properties.Resources.endlessfire12,
            Properties.Resources.endlessfire13,
            Properties.Resources.endlessfire14,
        };
        static Image[] thebeanImages =
       {
            Properties.Resources.thebean1,
            Properties.Resources.thebean2,
            Properties.Resources.thebean3,
            Properties.Resources.thebean4,
            Properties.Resources.thebean5,
            Properties.Resources.thebean6,
            Properties.Resources.thebean7,
            Properties.Resources.thebean8,
            Properties.Resources.thebean9,
            Properties.Resources.thebean10,
            Properties.Resources.thebean11,
            Properties.Resources.thebean12,
            Properties.Resources.thebean13,
        };

        static int imageIndex = 0;
        GameSelected gameSelected;
        int endlessFireImageZoom = 1;
        int theBeanImageZoom = 1;

        static int gameSelectedIndex;
        static string[][] gamesVersionsURL;
        static List<int>[] gamesInstalledVersions;
        static Size[] gamesImageSize;
        static Point[] gamesImagePos;

        static string launcherVersion = "1.3";

        static string gamesLocation = string.Format(Directory.GetParent(Directory.GetCurrentDirectory()).FullName + @"\games\");



        public MainForm()
        {
            InitializeComponent();

            EndlessFire.EndlessFireChangeImage1.Click += new EventHandler(EndlessFireChangeImage1_Click);
            EndlessFire.EndlessFireChangeImage2.Click += new EventHandler(EndlessFireChangeImage2_Click);
            EndlessFire.EndlessFireImagePictureBox.Click += new EventHandler(EndlessFireImage_Click);

            TheBean.TheBeanChangeImage1.Click += new EventHandler(TheBeanChangeImage1_Click);
            TheBean.TheBeanChangeImage2.Click += new EventHandler(TheBeanChangeImage2_Click);
            TheBean.TheBeanImagePictureBox.Click += new EventHandler(TheBeanImage_Click);

            Library.TheBeanBannerPictureBox.Click += new EventHandler(TheBeanBanner_Click);
            Library.EndlessFireBannerPictureBox.Click += new EventHandler(EndlessFireBanner_Click);


            Footer.LibraryButton.Click += new EventHandler(LibraryButton_Click);
            Footer.HomeButton.Click += new EventHandler(HomeButton_Click);
            Footer.PlayButton.Click += new EventHandler(Play_Click);
            Footer.InstallButton.Click += new EventHandler(Install_Click);
            Footer.UnistallButton.Click += new EventHandler(Unistall_Click);
            Footer.GameVersionsComboBox.SelectedIndexChanged += new EventHandler(GamesVersions_SelectedIndexChanged_1);

        }

        public void LoadGameData(int gameIndex, string gameName)
        {
            DirectoryInfo gamesDirectory = new DirectoryInfo(gamesLocation + @"\" + gameName);
            XmlNode gameNode = xmlDocument.ChildNodes[0].ChildNodes[0].ChildNodes[gameIndex];

            foreach (DirectoryInfo directory in gamesDirectory.GetDirectories())
                gamesInstalledVersions[gameIndex].Add(int.Parse(directory.Name));



            gamesVersionsURL[gameIndex] = new string[gameNode.ChildNodes.Count];

            for (int y = 0; y < gameNode.ChildNodes.Count; y++)
            {
                gamesVersionsURL[gameIndex][y] = gameNode.ChildNodes[y].Attributes[1].Value;
            }


            gamesImagePos[gameIndex] = EndlessFire.EndlessFireImagePictureBox.Location;
            gamesImageSize[gameIndex] = EndlessFire.EndlessFireImagePictureBox.Size;
        }

        public void FinishDownloadXML()
        {
            Footer.LibraryButton.Visible = true;

            xmlDocument.Load(@".\data.xml");

            XmlNode gamesNode = xmlDocument.ChildNodes[0].ChildNodes[0];
            XmlNode root = xmlDocument.ChildNodes[0];

            if (!Directory.Exists(gamesLocation))
            {
                Directory.CreateDirectory(gamesLocation);

                for (int i = 0; i < gamesNode.ChildNodes.Count; i++)
                    Directory.CreateDirectory(gamesLocation + @"\" + gamesNode.ChildNodes[i].Name);
            }


            gamesVersionsURL = new string[gamesNode.ChildNodes.Count][];
            gamesInstalledVersions = new List<int>[2] { new List<int>(), new List<int>() };
            gamesImageSize = new Size[gamesNode.ChildNodes.Count];
            gamesImagePos = new Point[gamesNode.ChildNodes.Count];

            for (int i = 0; i < gamesNode.ChildNodes.Count; i++)
            {
                LoadGameData(i, gamesNode.ChildNodes[i].Name);
            }

            Home.NewsTextBox.Text = root.ChildNodes[2].InnerText;

            if (root.ChildNodes[1].Attributes[0].Value != launcherVersion)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to update?", "There is a newer version of the launcher!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetParent(Directory.GetCurrentDirectory()).FullName);
                    ProcessStartInfo processStartInfo = new ProcessStartInfo();
                    processStartInfo.FileName = Directory.GetParent(Directory.GetCurrentDirectory()).FullName + @"\Updater.exe";
                    processStartInfo.WorkingDirectory = directoryInfo.FullName;
                    Process.Start(processStartInfo);

                    Application.Exit();
                }
            }
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            Footer.LibraryButton.Visible = false;

            webClient = new WebClient();
            Uri uri = new Uri(@"https://www.dropbox.com/s/7vmfem44ejw7du3/data.xml?dl=1");
            webClient.DownloadFileAsync(uri, @".\data.xml");

            webClient.DownloadFileCompleted += delegate { FinishDownloadXML(); };
        }

        public void HomeButton_Click(object sender, EventArgs e)
        {
            Home.Visible = true;

            Library.Visible = false;
            TheBean.Visible = false;
            EndlessFire.Visible = false;
            Footer.GameVersionsComboBox.Visible = false;
            Footer.InstallButton.Visible = false;
            Footer.PlayButton.Visible = false;
            Footer.UnistallButton.Visible = false;
            Footer.SelectVersionLabel.Visible = false;
            Footer.GameVersionsComboBox.ResetText();

            TheBean.TheBeanImagePictureBox.Size = gamesImageSize[1];
            TheBean.TheBeanImagePictureBox.Location = gamesImagePos[1];

            theBeanImageZoom = 1;

            EndlessFire.EndlessFireImagePictureBox.Size = gamesImageSize[0];
            EndlessFire.EndlessFireImagePictureBox.Location = gamesImagePos[0];

            endlessFireImageZoom = 1;
        }

        public void LibraryButton_Click(object sender, EventArgs e)
        {
            Library.Visible = true;

            Home.Visible = false;
            TheBean.Visible = false;
            EndlessFire.Visible = false;
            Footer.GameVersionsComboBox.Visible = false;
            Footer.InstallButton.Visible = false;
            Footer.PlayButton.Visible = false;
            Footer.UnistallButton.Visible = false;
            Footer.SelectVersionLabel.Visible = false;
            Footer.GameVersionsComboBox.ResetText();

            TheBean.TheBeanImagePictureBox.Size = gamesImageSize[1];
            TheBean.TheBeanImagePictureBox.Location = gamesImagePos[1];

            theBeanImageZoom = 1;

            EndlessFire.EndlessFireImagePictureBox.Size = gamesImageSize[0];
            EndlessFire.EndlessFireImagePictureBox.Location = gamesImagePos[0];

            endlessFireImageZoom = 1;
        }

        public void EndlessFireBanner_Click(object sender, EventArgs e)
        {
            gameSelected = GameSelected.ENDLESSFIRE;
            gameSelectedIndex = 0;

            EndlessFire.Visible = true;

            Library.Visible = false;
            Home.Visible = false;
            TheBean.Visible = false;
            Footer.GameVersionsComboBox.Visible = true;
            Footer.SelectVersionLabel.Visible = true;

            Footer.GameVersionsComboBox.Items.Clear();

            XmlNode endlessFireNode = xmlDocument.ChildNodes[0].ChildNodes[0].ChildNodes[0];

            for (int y = 0; y < endlessFireNode.ChildNodes.Count; y++)
            {
                Footer.GameVersionsComboBox.Items.Add(endlessFireNode.ChildNodes[y].Attributes[0].Value);
            }
        }

        public void TheBeanBanner_Click(object sender, EventArgs e)
        {
            gameSelected = GameSelected.THEBEAN;
            gameSelectedIndex = 1;

            TheBean.Visible = true;
            EndlessFire.Visible = false;
            Library.Visible = false;
            Home.Visible = false;
            Footer.GameVersionsComboBox.Visible = true;
            Footer.SelectVersionLabel.Visible = true;

            Footer.GameVersionsComboBox.Items.Clear();

            XmlNode gamesNode = xmlDocument.ChildNodes[0].ChildNodes[0].ChildNodes[1];

            for (int y = 0; y < gamesNode.ChildNodes.Count; y++)
            {
                Footer.GameVersionsComboBox.Items.Add(gamesNode.ChildNodes[y].Attributes[0].Value);
            }
        }

        public void EndlessFireChangeImage1_Click(object sender, EventArgs e)
        {
            if (imageIndex > 0)
            {
                imageIndex -= 1;
                EndlessFire.EndlessFireImagePictureBox.Image = endlessfireImages[imageIndex];
            }
        }

        public void EndlessFireChangeImage2_Click(object sender, EventArgs e)
        {
            if (imageIndex < endlessfireImages.Length - 1)
            {
                imageIndex += 1;
                EndlessFire.EndlessFireImagePictureBox.Image = endlessfireImages[imageIndex];
            }
        }

        public void FinishDownload()
        {
            switch (gameSelected)
            {
                case GameSelected.ENDLESSFIRE:

                    ZipFile.ExtractToDirectory(gamesLocation + Footer.GameVersionsComboBox.SelectedIndex + ".zip", gamesLocation + @"\endlessfire\");
                    File.Delete(gamesLocation + Footer.GameVersionsComboBox.SelectedIndex + ".zip");
                    gamesInstalledVersions[gameSelectedIndex].Add(Footer.GameVersionsComboBox.SelectedIndex);

                    break;

                case GameSelected.THEBEAN:

                    ZipFile.ExtractToDirectory(gamesLocation + Footer.GameVersionsComboBox.SelectedIndex + ".zip", gamesLocation + @"\thebean\");
                    File.Delete(gamesLocation + Footer.GameVersionsComboBox.SelectedIndex + ".zip");
                    gamesInstalledVersions[gameSelectedIndex].Add(Footer.GameVersionsComboBox.SelectedIndex);

                    break;
            }


            Footer.DownloadBar.Visible = false;
            Footer.PlayButton.Visible = true;
            Footer.UnistallButton.Visible = true;
            Footer.GameVersionsComboBox.Visible = true;
            Footer.HomeButton.Visible = true;
            Footer.LibraryButton.Visible = true;
            Footer.DownloadValue.Visible = false;
            Footer.SelectVersionLabel.Visible = true;

            MessageBox.Show("The game has been installed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ProgressDownload(object sender, DownloadProgressChangedEventArgs e)
        {
            Footer.DownloadBar.Maximum = (int)e.TotalBytesToReceive / 100;
            Footer.DownloadBar.Value = (int)e.BytesReceived / 100;

            Footer.DownloadValue.Text = "Downloading: " +
                ((((float)e.BytesReceived / 100) / ((float)e.TotalBytesToReceive / 100)) * 100f).ToString("0")
                + "%";
        }

        public void Install_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to install this version?", "Warn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Uri uri = new Uri(gamesVersionsURL[gameSelectedIndex][Footer.GameVersionsComboBox.SelectedIndex]);


                webClient = new WebClient();
                webClient.DownloadFileAsync(uri, gamesLocation + Footer.GameVersionsComboBox.SelectedIndex + ".zip");

                Footer.DownloadBar.Visible = true;
                Footer.InstallButton.Visible = false;
                Footer.GameVersionsComboBox.Visible = false;
                Footer.HomeButton.Visible = false;
                Footer.LibraryButton.Visible = false;
                Footer.SelectVersionLabel.Visible = false;
                Footer.DownloadValue.Visible = true;

                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressDownload);

                webClient.DownloadFileCompleted += delegate { FinishDownload(); };
            }
        }

        public void Play_Click(object sender, EventArgs e)
        {
            string gameFiles = null;
            string gameEXE = null;

            switch (gameSelected)
            {
                case GameSelected.ENDLESSFIRE:
                    gameFiles = "endlessfire";
                    gameEXE = "EndlessFire.exe";
                    break;

                case GameSelected.THEBEAN:
                    gameFiles = "thebean";
                    gameEXE = "The Bean.exe";
                    break;
            }


            DirectoryInfo directoryInfo = new DirectoryInfo(string.Format(gamesLocation + @"{0}\", gameFiles));


            for (int i = 0; i < directoryInfo.GetDirectories().Length; i++)
            {
                if (directoryInfo.GetDirectories()[i].Name == Footer.GameVersionsComboBox.SelectedIndex.ToString())
                {
                    directoryInfo = directoryInfo.GetDirectories()[i];
                }
            }



            FileInfo[] fileInfos = directoryInfo.GetFiles();

            foreach (FileInfo file in fileInfos)
            {
                if (file.Name == gameEXE)
                {
                    ProcessStartInfo processStartInfo = new ProcessStartInfo();
                    processStartInfo.FileName = file.FullName;
                    processStartInfo.WorkingDirectory = directoryInfo.FullName;
                    Process.Start(processStartInfo);
                }
            }
        }

        public void Unistall_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to uninstall?", "Warn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string gameFiles = null;

                switch (gameSelected)
                {
                    case GameSelected.ENDLESSFIRE:
                        gameFiles = "endlessfire";
                        gamesInstalledVersions[gameSelectedIndex].Remove(Footer.GameVersionsComboBox.SelectedIndex);
                        break;

                    case GameSelected.THEBEAN:
                        gameFiles = "thebean";
                        gamesInstalledVersions[gameSelectedIndex].Remove(Footer.GameVersionsComboBox.SelectedIndex);
                        break;
                }



                Footer.UnistallButton.Visible = false;
                Footer.PlayButton.Visible = false;
                Footer.InstallButton.Visible = true;

                DirectoryInfo directoryInfo = new DirectoryInfo(string.Format(gamesLocation + @"{0}\", gameFiles));


                for (int i = 0; i < directoryInfo.GetDirectories().Length; i++)
                {
                    if (directoryInfo.GetDirectories()[i].Name == Footer.GameVersionsComboBox.SelectedIndex.ToString())
                    {
                        directoryInfo = directoryInfo.GetDirectories()[i];
                    }
                }

                directoryInfo.Delete(true);

                MessageBox.Show("The game has been uninstalled!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        public void TheBeanChangeImage1_Click(object sender, EventArgs e)
        {
            if (imageIndex > 0)
            {
                imageIndex -= 1;
                TheBean.TheBeanImagePictureBox.Image = thebeanImages[imageIndex];
            }
        }

        public void TheBeanChangeImage2_Click(object sender, EventArgs e)
        {
            if (imageIndex < thebeanImages.Length - 1)
            {
                imageIndex += 1;
                TheBean.TheBeanImagePictureBox.Image = thebeanImages[imageIndex];
            }
        }

        public void GamesVersions_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Footer.InstallButton.Visible = !gamesInstalledVersions[gameSelectedIndex].Contains(Footer.GameVersionsComboBox.SelectedIndex);
            Footer.PlayButton.Visible = gamesInstalledVersions[gameSelectedIndex].Contains(Footer.GameVersionsComboBox.SelectedIndex);
            Footer.UnistallButton.Visible = gamesInstalledVersions[gameSelectedIndex].Contains(Footer.GameVersionsComboBox.SelectedIndex);
        }

        public void EndlessFireImage_Click(object sender, EventArgs e)
        {
            if (endlessFireImageZoom == 1)
            {
                int sizeX = (int)960;
                int sizeY = (int)540;

                EndlessFire.EndlessFireImagePictureBox.Size = new Size(sizeX, sizeY);
                EndlessFire.EndlessFireImagePictureBox.Location = new Point(((int)((1135 / 2) - sizeX / 2) + 20), ((int)((446 / 2) - sizeY / 2) + 65));
                EndlessFire.EndlessFireImagePictureBox.BringToFront();

                endlessFireImageZoom = 2;
            }
            else
            {
                EndlessFire.EndlessFireImagePictureBox.Size = gamesImageSize[gameSelectedIndex];
                EndlessFire.EndlessFireImagePictureBox.Location = gamesImagePos[gameSelectedIndex];

                endlessFireImageZoom = 1;
            }
        }

        public void TheBeanImage_Click(object sender, EventArgs e)
        {
            if (theBeanImageZoom == 1)
            {
                int sizeX = (int)960;
                int sizeY = (int)540;

                TheBean.TheBeanImagePictureBox.Size = new Size(sizeX, sizeY);
                TheBean.TheBeanImagePictureBox.Location = new Point(((int)((1135 / 2) - sizeX / 2) + 20), ((int)((446 / 2) - sizeY / 2) + 65));

                TheBean.TheBeanImagePictureBox.BringToFront();

                theBeanImageZoom = 2;
            }
            else
            {
                TheBean.TheBeanImagePictureBox.Size = gamesImageSize[gameSelectedIndex];
                TheBean.TheBeanImagePictureBox.Location = gamesImagePos[gameSelectedIndex];

                theBeanImageZoom = 1;
            }
        }

    }
}
