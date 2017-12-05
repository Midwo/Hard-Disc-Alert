namespace Hard_Drive_Alert
{
    partial class ListEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListEmail));
            this.bzapisz = new System.Windows.Forms.Button();
            this.bzaladujliste = new System.Windows.Forms.Button();
            this.busunpozycje = new System.Windows.Forms.Button();
            this.gbdodajkontakt = new System.Windows.Forms.GroupBox();
            this.bdodajemail = new System.Windows.Forms.Button();
            this.tbdodajemial = new System.Windows.Forms.TextBox();
            this.ldodajemail = new System.Windows.Forms.Label();
            this.lblista = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pbstopka = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbdodajkontakt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbstopka)).BeginInit();
            this.SuspendLayout();
            // 
            // bzapisz
            // 
            this.bzapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bzapisz.Location = new System.Drawing.Point(202, 125);
            this.bzapisz.Name = "bzapisz";
            this.bzapisz.Size = new System.Drawing.Size(70, 43);
            this.bzapisz.TabIndex = 14;
            this.bzapisz.Text = "Save";
            this.bzapisz.UseVisualStyleBackColor = true;
            this.bzapisz.Click += new System.EventHandler(this.bzapisz_Click);
            // 
            // bzaladujliste
            // 
            this.bzaladujliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bzaladujliste.Location = new System.Drawing.Point(202, 76);
            this.bzaladujliste.Name = "bzaladujliste";
            this.bzaladujliste.Size = new System.Drawing.Size(70, 43);
            this.bzaladujliste.TabIndex = 13;
            this.bzaladujliste.Text = "Load List";
            this.bzaladujliste.UseVisualStyleBackColor = true;
            this.bzaladujliste.Click += new System.EventHandler(this.bzaladujliste_Click);
            // 
            // busunpozycje
            // 
            this.busunpozycje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.busunpozycje.Location = new System.Drawing.Point(202, 27);
            this.busunpozycje.Name = "busunpozycje";
            this.busunpozycje.Size = new System.Drawing.Size(70, 43);
            this.busunpozycje.TabIndex = 12;
            this.busunpozycje.Text = "Delete record";
            this.busunpozycje.UseVisualStyleBackColor = true;
            this.busunpozycje.Click += new System.EventHandler(this.busunpozycje_Click);
            // 
            // gbdodajkontakt
            // 
            this.gbdodajkontakt.Controls.Add(this.bdodajemail);
            this.gbdodajkontakt.Controls.Add(this.tbdodajemial);
            this.gbdodajkontakt.Controls.Add(this.ldodajemail);
            this.gbdodajkontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbdodajkontakt.Location = new System.Drawing.Point(4, 272);
            this.gbdodajkontakt.Name = "gbdodajkontakt";
            this.gbdodajkontakt.Size = new System.Drawing.Size(268, 77);
            this.gbdodajkontakt.TabIndex = 11;
            this.gbdodajkontakt.TabStop = false;
            this.gbdodajkontakt.Text = "Add Email:";
            // 
            // bdodajemail
            // 
            this.bdodajemail.Enabled = false;
            this.bdodajemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bdodajemail.Location = new System.Drawing.Point(6, 44);
            this.bdodajemail.Name = "bdodajemail";
            this.bdodajemail.Size = new System.Drawing.Size(256, 28);
            this.bdodajemail.TabIndex = 4;
            this.bdodajemail.Text = "Add";
            this.bdodajemail.UseVisualStyleBackColor = true;
            this.bdodajemail.Click += new System.EventHandler(this.bdodajemail_Click);
            // 
            // tbdodajemial
            // 
            this.tbdodajemial.Location = new System.Drawing.Point(49, 18);
            this.tbdodajemial.Name = "tbdodajemial";
            this.tbdodajemial.Size = new System.Drawing.Size(213, 23);
            this.tbdodajemial.TabIndex = 3;
            this.tbdodajemial.Text = "np@email.pl";
            this.tbdodajemial.TextChanged += new System.EventHandler(this.tbdodajemial_TextChanged);
            // 
            // ldodajemail
            // 
            this.ldodajemail.AutoSize = true;
            this.ldodajemail.Location = new System.Drawing.Point(6, 21);
            this.ldodajemail.Name = "ldodajemail";
            this.ldodajemail.Size = new System.Drawing.Size(46, 17);
            this.ldodajemail.TabIndex = 2;
            this.ldodajemail.Text = "Email:";
            // 
            // lblista
            // 
            this.lblista.FormattingEnabled = true;
            this.lblista.Location = new System.Drawing.Point(3, 27);
            this.lblista.Name = "lblista";
            this.lblista.Size = new System.Drawing.Size(193, 238);
            this.lblista.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(275, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pbstopka
            // 
            this.pbstopka.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbstopka.Location = new System.Drawing.Point(0, 350);
            this.pbstopka.Name = "pbstopka";
            this.pbstopka.Size = new System.Drawing.Size(284, 28);
            this.pbstopka.TabIndex = 23;
            this.pbstopka.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ListEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(275, 371);
            this.Controls.Add(this.pbstopka);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bzapisz);
            this.Controls.Add(this.bzaladujliste);
            this.Controls.Add(this.busunpozycje);
            this.Controls.Add(this.gbdodajkontakt);
            this.Controls.Add(this.lblista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListEmail";
            this.Text = "MD List Email";
            this.gbdodajkontakt.ResumeLayout(false);
            this.gbdodajkontakt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbstopka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bzapisz;
        private System.Windows.Forms.Button bzaladujliste;
        private System.Windows.Forms.Button busunpozycje;
        private System.Windows.Forms.GroupBox gbdodajkontakt;
        private System.Windows.Forms.Button bdodajemail;
        private System.Windows.Forms.TextBox tbdodajemial;
        private System.Windows.Forms.Label ldodajemail;
        private System.Windows.Forms.ListBox lblista;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pbstopka;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}