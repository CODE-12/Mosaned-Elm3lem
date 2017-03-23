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
    }
}
