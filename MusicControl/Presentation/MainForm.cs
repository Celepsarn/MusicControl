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

        private void interpretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterpretWizzard modalForm = new InterpretWizzard();
            modalForm.ShowDialog();
            prepareTree();
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlbumWizzard modalForm = new AlbumWizzard();
            modalForm.ShowDialog();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenreWizzard modalForm = new GenreWizzard();
            modalForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            setDetailEditingPanelsInvisible();
            prepareTree();
        }

        //adds the nodes to the tree and fills the objects in
        private void prepareTree()
        {
            List<InterpretDTO> interprets = new List<InterpretDTO>();
            List<String> albums = new List<string>();
            FunctionController fc = new FunctionController();
            interprets = fc.getAllInterprets();
            foreach (InterpretDTO i in interprets)
            {
                string interpretName = i.getName();
                string letter = interpretName.Substring(0, 1);
    
                if (!(treeMain.Nodes[0].Nodes.ContainsKey(letter)))
                {
                    treeMain.Nodes[0].Nodes.Add(letter.ToUpper(), letter.ToUpper());
                }
                TreeNode[] currentNode = treeMain.Nodes[0].Nodes.Find(letter, true);
                currentNode[0].Nodes.Add(interpretName, interpretName);
                albums = fc.getAlbumsByInterpret(interpretName);
                currentNode = treeMain.Nodes.Find(interpretName, true);
                foreach (String a in albums)
                {
                    currentNode[0].Nodes.Add(a);
                }
                
            }
            treeMain.Nodes[0].Expand();
        }

        private void treeMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string typeOfNode = getTypeOfNode(e.Node);
            setDetailEditingPanelsInvisible();
            if (typeOfNode == "interpret")
            {
                String interpretName = e.Node.Text;

                pnDetailEditingInterpret.Visible = true;
                edDetailEditingInterpretName.Text = 
            }
            else if (typeOfNode == "album")
            {
                String albumName = e.Node.Text;
                pnDetailEditingAlbum.Visible = true;
            }

        }

        private void setDetailEditingPanelsInvisible()
        {
            pnDetailEditingAlbum.Visible = false;
            pnDetailEditingInterpret.Visible = false;
        }

        private string getTypeOfNode(TreeNode node)
        {
            if (node == treeMain.Nodes[0] || node.Parent == treeMain.Nodes[0]) 
            {
                return "no Propagate";
            }
            else if (node.Parent.Parent == treeMain.Nodes[0])
            {
                return "interpret";
            }
            else if ((node.Parent.Parent.Parent == treeMain.Nodes[0]))
            {
                return "album";
            }
            else
            {
                return "no Propagate";
            }
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = treeMain.SelectedNode.Name;
            string typeOfObject = getTypeOfNode(treeMain.SelectedNode);
            if (typeOfObject.Equals("interpret"))
            {
                Interpret i = new Interpret(name, "", "");
            }
            prepareTree();
        }
    }
}
