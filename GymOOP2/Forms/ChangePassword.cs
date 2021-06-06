using GymOOP2.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymOOP2.Forms
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
            textBox3.PasswordChar = checkBox1.Checked ? '\0' : '*';
            textBox4.PasswordChar= checkBox1.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Morate popuniti sva polja");
                }
                else
                {
                    korisnik k = new korisnik();
                    k.KorisnickoIme = textBox1.Text;
                    k.Lozinka = textBox2.Text;
                    string allowedchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    if (textBox4.Text.Equals(textBox3.Text))
                    {


                        if (!textBox4.Text.All(allowedchar.Contains))
                        {
                            MessageBox.Show("Proverite lozinku");
                        }

                        else if (Base.resetLozinku(k, textBox4.Text))
                        {

                            MessageBox.Show("Lozinka je uspešno promenjena");
                        }

                        else MessageBox.Show("Neuspešna promena lozinke");


                    }
                    else MessageBox.Show("Nepravilno potvrđena lozinka");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
