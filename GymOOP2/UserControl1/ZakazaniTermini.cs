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
    public partial class ZakazaniTermini : UserControl
    {
        TeretanaEntities vezasaBazom;
        public ZakazaniTermini()
        {
            InitializeComponent();
            vezasaBazom = new TeretanaEntities();
            ZakazaniTerminiPrikaz();
            this.Dock = DockStyle.Fill;
           // this.dataGridView2.Columns[5].Visible = false;

        }
        public ZakazaniTermini(String IDClana)
        {
            InitializeComponent();
            this.label2.Text = IDClana;
            vezasaBazom = new TeretanaEntities();
            ZakazaniTerminiPrikaz();
            this.Dock = DockStyle.Fill;
        }

        private void ZakazaniTerminiPrikaz()
        {
            try
            {
                dataGridView1.DataSource = Base.PrikazClana(label2.Text);
                dataGridView2.DataSource = Base.PrikazTermina(label2.Text);
                this.dataGridView2.Columns[5].Visible = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }
        }

       
    }
}
