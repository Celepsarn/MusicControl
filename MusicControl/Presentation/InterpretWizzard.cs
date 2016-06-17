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
            FunctionController fc = new FunctionController();
            if (edName.Text == "")
            {
                edName.BackColor = ColorTranslator.FromHtml("#ff6666");
                MessageBox.Show("Kein Name wurde angegeben.", "Eingabe nicht vollständig", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!isNumeric || edFoundationYear.Text.Length > 4)
            {
                edName.BackColor = Color.White;
                edFoundationYear.BackColor = ColorTranslator.FromHtml("#ff6666");
                MessageBox.Show("Das angegebene Gründungsjahr ist nicht gültig.", "Eingabe nicht vollständig", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (fc.objectAlreadyExists(edName.Text, "Interpret"))
            {
                edFoundationYear.BackColor = Color.White;
                edName.BackColor = ColorTranslator.FromHtml("#ff6666");
                MessageBox.Show("Interpret existiert bereits.", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Interpret i = new Interpret(edName.Text, edFoundationYear.Text, edLand.Text);
                i.create();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
