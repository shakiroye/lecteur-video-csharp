namespace miabeLecteur2._1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnPlaying = new System.Windows.Forms.Button();
            this.ecran = new AxWMPLib.AxWindowsMediaPlayer();
            this.playlist = new System.Windows.Forms.ListBox();
            this.btnOpenMenu = new System.Windows.Forms.Button();
            this.btnCloseMenu = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecran)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.btnOuvrir);
            this.panelMenu.Controls.Add(this.btnPlaylist);
            this.panelMenu.Controls.Add(this.btnPlaying);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(221, 553);
            this.panelMenu.TabIndex = 0;
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOuvrir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOuvrir.FlatAppearance.BorderSize = 0;
            this.btnOuvrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOuvrir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuvrir.ForeColor = System.Drawing.Color.White;
            this.btnOuvrir.Image = ((System.Drawing.Image)(resources.GetObject("btnOuvrir.Image")));
            this.btnOuvrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOuvrir.Location = new System.Drawing.Point(0, 388);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(221, 55);
            this.btnOuvrir.TabIndex = 2;
            this.btnOuvrir.Text = "Ouvrir un fichier";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Image")));
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 443);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(221, 55);
            this.btnPlaylist.TabIndex = 1;
            this.btnPlaylist.Text = "Liste de lecture";
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnPlaying
            // 
            this.btnPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaying.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPlaying.FlatAppearance.BorderSize = 0;
            this.btnPlaying.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaying.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaying.ForeColor = System.Drawing.Color.White;
            this.btnPlaying.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaying.Image")));
            this.btnPlaying.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaying.Location = new System.Drawing.Point(0, 498);
            this.btnPlaying.Name = "btnPlaying";
            this.btnPlaying.Size = new System.Drawing.Size(221, 55);
            this.btnPlaying.TabIndex = 0;
            this.btnPlaying.Text = "En cours de lecture";
            this.btnPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaying.UseVisualStyleBackColor = true;
            this.btnPlaying.Click += new System.EventHandler(this.btnPlaying_Click);
            // 
            // ecran
            // 
            this.ecran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ecran.Enabled = true;
            this.ecran.Location = new System.Drawing.Point(221, 0);
            this.ecran.Name = "ecran";
            this.ecran.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ecran.OcxState")));
            this.ecran.Size = new System.Drawing.Size(661, 553);
            this.ecran.TabIndex = 1;
            // 
            // playlist
            // 
            this.playlist.BackColor = System.Drawing.Color.SteelBlue;
            this.playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playlist.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlist.ForeColor = System.Drawing.Color.White;
            this.playlist.FormattingEnabled = true;
            this.playlist.ItemHeight = 24;
            this.playlist.Location = new System.Drawing.Point(221, 0);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(661, 553);
            this.playlist.TabIndex = 2;
            this.playlist.SelectedIndexChanged += new System.EventHandler(this.playlist_SelectedIndexChanged);
            // 
            // btnOpenMenu
            // 
            this.btnOpenMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpenMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenMenu.FlatAppearance.BorderSize = 0;
            this.btnOpenMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenMenu.Image")));
            this.btnOpenMenu.Location = new System.Drawing.Point(0, 0);
            this.btnOpenMenu.Name = "btnOpenMenu";
            this.btnOpenMenu.Size = new System.Drawing.Size(31, 27);
            this.btnOpenMenu.TabIndex = 3;
            this.btnOpenMenu.UseVisualStyleBackColor = false;
            this.btnOpenMenu.Click += new System.EventHandler(this.btnOpenMenu_Click);
            // 
            // btnCloseMenu
            // 
            this.btnCloseMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCloseMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseMenu.FlatAppearance.BorderSize = 0;
            this.btnCloseMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseMenu.Image")));
            this.btnCloseMenu.Location = new System.Drawing.Point(221, 0);
            this.btnCloseMenu.Name = "btnCloseMenu";
            this.btnCloseMenu.Size = new System.Drawing.Size(31, 27);
            this.btnCloseMenu.TabIndex = 4;
            this.btnCloseMenu.UseVisualStyleBackColor = false;
            this.btnCloseMenu.Click += new System.EventHandler(this.btnCloseMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btnCloseMenu);
            this.Controls.Add(this.btnOpenMenu);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.ecran);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Miabe Lecteur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ecran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnPlaying;
        private AxWMPLib.AxWindowsMediaPlayer ecran;
        private System.Windows.Forms.ListBox playlist;
        private System.Windows.Forms.Button btnOpenMenu;
        private System.Windows.Forms.Button btnCloseMenu;
    }
}

