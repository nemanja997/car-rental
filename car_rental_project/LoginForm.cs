
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
        Korisnik korisnik;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if ( TBoxKorisnickoIme.Text.Trim().Length !=0 && TBoxLozinka.Text.Trim().Length !=0 )
            {
                korisnik = Korisnik.pronadjiKorisnika(TBoxKorisnickoIme.Text, TBoxLozinka.Text);

                if ( korisnik != null )
                {
                    if (korisnik is Kupac)
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
