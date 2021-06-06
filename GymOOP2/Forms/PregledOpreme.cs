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

namespace GymOOP2
{
    public partial class PregledOpreme : Form
    {
        TeretanaEntities vezasaBazom;

        public PregledOpreme()
        {
            InitializeComponent();
            vezasaBazom = new TeretanaEntities();
            prikaziOpremu();
            this.Dock = DockStyle.Fill;
        }

        private void prikaziOpremu()
        {
            var oprema = Base.prikazOpreme();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = oprema;
        }
    }
}
