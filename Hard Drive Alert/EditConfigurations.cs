using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hard_Drive_Alert
{
    public partial class EditConfigurations : Form
    {
        public EditConfigurations()
        {
            InitializeComponent();

            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD_DISC_ALERT_DATE");

            try
            {
                if (key.GetValue("Hour").ToString() != string.Empty || key.GetValue("Minute").ToString() != string.Empty || key.GetValue("Second").ToString() != string.Empty)
                {
                    tbYourEmailName.Text = key.GetValue("Name").ToString();
                    mtbYourPass.Text = key.GetValue("Password").ToString();
                    tbYourSignature.Text = key.GetValue("Signature").ToString();
                    tbConfSMTP.Text = key.GetValue("SMTP").ToString();
                    tbConfPort.Text = key.GetValue("Port").ToString();
                }
                else
                {
                    tbYourEmailName.Text = "YourEmail@xyz.pl";
                    mtbYourPass.Clear();
                    tbYourSignature.Text = "Your Signature";
                    tbConfSMTP.Text = "SMTP name";
                    tbConfPort.Text = "Port number";
                }

            }
            catch
            {
                tbYourEmailName.Text = "YourEmail@xyz.pl";
                mtbYourPass.Clear();
                tbYourSignature.Text = "Your Signature";
                tbConfSMTP.Text = "SMTP name";
                tbConfPort.Text = "Port number";
            }
            key.Close();

        }

        private void bSave_Click(object sender, EventArgs e)
        {

            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");


            if (!rEmail.IsMatch(tbYourEmailName.Text.Trim()))
            {
                MessageBox.Show("Wrong address email!", "Information - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbYourEmailName.SelectAll();

            }
            else
            {
                if (tbYourEmailName.Text.Trim().Length > 0 && mtbYourPass.Text.Trim().Length > 0 && tbYourSignature.Text.Trim().Length > 0 && tbConfSMTP.Text.Trim().Length > 0 && tbConfPort.Text.Trim().Length > 0)
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD_DISC_ALERT_DATE");
                    key.SetValue("Name", tbYourEmailName.Text.Trim());
                    key.SetValue("Password", mtbYourPass.Text.Trim());
                    key.SetValue("Signature", tbYourSignature.Text.Trim());
                    key.SetValue("SMTP", tbConfSMTP.Text.Trim());
                    key.SetValue("Port", tbConfPort.Text.Trim());
                    key.Close();

                    MessageBox.Show("Saved your configuration", "Information - success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You must enter all fields", "Warining", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            

           

        }
    }
}
