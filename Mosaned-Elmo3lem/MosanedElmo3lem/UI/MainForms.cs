using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MosanedElmo3lem.UI
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StudentsSchudle sc = new StudentsSchudle();
            sc.ShowDialog();
            sc = null;
        }

        private void MainForms_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PrepationViewer p = new PrepationViewer();
            p.ShowDialog();
            p = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sectionViewr sc = new sectionViewr();
            sc.ShowDialog();
            sc = null;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            PictureBox controleHandel = ((PictureBox)sender);
            switch (controleHandel.Name)
            {
                case "place1":
                    controleHandel.Image = Properties.Resources._6;
                    break;
                case "place2":
                    controleHandel.Image = Properties.Resources._5;
                    break;
                case "place3":
                    controleHandel.Image = Properties.Resources._4;
                    break;
                default:
                    break;
            }
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            PictureBox controleHandel = ((PictureBox)sender);
            switch (controleHandel.Name)
            {
                case "place1":
                    controleHandel.Image = Properties.Resources._1;
                    break;
                case "place2":
                    controleHandel.Image = Properties.Resources._8;
                    break;
                case "place3":
                    controleHandel.Image = Properties.Resources._7;
                    break;
                default:
                    break;
            }
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox controleHandel = ((PictureBox)sender);
            switch (controleHandel.Name)
            {
                case "place1":
                    controleHandel.Image = Properties.Resources._3;
                    break;
                case "place2":
                    controleHandel.Image = Properties.Resources._2;
                    break;
                case "place3":
                    controleHandel.Image = Properties.Resources._9;
                    break;
                default:
                    break;
            }
        }
    }
}
