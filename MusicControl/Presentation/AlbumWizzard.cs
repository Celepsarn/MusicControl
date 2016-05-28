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
        public AlbumWizzard()
        {
            InitializeComponent();
        }

        //Loads interpreters into the combobox
        private void AlbumWizzard_Load(object sender, EventArgs e)
        {
            FunctionController fc = new FunctionController();
            List<InterpretDTO> interprets = fc.getAllInterprets();
            foreach (InterpretDTO i in interprets)
            {
                cbInterprets.Items.Add(i.getName());
            }
        }
    }
}
