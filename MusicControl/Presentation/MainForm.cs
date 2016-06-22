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
        string coverpath;
        List<InterpretDTO> favInterprets = new List<InterpretDTO>();

        public MainForm()
        {
            InitializeComponent();
            löschenToolStripMenuItem.Enabled = false;
            alsFavoritMarkierenToolStripMenuItem.Enabled = false;
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
            prepareTree();
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
            pnDetailEditing.BackgroundImageLayout = ImageLayout.Center;
        }

        //adds the nodes to the tree and fills the objects in
        private void prepareTree()
        {
            treeMain.Nodes[0].Nodes.Clear();
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

        public void updateFavs()
        {
            favList.Items.Clear();
            foreach(InterpretDTO fav in favInterprets)
            {
                favList.Items.Add(fav.getName());
            }
        }
        private void treeMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            FunctionController fc = new FunctionController();
            string typeOfNode = getTypeOfNode(e.Node);
            setDetailEditingPanelsInvisible();
            if (typeOfNode == "interpret")
            {
                String interpretName = e.Node.Text;
                InterpretDTO iDTO = fc.getInterpretByName(interpretName);
                löschenToolStripMenuItem.Enabled = true;
                alsFavoritMarkierenToolStripMenuItem.Enabled = true;
                
                pnDetailEditingInterpret.Visible = true;
                edDetailEditingInterpretName.Text = iDTO.getName();
                edDetailEditingInterpretFoundationYear.Text = iDTO.getFoundationYear();
                edDetailEditingInterpretLand.Text = iDTO.getLand();
                edDetailEditingInterpretNoOfAlbums.Text = fc.getAlbumsByInterpret(iDTO.getName()).Count.ToString();
            }
            else if (typeOfNode == "album")
            {
                String albumName = e.Node.Text;
                AlbumDTO aDTO = fc.getAlbumByName(albumName);
                List<SongDTO> songs = new List<SongDTO>();
                listSongs.Items.Clear();

                pnDetailEditingAlbum.Visible = true;
                edDetailEditingAlbumName.Text = aDTO.getName();
                edDetailEditingAlbumInterpret.Text = fc.getInterpretNameById(aDTO.getInterpret());
                edDetailEditingAlbumYear.Text = aDTO.getReleaseYear();
                edDetailEditingAlbumGenre.Text = fc.getGenreById(aDTO.getGenre());
                if (aDTO.getCoverpath() != null && aDTO.getCoverpath() != "")
                {
                    pictureBox1.Image = Image.FromFile(aDTO.getCoverpath());
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox1.Image = null;
                }

                songs = fc.getAllSongsByAlbum(albumName);
                foreach (SongDTO song in songs)
                {
                    listSongs.Items.Add(song.getTrackNo() + " - " + song.getName() + " | " + song.getDuration());
                }
                
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
            string name = treeMain.SelectedNode.Text;
            string typeOfObject = getTypeOfNode(treeMain.SelectedNode);
            if (typeOfObject.Equals("interpret"))
            {
                Interpret i = new Interpret(name, "", "");
                i.delete(name);
            }
            else if (typeOfObject.Equals("album"))
            {
                Album a = new Album(name, "", "", "", "");
                a.delete(name);
            }
            prepareTree();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            FunctionController fc = new FunctionController();
            coverpath = fc.addCover();
            if (coverpath != null)
            {
                pictureBox1.Image = Image.FromFile(coverpath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FunctionController fc = new FunctionController();
            AlbumDTO aDTO = new AlbumDTO(edDetailEditingAlbumName.Text, edDetailEditingAlbumYear.Text, fc.getGenreIdByName(edDetailEditingAlbumGenre.Text), fc.getInterpretIdByName(edDetailEditingAlbumInterpret.Text), coverpath);
            fc.updateAlbum(aDTO);
        }

        private void alsFavoritMarkierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionController fc = new FunctionController();
            string selectedInterpret = treeMain.SelectedNode.Name;
            InterpretDTO iDTO = fc.getInterpretByName(selectedInterpret);
            favInterprets.Add(iDTO);
            updateFavs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FunctionController fc = new FunctionController();
            InterpretDTO iDTO = new InterpretDTO(edDetailEditingInterpretName.Text, edDetailEditingInterpretFoundationYear.Text, edDetailEditingInterpretLand.Text);
            fc.updateInterpret(iDTO);
        }
    }
}
