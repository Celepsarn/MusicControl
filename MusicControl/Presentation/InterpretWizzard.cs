using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicControl.Business;

namespace MusicControl.Presentation
{
    public partial class InterpretWizzard : Form
    {
        
        public InterpretWizzard()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            int n;
            bool isNumeric = int.TryParse(edFoundationYear.Text, out n);
            if (edName.Text == "")
            {
                MessageBox.Show("Kein Name wurde angegeben.", "Eingabe nicht vollständig", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!isNumeric || edFoundationYear.Text.Length > 4)
            {
                MessageBox.Show("Das angegebene Gründungsjahr ist nicht gültig.", "Eingabe nicht vollständig", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {
                Interpret i = new Interpret(edName.Text, edFoundationYear.Text, edLand.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
