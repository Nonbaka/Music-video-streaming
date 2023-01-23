using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace streaming_neshtosi.View.Artist
{
    public partial class Artist : Form
    {
        public Artist()
        {
            InitializeComponent();
        }

        private void Artist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicStreamingDBDataSet.Artist' table. You can move, or remove it, as needed.
            this.artistTableAdapter.Fill(this.musicStreamingDBDataSet.Artist);

        }

        private void btnCreate1_Click(object sender, EventArgs e)
        {

        }
    }
}
