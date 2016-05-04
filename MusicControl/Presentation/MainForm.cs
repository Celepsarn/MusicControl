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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnDetailEditing_Paint(object sender, PaintEventArgs e)
        {

        }

        private void interpretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterpretWizzard modalForm = new InterpretWizzard();
            modalForm.ShowDialog();
        }
    }
}
