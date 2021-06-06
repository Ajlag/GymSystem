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
    public partial class PotvrdiRadnika : UserControl
    {
        public PotvrdiRadnika()
        {
            InitializeComponent();
            prikaziImena();
        }
        private void prikaziImena()
        {
            var clanovi = new List<string>();
            comboBox1.DataSource = Base.imeRadnikaZaPotvrdu();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var radnikIme = comboBox1.SelectedItem as string;
            label3.Text = Base.KorisnickoImeRadnika(radnikIme);

            if (Base.tipKorisnika(radnikIme) == "R") {
                label5.Text = "Radnik";
            }
            else {
                label5.Text = "Trener";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || label3.Text == "" || label5.Text=="")
            {
                MessageBox.Show("Nema korisnika kojima nije potvrdjena prijava!");
            }
            else
            {
                try
                {
                    Base.potvrdiKorisnika(label3.Text);
                    MessageBox.Show("Uspešno");
                }
                catch
                {
                    MessageBox.Show("Trenutno je doslo do greske ne mozete potvrditi korisnika");
                }
            }
        }
    }
}
