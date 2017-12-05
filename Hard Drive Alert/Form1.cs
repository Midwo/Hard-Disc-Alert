using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hard_Drive_Alert
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            notifyIcon1.BalloonTipText = "Hard Disc Alert - Welcome";
            notifyIcon1.ShowBalloonTip(1000);
            label2.Text = "";
            timer1.Start();
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD_DISC_ALERT_DATE");

  
            try
            {
                if (key.GetValue("Hour").ToString() != string.Empty || key.GetValue("Minute").ToString() != string.Empty || key.GetValue("Second").ToString() != string.Empty)
                {
                    comboBox2.SelectedItem = key.GetValue("Hour");
                    comboBox3.SelectedItem = key.GetValue("Minute");
                    comboBox4.SelectedItem = key.GetValue("Second");
                    numericUpDown2.Value = Convert.ToUInt32(key.GetValue("NumericMinute"));
                }
                else
                {
                    comboBox2.SelectedItem = "00";
                    comboBox3.SelectedItem = "00";
                    comboBox4.SelectedItem = "00";
                    numericUpDown2.Value = 1;
                }
           
                }
            catch
            {
                comboBox2.SelectedItem = "00";
                comboBox3.SelectedItem = "00";
                comboBox4.SelectedItem = "00";
                numericUpDown2.Value = 1;
            }
            key.Close();

        

            DriveInfo[] iDrvs = DriveInfo.GetDrives();
            foreach (var Drv in iDrvs)
            {
                if (Drv.IsReady)
                {
                    listBox1.Items.Add("Disc name: " + Drv.Name + " available: " + (Convert.ToDecimal(Drv.AvailableFreeSpace) / 1024 / 1024 / 1024).ToString("n2") +
                        " GB with " + (Convert.ToDecimal(Drv.TotalSize) / 1024 / 1024 / 1024).ToString("n2") + " GB, this is: "
                        + (((Convert.ToDecimal(Drv.AvailableFreeSpace) / 1024 / 1024 / 1024) / (Convert.ToDecimal(Drv.TotalSize) / 1024 / 1024 / 1024))*100).ToString("n2") + "%");
                    comboBox1.Items.Add(Drv.Name);
                    AllAvailableFreeSpace += ((Convert.ToDecimal(Drv.AvailableFreeSpace) / 1024 / 1024 / 1024));
                    AllTotalSize += (Convert.ToDecimal(Drv.TotalSize) / 1024 / 1024 / 1024);
                }
            }

            this.chart1.Series["FreeSize"].Points.AddXY("Total Available", ((Convert.ToDecimal(AllAvailableFreeSpace) / (Convert.ToDecimal(AllTotalSize)))));
            this.chart1.Series["FreeSize"].Points.AddXY("Total Occupied", ((((Convert.ToDecimal(AllTotalSize) ) - (Convert.ToDecimal(AllAvailableFreeSpace))) / (Convert.ToDecimal(AllTotalSize)))));

        }
        Decimal AllAvailableFreeSpace;
        Decimal AllTotalSize;
        Dictionary<string, int> DiscNameAndPercent = new Dictionary<string, int>();
        bool ActiveButton = false;
        DateTime DateMonit;
        string combineCombobox;

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

    

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.BalloonTipText = "Hard Disc Alert - Minimalized";
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.BalloonTipText = "Hard Disc Alert - Normal Window";
                notifyIcon1.ShowBalloonTip(1000);

            }
          
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "Hard Disc Alert - Goodbye";
            notifyIcon1.ShowBalloonTip(1000);
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.BalloonTipText = "Hard Disc Alert - Goodbye";
            notifyIcon1.ShowBalloonTip(1000);
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DiscNameAndPercent.Add(comboBox1.Text, Convert.ToInt32(numericUpDown1.Value));
                lbAlertOptions.Items.Add(comboBox1.SelectedItem.ToString() + " alert below: " + numericUpDown1.Value + " %");
            }
            catch
            {
                MessageBox.Show("You must selected another disc", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            lbAlertOptions.Items.Clear();
            DiscNameAndPercent.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbAlertOptions.Items.Count > 0)
            {
                EmailConf stringListEmail = new EmailConf();

                try
                {
                    if (stringListEmail.StringListEmail().Trim().Length > 1)
                    {
                        if (cbOptionCheck.SelectedIndex != -1)
                        {
                            DateMonit = DateTime.Now.AddSeconds(Convert.ToDouble(numericUpDown2.Value));
                            button3.Text = "Monitored";
                            ActiveButton = true;
                            combineCombobox = comboBox2.SelectedItem + ":" + comboBox3.SelectedItem + ":" + comboBox4.SelectedItem;


                            Microsoft.Win32.RegistryKey key;
                            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD_DISC_ALERT_DATE");
                            key.SetValue("Hour", comboBox2.SelectedItem);
                            key.SetValue("Minute", comboBox3.SelectedItem);
                            key.SetValue("Second", comboBox4.SelectedItem);
                            key.SetValue("NumericMinute", numericUpDown2.Value);
                            key.Close();

                        }
                        else
                        {
                            MessageBox.Show("You must select 'Options - When to check the disc'", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show("You must load emial list and save IT!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("You must load emial list and save IT!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("You must add Alert Options!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

   
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            //if (ActiveButton == true)
            //{
            //    if (System.DateTime.Now.ToLongTimeString() == textBox1.Text)
            //    {

            //        MessageBox.Show("To small hard disc");
            //    }
            //}


            if (ActiveButton == true)
            {

                if (cbOptionCheck.SelectedIndex == 0)
                {
                    DateTime changeCombine = DateTime.Parse((DateMonit.ToString("dd/MM/yyyy") + " " + combineCombobox));

                    if (changeCombine <= DateTime.Now)
                    {
                        DateMonit = DateTime.Parse((DateTime.Now.AddDays(1).ToString("dd/MM/yyyy") + " " + combineCombobox));

                        DriveInfo[] yDrvs = DriveInfo.GetDrives();
                        foreach (var Drv in yDrvs)
                        {
                            if (Drv.IsReady)
                            {

                                if (!DiscNameAndPercent.TryGetValue("" + Drv.Name + "", out int actualValue))
                                {
                                    // We don't have this disc : )
                                }
                                else
                                {


                                    if ((((Convert.ToDecimal(Drv.AvailableFreeSpace) / 1024 / 1024 / 1024) / (Convert.ToDecimal(Drv.TotalSize) / 1024 / 1024 / 1024)) * 100) <= (Convert.ToDecimal(DiscNameAndPercent["" + Drv.Name + ""])))
                                    {
                                        //  MessageBox.Show("" + (Convert.ToDecimal(DiscNameAndPercent["" + Drv.Name + ""]) + ""));
                                    }//["" + Drv.Name.Substring(0, Drv.Name.Length - 1) + ""]
                                    else
                                    {
                                        try
                                        {
                                            Microsoft.Win32.RegistryKey key;
                                            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD_DISC_ALERT_DATE");

                                            MessageBox.Show("wysyłamy wiadomość na temat dysku: " + Drv.Name + "");
                                            int port = Int32.Parse(key.GetValue("Port").ToString());
                                            SmtpClient mailServer = new SmtpClient(key.GetValue("SMTP").ToString(), port);
                                            mailServer.EnableSsl = true;

                                            mailServer.Credentials = new System.Net.NetworkCredential(key.GetValue("Name").ToString(), key.GetValue("Password").ToString());

                                            MailMessage msg = new MailMessage();
                                            msg.From = new MailAddress(key.GetValue("Name").ToString(), key.GetValue("Signature").ToString());

                                            EmailConf stringListEmail = new EmailConf();
                                            string emaile = stringListEmail.ToString();


                                            foreach (string email in EmailConf.ListEmail)
                                            {
                                                msg.To.Add(email);
                                            }


                                            msg.Subject = "Ticket - Warning Server - low capacity";
                                            msg.Body = "Welcome, there is not enough disk space: " + Drv.Name + " ";

                                            mailServer.Send(msg);

                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }

                                }

                            }
                        }

                    }
                }
                else
                {
                    if (DateMonit <= DateTime.Now)
                    {
                        DateMonit = DateTime.Now.AddMinutes(Convert.ToDouble(numericUpDown2.Value));


                        DriveInfo[] yDrvs = DriveInfo.GetDrives();
                        foreach (var Drv in yDrvs)
                        {
                            if (Drv.IsReady)
                            {

                                if (!DiscNameAndPercent.TryGetValue("" + Drv.Name + "", out int actualValue))
                                {
                                    // We don't have this disc : )
                                }
                                else
                                {


                                    if ((((Convert.ToDecimal(Drv.AvailableFreeSpace) / 1024 / 1024 / 1024) / (Convert.ToDecimal(Drv.TotalSize) / 1024 / 1024 / 1024)) * 100) <= (Convert.ToDecimal(DiscNameAndPercent["" + Drv.Name + ""])))
                                    {
                                        //  MessageBox.Show("" + (Convert.ToDecimal(DiscNameAndPercent["" + Drv.Name + ""]) + ""));
                                    }//["" + Drv.Name.Substring(0, Drv.Name.Length - 1) + ""]
                                    else
                                    {
                                        try
                                        {
                                            Microsoft.Win32.RegistryKey key;
                                            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD_DISC_ALERT_DATE");

                                            MessageBox.Show("wysyłamy wiadomość na temat dysku: " + Drv.Name + "");
                                            int port = Int32.Parse(key.GetValue("Port").ToString());
                                            SmtpClient mailServer = new SmtpClient(key.GetValue("SMTP").ToString(), port);
                                            mailServer.EnableSsl = true;

                                            mailServer.Credentials = new System.Net.NetworkCredential(key.GetValue("Name").ToString(), key.GetValue("Password").ToString());

                                            MailMessage msg = new MailMessage();
                                            msg.From = new MailAddress(key.GetValue("Name").ToString(), key.GetValue("Signature").ToString());

                                            EmailConf stringListEmail = new EmailConf();
                                            string emaile = stringListEmail.ToString();


                                            foreach (string email in EmailConf.ListEmail)
                                            {
                                                msg.To.Add(email);
                                            }


                                            msg.Subject = "Ticket - Warning Server - low capacity";
                                            msg.Body = "Welcome, there is not enough disk space: " + Drv.Name + " ";

                                            mailServer.Send(msg);

                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }

                                }
                            }
                        
                    }
                }
            }
            }

    


        }


        private void emailConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditConfigurations m = new EditConfigurations();
            m.Show();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chart1.Series["FreeSize"].Points.Clear();
          

            DriveInfo[] iDrvs = DriveInfo.GetDrives();
            foreach (var Drv1 in iDrvs)
            {
                if (Drv1.IsReady)
                {
                    if (Drv1.Name == comboBox1.SelectedItem.ToString())
                    {
                       
                        this.chart1.Series["FreeSize"].Points.AddXY("Available size", (((Convert.ToDecimal(Drv1.AvailableFreeSpace) / 1024 / 1024 / 1024)/ (Convert.ToDecimal(Drv1.TotalSize) / 1024 / 1024 / 1024))));
                        this.chart1.Series["FreeSize"].Points.AddXY("Occupied size", ((((Convert.ToDecimal(Drv1.TotalSize) / 1024 / 1024 / 1024) - (Convert.ToDecimal(Drv1.AvailableFreeSpace) / 1024 / 1024 / 1024))/(Convert.ToDecimal(Drv1.TotalSize) / 1024 / 1024 / 1024))));

                    }

                }
            }

   

         
        }

        private void listEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListEmail m = new ListEmail();
            m.Show();
        }

        private void cbOptionCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOptionCheck.SelectedIndex == 0)
            {
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
                numericUpDown2.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;

            }
            else if (cbOptionCheck.SelectedIndex == 1)
            {
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                numericUpDown2.Enabled = true;
                label6.Enabled = true;
                label7.Enabled = true;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
            }
        }
    }
}
