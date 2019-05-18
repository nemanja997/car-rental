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
            this.SuspendLayout();
            // 
            // LBRezervacije
            // 
            this.LBRezervacije.FormattingEnabled = true;
            this.LBRezervacije.Location = new System.Drawing.Point(24, 48);
            this.LBRezervacije.Name = "LBRezervacije";
            this.LBRezervacije.Size = new System.Drawing.Size(561, 121);
            this.LBRezervacije.TabIndex = 0;
            // 
            // CBKupac
            // 
            this.CBKupac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBKupac.FormattingEnabled = true;
            this.CBKupac.Location = new System.Drawing.Point(116, 18);
            this.CBKupac.Name = "CBKupac";
            this.CBKupac.Size = new System.Drawing.Size(469, 21);
            this.CBKupac.TabIndex = 1;
            this.CBKupac.SelectedIndexChanged += new System.EventHandler(this.CBKupac_SelectedIndexChanged);
            // 
            // CBDodajAutomobil
            // 
            this.CBDodajAutomobil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDodajAutomobil.FormattingEnabled = true;
            this.CBDodajAutomobil.Location = new System.Drawing.Point(94, 188);
            this.CBDodajAutomobil.Name = "CBDodajAutomobil";
            this.CBDodajAutomobil.Size = new System.Drawing.Size(121, 21);
            this.CBDodajAutomobil.TabIndex = 2;
            // 
            // DTPDodajDatumOd
            // 
            this.DTPDodajDatumOd.Location = new System.Drawing.Point(94, 216);
            this.DTPDodajDatumOd.Name = "DTPDodajDatumOd";
            this.DTPDodajDatumOd.Size = new System.Drawing.Size(200, 20);
            this.DTPDodajDatumOd.TabIndex = 3;
            // 
            // DTPDodajDatumDo
            // 
            this.DTPDodajDatumDo.Location = new System.Drawing.Point(94, 243);
            this.DTPDodajDatumDo.Name = "DTPDodajDatumDo";
            this.DTPDodajDatumDo.Size = new System.Drawing.Size(200, 20);
            this.DTPDodajDatumDo.TabIndex = 4;
            // 
            // TBoxDodajCena
            // 
            this.TBoxDodajCena.Location = new System.Drawing.Point(94, 270);
            this.TBoxDodajCena.Name = "TBoxDodajCena";
            this.TBoxDodajCena.Size = new System.Drawing.Size(121, 20);
            this.TBoxDodajCena.TabIndex = 5;
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(94, 296);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(121, 33);
            this.btnDodajRezervaciju.TabIndex = 6;
            this.btnDodajRezervaciju.Text = "Dodaj rezervaciju";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = true;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Odaberite kupca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Automobil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Datum do:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cena:";
            // 
            // BtnObrisiRezervaciju
            // 
            this.BtnObrisiRezervaciju.Location = new System.Drawing.Point(465, 175);
            this.BtnObrisiRezervaciju.Name = "BtnObrisiRezervaciju";
            this.BtnObrisiRezervaciju.Size = new System.Drawing.Size(120, 34);
            this.BtnObrisiRezervaciju.TabIndex = 12;
            this.BtnObrisiRezervaciju.Text = "Obrisi rezervaciju";
            this.BtnObrisiRezervaciju.UseVisualStyleBackColor = true;
            this.BtnObrisiRezervaciju.Click += new System.EventHandler(this.BtnObrisiRezervaciju_Click);
            // 
            // AdRezervacijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 446);
            this.Controls.Add(this.BtnObrisiRezervaciju);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajRezervaciju);
            this.Controls.Add(this.TBoxDodajCena);
            this.Controls.Add(this.DTPDodajDatumDo);
            this.Controls.Add(this.DTPDodajDatumOd);
            this.Controls.Add(this.CBDodajAutomobil);
            this.Controls.Add(this.CBKupac);
            this.Controls.Add(this.LBRezervacije);
            this.Name = "AdRezervacijeForm";
            this.Text = "AdRezervacijeForm";
            this.Load += new System.EventHandler(this.AdRezervacijeForm_Load);
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
    }
}