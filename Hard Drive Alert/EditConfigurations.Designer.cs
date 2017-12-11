namespace Hard_Drive_Alert
{
    partial class EditConfigurations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditConfigurations));
            this.gbustawienia = new System.Windows.Forms.GroupBox();
            this.tbConfPort = new System.Windows.Forms.TextBox();
            this.tbConfSMTP = new System.Windows.Forms.TextBox();
            this.lConfPort = new System.Windows.Forms.Label();
            this.lConfSMTP = new System.Windows.Forms.Label();
            this.gbmoje = new System.Windows.Forms.GroupBox();
            this.mtbYourPass = new System.Windows.Forms.MaskedTextBox();
            this.tbYourSignature = new System.Windows.Forms.TextBox();
            this.tbYourEmailName = new System.Windows.Forms.TextBox();
            this.lYourSignature = new System.Windows.Forms.Label();
            this.lYourPass = new System.Windows.Forms.Label();
            this.lYourEmailName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pbstopka = new System.Windows.Forms.PictureBox();
            this.bSave = new System.Windows.Forms.Button();
            this.gbustawienia.SuspendLayout();
            this.gbmoje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbstopka)).BeginInit();
            this.SuspendLayout();
            // 
            // gbustawienia
            // 
            this.gbustawienia.Controls.Add(this.tbConfPort);
            this.gbustawienia.Controls.Add(this.tbConfSMTP);
            this.gbustawienia.Controls.Add(this.lConfPort);
            this.gbustawienia.Controls.Add(this.lConfSMTP);
            this.gbustawienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbustawienia.Location = new System.Drawing.Point(332, 25);
            this.gbustawienia.Name = "gbustawienia";
            this.gbustawienia.Size = new System.Drawing.Size(194, 73);
            this.gbustawienia.TabIndex = 8;
            this.gbustawienia.TabStop = false;
            this.gbustawienia.Text = "Server Configuration";
            // 
            // tbConfPort
            // 
            this.tbConfPort.Location = new System.Drawing.Point(56, 44);
            this.tbConfPort.Name = "tbConfPort";
            this.tbConfPort.Size = new System.Drawing.Size(131, 23);
            this.tbConfPort.TabIndex = 3;
            this.tbConfPort.Text = "587";
            this.tbConfPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbConfSMTP
            // 
            this.tbConfSMTP.Location = new System.Drawing.Point(56, 17);
            this.tbConfSMTP.Name = "tbConfSMTP";
            this.tbConfSMTP.Size = new System.Drawing.Size(131, 23);
            this.tbConfSMTP.TabIndex = 2;
            this.tbConfSMTP.Text = "smtp.gmail.com";
            this.tbConfSMTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lConfPort
            // 
            this.lConfPort.AutoSize = true;
            this.lConfPort.Location = new System.Drawing.Point(6, 46);
            this.lConfPort.Name = "lConfPort";
            this.lConfPort.Size = new System.Drawing.Size(38, 17);
            this.lConfPort.TabIndex = 1;
            this.lConfPort.Text = "Port:";
            // 
            // lConfSMTP
            // 
            this.lConfSMTP.AutoSize = true;
            this.lConfSMTP.Location = new System.Drawing.Point(6, 20);
            this.lConfSMTP.Name = "lConfSMTP";
            this.lConfSMTP.Size = new System.Drawing.Size(50, 17);
            this.lConfSMTP.TabIndex = 0;
            this.lConfSMTP.Text = "SMTP:";
            // 
            // gbmoje
            // 
            this.gbmoje.Controls.Add(this.mtbYourPass);
            this.gbmoje.Controls.Add(this.tbYourSignature);
            this.gbmoje.Controls.Add(this.tbYourEmailName);
            this.gbmoje.Controls.Add(this.lYourSignature);
            this.gbmoje.Controls.Add(this.lYourPass);
            this.gbmoje.Controls.Add(this.lYourEmailName);
            this.gbmoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbmoje.Location = new System.Drawing.Point(2, 25);
            this.gbmoje.Name = "gbmoje";
            this.gbmoje.Size = new System.Drawing.Size(324, 104);
            this.gbmoje.TabIndex = 7;
            this.gbmoje.TabStop = false;
            this.gbmoje.Text = "Configuration Email";
            // 
            // mtbYourPass
            // 
            this.mtbYourPass.Location = new System.Drawing.Point(84, 45);
            this.mtbYourPass.Name = "mtbYourPass";
            this.mtbYourPass.PasswordChar = '*';
            this.mtbYourPass.Size = new System.Drawing.Size(234, 23);
            this.mtbYourPass.TabIndex = 6;
            this.mtbYourPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbYourSignature
            // 
            this.tbYourSignature.Location = new System.Drawing.Point(84, 73);
            this.tbYourSignature.Name = "tbYourSignature";
            this.tbYourSignature.Size = new System.Drawing.Size(234, 23);
            this.tbYourSignature.TabIndex = 5;
            this.tbYourSignature.Text = "Your signature";
            this.tbYourSignature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbYourEmailName
            // 
            this.tbYourEmailName.Location = new System.Drawing.Point(84, 17);
            this.tbYourEmailName.Name = "tbYourEmailName";
            this.tbYourEmailName.Size = new System.Drawing.Size(234, 23);
            this.tbYourEmailName.TabIndex = 3;
            this.tbYourEmailName.Text = "xyz@gmail.com";
            this.tbYourEmailName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lYourSignature
            // 
            this.lYourSignature.AutoSize = true;
            this.lYourSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lYourSignature.Location = new System.Drawing.Point(5, 76);
            this.lYourSignature.Name = "lYourSignature";
            this.lYourSignature.Size = new System.Drawing.Size(73, 17);
            this.lYourSignature.TabIndex = 2;
            this.lYourSignature.Text = "Signature:";
            // 
            // lYourPass
            // 
            this.lYourPass.AutoSize = true;
            this.lYourPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lYourPass.Location = new System.Drawing.Point(5, 47);
            this.lYourPass.Name = "lYourPass";
            this.lYourPass.Size = new System.Drawing.Size(73, 17);
            this.lYourPass.TabIndex = 1;
            this.lYourPass.Text = "Password:";
            // 
            // lYourEmailName
            // 
            this.lYourEmailName.AutoSize = true;
            this.lYourEmailName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lYourEmailName.Location = new System.Drawing.Point(5, 20);
            this.lYourEmailName.Name = "lYourEmailName";
            this.lYourEmailName.Size = new System.Drawing.Size(49, 17);
            this.lYourEmailName.TabIndex = 0;
            this.lYourEmailName.Text = "Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pbstopka
            // 
            this.pbstopka.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbstopka.Location = new System.Drawing.Point(0, 135);
            this.pbstopka.Name = "pbstopka";
            this.pbstopka.Size = new System.Drawing.Size(554, 28);
            this.pbstopka.TabIndex = 10;
            this.pbstopka.TabStop = false;
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSave.Location = new System.Drawing.Point(332, 99);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(194, 30);
            this.bSave.TabIndex = 11;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // EditConfigurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 159);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.pbstopka);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbustawienia);
            this.Controls.Add(this.gbmoje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditConfigurations";
            this.Text = "MD Hard Disc - Alert, Email Configurations";
            this.gbustawienia.ResumeLayout(false);
            this.gbustawienia.PerformLayout();
            this.gbmoje.ResumeLayout(false);
            this.gbmoje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbstopka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbustawienia;
        private System.Windows.Forms.TextBox tbConfPort;
        private System.Windows.Forms.TextBox tbConfSMTP;
        private System.Windows.Forms.Label lConfPort;
        private System.Windows.Forms.Label lConfSMTP;
        private System.Windows.Forms.GroupBox gbmoje;
        private System.Windows.Forms.MaskedTextBox mtbYourPass;
        private System.Windows.Forms.TextBox tbYourSignature;
        private System.Windows.Forms.TextBox tbYourEmailName;
        private System.Windows.Forms.Label lYourSignature;
        private System.Windows.Forms.Label lYourPass;
        private System.Windows.Forms.Label lYourEmailName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pbstopka;
        private System.Windows.Forms.Button bSave;
    }
}