using GymOOP2.UserControl1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymOOP2.Forms
{
    public partial class AdminForma : Form
    {
        public AdminForma()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            PrikaziRadnike p = new PrikaziRadnike();
            p.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(p);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            PrikazTrenera p = new PrikazTrenera();
            p.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(p);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            PotvrdiRadnika p = new PotvrdiRadnika();
            p.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(p);
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            DialogResult Izlaz;
            Izlaz = MessageBox.Show("Da li zelite da se odjavite? ", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Izlaz == DialogResult.Yes)
            {
                this.Hide();
                Login log = new Login();
                log.ShowDialog();
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacija se zatvara");
            this.Close();
        }

       
    }
}
