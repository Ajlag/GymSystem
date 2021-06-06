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
    public partial class LoginClan : Form
    {
        public LoginClan()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clan k = new clan();
            k.JMBG = textBox1.Text;
            Prisustvo p = new Prisustvo();
            DataTable dt = Base.UlazClanova(k);

            string allowedchar = "0123456789";
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Morate uneti ID");
                }
                else if (!textBox1.Text.All(allowedchar.Contains))
                {
                    MessageBox.Show("Proverite ID");
                }
                else
                {
                    if (dt.Rows.Count == 1)

                    {
                        UlazKartice m = new UlazKartice(textBox1.Text);
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("Proverite ID.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
