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
            this.bSave = new System.Windows.Forms.Button();
            this.bLoadList = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.gbdodajkontakt = new System.Windows.Forms.GroupBox();
            this.bAddEmail = new System.Windows.Forms.Button();
            this.tbAddEmail = new System.Windows.Forms.TextBox();
            this.lAddEmail = new System.Windows.Forms.Label();
            this.lbList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pbstopka = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbdodajkontakt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbstopka)).BeginInit();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bSave.Location = new System.Drawing.Point(202, 125);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(70, 43);
            this.bSave.TabIndex = 14;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bLoadList
            // 
            this.bLoadList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bLoadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLoadList.Location = new System.Drawing.Point(202, 76);
            this.bLoadList.Name = "bLoadList";
            this.bLoadList.Size = new System.Drawing.Size(70, 43);
            this.bLoadList.TabIndex = 13;
            this.bLoadList.Text = "Load List";
            this.bLoadList.UseVisualStyleBackColor = false;
            this.bLoadList.Click += new System.EventHandler(this.bLoadList_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bDelete.Location = new System.Drawing.Point(202, 27);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(70, 43);
            this.bDelete.TabIndex = 12;
            this.bDelete.Text = "Delete record";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // gbdodajkontakt
            // 
            this.gbdodajkontakt.Controls.Add(this.bAddEmail);
            this.gbdodajkontakt.Controls.Add(this.tbAddEmail);
            this.gbdodajkontakt.Controls.Add(this.lAddEmail);
            this.gbdodajkontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbdodajkontakt.Location = new System.Drawing.Point(4, 267);
            this.gbdodajkontakt.Name = "gbdodajkontakt";
            this.gbdodajkontakt.Size = new System.Drawing.Size(268, 77);
            this.gbdodajkontakt.TabIndex = 11;
            this.gbdodajkontakt.TabStop = false;
            this.gbdodajkontakt.Text = "Add Email:";
            // 
            // bAddEmail
            // 
            this.bAddEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddEmail.Enabled = false;
            this.bAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bAddEmail.Location = new System.Drawing.Point(6, 44);
            this.bAddEmail.Name = "bAddEmail";
            this.bAddEmail.Size = new System.Drawing.Size(256, 28);
            this.bAddEmail.TabIndex = 4;
            this.bAddEmail.Text = "Add";
            this.bAddEmail.UseVisualStyleBackColor = false;
            this.bAddEmail.Click += new System.EventHandler(this.bAddEmail_Click);
            // 
            // tbAddEmail
            // 
            this.tbAddEmail.Location = new System.Drawing.Point(49, 18);
            this.tbAddEmail.Name = "tbAddEmail";
            this.tbAddEmail.Size = new System.Drawing.Size(213, 23);
            this.tbAddEmail.TabIndex = 3;
            this.tbAddEmail.Text = "xyz@email.pl";
            this.tbAddEmail.TextChanged += new System.EventHandler(this.tbAddEmail_TextChanged);
            // 
            // lAddEmail
            // 
            this.lAddEmail.AutoSize = true;
            this.lAddEmail.Location = new System.Drawing.Point(6, 21);
            this.lAddEmail.Name = "lAddEmail";
            this.lAddEmail.Size = new System.Drawing.Size(46, 17);
            this.lAddEmail.TabIndex = 2;
            this.lAddEmail.Text = "Email:";
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.Location = new System.Drawing.Point(3, 27);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(193, 238);
            this.lbList.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(278, 24);
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
            this.ClientSize = new System.Drawing.Size(278, 373);
            this.Controls.Add(this.pbstopka);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bLoadList);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.gbdodajkontakt);
            this.Controls.Add(this.lbList);
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

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bLoadList;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.GroupBox gbdodajkontakt;
        private System.Windows.Forms.Button bAddEmail;
        private System.Windows.Forms.TextBox tbAddEmail;
        private System.Windows.Forms.Label lAddEmail;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pbstopka;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}