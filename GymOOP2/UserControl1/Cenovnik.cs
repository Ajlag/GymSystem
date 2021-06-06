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
    public partial class Cenovnik : UserControl
    {
        TeretanaEntities vezasaBazom;
        string vr_old = DateTime.Now.ToString("MM/dd/yyyy");
        public Cenovnik()
        {
            InitializeComponent();
            vezasaBazom = new TeretanaEntities();
            var sve = vezasaBazom.cenovniks.ToList();
            var napisi = sve.ElementAt(0).poslednjePromene;
            textBox5.Text = napisi;
            PrikaziCene();
        }

        private void PrikaziCene() 
        {
           DataTable dt = Base.selectCene();
            if (dt.Rows.Count > 0)
            {
                textBox1.Text = dt.Rows[0][0].ToString();
                textBox2.Text = dt.Rows[1][0].ToString();
                textBox3.Text = dt.Rows[2][0].ToString();
                textBox4.Text = dt.Rows[3][0].ToString();
            }
            else
            {
                MessageBox.Show("Proverite");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String vr_new = DateTime.Now.ToString("MM/dd/yyyy");
                vr_old = vr_new;
                Base.Promenicene(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), vr_new);
                MessageBox.Show("Uspesno");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
