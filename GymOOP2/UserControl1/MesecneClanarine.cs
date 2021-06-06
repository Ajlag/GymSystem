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

namespace GymOOP2
{
    public partial class MesecneClanarine : UserControl
    {
        public MesecneClanarine()
        {
            InitializeComponent();
            prikaziImena();
        }
        private void prikaziImena()
        {
            var clanovi = new List<string>();
            comboBox1.DataSource = Base.imezaMesecnu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="" || label1.Text=="")
            {
                MessageBox.Show("Nema člana sa mesečnom članarinom!");
            }
            else
            {
                try
                {
                    Base.produziClanarinu(DateTime.Now, label1.Text);
                    MessageBox.Show("Uspešno");
                }
                catch
                {
                    MessageBox.Show("Trenutno je doslo do greske ne mozete produziti clanarinu");
                }
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clanime = comboBox1.SelectedItem as string;
            string[] unosiC = clanime.Split(' ');

            var imeC = unosiC[0];
            var prezimeC = unosiC[1];
            label1.Text = Base.PrikazIDC(imeC, prezimeC);
        }
    }
} 
