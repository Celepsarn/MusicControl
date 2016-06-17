using MusicControl.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicControl.Presentation
{
    public partial class SongWizzard : Form
    {
        public SongDTO song { get; set; }

        public SongWizzard()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (edSongName.Text.Equals(""))
            {
                edSongName.BackColor = ColorTranslator.FromHtml("#ff6666");
                MessageBox.Show("Kein Name wurde angegeben..", "Eingabe nicht vollständig", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                song = new SongDTO(edSongName.Text, edTrackNo.Text, edDuration.Text, edLyrics.Text, -1);
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
