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
    public partial class GenreWizzard : Form
    {
        public GenreWizzard()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FunctionController fc = new FunctionController();

            if (edName.Text.Equals(""))
            {
                edName.BackColor = ColorTranslator.FromHtml("#ff6666");
                MessageBox.Show("Kein Name wurde angegeben.", "Eingabe nicht vollständig", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (fc.objectAlreadyExists(edName.Text, "Genre"))
            {
                edName.BackColor = ColorTranslator.FromHtml("#ff6666");
                MessageBox.Show("Genre existiert bereits.", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Genre g = new Genre(edName.Text);
                g.create();
                Close();
            }
        }
    }
}
