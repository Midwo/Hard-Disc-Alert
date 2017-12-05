using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hard_Drive_Alert
{
    public partial class ListEmail : Form
    {
        public ListEmail()
        {
            InitializeComponent();
        }

        private void bdodajemail_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (tbdodajemial.Text.Length > 0 && tbdodajemial.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(tbdodajemial.Text.Trim()))
                {
                    MessageBox.Show("Wrong address email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbdodajemial.SelectAll();

                }
                else
                {
                    lblista.Items.Add(tbdodajemial.Text);
                    tbdodajemial.Text = "";
                }
            }
        }

        private void tbdodajemial_TextChanged(object sender, EventArgs e)
        {
            if (tbdodajemial.Text == "")
            {
                bdodajemail.Enabled = false;
            }
            else
            {
                bdodajemail.Enabled = true;
            }
        }

        private void bzaladujliste_Click(object sender, EventArgs e)
        {

            OpenFileDialog f1 = new OpenFileDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                lblista.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f1.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        lblista.Items.Add(line);

                    }
                }
            }
        }

        private void bzapisz_Click(object sender, EventArgs e)
        {
            const string sPath = "My_List_Email.txt";

            ArrayList myAL = new ArrayList();
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in lblista.Items)
            {
                SaveFile.WriteLine(item);
                myAL.Add(item);
            }
            EmailConf.ListEmail = myAL;

            SaveFile.Close();

            MessageBox.Show("Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void busunpozycje_Click(object sender, EventArgs e)
        {
            if (lblista.SelectedIndex != -1)
            {
                lblista.Items.Remove(lblista.SelectedItems[0]);
            }
        }
    }
}
