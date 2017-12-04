using System;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            notifyIcon1.BalloonTipText = "Hard Disc Alert - Welcome";
            notifyIcon1.ShowBalloonTip(1000);
            label2.Text = "";
            timer1.Start();
            
            DriveInfo[] iDrvs = DriveInfo.GetDrives();
            foreach (var Drv in iDrvs)
            {
                if (Drv.IsReady)
                {
                    listBox1.Items.Add("Disc name: " + Drv.Name + " available: " + (Convert.ToDecimal(Drv.AvailableFreeSpace) / 1024 / 1024 / 1024).ToString("n2") +
                        " GB with " + (Convert.ToDecimal(Drv.TotalSize) / 1024 / 1024 / 1024).ToString("n2") + " GB, this is: "
                        + Drv.TotalSize / Drv.AvailableFreeSpace + "%");
                    comboBox1.Items.Add(Drv.Name);
                }
            }
           

        }
        Dictionary<string, int> DiscNameAndPercent = new Dictionary<string, int>();
        bool ActiveButton = false;

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
                listBox2.Items.Add(comboBox1.SelectedItem.ToString() + " alert below: " + numericUpDown1.Value + " %");
            }
            catch
            {
                MessageBox.Show("You must selected another disc", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            DiscNameAndPercent.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            button3.Text = "Monitored";
            ActiveButton = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = System.DateTime.Now.ToLongTimeString();
            if (ActiveButton == true)
            {
                if (System.DateTime.Now.ToLongTimeString() == textBox1.Text)
                {

                    MessageBox.Show("To small hard disc");
                }
            }
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9:]"))
            {
                MessageBox.Show("Tylko liczby od 0-9 i :");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
    }
}
