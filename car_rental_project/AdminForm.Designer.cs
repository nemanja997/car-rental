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
            this.SuspendLayout();
            // 
            // BtnKupac
            // 
            this.BtnKupac.Location = new System.Drawing.Point(26, 29);
            this.BtnKupac.Name = "BtnKupac";
            this.BtnKupac.Size = new System.Drawing.Size(255, 69);
            this.BtnKupac.TabIndex = 0;
            this.BtnKupac.Text = "Kupac";
            this.BtnKupac.UseVisualStyleBackColor = true;
            this.BtnKupac.Click += new System.EventHandler(this.BtnKupac_Click);
            // 
            // BtnAutomobil
            // 
            this.BtnAutomobil.Location = new System.Drawing.Point(297, 29);
            this.BtnAutomobil.Name = "BtnAutomobil";
            this.BtnAutomobil.Size = new System.Drawing.Size(255, 69);
            this.BtnAutomobil.TabIndex = 0;
            this.BtnAutomobil.Text = "Automobil";
            this.BtnAutomobil.UseVisualStyleBackColor = true;
            this.BtnAutomobil.Click += new System.EventHandler(this.BtnAutomobil_Click);
            // 
            // BtnPonuda
            // 
            this.BtnPonuda.Location = new System.Drawing.Point(297, 113);
            this.BtnPonuda.Name = "BtnPonuda";
            this.BtnPonuda.Size = new System.Drawing.Size(255, 69);
            this.BtnPonuda.TabIndex = 0;
            this.BtnPonuda.Text = "Ponuda";
            this.BtnPonuda.UseVisualStyleBackColor = true;
            // 
            // BtnRezervacija
            // 
            this.BtnRezervacija.Location = new System.Drawing.Point(26, 113);
            this.BtnRezervacija.Name = "BtnRezervacija";
            this.BtnRezervacija.Size = new System.Drawing.Size(255, 69);
            this.BtnRezervacija.TabIndex = 0;
            this.BtnRezervacija.Text = "Rezervacije";
            this.BtnRezervacija.UseVisualStyleBackColor = true;
            // 
            // BtnStatistika
            // 
            this.BtnStatistika.Location = new System.Drawing.Point(162, 199);
            this.BtnStatistika.Name = "BtnStatistika";
            this.BtnStatistika.Size = new System.Drawing.Size(255, 69);
            this.BtnStatistika.TabIndex = 0;
            this.BtnStatistika.Text = "Statistika";
            this.BtnStatistika.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnStatistika);
            this.Controls.Add(this.BtnRezervacija);
            this.Controls.Add(this.BtnPonuda);
            this.Controls.Add(this.BtnAutomobil);
            this.Controls.Add(this.BtnKupac);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKupac;
        private System.Windows.Forms.Button BtnAutomobil;
        private System.Windows.Forms.Button BtnPonuda;
        private System.Windows.Forms.Button BtnRezervacija;
        private System.Windows.Forms.Button BtnStatistika;
    }
}