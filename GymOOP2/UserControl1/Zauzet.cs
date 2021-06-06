using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymOOP2.Klase;

namespace GymOOP2.UserControl1
{
    public partial class Zauzet : UserControl
    {
        public Zauzet()
        {
            InitializeComponent();
        }
        public Zauzet(String IDClana)
        {
            InitializeComponent();
            this.label3.Text = IDClana;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
  try
            {
                if (radioButton1.Checked)
                {
                    Base.PromenaZauzetNE(label3.Text);
                    MessageBox.Show("Vise niste zauzeti");
                }
                else if (radioButton2.Checked)
                {
                    Base.PromenaZauzet(label3.Text);
                    MessageBox.Show("Jos uvek ste zauzeti");
                }
                else
                {
                    MessageBox.Show("Morate izabrati jedno od ponudjenih!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Zauzet_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }
    }
}
