namespace car_rental_project
{
    partial class AdKupacForm
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
            this.DTPIzmenaDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TBoxIzmenaLozinka = new System.Windows.Forms.TextBox();
            this.TBoxIzmenaKorisnickoIme = new System.Windows.Forms.TextBox();
            this.BtnIzmeniKupca = new System.Windows.Forms.Button();
            this.LBKupci = new System.Windows.Forms.ListBox();
            this.BtnObrisiKupca = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBoxIzmenaJMBG = new System.Windows.Forms.TextBox();
            this.TBoxIzmenaTelefon = new System.Windows.Forms.TextBox();
            this.TBoxIzmenaPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxIzmenaIme = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DTPDodajDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.TBoxDodajLozinka = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TBoxDodajKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnDodajKupca = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBoxDodajJMBG = new System.Windows.Forms.TextBox();
            this.TBoxDodajTelefon = new System.Windows.Forms.TextBox();
            this.TBoxDodajPrezime = new System.Windows.Forms.TextBox();
            this.TBoxDodajIme = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTPIzmenaDatumRodjenja
            // 
            this.DTPIzmenaDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPIzmenaDatumRodjenja.Location = new System.Drawing.Point(440, 125);
            this.DTPIzmenaDatumRodjenja.MaxDate = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.DTPIzmenaDatumRodjenja.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.DTPIzmenaDatumRodjenja.Name = "DTPIzmenaDatumRodjenja";
            this.DTPIzmenaDatumRodjenja.Size = new System.Drawing.Size(145, 21);
            this.DTPIzmenaDatumRodjenja.TabIndex = 21;
            this.DTPIzmenaDatumRodjenja.Value = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(594, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "Lozinka";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(436, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Korisnicko ime:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // TBoxIzmenaLozinka
            // 
            this.TBoxIzmenaLozinka.Location = new System.Drawing.Point(594, 40);
            this.TBoxIzmenaLozinka.Name = "TBoxIzmenaLozinka";
            this.TBoxIzmenaLozinka.Size = new System.Drawing.Size(149, 21);
            this.TBoxIzmenaLozinka.TabIndex = 17;
            // 
            // TBoxIzmenaKorisnickoIme
            // 
            this.TBoxIzmenaKorisnickoIme.Location = new System.Drawing.Point(439, 40);
            this.TBoxIzmenaKorisnickoIme.Name = "TBoxIzmenaKorisnickoIme";
            this.TBoxIzmenaKorisnickoIme.Size = new System.Drawing.Size(150, 21);
            this.TBoxIzmenaKorisnickoIme.TabIndex = 16;
            this.TBoxIzmenaKorisnickoIme.TextChanged += new System.EventHandler(this.TBoxIzmenaKorisnickoIme_TextChanged);
            // 
            // BtnIzmeniKupca
            // 
            this.BtnIzmeniKupca.Location = new System.Drawing.Point(298, 184);
            this.BtnIzmeniKupca.Name = "BtnIzmeniKupca";
            this.BtnIzmeniKupca.Size = new System.Drawing.Size(133, 41);
            this.BtnIzmeniKupca.TabIndex = 13;
            this.BtnIzmeniKupca.Text = "Izmeni kupca";
            this.BtnIzmeniKupca.UseVisualStyleBackColor = true;
            this.BtnIzmeniKupca.Click += new System.EventHandler(this.BtnIzmeniKupca_Click);
            // 
            // LBKupci
            // 
            this.LBKupci.FormattingEnabled = true;
            this.LBKupci.ItemHeight = 15;
            this.LBKupci.Location = new System.Drawing.Point(15, 39);
            this.LBKupci.Name = "LBKupci";
            this.LBKupci.Size = new System.Drawing.Size(418, 139);
            this.LBKupci.TabIndex = 12;
            this.LBKupci.SelectedIndexChanged += new System.EventHandler(this.lBKupci_SelectedIndexChanged);
            // 
            // BtnObrisiKupca
            // 
            this.BtnObrisiKupca.Location = new System.Drawing.Point(159, 184);
            this.BtnObrisiKupca.Name = "BtnObrisiKupca";
            this.BtnObrisiKupca.Size = new System.Drawing.Size(133, 41);
            this.BtnObrisiKupca.TabIndex = 14;
            this.BtnObrisiKupca.Text = "Obrisi kupca";
            this.BtnObrisiKupca.UseVisualStyleBackColor = true;
            this.BtnObrisiKupca.Click += new System.EventHandler(this.btnObrisiKupca_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pretraga:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "JMBG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon:";
            // 
            // TBoxIzmenaJMBG
            // 
            this.TBoxIzmenaJMBG.Location = new System.Drawing.Point(594, 125);
            this.TBoxIzmenaJMBG.Name = "TBoxIzmenaJMBG";
            this.TBoxIzmenaJMBG.Size = new System.Drawing.Size(149, 21);
            this.TBoxIzmenaJMBG.TabIndex = 7;
            // 
            // TBoxIzmenaTelefon
            // 
            this.TBoxIzmenaTelefon.Location = new System.Drawing.Point(595, 164);
            this.TBoxIzmenaTelefon.Name = "TBoxIzmenaTelefon";
            this.TBoxIzmenaTelefon.Size = new System.Drawing.Size(149, 21);
            this.TBoxIzmenaTelefon.TabIndex = 6;
            // 
            // TBoxIzmenaPrezime
            // 
            this.TBoxIzmenaPrezime.Location = new System.Drawing.Point(595, 83);
            this.TBoxIzmenaPrezime.Name = "TBoxIzmenaPrezime";
            this.TBoxIzmenaPrezime.Size = new System.Drawing.Size(149, 21);
            this.TBoxIzmenaPrezime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum rodjenja:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBoxIzmenaIme
            // 
            this.TBoxIzmenaIme.Location = new System.Drawing.Point(439, 83);
            this.TBoxIzmenaIme.Name = "TBoxIzmenaIme";
            this.TBoxIzmenaIme.Size = new System.Drawing.Size(149, 21);
            this.TBoxIzmenaIme.TabIndex = 0;
            this.TBoxIzmenaIme.TextChanged += new System.EventHandler(this.TBoxIzmenaIme_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DTPDodajDatumRodjenja);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.TBoxDodajLozinka);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.TBoxDodajKorisnickoIme);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.BtnDodajKupca);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TBoxDodajJMBG);
            this.groupBox2.Controls.Add(this.TBoxDodajTelefon);
            this.groupBox2.Controls.Add(this.TBoxDodajPrezime);
            this.groupBox2.Controls.Add(this.TBoxDodajIme);
            this.groupBox2.Location = new System.Drawing.Point(135, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 234);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj kupca";
            // 
            // DTPDodajDatumRodjenja
            // 
            this.DTPDodajDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDodajDatumRodjenja.Location = new System.Drawing.Point(16, 125);
            this.DTPDodajDatumRodjenja.MaxDate = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.DTPDodajDatumRodjenja.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.DTPDodajDatumRodjenja.Name = "DTPDodajDatumRodjenja";
            this.DTPDodajDatumRodjenja.Size = new System.Drawing.Size(131, 21);
            this.DTPDodajDatumRodjenja.TabIndex = 21;
            this.DTPDodajDatumRodjenja.Value = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(150, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "Lozinka:";
            // 
            // TBoxDodajLozinka
            // 
            this.TBoxDodajLozinka.Location = new System.Drawing.Point(153, 44);
            this.TBoxDodajLozinka.Name = "TBoxDodajLozinka";
            this.TBoxDodajLozinka.Size = new System.Drawing.Size(131, 21);
            this.TBoxDodajLozinka.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Korisnicko ime:";
            // 
            // TBoxDodajKorisnickoIme
            // 
            this.TBoxDodajKorisnickoIme.Location = new System.Drawing.Point(16, 44);
            this.TBoxDodajKorisnickoIme.Name = "TBoxDodajKorisnickoIme";
            this.TBoxDodajKorisnickoIme.Size = new System.Drawing.Size(131, 21);
            this.TBoxDodajKorisnickoIme.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Datum rodjenja:";
            // 
            // BtnDodajKupca
            // 
            this.BtnDodajKupca.Location = new System.Drawing.Point(305, 94);
            this.BtnDodajKupca.Name = "BtnDodajKupca";
            this.BtnDodajKupca.Size = new System.Drawing.Size(131, 41);
            this.BtnDodajKupca.TabIndex = 10;
            this.BtnDodajKupca.Text = "Dodaj kupca";
            this.BtnDodajKupca.UseVisualStyleBackColor = true;
            this.BtnDodajKupca.Click += new System.EventHandler(this.btnDodajKupca_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "JMBG:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Telefon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Prezime:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ime:";
            // 
            // TBoxDodajJMBG
            // 
            this.TBoxDodajJMBG.Location = new System.Drawing.Point(153, 166);
            this.TBoxDodajJMBG.Name = "TBoxDodajJMBG";
            this.TBoxDodajJMBG.Size = new System.Drawing.Size(131, 21);
            this.TBoxDodajJMBG.TabIndex = 4;
            // 
            // TBoxDodajTelefon
            // 
            this.TBoxDodajTelefon.Location = new System.Drawing.Point(153, 125);
            this.TBoxDodajTelefon.Name = "TBoxDodajTelefon";
            this.TBoxDodajTelefon.Size = new System.Drawing.Size(131, 21);
            this.TBoxDodajTelefon.TabIndex = 3;
            // 
            // TBoxDodajPrezime
            // 
            this.TBoxDodajPrezime.Location = new System.Drawing.Point(153, 83);
            this.TBoxDodajPrezime.Name = "TBoxDodajPrezime";
            this.TBoxDodajPrezime.Size = new System.Drawing.Size(131, 21);
            this.TBoxDodajPrezime.TabIndex = 1;
            // 
            // TBoxDodajIme
            // 
            this.TBoxDodajIme.Location = new System.Drawing.Point(16, 83);
            this.TBoxDodajIme.Name = "TBoxDodajIme";
            this.TBoxDodajIme.Size = new System.Drawing.Size(131, 21);
            this.TBoxDodajIme.TabIndex = 0;
            // 
            // AdKupacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 487);
            this.Controls.Add(this.DTPIzmenaDatumRodjenja);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LBKupci);
            this.Controls.Add(this.TBoxIzmenaLozinka);
            this.Controls.Add(this.TBoxIzmenaIme);
            this.Controls.Add(this.TBoxIzmenaKorisnickoIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIzmeniKupca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnObrisiKupca);
            this.Controls.Add(this.TBoxIzmenaPrezime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBoxIzmenaTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBoxIzmenaJMBG);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdKupacForm";
            this.Text = "Kupac";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LBKupci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBoxIzmenaJMBG;
        private System.Windows.Forms.TextBox TBoxIzmenaTelefon;
        private System.Windows.Forms.TextBox TBoxIzmenaPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxIzmenaIme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnIzmeniKupca;
        private System.Windows.Forms.Button BtnObrisiKupca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBoxDodajJMBG;
        private System.Windows.Forms.TextBox TBoxDodajTelefon;
        private System.Windows.Forms.TextBox TBoxDodajPrezime;
        private System.Windows.Forms.TextBox TBoxDodajIme;
        private System.Windows.Forms.Button BtnDodajKupca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBoxIzmenaLozinka;
        private System.Windows.Forms.TextBox TBoxIzmenaKorisnickoIme;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TBoxDodajLozinka;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TBoxDodajKorisnickoIme;
        private System.Windows.Forms.DateTimePicker DTPIzmenaDatumRodjenja;
        private System.Windows.Forms.DateTimePicker DTPDodajDatumRodjenja;
    }
}