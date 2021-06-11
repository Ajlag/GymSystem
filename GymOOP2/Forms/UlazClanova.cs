using GymOOP2.Forms;
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
    public partial class UlazClanova : Form
    {
        Boolean ulaz=false, izlaz=false;

        public UlazClanova()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {       
            clan k = new clan();
            k.JMBG = textBox1.Text;
            Prisustvo p = new Prisustvo();
            p.IDClana = textBox1.Text;

            DataTable dt = Base.UlazClanova(k);
            DataTable dtp = Base.SelectPrisustvo(p);
           // System.Threading.Thread.Sleep(1000);
            string allowedchar = "0123456789";
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Morate uneti ID");
                }
                else if (!textBox1.Text.All(allowedchar.Contains))
                {
                    MessageBox.Show("Proverite ID");
                }
                else
                {
                    if (dt.Rows.Count == 1)


                    {
                        var UplataClanarine = Base.PrikaziClanarinu(textBox1.Text).ToString();
                        DateTime uplataClanarine = Base.PrikaziClanarinu(textBox1.Text);
                        DateTime istek;
                        if (Base.SelektujClanarinu(textBox1.Text) == "Mesecna ")
                        {

                            int istekMClanarine = uplataClanarine.Month + 1;
                            string mesec = istekMClanarine.ToString() + "/" + uplataClanarine.Day + "/" + uplataClanarine.Year;
                            istek = DateTime.Parse(mesec.ToString());
                            if (istek < DateTime.Now)
                            {
                                label1.ForeColor = Color.Red;
                                label1.Text = "Produži" + "\n" + " članarinu";
                            }
                            else
                            {
                                if (dtp.Rows.Count > 0)
                                {
                                    if (Base.UlaziliIzlaz(textBox1.Text) == "ULAZ")
                                    {

                                        Base.DodajPrisustvo(textBox1.Text, DateTime.Now, "IZLAZ");
                                        label1.ForeColor = Color.Black;
                                        label1.Text = "Izlaz";
                                        return;
                                    }
                                    else
                                    {

                                        Base.DodajPrisustvo(textBox1.Text, DateTime.Now, "ULAZ");
                                        label1.ForeColor = Color.Green;
                                        label1.Text = "Ulaz";
                                        return;

                                    }
                                }
                                else
                                {
                                    Base.DodajPrisustvo(textBox1.Text, DateTime.Now, "ULAZ");
                                    label1.ForeColor = Color.Green;
                                    label1.Text = "Ulaz";

                                }
                            }
                        }

                        else if (Base.SelektujClanarinu(textBox1.Text) == "Dnevna")
                        {
                            int istekD ;
                            int istekM = uplataClanarine.Month;
                            if (uplataClanarine.Day+1 >= 31)
                            {
                                istekD = 1;
                                istekM = istekM + 1;
                            }
                            else {
                                istekD = uplataClanarine.Day+1;
                            }
                            string dan = istekM.ToString() + "/" + istekD.ToString() + "/" + uplataClanarine.Year;
                            istek = DateTime.Parse(dan.ToString());
                            
                            if (istek < DateTime.Now)
                            {
                                label1.ForeColor = Color.Red;
                                label1.Text = "Niste " + "\n" + "uplatili";
                            }
                            else
                            {

                                if (dtp.Rows.Count > 0)
                                {
                                    if (Base.UlaziliIzlaz(textBox1.Text) == "ULAZ")
                                    {

                                        Base.DodajPrisustvo(textBox1.Text, DateTime.Now, "IZLAZ");
                                        label1.ForeColor = Color.Black;
                                        label1.Text = "Izlaz";
                                        return;
                                    }
                                    else
                                    {

                                        Base.DodajPrisustvo(textBox1.Text, DateTime.Now, "ULAZ");
                                        label1.ForeColor = Color.Green;
                                        label1.Text = "Ulaz";
                                        return;

                                    }
                                }
                                else
                                {
                                    Base.DodajPrisustvo(textBox1.Text, DateTime.Now, "ULAZ");
                                    label1.ForeColor = Color.Green;
                                    label1.Text = "Ulaz";

                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Proverite ID.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
