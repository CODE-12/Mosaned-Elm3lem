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
    public partial class EditClass : Form
    {
        public EditClass()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 2)
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || listBox1.Items.Contains(textBox1.Text)) 
                return;
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = string.Empty;
        }
    }
}
