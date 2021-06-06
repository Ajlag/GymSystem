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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
            else
            {
                string tip;
                if (comboBox1.Text == "Radnik")
                {
                    tip = "R";
                }
                else {
                    tip = "T";
                }
               
                  try
                {

                    korisnik k = new korisnik();
                    k.KorisnickoIme = textBox1.Text;
                    k.Lozinka = textBox2.Text;
                    DataTable dt = Base.UlogujKorisnika(k);
                    if (dt.Rows.Count == 0)
                    {

                        Base.DodajKorisnika(textBox3.Text, textBox1.Text, textBox2.Text, tip);
                        MessageBox.Show("Uspešno");
                    }
                    else {
                        MessageBox.Show("Korisnik sa ovim korisnickim imenom je vec registrovan u sistem.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}
