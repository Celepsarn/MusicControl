using MusicControl.dto;
using MusicControl.Business;
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
    public partial class AlbumWizzard : Form
    {
        private List<SongDTO> songs = new List<SongDTO>();
        private string coverpath;
        public AlbumWizzard()
        {
            InitializeComponent();
        }

        //Loads interpreters and genres into their comboboxes. Also prepares some form components.
        private void AlbumWizzard_Load(object sender, EventArgs e)
        {
            FunctionController fc = new FunctionController();
            List<InterpretDTO> interprets = fc.getAllInterprets();
            foreach (InterpretDTO i in interprets)
            {
                cbInterprets.Items.Add(i.getName());
            }

            List<GenreDTO> genres = fc.getAllGenres();
            foreach (GenreDTO g in genres)
            {
                cbGenres.Items.Add(g.getName());
            }

            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbInterprets.SelectedItem == null)
            {
                cbInterprets.BackColor = ColorTranslator.FromHtml("#ff6666");
                MessageBox.Show("Kein Interpret wurde angegeben.", "Eingabe nicht vollständig", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (edName.Text == "")
            {
                edName.BackColor = ColorTranslator.FromHtml("#ff6666");
                MessageBox.Show("Kein Name wurde angegeben.", "Eingabe nicht vollständig", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listSongs.Items.Count == 0)
            {
                edName.BackColor = Color.White;
                MessageBox.Show("Alben müssen mindestens einen(1) Song beinhalten.", "Eingabe nicht vollständig", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Album a = new Album(edName.Text, edReleaseYear.Text, cbGenres.Text, cbInterprets.Text, coverpath);
                a.create();
                foreach (SongDTO songObj in songs)
                {
                    Song s = new Song(songObj.getName(), songObj.getTrackNo(), songObj.getDuration(), songObj.getSongtext(), edName.Text);
                    s.create();
                }
                Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SongWizzard modalFormSong = new SongWizzard();
            modalFormSong.ShowDialog();
            songs.Add(modalFormSong.song);
            listSongs.Items.Add(modalFormSong.song.getTrackNo() + " - " + modalFormSong.song.getName() + " | " + modalFormSong.song.getDuration());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FunctionController fc = new FunctionController();
            coverpath = fc.addCover();
            if (coverpath != null)
            {
                pictureBox1.Image = Image.FromFile(coverpath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
