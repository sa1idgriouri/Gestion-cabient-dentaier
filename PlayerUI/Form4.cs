using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
           

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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            showSubMenu(panel4);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            showSubMenu(panel5);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            showSubMenu(panel6);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            showSubMenu(panel7);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            showSubMenu(panel8);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ajouterPatient1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listPatient1.BringToFront();
        }

        private void listPatient1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ajouterRDV1.BringToFront();
        }
    }
}
