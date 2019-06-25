namespace car_rental_project
{
    partial class LoginForm
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
            this.TBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.TBoxLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBoxKorisnickoIme
            // 
            this.TBoxKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxKorisnickoIme.Location = new System.Drawing.Point(59, 120);
            this.TBoxKorisnickoIme.Name = "TBoxKorisnickoIme";
            this.TBoxKorisnickoIme.Size = new System.Drawing.Size(336, 26);
            this.TBoxKorisnickoIme.TabIndex = 0;
            this.TBoxKorisnickoIme.TextChanged += new System.EventHandler(this.TBoxKorisnickoIme_TextChanged);
            // 
            // TBoxLozinka
            // 
            this.TBoxLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxLozinka.Location = new System.Drawing.Point(59, 189);
            this.TBoxLozinka.Name = "TBoxLozinka";
            this.TBoxLozinka.Size = new System.Drawing.Size(336, 26);
            this.TBoxLozinka.TabIndex = 1;
            this.TBoxLozinka.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ulogujte se";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Korisnicko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lozinka:";
            // 
            // Button_login
            // 
            this.Button_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_login.Location = new System.Drawing.Point(59, 238);
            this.Button_login.Margin = new System.Windows.Forms.Padding(0);
            this.Button_login.Name = "Button_login";
            this.Button_login.Size = new System.Drawing.Size(336, 53);
            this.Button_login.TabIndex = 5;
            this.Button_login.Text = "Nastavi";
            this.Button_login.UseVisualStyleBackColor = false;
            this.Button_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 353);
            this.Controls.Add(this.Button_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBoxLozinka);
            this.Controls.Add(this.TBoxKorisnickoIme);
            this.Name = "LoginForm";
            this.Text = "Logovanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBoxKorisnickoIme;
        private System.Windows.Forms.TextBox TBoxLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_login;
    }
}

