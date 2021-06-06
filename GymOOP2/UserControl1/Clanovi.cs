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
    public partial class Clanovi : UserControl
    {
        TeretanaEntities vezasaBazom;
        public Clanovi()
        {
           
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            vezasaBazom = new TeretanaEntities();
            popuniTabelu();
            this.listBox1.Columns[13].Visible = false;
            this.listBox1.Columns[14].Visible = false;

        }
        private void popuniTabelu()
        {
            listBox1.DataSource = Base.PrikaziSveClanove();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtJMBG.Text = "";
            txtAdresa.Text = "";
            txtBrojTelefona.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtEmail.Text="";
            cBClanarina.ResetText();
            dTPDatumUpisa.Value = DateTime.Now;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            if (txtIme.Text == "" || txtPrezime.Text == "" || txtBrojTelefona.Text == "" || txtAdresa.Text == "" || txtEmail.Text == "" || txtJMBG.Text == "" ||  cBClanarina.Text=="")
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
            else
            {
                string res = "";
                if (rbMale.Checked)
                    res = "M";
                else
                    res = "Ž";

                string dodTrenera = "";
                if (rbDATrener.Checked)
                    dodTrenera = "DA";
                else
                    dodTrenera = "NE";


                string IndGrup = "";
                if (daGrupa.Checked)
                    IndGrup = "DA";
                else
                    IndGrup = "NE";

                try
                {
                  
                    var datumUpisa = dTPDatumUpisa.Value.ToString("dd/MM/yyyy");
                    //var uplataClanarine = DateTime.Now.ToString("dd/MM/yyyy");
                    Base.DodajClana(txtIme.Text, txtPrezime.Text, txtBrojTelefona.Text, txtAdresa.Text, txtEmail.Text, txtJMBG.Text, res, dTPDatumUpisa.Value, DateTime.Now, dodTrenera, cBClanarina.Text,IndGrup);
                    MessageBox.Show("Uspešno");

                }
                catch
                {
                    MessageBox.Show("Član već postoji!");
                }

            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
           
            clan o = new clan();
            DataTable dt = Base.radniciBox(o);
            if (dt.Rows.Count > 0)
            {
                txtIme.Text = dt.Rows[0][0].ToString();
                txtPrezime.Text = dt.Rows[0][1].ToString();
                txtBrojTelefona.Text = dt.Rows[0][2].ToString();
                txtAdresa.Text = dt.Rows[0][3].ToString();
                txtEmail.Text = dt.Rows[0][4].ToString();
                txtJMBG.Text = dt.Rows[0][6].ToString();

              

            }
            else
            {
                MessageBox.Show("Proverite JMBG");
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {

            if (txtIme.Text == "" || txtPrezime.Text == "" || txtBrojTelefona.Text == "" || txtAdresa.Text == "" || txtEmail.Text == "" || txtJMBG.Text == "" || cBClanarina.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
            else
            {
                try
                {
                    Base.azuriranjeClanova(txtBrojTelefona.Text, txtAdresa.Text, txtEmail.Text, txtJMBG.Text, dTPDatumUpisa.Text, cBClanarina.Text);
                    MessageBox.Show("Uspešno");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            DialogResult Izlaz;
            Izlaz = MessageBox.Show("Da li želite da izbrišete člana?", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (txtIme.Text == "" || txtPrezime.Text == "" || txtJMBG.Text == "")
            {
                MessageBox.Show("Morate uneti ime , prezime i JMBG!");
            }
            else
            {
                if (Izlaz == DialogResult.Yes)
                {
                    try
                    {
                        Base.brisanjeClanova(txtJMBG.Text, txtIme.Text, txtPrezime.Text);
                        MessageBox.Show("Uspešno");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

      

        private void listBox1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (listBox1.SelectedRows.Count>0)
            {
                

                string ime = listBox1.SelectedRows[0].Cells[0].Value + string.Empty;
                string prezime = listBox1.SelectedRows[0].Cells[1].Value + string.Empty;
                string brojTelefona = listBox1.SelectedRows[0].Cells[2].Value + string.Empty;
                string adresa = listBox1.SelectedRows[0].Cells[3].Value + string.Empty;
                string email = listBox1.SelectedRows[0].Cells[4].Value + string.Empty;
                string pol = listBox1.SelectedRows[0].Cells[5].Value + string.Empty;
                string jmbg = listBox1.SelectedRows[0].Cells[6].Value + string.Empty;
                string clanarina = listBox1.SelectedRows[0].Cells[10].Value + string.Empty;

                string datumUpisa = listBox1.SelectedRows[0].Cells[7].Value + string.Empty;


                txtIme.Text = ime;
                txtPrezime.Text = prezime;
                txtBrojTelefona.Text = brojTelefona;
                txtAdresa.Text = adresa;
                txtEmail.Text = email;
                txtJMBG.Text = jmbg;
                cBClanarina.Text = clanarina;
                dTPDatumUpisa.Text = datumUpisa;
            }
        }

        private void listBox1_SelectionChanged(object sender, EventArgs e)
        {
            (sender as DataGridView).CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Peru;

        }
    }
}
