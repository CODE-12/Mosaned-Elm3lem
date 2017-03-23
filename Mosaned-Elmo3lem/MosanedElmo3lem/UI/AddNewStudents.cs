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
    public partial class AddNewStudents : Form
    {
        public AddNewStudents()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                if(!(e.KeyChar == '\b'))
                    e.Handled= true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || textBox1.Text.Trim().Length != 5)
                return;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[0].Value.ToString() == textBox1.Text || item.Cells[1].Value.ToString() == textBox2.Text)
                    return;
            }
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opf = new OpenFileDialog();
            Opf.Title = "إستيراد ملف أكسل";
            Opf.Filter = "ملفات إكسل|*.xlsx;*.xls";
            if (Opf.ShowDialog() != DialogResult.OK)
                return;
            GetFromExcel GFE = new GetFromExcel(Opf.FileName);
            GFE.button1.Click += (sen, eve) =>
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < GFE.dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(GFE.dataGridView1.Rows[i].Cells[0].Value, GFE.dataGridView1.Rows[i].Cells[1].Value);
                }
                GFE.Close();
                GFE.Dispose();
            };
            GFE.ShowDialog();
        }
        
    }
}
