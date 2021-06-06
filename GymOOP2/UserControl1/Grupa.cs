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
using GymOOP2.Forms;

namespace GymOOP2.UserControl1
{
    public partial class Grupa : UserControl
    {
        public Grupa()
        {
            InitializeComponent();
            prikaziImena();
            //prikaziImenaTrenera();
           
        }

        public Grupa(String trener)
        {
            InitializeComponent();
            prikaziImena();
            ////prikaziImenaTrenera();
            this.label1.Text = trener;

        }

        private void prikaziImena() {
            var clanovi = new List<string>();
            comboBox1.DataSource = Base.prikaziImezaGrupu();
        }


        //private void prikaziImenaTrenera()
        //{
        //    var treneri = new List<string>();
        //   comboBox2.DataSource = Base.ImenaTrenera();
        //}
    private void button3_Click(object sender, EventArgs e)
        {        

            if (comboBox1.Text == "" || label1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
            else
            {
                try
                {


                    if (dateTimePicker1.Value < DateTime.Now)
                    {
                        MessageBox.Show("Izaberite neki drugi datum");
                    }
                    else
                    {
                        Base.ZakaziTermin(label5.Text, label1.Text, dateTimePicker1.Value, textBox1.Text);
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

        private void Grupa_Load(object sender, EventArgs e)
        {

        //    string imeC = "";
        //    string prezimeC = "";
        //    var unetoC = "";
        //    var unesenoC = comboBox1.Text;



        //    try
        //    {
        //        string[] unosiC = unesenoC.Split(' ');

        //        imeC = unosiC[0];
        //        prezimeC = unosiC[1];
        //    }
        //    catch
        //    {
        //        unetoC = comboBox1.Text;

        //    }

        //    var clanovi = new List<string>();
        //    label5.Text= clanovi.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clanime = comboBox1.SelectedItem as string;
            string[] unosiC = clanime.Split(' ');

            var imeC = unosiC[0];
            var prezimeC = unosiC[1];
            label5.Text = Base.PrikazIDC(imeC, prezimeC);
        }

       
    }
}
