namespace car_rental_project
{
    partial class KupacForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
            this.btnNapraviRezervaciju = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBRezervacije
            // 
            this.LBRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBRezervacije.FormattingEnabled = true;
            this.LBRezervacije.ItemHeight = 20;
            this.LBRezervacije.Location = new System.Drawing.Point(12, 49);
            this.LBRezervacije.Name = "LBRezervacije";
            this.LBRezervacije.Size = new System.Drawing.Size(668, 164);
            this.LBRezervacije.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezervacije:";
            // 
            // btnObrisiRezervaciju
            // 
            this.btnObrisiRezervaciju.BackColor = System.Drawing.Color.LightCoral;
            this.btnObrisiRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiRezervaciju.Location = new System.Drawing.Point(12, 243);
            this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
            this.btnObrisiRezervaciju.Size = new System.Drawing.Size(326, 82);
            this.btnObrisiRezervaciju.TabIndex = 2;
            this.btnObrisiRezervaciju.Text = "Ukini rezervaciju";
            this.btnObrisiRezervaciju.UseVisualStyleBackColor = false;
            this.btnObrisiRezervaciju.Click += new System.EventHandler(this.btnObrisiRezervaciju_Click);
            // 
            // btnNapraviRezervaciju
            // 
            this.btnNapraviRezervaciju.BackColor = System.Drawing.Color.LightBlue;
            this.btnNapraviRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapraviRezervaciju.Location = new System.Drawing.Point(354, 243);
            this.btnNapraviRezervaciju.Name = "btnNapraviRezervaciju";
            this.btnNapraviRezervaciju.Size = new System.Drawing.Size(326, 82);
            this.btnNapraviRezervaciju.TabIndex = 2;
            this.btnNapraviRezervaciju.Text = "Napravi novu rezervaciju";
            this.btnNapraviRezervaciju.UseVisualStyleBackColor = false;
            this.btnNapraviRezervaciju.Click += new System.EventHandler(this.btnNapraviRezervaciju_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // KupacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNapraviRezervaciju);
            this.Controls.Add(this.btnObrisiRezervaciju);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBRezervacije);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KupacForm";
            this.Text = "KupacForm";
            this.Load += new System.EventHandler(this.KupacForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiRezervaciju;
        private System.Windows.Forms.Button btnNapraviRezervaciju;
        private System.Windows.Forms.Label label2;
    }
}