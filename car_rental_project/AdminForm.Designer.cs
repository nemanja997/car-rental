﻿namespace car_rental_project
{
    partial class AdminForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBoxIzmenaJMBG = new System.Windows.Forms.TextBox();
            this.TBoxIzmenaTelefon = new System.Windows.Forms.TextBox();
            this.TBoxIzmenaDatumRodjenja = new System.Windows.Forms.TextBox();
            this.TBoxIzmenaPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxIzmenaIme = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBoxDodajIme = new System.Windows.Forms.TextBox();
            this.TBoxDodajPrezime = new System.Windows.Forms.TextBox();
            this.TBoxDodajDatumRodjenja = new System.Windows.Forms.TextBox();
            this.TBoxDodajTelefon = new System.Windows.Forms.TextBox();
            this.TBoxDodajJMBG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.TBoxIzmenaKorisnickoIme = new System.Windows.Forms.TextBox();
            this.TBoxIzmenaLozinka = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TBoxDodajKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TBoxDodajLozinka = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TBoxIzmenaLozinka);
            this.groupBox1.Controls.Add(this.TBoxIzmenaKorisnickoIme);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TBoxIzmenaJMBG);
            this.groupBox1.Controls.Add(this.TBoxIzmenaTelefon);
            this.groupBox1.Controls.Add(this.TBoxIzmenaDatumRodjenja);
            this.groupBox1.Controls.Add(this.TBoxIzmenaPrezime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBoxIzmenaIme);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kupac";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(9, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 124);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pretraga:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "JMBG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon:";
            // 
            // TBoxIzmenaJMBG
            // 
            this.TBoxIzmenaJMBG.Location = new System.Drawing.Point(462, 131);
            this.TBoxIzmenaJMBG.Name = "TBoxIzmenaJMBG";
            this.TBoxIzmenaJMBG.Size = new System.Drawing.Size(149, 21);
            this.TBoxIzmenaJMBG.TabIndex = 7;
            // 
            // TBoxIzmenaTelefon
            // 
            this.TBoxIzmenaTelefon.Location = new System.Drawing.Point(309, 131);
            this.TBoxIzmenaTelefon.Name = "TBoxIzmenaTelefon";
            this.TBoxIzmenaTelefon.Size = new System.Drawing.Size(149, 21);
            this.TBoxIzmenaTelefon.TabIndex = 6;
            // 
            // TBoxIzmenaDatumRodjenja
            // 
            this.TBoxIzmenaDatumRodjenja.Location = new System.Drawing.Point(309, 174);
            this.TBoxIzmenaDatumRodjenja.Name = "TBoxIzmenaDatumRodjenja";
            this.TBoxIzmenaDatumRodjenja.Size = new System.Drawing.Size(149, 21);
            this.TBoxIzmenaDatumRodjenja.TabIndex = 5;
            // 
            // TBoxIzmenaPrezime
            // 
            this.TBoxIzmenaPrezime.Location = new System.Drawing.Point(463, 83);
            this.TBoxIzmenaPrezime.Name = "TBoxIzmenaPrezime";
            this.TBoxIzmenaPrezime.Size = new System.Drawing.Size(149, 21);
            this.TBoxIzmenaPrezime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum rodjenja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // TBoxIzmenaIme
            // 
            this.TBoxIzmenaIme.Location = new System.Drawing.Point(308, 83);
            this.TBoxIzmenaIme.Name = "TBoxIzmenaIme";
            this.TBoxIzmenaIme.Size = new System.Drawing.Size(149, 21);
            this.TBoxIzmenaIme.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Izmeni";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 27);
            this.button2.TabIndex = 14;
            this.button2.Text = "Obrisi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.TBoxDodajLozinka);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.TBoxDodajKorisnickoIme);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TBoxDodajJMBG);
            this.groupBox2.Controls.Add(this.TBoxDodajTelefon);
            this.groupBox2.Controls.Add(this.TBoxDodajDatumRodjenja);
            this.groupBox2.Controls.Add(this.TBoxDodajPrezime);
            this.groupBox2.Controls.Add(this.TBoxDodajIme);
            this.groupBox2.Location = new System.Drawing.Point(618, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 198);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj kupca";
            // 
            // TBoxDodajIme
            // 
            this.TBoxDodajIme.Location = new System.Drawing.Point(16, 83);
            this.TBoxDodajIme.Name = "TBoxDodajIme";
            this.TBoxDodajIme.Size = new System.Drawing.Size(131, 21);
            this.TBoxDodajIme.TabIndex = 0;
            // 
            // TBoxDodajPrezime
            // 
            this.TBoxDodajPrezime.Location = new System.Drawing.Point(153, 83);
            this.TBoxDodajPrezime.Name = "TBoxDodajPrezime";
            this.TBoxDodajPrezime.Size = new System.Drawing.Size(131, 21);
            this.TBoxDodajPrezime.TabIndex = 1;
            // 
            // TBoxDodajDatumRodjenja
            // 
            this.TBoxDodajDatumRodjenja.Location = new System.Drawing.Point(16, 125);
            this.TBoxDodajDatumRodjenja.Name = "TBoxDodajDatumRodjenja";
            this.TBoxDodajDatumRodjenja.Size = new System.Drawing.Size(131, 21);
            this.TBoxDodajDatumRodjenja.TabIndex = 2;
            // 
            // TBoxDodajTelefon
            // 
            this.TBoxDodajTelefon.Location = new System.Drawing.Point(153, 125);
            this.TBoxDodajTelefon.Name = "TBoxDodajTelefon";
            this.TBoxDodajTelefon.Size = new System.Drawing.Size(131, 21);
            this.TBoxDodajTelefon.TabIndex = 3;
            // 
            // TBoxDodajJMBG
            // 
            this.TBoxDodajJMBG.Location = new System.Drawing.Point(16, 164);
            this.TBoxDodajJMBG.Name = "TBoxDodajJMBG";
            this.TBoxDodajJMBG.Size = new System.Drawing.Size(131, 21);
            this.TBoxDodajJMBG.TabIndex = 4;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Prezime:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "DatumRodjenja";
            this.label9.Click += new System.EventHandler(this.label9_Click);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "JMBG:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 30);
            this.button3.TabIndex = 10;
            this.button3.Text = "Dodaj kupca";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TBoxIzmenaKorisnickoIme
            // 
            this.TBoxIzmenaKorisnickoIme.Location = new System.Drawing.Point(307, 36);
            this.TBoxIzmenaKorisnickoIme.Name = "TBoxIzmenaKorisnickoIme";
            this.TBoxIzmenaKorisnickoIme.Size = new System.Drawing.Size(150, 21);
            this.TBoxIzmenaKorisnickoIme.TabIndex = 16;
            // 
            // TBoxIzmenaLozinka
            // 
            this.TBoxIzmenaLozinka.Location = new System.Drawing.Point(462, 36);
            this.TBoxIzmenaLozinka.Name = "TBoxIzmenaLozinka";
            this.TBoxIzmenaLozinka.Size = new System.Drawing.Size(149, 21);
            this.TBoxIzmenaLozinka.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Korisnicko ime:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(462, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "Lozinka";
            // 
            // TBoxDodajKorisnickoIme
            // 
            this.TBoxDodajKorisnickoIme.Location = new System.Drawing.Point(16, 44);
            this.TBoxDodajKorisnickoIme.Name = "TBoxDodajKorisnickoIme";
            this.TBoxDodajKorisnickoIme.Size = new System.Drawing.Size(131, 21);
            this.TBoxDodajKorisnickoIme.TabIndex = 11;
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
            // TBoxDodajLozinka
            // 
            this.TBoxDodajLozinka.Location = new System.Drawing.Point(153, 44);
            this.TBoxDodajLozinka.Name = "TBoxDodajLozinka";
            this.TBoxDodajLozinka.Size = new System.Drawing.Size(131, 21);
            this.TBoxDodajLozinka.TabIndex = 13;
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 519);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBoxIzmenaJMBG;
        private System.Windows.Forms.TextBox TBoxIzmenaTelefon;
        private System.Windows.Forms.TextBox TBoxIzmenaDatumRodjenja;
        private System.Windows.Forms.TextBox TBoxIzmenaPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxIzmenaIme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBoxDodajJMBG;
        private System.Windows.Forms.TextBox TBoxDodajTelefon;
        private System.Windows.Forms.TextBox TBoxDodajDatumRodjenja;
        private System.Windows.Forms.TextBox TBoxDodajPrezime;
        private System.Windows.Forms.TextBox TBoxDodajIme;
        private System.Windows.Forms.Button button3;
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
    }
}