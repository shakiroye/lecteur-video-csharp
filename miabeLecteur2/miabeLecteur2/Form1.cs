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

namespace miabeLecteur2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listFile.Visible = false;
            btnPlay.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.play();
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() 
                    { Multiselect = true, ValidateNames = true, Filter = "MP4|*.mp4|AVI|*.avi|WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MKV|*.mkv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFile> files = new List<MediaFile>();  
                    foreach(string fileName in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(fileName);  
                        files.Add(new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                        this.Text = "Miabe Lecteur - "+fi.Name;
                    }
                    listFile.DataSource = files;
                }
            }
        }

        private void listFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFile file = listFile.SelectedItem as MediaFile;
            if(file != null)
            {
                axWindowsMediaPlayer.URL = file.Path;
                axWindowsMediaPlayer.Ctlcontrols.play(); 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listFile.ValueMember = "Path";
            listFile.DisplayMember = "FileName";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.stop();
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.next();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.previous();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void btnPause_MouseClick(object sender, MouseEventArgs e)
        {
            btnPlay.Visible = true;
            btnPause.Visible = false;
        }

        private void btnPlay_MouseClick(object sender, MouseEventArgs e)
        {
            btnPlay.Visible = false;
            btnPause.Visible = true;
        }

        private void btnStop_MouseClick(object sender, MouseEventArgs e)
        {
            btnPlay.Visible = true;
            btnPause.Visible = false;
        }
    }
}
