using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miabeLecteur2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ecran.Visible = true;
            playlist.Visible = false;
            btnOpenMenu.Visible = false;
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            { Multiselect = true, ValidateNames = true, Filter = "MP4|*.mp4|AVI|*.avi|WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MKV|*.mkv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFile> files = new List<MediaFile>();
                    foreach (string fileName in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(fileName);
                        files.Add(new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                        this.Text = "Miabe Lecteur - " + fi.Name;
                    }
                    playlist.DataSource = files;
                }
            }
        }

        private void playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFile file = playlist.SelectedItem as MediaFile;
            if (file != null)
            {
                ecran.URL = file.Path;
                ecran.Ctlcontrols.play();
            }
            ecran.Visible = true;
            playlist.Visible = false;
            btnCloseMenu.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playlist.ValueMember = "Path";
            playlist.DisplayMember = "FileName";
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            ecran.Visible = false;
            playlist.Visible = true;
            btnOpenMenu.Visible = false;
            btnCloseMenu.Visible = false;
        }

        private void btnPlaying_Click(object sender, EventArgs e)
        {
            ecran.Visible = true;
            playlist.Visible = false;
            btnOpenMenu.Visible = false;
            btnCloseMenu.Visible = true;
        }

        private void btnOpenMenu_Click(object sender, EventArgs e)
        {
            btnCloseMenu.Visible = true;
            panelMenu.Visible = true;
            btnOpenMenu.Visible = false;
        }

        private void btnCloseMenu_Click(object sender, EventArgs e)
        {
            btnCloseMenu.Visible = false;
            panelMenu.Visible = false;
            btnOpenMenu.Visible = true;
        }
    }
}
