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
    public partial class SearchMember : UserControl
    {
        TeretanaEntities vezasaBazom;
        public SearchMember()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            vezasaBazom = new TeretanaEntities();
            prikaziClanove();
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtSearch.Text == "")
                {
                    MessageBox.Show("Unesite ime i prezime za pretragu");

                }
                else
                {
                    string pretraga = txtSearch.Text;
                    listBox1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    foreach (DataGridViewRow row in listBox1.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Equals(pretraga)  ||  row.Cells[0].Value.ToString().Equals(pretraga) || row.Cells[6].Value.ToString().Equals(pretraga))
                        {

                            row.Selected = true;
                            break;

                          

                        }

                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void prikaziClanove()
        {
            var clanovi = new List<string>();
            listBox1.DataSource = Base.PrikaziSveClanove();
         
        }

        private void listBox1_SelectionChanged(object sender, EventArgs e)
        {
            (sender as DataGridView).CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Gold;
        }
    }
}
