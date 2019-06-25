namespace car_rental_project
{
    partial class AdRezervacijeForm
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
            this.LBRezervacije = new System.Windows.Forms.ListBox();
            this.CBKupac = new System.Windows.Forms.ComboBox();
            this.CBDodajAutomobil = new System.Windows.Forms.ComboBox();
            this.DTPDodajDatumOd = new System.Windows.Forms.DateTimePicker();
            this.DTPDodajDatumDo = new System.Windows.Forms.DateTimePicker();
            this.TBoxDodajCena = new System.Windows.Forms.TextBox();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnObrisiRezervaciju = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DTPIzmeniDatumDo = new System.Windows.Forms.DateTimePicker();
            this.CBIzmeniAutomobil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DTPIzmeniDatumOd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TBoxIzmeniCena = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIzmeniRezervaciju = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBRezervacije
            // 
            this.LBRezervacije.FormattingEnabled = true;
            this.LBRezervacije.ItemHeight = 20;
            this.LBRezervacije.Location = new System.Drawing.Point(13, 112);
            this.LBRezervacije.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LBRezervacije.Name = "LBRezervacije";
            this.LBRezervacije.Size = new System.Drawing.Size(622, 304);
            this.LBRezervacije.TabIndex = 0;
            this.LBRezervacije.SelectedIndexChanged += new System.EventHandler(this.LBRezervacije_SelectedIndexChanged);
            // 
            // CBKupac
            // 
            this.CBKupac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBKupac.FormattingEnabled = true;
            this.CBKupac.Location = new System.Drawing.Point(13, 74);
            this.CBKupac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBKupac.Name = "CBKupac";
            this.CBKupac.Size = new System.Drawing.Size(622, 28);
            this.CBKupac.TabIndex = 1;
            this.CBKupac.SelectedIndexChanged += new System.EventHandler(this.CBKupac_SelectedIndexChanged);
            // 
            // CBDodajAutomobil
            // 
            this.CBDodajAutomobil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDodajAutomobil.DropDownWidth = 600;
            this.CBDodajAutomobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDodajAutomobil.FormattingEnabled = true;
            this.CBDodajAutomobil.Location = new System.Drawing.Point(107, 42);
            this.CBDodajAutomobil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBDodajAutomobil.Name = "CBDodajAutomobil";
            this.CBDodajAutomobil.Size = new System.Drawing.Size(465, 24);
            this.CBDodajAutomobil.TabIndex = 2;
            // 
            // DTPDodajDatumOd
            // 
            this.DTPDodajDatumOd.CustomFormat = "dd.MM.yyyy.";
            this.DTPDodajDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDodajDatumOd.Location = new System.Drawing.Point(107, 77);
            this.DTPDodajDatumOd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTPDodajDatumOd.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.DTPDodajDatumOd.MinDate = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.DTPDodajDatumOd.Name = "DTPDodajDatumOd";
            this.DTPDodajDatumOd.Size = new System.Drawing.Size(152, 26);
            this.DTPDodajDatumOd.TabIndex = 3;
            // 
            // DTPDodajDatumDo
            // 
            this.DTPDodajDatumDo.CustomFormat = "dd.MM.yyyy.";
            this.DTPDodajDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDodajDatumDo.Location = new System.Drawing.Point(420, 77);
            this.DTPDodajDatumDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTPDodajDatumDo.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.DTPDodajDatumDo.MinDate = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.DTPDodajDatumDo.Name = "DTPDodajDatumDo";
            this.DTPDodajDatumDo.Size = new System.Drawing.Size(152, 26);
            this.DTPDodajDatumDo.TabIndex = 4;
            // 
            // TBoxDodajCena
            // 
            this.TBoxDodajCena.Location = new System.Drawing.Point(107, 115);
            this.TBoxDodajCena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBoxDodajCena.Name = "TBoxDodajCena";
            this.TBoxDodajCena.Size = new System.Drawing.Size(152, 26);
            this.TBoxDodajCena.TabIndex = 5;
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(19, 158);
            this.btnDodajRezervaciju.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(553, 51);
            this.btnDodajRezervaciju.TabIndex = 6;
            this.btnDodajRezervaciju.Text = "Dodaj rezervaciju";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = false;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Odaberite kupca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Automobil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Datum do:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cena:";
            // 
            // BtnObrisiRezervaciju
            // 
            this.BtnObrisiRezervaciju.BackColor = System.Drawing.Color.LightCoral;
            this.BtnObrisiRezervaciju.Location = new System.Drawing.Point(13, 426);
            this.BtnObrisiRezervaciju.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnObrisiRezervaciju.Name = "BtnObrisiRezervaciju";
            this.BtnObrisiRezervaciju.Size = new System.Drawing.Size(302, 51);
            this.BtnObrisiRezervaciju.TabIndex = 12;
            this.BtnObrisiRezervaciju.Text = "Obrisi rezervaciju";
            this.BtnObrisiRezervaciju.UseVisualStyleBackColor = false;
            this.BtnObrisiRezervaciju.Click += new System.EventHandler(this.BtnObrisiRezervaciju_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTPDodajDatumDo);
            this.groupBox1.Controls.Add(this.CBDodajAutomobil);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DTPDodajDatumOd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TBoxDodajCena);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDodajRezervaciju);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(656, 268);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(593, 221);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj rezervaciju";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DTPIzmeniDatumDo);
            this.groupBox2.Controls.Add(this.CBIzmeniAutomobil);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.DTPIzmeniDatumOd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TBoxIzmeniCena);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(656, 74);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(593, 184);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izmeni rezervaciju";
            // 
            // DTPIzmeniDatumDo
            // 
            this.DTPIzmeniDatumDo.CustomFormat = "dd.MM.yyyy.";
            this.DTPIzmeniDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPIzmeniDatumDo.Location = new System.Drawing.Point(420, 80);
            this.DTPIzmeniDatumDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTPIzmeniDatumDo.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.DTPIzmeniDatumDo.MinDate = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.DTPIzmeniDatumDo.Name = "DTPIzmeniDatumDo";
            this.DTPIzmeniDatumDo.Size = new System.Drawing.Size(152, 26);
            this.DTPIzmeniDatumDo.TabIndex = 4;
            // 
            // CBIzmeniAutomobil
            // 
            this.CBIzmeniAutomobil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBIzmeniAutomobil.DropDownWidth = 600;
            this.CBIzmeniAutomobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBIzmeniAutomobil.FormattingEnabled = true;
            this.CBIzmeniAutomobil.Location = new System.Drawing.Point(107, 43);
            this.CBIzmeniAutomobil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBIzmeniAutomobil.Name = "CBIzmeniAutomobil";
            this.CBIzmeniAutomobil.Size = new System.Drawing.Size(465, 24);
            this.CBIzmeniAutomobil.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cena:";
            // 
            // DTPIzmeniDatumOd
            // 
            this.DTPIzmeniDatumOd.CustomFormat = "dd.MM.yyyy.";
            this.DTPIzmeniDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPIzmeniDatumOd.Location = new System.Drawing.Point(107, 80);
            this.DTPIzmeniDatumOd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTPIzmeniDatumOd.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.DTPIzmeniDatumOd.MinDate = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.DTPIzmeniDatumOd.Name = "DTPIzmeniDatumOd";
            this.DTPIzmeniDatumOd.Size = new System.Drawing.Size(152, 26);
            this.DTPIzmeniDatumOd.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Datum do:";
            // 
            // TBoxIzmeniCena
            // 
            this.TBoxIzmeniCena.Location = new System.Drawing.Point(107, 116);
            this.TBoxIzmeniCena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBoxIzmeniCena.Name = "TBoxIzmeniCena";
            this.TBoxIzmeniCena.Size = new System.Drawing.Size(152, 26);
            this.TBoxIzmeniCena.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Datum od:";
            // 
            // btnIzmeniRezervaciju
            // 
            this.btnIzmeniRezervaciju.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIzmeniRezervaciju.Location = new System.Drawing.Point(318, 426);
            this.btnIzmeniRezervaciju.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIzmeniRezervaciju.Name = "btnIzmeniRezervaciju";
            this.btnIzmeniRezervaciju.Size = new System.Drawing.Size(317, 51);
            this.btnIzmeniRezervaciju.TabIndex = 6;
            this.btnIzmeniRezervaciju.Text = "Izmeni rezervaciju";
            this.btnIzmeniRezervaciju.UseVisualStyleBackColor = false;
            this.btnIzmeniRezervaciju.Click += new System.EventHandler(this.btnIzmeniRezervaciju_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Automobil:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(534, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Administracija rezervacija";
            // 
            // AdRezervacijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 497);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnObrisiRezervaciju);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBKupac);
            this.Controls.Add(this.LBRezervacije);
            this.Controls.Add(this.btnIzmeniRezervaciju);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdRezervacijeForm";
            this.Text = "AdRezervacijeForm";
            this.Load += new System.EventHandler(this.AdRezervacijeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBRezervacije;
        private System.Windows.Forms.ComboBox CBKupac;
        private System.Windows.Forms.ComboBox CBDodajAutomobil;
        private System.Windows.Forms.DateTimePicker DTPDodajDatumOd;
        private System.Windows.Forms.DateTimePicker DTPDodajDatumDo;
        private System.Windows.Forms.TextBox TBoxDodajCena;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnObrisiRezervaciju;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DTPIzmeniDatumDo;
        private System.Windows.Forms.ComboBox CBIzmeniAutomobil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTPIzmeniDatumOd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBoxIzmeniCena;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIzmeniRezervaciju;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}