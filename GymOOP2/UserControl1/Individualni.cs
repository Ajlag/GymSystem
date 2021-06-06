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
    public partial class Individualni : UserControl
    {
        public Individualni()
        {
            InitializeComponent();
            prikaziImena();
            //prikaziImenaTrenera();
        }

        public Individualni(String trener)
        {
            InitializeComponent();
            prikaziImena();
            //prikaziImenaTrenera();
            this.label6.Text = trener;

        }
        private void prikaziImena()
        {
            var clanovi = new List<string>();
            comboBox1.DataSource = Base.imezaIndividualni();
        }

        //private void prikaziImenaTrenera()
        //{
        //    var treneri = new List<string>();
        //    comboBox2.DataSource = Base.ImenaTrenera();
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clanime = comboBox1.SelectedItem as string;
            string[] unosiC = clanime.Split(' ');

            var imeC = unosiC[0];
            var prezimeC = unosiC[1];
            label5.Text = Base.PrikazIDC(imeC, prezimeC);
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text == "" || label5.Text == "" || textBox1.Text == "" || label6.Text=="")
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
            else
            {
                try
                {

                    var Datum = dateTimePicker1.Value.ToString("dd/MM/yyyy");

                    if (dateTimePicker1.Value < DateTime.Now)
                    {
                        MessageBox.Show("Izaberite neki drugi datum");
                    }
                    else
                    {
                        Base.ZakaziTermin(label5.Text, label6.Text, dateTimePicker1.Value, textBox1.Text);
                        Base.PromenaZauzet(label5.Text);
                        MessageBox.Show("Uspešno");
                    }
                }
                catch
                {
                    MessageBox.Show("Greska!Proverite da li je termin za zeljenog clana vec zakazan i proverite pofatke.");
                }

            }


        }

}
}
