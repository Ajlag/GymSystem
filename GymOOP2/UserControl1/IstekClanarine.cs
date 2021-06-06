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
    public partial class IstekClanarine : UserControl
    {
        public IstekClanarine()
        {
            InitializeComponent();
        }
        public IstekClanarine(String clan)
        {
            InitializeComponent();
            this.label1.Text = clan;

        }

        private void IstekClanarine_Load(object sender, EventArgs e)
        {
          label1.Hide();
            var UplataClanarine = Base.PrikaziClanarinu(label1.Text).ToString();
            label4.Text = UplataClanarine;
            DateTime uplataClanarine = Base.PrikaziClanarinu(label1.Text);
            if (Base.SelektujClanarinu(label1.Text) == "Mesecna ")
            {

                int istekMClanarine = uplataClanarine.Month + 1;
                label5.Text = istekMClanarine.ToString() + "/" + uplataClanarine.Day + "/" + uplataClanarine.Year;
            }
            else if (Base.SelektujClanarinu(label1.Text) == "Dnevna")
            {
                int istekD = uplataClanarine.Day + 1;
                label5.Text = uplataClanarine.Month + "/" + istekD.ToString() + "/" + uplataClanarine.Year;
            }
            else
            {
                MessageBox.Show("Greska!");
            }
        }

      
    }
}
