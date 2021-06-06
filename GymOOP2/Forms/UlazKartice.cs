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
    public partial class UlazKartice : Form
    {
        public UlazKartice()
        {
            InitializeComponent();
        }

        public UlazKartice(String IDClana)
        {
            InitializeComponent();
            this.label2.Text = IDClana;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ZakazaniTermini p = new ZakazaniTermini(label2.Text);
            p.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(p);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            Zauzet p = new Zauzet(label2.Text);
            p.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(p);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            IstekClanarine p = new IstekClanarine(label2.Text);
            p.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(p);
        }

       
    }
}
