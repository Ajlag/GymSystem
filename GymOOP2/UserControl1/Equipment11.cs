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
    public partial class Equipment11 : UserControl
    {
        public Equipment11()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtEquipmentName.Text == "" || txtDescription.Text == "" ||  txtCost.Text == "" )
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }


            else
            {

                try
                {

                    Base.DodajOpremu(txtEquipmentName.Text, txtDescription.Text, txtCost.Text);
                    MessageBox.Show("Uspesno");


                }
                catch
                {
                    MessageBox.Show("Oprema vec postoji");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {


            txtEquipmentName.Clear();
            txtDescription.Clear();
            txtCost.Clear();
          

        }

        private void btnViewEq_Click(object sender, EventArgs e)
        {
            PregledOpreme ve = new PregledOpreme();
            ve.Show();
        }
    }
}
