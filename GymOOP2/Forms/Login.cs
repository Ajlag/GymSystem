using GymOOP2.Forms;
using GymOOP2.Klase;
using GymOOP2.UserControl1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymOOP2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      
       

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show();
        }

      
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
           
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UlazClanova m = new UlazClanova();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            korisnik k = new korisnik();
            k.KorisnickoIme = textBox1.Text;
            k.Lozinka = textBox2.Text;
            DataTable dt = Base.UlogujKorisnika(k);
            string allowedchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Morate popuniti sva polja");
                }
                else if (!textBox2.Text.All(allowedchar.Contains))
                {
                    MessageBox.Show("Proverite lozinku");
                }
                else
                {

                    if (dt.Rows.Count == 1)

                    {
                        if (dt.Rows[0][5].ToString() == "NE")
                        {
                            MessageBox.Show("Vasa registracija jos uvek nije potvrdjena!");
                        }
                        else
                        {

                            if (dt.Rows[0][4].ToString() == "T")
                            {
                                this.Hide();
                                Trener1 f = new Trener1(dt.Rows[0][1].ToString());
                                f.Show();
                            }
                            else if (dt.Rows[0][4].ToString() == "R")
                            {
                                this.Hide();
                                Main1 f = new Main1(dt.Rows[0][1].ToString());
                                f.Show();

                            }
                            else if (dt.Rows[0][4].ToString() == "A")
                            {
                                this.Hide();
                                AdminForma f = new AdminForma();
                                f.Show();

                            }
                            else {
                                MessageBox.Show("Greska");
                            }
                        }
                          
                    }
                    else
                    {
                        MessageBox.Show("Neispravno ste uneli lozinku.");
                    }




                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

     
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registracija m = new Registracija();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginClan m = new LoginClan();
            m.Show();
        }

        
    }
}
