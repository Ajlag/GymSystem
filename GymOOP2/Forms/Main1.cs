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
    public partial class Main1 : Form
    {
        public Main1()
        {
            InitializeComponent();
            customizeDesign();
        }

        String ImePrezime;
        public Main1(String ime)
        {
            InitializeComponent();
            ImePrezime = ime;
            label2.Text = ime;
        }
        private void customizeDesign() {
            panel2.Visible = false;

        }
        private void hideSubMenu() {
            if (panel2.Visible == true)
                panel2.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }
        private void btn_newMember_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Equipment11 p = new Equipment11();
            p.Dock = DockStyle.Fill;
            panelCentar.Controls.Clear();
            panelCentar.Controls.Add(p);
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Aplikacija se zatvara");
            this.Close();
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
            SearchMember p = new SearchMember();
            p.Dock = DockStyle.Fill;
            panelCentar.Controls.Clear();
            panelCentar.Controls.Add(p);

        }

    

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Cenovnik p = new Cenovnik();
            p.Dock = DockStyle.Fill;
            panelCentar.Controls.Clear();
            panelCentar.Controls.Add(p);


        }
       

        private void iconButton6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Clanovi p = new Clanovi();
            p.Dock = DockStyle.Fill;
            panelCentar.Controls.Clear();
            panelCentar.Controls.Add(p);
        }

      

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            SearchMember p = new SearchMember();
            p.Dock = DockStyle.Fill;
            panelCentar.Controls.Clear();
            panelCentar.Controls.Add(p);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            MesecneClanarine p = new MesecneClanarine();
            p.Dock = DockStyle.Fill;
            panelCentar.Controls.Clear();
            panelCentar.Controls.Add(p);
        }

       
        private void iconButton7_Click_1(object sender, EventArgs e)
        {
            PrisustvoClanova p = new PrisustvoClanova();
            p.Dock = DockStyle.Fill;
            panelCentar.Controls.Clear();
            panelCentar.Controls.Add(p);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            DnevnaClanarina p = new DnevnaClanarina();
            p.Dock = DockStyle.Fill;
            panelCentar.Controls.Clear();
            panelCentar.Controls.Add(p);
        }
    }
}
