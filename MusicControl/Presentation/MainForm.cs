using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicControl.dto;
using MusicControl.Business;

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

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlbumWizzard modalForm = new AlbumWizzard();
            modalForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            prepareTree();
        }

        //adds the nodes to the tree and fills the objects in
        private void prepareTree()
        {
            List<InterpretDTO> interprets = new List<InterpretDTO>();
            FunctionController fc = new FunctionController();
            interprets = fc.getAllInterprets();
            foreach (InterpretDTO i in interprets)
            {
                string letter = i.getName().Substring(0, 1);
                if (treeMain.Nodes.Find(letter, false).Length == 0)
                {
                    treeMain.Nodes[0].Nodes.Add(letter.ToUpper());
                }
            }
            treeMain.Nodes[0].Expand();
        }
    }
}
