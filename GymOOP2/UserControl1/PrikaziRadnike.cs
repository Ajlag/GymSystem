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
    public partial class PrikaziRadnike : UserControl
    {
        TeretanaEntities vezasabazom;
        public PrikaziRadnike()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            vezasabazom = new TeretanaEntities();
            prikazRadnika();

            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
        }

        private void prikazRadnika()
        {
            dataGridView1.DataSource = Base.PrikaziSveRadnike();
        }
    }
}
