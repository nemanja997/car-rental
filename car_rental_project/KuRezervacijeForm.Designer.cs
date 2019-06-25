namespace car_rental_project
{
    partial class KuRezervacijeForm
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
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.CBoxMarka = new System.Windows.Forms.ComboBox();
            this.CBoxModel = new System.Windows.Forms.ComboBox();
            this.CBoxKubikaza = new System.Windows.Forms.ComboBox();
            this.CBoxKaroserija = new System.Windows.Forms.ComboBox();
            this.CBoxGorivo = new System.Windows.Forms.ComboBox();
            this.CBoxPogon = new System.Windows.Forms.ComboBox();
            this.CBoxMenjac = new System.Windows.Forms.ComboBox();
            this.CBoxBrojVrata = new System.Windows.Forms.ComboBox();
            this.CBoxGodiste = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPrikaziPonudu = new System.Windows.Forms.Button();
            this.LBPonude = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DTPDatumOd = new System.Windows.Forms.DateTimePicker();
            this.DTPDatumDo = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TBoxUkupnaCena = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervisi.Location = new System.Drawing.Point(11, 522);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(523, 69);
            this.btnRezervisi.TabIndex = 0;
            this.btnRezervisi.Text = "Rezervisi";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // CBoxMarka
            // 
            this.CBoxMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxMarka.FormattingEnabled = true;
            this.CBoxMarka.Location = new System.Drawing.Point(12, 40);
            this.CBoxMarka.Name = "CBoxMarka";
            this.CBoxMarka.Size = new System.Drawing.Size(146, 28);
            this.CBoxMarka.TabIndex = 1;
            this.CBoxMarka.SelectedIndexChanged += new System.EventHandler(this.CBoxMarka_SelectedIndexChanged);
            // 
            // CBoxModel
            // 
            this.CBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxModel.FormattingEnabled = true;
            this.CBoxModel.Location = new System.Drawing.Point(12, 95);
            this.CBoxModel.Name = "CBoxModel";
            this.CBoxModel.Size = new System.Drawing.Size(146, 28);
            this.CBoxModel.TabIndex = 1;
            // 
            // CBoxKubikaza
            // 
            this.CBoxKubikaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxKubikaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxKubikaza.FormattingEnabled = true;
            this.CBoxKubikaza.Location = new System.Drawing.Point(197, 40);
            this.CBoxKubikaza.Name = "CBoxKubikaza";
            this.CBoxKubikaza.Size = new System.Drawing.Size(146, 28);
            this.CBoxKubikaza.TabIndex = 1;
            // 
            // CBoxKaroserija
            // 
            this.CBoxKaroserija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxKaroserija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxKaroserija.FormattingEnabled = true;
            this.CBoxKaroserija.Location = new System.Drawing.Point(197, 95);
            this.CBoxKaroserija.Name = "CBoxKaroserija";
            this.CBoxKaroserija.Size = new System.Drawing.Size(146, 28);
            this.CBoxKaroserija.TabIndex = 1;
            // 
            // CBoxGorivo
            // 
            this.CBoxGorivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxGorivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxGorivo.FormattingEnabled = true;
            this.CBoxGorivo.Location = new System.Drawing.Point(389, 40);
            this.CBoxGorivo.Name = "CBoxGorivo";
            this.CBoxGorivo.Size = new System.Drawing.Size(146, 28);
            this.CBoxGorivo.TabIndex = 1;
            // 
            // CBoxPogon
            // 
            this.CBoxPogon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxPogon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxPogon.FormattingEnabled = true;
            this.CBoxPogon.Location = new System.Drawing.Point(389, 95);
            this.CBoxPogon.Name = "CBoxPogon";
            this.CBoxPogon.Size = new System.Drawing.Size(146, 28);
            this.CBoxPogon.TabIndex = 1;
            // 
            // CBoxMenjac
            // 
            this.CBoxMenjac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxMenjac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxMenjac.FormattingEnabled = true;
            this.CBoxMenjac.Location = new System.Drawing.Point(389, 150);
            this.CBoxMenjac.Name = "CBoxMenjac";
            this.CBoxMenjac.Size = new System.Drawing.Size(146, 28);
            this.CBoxMenjac.TabIndex = 1;
            // 
            // CBoxBrojVrata
            // 
            this.CBoxBrojVrata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxBrojVrata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxBrojVrata.FormattingEnabled = true;
            this.CBoxBrojVrata.Location = new System.Drawing.Point(197, 150);
            this.CBoxBrojVrata.Name = "CBoxBrojVrata";
            this.CBoxBrojVrata.Size = new System.Drawing.Size(146, 28);
            this.CBoxBrojVrata.TabIndex = 1;
            // 
            // CBoxGodiste
            // 
            this.CBoxGodiste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxGodiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxGodiste.FormattingEnabled = true;
            this.CBoxGodiste.Location = new System.Drawing.Point(12, 150);
            this.CBoxGodiste.Name = "CBoxGodiste";
            this.CBoxGodiste.Size = new System.Drawing.Size(146, 28);
            this.CBoxGodiste.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberte marku:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odaberite kubikazu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odaberite gorivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Odaberite pogon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Odaberite kaorseriju:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Odaberite model:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Odaberite godiste:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(193, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Odaberite broj vrata:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Odaberite menjac:";
            // 
            // btnPrikaziPonudu
            // 
            this.btnPrikaziPonudu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziPonudu.Location = new System.Drawing.Point(12, 187);
            this.btnPrikaziPonudu.Name = "btnPrikaziPonudu";
            this.btnPrikaziPonudu.Size = new System.Drawing.Size(524, 44);
            this.btnPrikaziPonudu.TabIndex = 3;
            this.btnPrikaziPonudu.Text = "Prikazi dostupne termine odabranog automobila";
            this.btnPrikaziPonudu.UseVisualStyleBackColor = true;
            this.btnPrikaziPonudu.Click += new System.EventHandler(this.btnPrikaziPonudu_Click);
            // 
            // LBPonude
            // 
            this.LBPonude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPonude.FormattingEnabled = true;
            this.LBPonude.ItemHeight = 20;
            this.LBPonude.Location = new System.Drawing.Point(13, 257);
            this.LBPonude.Name = "LBPonude";
            this.LBPonude.Size = new System.Drawing.Size(522, 124);
            this.LBPonude.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Termini:";
            // 
            // DTPDatumOd
            // 
            this.DTPDatumOd.CustomFormat = "dd.MM.yyyy.";
            this.DTPDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDatumOd.Location = new System.Drawing.Point(11, 428);
            this.DTPDatumOd.Name = "DTPDatumOd";
            this.DTPDatumOd.Size = new System.Drawing.Size(200, 20);
            this.DTPDatumOd.TabIndex = 5;
            this.DTPDatumOd.ValueChanged += new System.EventHandler(this.DTPDatumOd_ValueChanged);
            // 
            // DTPDatumDo
            // 
            this.DTPDatumDo.CustomFormat = "dd.MM.yyyy.";
            this.DTPDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDatumDo.Location = new System.Drawing.Point(13, 483);
            this.DTPDatumDo.Name = "DTPDatumDo";
            this.DTPDatumDo.Size = new System.Drawing.Size(200, 20);
            this.DTPDatumDo.TabIndex = 5;
            this.DTPDatumDo.ValueChanged += new System.EventHandler(this.DTPDatumDo_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Datum preuzimanja:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 460);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Datum vracanja:";
            // 
            // TBoxUkupnaCena
            // 
            this.TBoxUkupnaCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxUkupnaCena.Location = new System.Drawing.Point(330, 453);
            this.TBoxUkupnaCena.Name = "TBoxUkupnaCena";
            this.TBoxUkupnaCena.ReadOnly = true;
            this.TBoxUkupnaCena.Size = new System.Drawing.Size(132, 31);
            this.TBoxUkupnaCena.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(306, 428);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ukupna cena rezervacije:";
            // 
            // KuRezervacijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 604);
            this.Controls.Add(this.TBoxUkupnaCena);
            this.Controls.Add(this.DTPDatumDo);
            this.Controls.Add(this.DTPDatumOd);
            this.Controls.Add(this.LBPonude);
            this.Controls.Add(this.btnPrikaziPonudu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxGodiste);
            this.Controls.Add(this.CBoxBrojVrata);
            this.Controls.Add(this.CBoxMenjac);
            this.Controls.Add(this.CBoxPogon);
            this.Controls.Add(this.CBoxKaroserija);
            this.Controls.Add(this.CBoxGorivo);
            this.Controls.Add(this.CBoxKubikaza);
            this.Controls.Add(this.CBoxModel);
            this.Controls.Add(this.CBoxMarka);
            this.Controls.Add(this.btnRezervisi);
            this.Name = "KuRezervacijeForm";
            this.Text = "KuRezervacijeForm";
            this.Load += new System.EventHandler(this.KuRezervacijeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRezervisi;
        private System.Windows.Forms.ComboBox CBoxMarka;
        private System.Windows.Forms.ComboBox CBoxModel;
        private System.Windows.Forms.ComboBox CBoxKubikaza;
        private System.Windows.Forms.ComboBox CBoxKaroserija;
        private System.Windows.Forms.ComboBox CBoxGorivo;
        private System.Windows.Forms.ComboBox CBoxPogon;
        private System.Windows.Forms.ComboBox CBoxMenjac;
        private System.Windows.Forms.ComboBox CBoxBrojVrata;
        private System.Windows.Forms.ComboBox CBoxGodiste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPrikaziPonudu;
        private System.Windows.Forms.ListBox LBPonude;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DTPDatumOd;
        private System.Windows.Forms.DateTimePicker DTPDatumDo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBoxUkupnaCena;
        private System.Windows.Forms.Label label13;
    }
}