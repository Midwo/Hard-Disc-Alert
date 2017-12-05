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


        private void bDelete_Click(object sender, EventArgs e)
        {
            if (lbList.SelectedIndex != -1)
            {
                lbList.Items.Remove(lbList.SelectedItems[0]);
            }
        }

        private void bLoadList_Click(object sender, EventArgs e)
        {
            OpenFileDialog f1 = new OpenFileDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                lbList.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f1.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        lbList.Items.Add(line);

                    }
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {

            if (lbList.Items.Count > 0)
            {

                const string sPath = "My_List_Email.txt";

                ArrayList myAL = new ArrayList();
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
                foreach (var item in lbList.Items)
                {
                    SaveFile.WriteLine(item);
                    myAL.Add(item);
                }
                EmailConf.ListEmail = myAL;

                SaveFile.Close();

                MessageBox.Show("Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You can't save list with null addresses!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbAddEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbAddEmail.Text == "")
            {
                bAddEmail.Enabled = false;
            }
            else
            {
                bAddEmail.Enabled = true;
            }
        }

        private void bAddEmail_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (tbAddEmail.Text.Length > 0 && tbAddEmail.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(tbAddEmail.Text.Trim()))
                {
                    MessageBox.Show("Wrong address email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbAddEmail.SelectAll();

                }
                else
                {
                    lbList.Items.Add(tbAddEmail.Text);
                    tbAddEmail.Text = "";
                }
            }
        }
    }
}
