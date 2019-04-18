using car_rental_project.RadSaFajlovima;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental_project
{
    public partial class LoginForm : Form
    {
        Korisnik k;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!TBoxKorisnickoIme.Text.Trim().Equals("") && !TBoxLozinka.Text.Trim().Equals(""))
            {
                k = KorisnikRepository.pronadjiKorisnika(TBoxKorisnickoIme.Text, TBoxLozinka.Text);

                if (k != null)
                {
                    if (k is Kupac)
                    {
                        MessageBox.Show("Uspesno ste se ulogovali kao korisnik.");
                        Form kupacForm = new KupacForm();
                        kupacForm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Uspesno ste se ulogovali kao administrator.");
                        Form adminForm = new AdminForm();
                        adminForm.ShowDialog();
                    }
                }
                else
                {
                    TBoxKorisnickoIme.Text = "";
                    TBoxLozinka.Text = "";
                    MessageBox.Show("Ne postoji korisnik sa unetim kredencijalima. Molimo pokusajte ponovo.");
                }

            }else {
                MessageBox.Show("Morate uneti podatke.");
            }
            
        }
    }
}
