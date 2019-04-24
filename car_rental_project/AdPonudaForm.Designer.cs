namespace car_rental_project
{
    partial class AdPonudaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.LBPonude = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnObrisiPonudu = new System.Windows.Forms.Button();
            this.CBDodajAutomobil = new System.Windows.Forms.ComboBox();
            this.DTPDodajDatumOd = new System.Windows.Forms.DateTimePicker();
            this.DTPDodajDatumDo = new System.Windows.Forms.DateTimePicker();
            this.TBoxDodajCenaPoDanu = new System.Windows.Forms.TextBox();
            this.BtnDodajPonudu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CBIzmenaAutomobil = new System.Windows.Forms.ComboBox();
            this.DTPIzmenaDatumOd = new System.Windows.Forms.DateTimePicker();
            this.DTPIzmenaDatumDo = new System.Windows.Forms.DateTimePicker();
            this.TBoxIzmenaCenaPoDanu = new System.Windows.Forms.TextBox();
            this.BtnIzmenaPonuda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberite zeljenu ponudu:";
            // 
            // LBPonude
            // 
            this.LBPonude.FormattingEnabled = true;
            this.LBPonude.Location = new System.Drawing.Point(12, 37);
            this.LBPonude.Name = "LBPonude";
            this.LBPonude.Size = new System.Drawing.Size(365, 121);
            this.LBPonude.TabIndex = 1;
            this.LBPonude.SelectedIndexChanged += new System.EventHandler(this.LBPonude_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Automobil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datum do:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cena po danu:";
            // 
            // BtnObrisiPonudu
            // 
            this.BtnObrisiPonudu.Location = new System.Drawing.Point(161, 164);
            this.BtnObrisiPonudu.Name = "BtnObrisiPonudu";
            this.BtnObrisiPonudu.Size = new System.Drawing.Size(100, 37);
            this.BtnObrisiPonudu.TabIndex = 6;
            this.BtnObrisiPonudu.Text = "Obrisi ponudu";
            this.BtnObrisiPonudu.UseVisualStyleBackColor = true;
            this.BtnObrisiPonudu.Click += new System.EventHandler(this.BtnObrisiPonudu_Click);
            // 
            // CBDodajAutomobil
            // 
            this.CBDodajAutomobil.DropDownHeight = 200;
            this.CBDodajAutomobil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDodajAutomobil.DropDownWidth = 500;
            this.CBDodajAutomobil.FormattingEnabled = true;
            this.CBDodajAutomobil.IntegralHeight = false;
            this.CBDodajAutomobil.Location = new System.Drawing.Point(141, 67);
            this.CBDodajAutomobil.Name = "CBDodajAutomobil";
            this.CBDodajAutomobil.Size = new System.Drawing.Size(258, 21);
            this.CBDodajAutomobil.TabIndex = 7;
            // 
            // DTPDodajDatumOd
            // 
            this.DTPDodajDatumOd.CustomFormat = "dd.MM.yyyy.";
            this.DTPDodajDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDodajDatumOd.Location = new System.Drawing.Point(141, 98);
            this.DTPDodajDatumOd.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.DTPDodajDatumOd.MinDate = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.DTPDodajDatumOd.Name = "DTPDodajDatumOd";
            this.DTPDodajDatumOd.Size = new System.Drawing.Size(121, 20);
            this.DTPDodajDatumOd.TabIndex = 8;
            // 
            // DTPDodajDatumDo
            // 
            this.DTPDodajDatumDo.CustomFormat = "dd.MM.yyyy.";
            this.DTPDodajDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDodajDatumDo.Location = new System.Drawing.Point(141, 125);
            this.DTPDodajDatumDo.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.DTPDodajDatumDo.MinDate = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.DTPDodajDatumDo.Name = "DTPDodajDatumDo";
            this.DTPDodajDatumDo.Size = new System.Drawing.Size(121, 20);
            this.DTPDodajDatumDo.TabIndex = 9;
            // 
            // TBoxDodajCenaPoDanu
            // 
            this.TBoxDodajCenaPoDanu.Location = new System.Drawing.Point(141, 149);
            this.TBoxDodajCenaPoDanu.Name = "TBoxDodajCenaPoDanu";
            this.TBoxDodajCenaPoDanu.Size = new System.Drawing.Size(121, 20);
            this.TBoxDodajCenaPoDanu.TabIndex = 10;
            // 
            // BtnDodajPonudu
            // 
            this.BtnDodajPonudu.Location = new System.Drawing.Point(299, 94);
            this.BtnDodajPonudu.Name = "BtnDodajPonudu";
            this.BtnDodajPonudu.Size = new System.Drawing.Size(100, 37);
            this.BtnDodajPonudu.TabIndex = 11;
            this.BtnDodajPonudu.Text = "Dodaj ponudu";
            this.BtnDodajPonudu.UseVisualStyleBackColor = true;
            this.BtnDodajPonudu.Click += new System.EventHandler(this.BtnDodajPonudu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Automobil:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Datum od:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Datum do:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cena po danu:";
            // 
            // CBIzmenaAutomobil
            // 
            this.CBIzmenaAutomobil.DropDownHeight = 200;
            this.CBIzmenaAutomobil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBIzmenaAutomobil.DropDownWidth = 500;
            this.CBIzmenaAutomobil.FormattingEnabled = true;
            this.CBIzmenaAutomobil.IntegralHeight = false;
            this.CBIzmenaAutomobil.Location = new System.Drawing.Point(495, 37);
            this.CBIzmenaAutomobil.Name = "CBIzmenaAutomobil";
            this.CBIzmenaAutomobil.Size = new System.Drawing.Size(258, 21);
            this.CBIzmenaAutomobil.TabIndex = 7;
            // 
            // DTPIzmenaDatumOd
            // 
            this.DTPIzmenaDatumOd.CustomFormat = "dd.MM.yyyy.";
            this.DTPIzmenaDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPIzmenaDatumOd.Location = new System.Drawing.Point(495, 68);
            this.DTPIzmenaDatumOd.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.DTPIzmenaDatumOd.MinDate = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.DTPIzmenaDatumOd.Name = "DTPIzmenaDatumOd";
            this.DTPIzmenaDatumOd.Size = new System.Drawing.Size(121, 20);
            this.DTPIzmenaDatumOd.TabIndex = 8;
            // 
            // DTPIzmenaDatumDo
            // 
            this.DTPIzmenaDatumDo.CustomFormat = "dd.MM.yyyy.";
            this.DTPIzmenaDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPIzmenaDatumDo.Location = new System.Drawing.Point(495, 95);
            this.DTPIzmenaDatumDo.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.DTPIzmenaDatumDo.MinDate = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.DTPIzmenaDatumDo.Name = "DTPIzmenaDatumDo";
            this.DTPIzmenaDatumDo.Size = new System.Drawing.Size(121, 20);
            this.DTPIzmenaDatumDo.TabIndex = 9;
            // 
            // TBoxIzmenaCenaPoDanu
            // 
            this.TBoxIzmenaCenaPoDanu.Location = new System.Drawing.Point(495, 119);
            this.TBoxIzmenaCenaPoDanu.Name = "TBoxIzmenaCenaPoDanu";
            this.TBoxIzmenaCenaPoDanu.Size = new System.Drawing.Size(121, 20);
            this.TBoxIzmenaCenaPoDanu.TabIndex = 10;
            // 
            // BtnIzmenaPonuda
            // 
            this.BtnIzmenaPonuda.Location = new System.Drawing.Point(277, 164);
            this.BtnIzmenaPonuda.Name = "BtnIzmenaPonuda";
            this.BtnIzmenaPonuda.Size = new System.Drawing.Size(100, 37);
            this.BtnIzmenaPonuda.TabIndex = 12;
            this.BtnIzmenaPonuda.Text = "Izmeni ponudu";
            this.BtnIzmenaPonuda.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBDodajAutomobil);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnDodajPonudu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TBoxDodajCenaPoDanu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DTPDodajDatumOd);
            this.groupBox1.Controls.Add(this.DTPDodajDatumDo);
            this.groupBox1.Location = new System.Drawing.Point(143, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 211);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj ponudu:";
            // 
            // AdPonudaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 459);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnIzmenaPonuda);
            this.Controls.Add(this.TBoxIzmenaCenaPoDanu);
            this.Controls.Add(this.DTPIzmenaDatumDo);
            this.Controls.Add(this.DTPIzmenaDatumOd);
            this.Controls.Add(this.CBIzmenaAutomobil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnObrisiPonudu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBPonude);
            this.Controls.Add(this.label1);
            this.Name = "AdPonudaForm";
            this.Text = "AdPonudaForm";
            this.Load += new System.EventHandler(this.AdPonudaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LBPonude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnObrisiPonudu;
        private System.Windows.Forms.ComboBox CBDodajAutomobil;
        private System.Windows.Forms.DateTimePicker DTPDodajDatumOd;
        private System.Windows.Forms.DateTimePicker DTPDodajDatumDo;
        private System.Windows.Forms.TextBox TBoxDodajCenaPoDanu;
        private System.Windows.Forms.Button BtnDodajPonudu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBIzmenaAutomobil;
        private System.Windows.Forms.DateTimePicker DTPIzmenaDatumOd;
        private System.Windows.Forms.DateTimePicker DTPIzmenaDatumDo;
        private System.Windows.Forms.TextBox TBoxIzmenaCenaPoDanu;
        private System.Windows.Forms.Button BtnIzmenaPonuda;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}