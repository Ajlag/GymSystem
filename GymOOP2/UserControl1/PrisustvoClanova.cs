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
    public partial class PrisustvoClanova : UserControl
    {
        TeretanaEntities vezasaBazom;
        public PrisustvoClanova()
        {
            InitializeComponent();
            vezasaBazom = new TeretanaEntities();
            prikaziPrisutneClanove();
            this.Dock = DockStyle.Fill;
            this.dataGridView1.Columns[4].Visible = false;
        }
        private void prikaziPrisutneClanove()
        {
            var prisustvo = Base.PrikazPrisustva();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = prisustvo;
         }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
          //dataGridView1.SelectedRows[0].Cells[4].Visible = false;
        }

      
    }
}
