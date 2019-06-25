namespace car_rental_project
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
            this.BtnKupac = new System.Windows.Forms.Button();
            this.BtnAutomobil = new System.Windows.Forms.Button();
            this.BtnPonuda = new System.Windows.Forms.Button();
            this.BtnRezervacija = new System.Windows.Forms.Button();
            this.BtnStatistika = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnKupac
            // 
            this.BtnKupac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKupac.Location = new System.Drawing.Point(47, 57);
            this.BtnKupac.Name = "BtnKupac";
            this.BtnKupac.Size = new System.Drawing.Size(255, 69);
            this.BtnKupac.TabIndex = 0;
            this.BtnKupac.Text = "Kupci";
            this.BtnKupac.UseVisualStyleBackColor = true;
            this.BtnKupac.Click += new System.EventHandler(this.BtnKupac_Click);
            // 
            // BtnAutomobil
            // 
            this.BtnAutomobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAutomobil.Location = new System.Drawing.Point(47, 141);
            this.BtnAutomobil.Name = "BtnAutomobil";
            this.BtnAutomobil.Size = new System.Drawing.Size(255, 69);
            this.BtnAutomobil.TabIndex = 0;
            this.BtnAutomobil.Text = "Automobili";
            this.BtnAutomobil.UseVisualStyleBackColor = true;
            this.BtnAutomobil.Click += new System.EventHandler(this.BtnAutomobil_Click);
            // 
            // BtnPonuda
            // 
            this.BtnPonuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPonuda.Location = new System.Drawing.Point(322, 57);
            this.BtnPonuda.Name = "BtnPonuda";
            this.BtnPonuda.Size = new System.Drawing.Size(255, 69);
            this.BtnPonuda.TabIndex = 0;
            this.BtnPonuda.Text = "Ponude";
            this.BtnPonuda.UseVisualStyleBackColor = true;
            this.BtnPonuda.Click += new System.EventHandler(this.BtnPonuda_Click);
            // 
            // BtnRezervacija
            // 
            this.BtnRezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRezervacija.Location = new System.Drawing.Point(322, 141);
            this.BtnRezervacija.Name = "BtnRezervacija";
            this.BtnRezervacija.Size = new System.Drawing.Size(255, 69);
            this.BtnRezervacija.TabIndex = 0;
            this.BtnRezervacija.Text = "Rezervacije";
            this.BtnRezervacija.UseVisualStyleBackColor = true;
            this.BtnRezervacija.Click += new System.EventHandler(this.BtnRezervacija_Click);
            // 
            // BtnStatistika
            // 
            this.BtnStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStatistika.Location = new System.Drawing.Point(184, 227);
            this.BtnStatistika.Name = "BtnStatistika";
            this.BtnStatistika.Size = new System.Drawing.Size(255, 69);
            this.BtnStatistika.TabIndex = 0;
            this.BtnStatistika.Text = "Statistika";
            this.BtnStatistika.UseVisualStyleBackColor = true;
            this.BtnStatistika.Click += new System.EventHandler(this.BtnStatistika_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administracija";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStatistika);
            this.Controls.Add(this.BtnRezervacija);
            this.Controls.Add(this.BtnPonuda);
            this.Controls.Add(this.BtnAutomobil);
            this.Controls.Add(this.BtnKupac);
            this.Name = "AdminForm";
            this.Text = "Administracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKupac;
        private System.Windows.Forms.Button BtnAutomobil;
        private System.Windows.Forms.Button BtnPonuda;
        private System.Windows.Forms.Button BtnRezervacija;
        private System.Windows.Forms.Button BtnStatistika;
        private System.Windows.Forms.Label label1;
    }
}