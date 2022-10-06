using streaming_neshtosi.View.Artist;
using streaming_neshtosi.View.janr;
using streaming_neshtosi.View.music_video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace streaming_neshtosi
{
    public partial class startpage : Form
    {
        public startpage()
        {
            InitializeComponent();
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            this.Hide();
            Artist Artist2 = new Artist();
            Artist2.Show();
            
        }

        private void btnJanr_Click(object sender, EventArgs e)
        {
            this.Hide();
            Genre Genre2 = new Genre();
            Genre2.Show();
        }

        private void btnMusicvideo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Music_Video MusicVid2 = new Music_Video();
            MusicVid2.Show();
        }
    }
}
