using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MosanedElmo3lem.UI
{
    public partial class addLessonse : Form
    {
        string FileName = "";
        public addLessonse()
        {
            InitializeComponent();
        }

        private void addLessonse_Load(object sender, EventArgs e)
        {
            DirectoryInfo[] Dirs = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"\Data").GetDirectories();
            foreach (DirectoryInfo item in Dirs)
            {
                this.comboBox1.Items.Add(item.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox2.SelectedIndex = -1;
            this.comboBox2.Items.Clear();
            if (this.comboBox1.SelectedIndex == -1)
                return;
            DirectoryInfo[] Dirs = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"\Data\"+this.comboBox1.SelectedItem.ToString()).GetDirectories();
            foreach (DirectoryInfo item in Dirs)
            {
                this.comboBox2.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opf = new OpenFileDialog();
            Opf.Title = "اختر الدرس";
            Opf.SupportMultiDottedExtensions = true;
            Opf.Filter = "PowerPoint|*.pptx|Word|*.docx|Pdf|*.pdf";
            if (Opf.ShowDialog() == DialogResult.OK)
            {
                FileInfo F = new FileInfo(Opf.FileName);
                int PointOfDot = F.Name.LastIndexOf('.');
                StringBuilder Sb = new StringBuilder();
                for (int i = 0; i < PointOfDot; i++)
                {
                    Sb.Append(F.Name[i]);
                }
                label4.Text = Sb.ToString();
                FileName = Opf.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.FileName) || comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
                return;
            string NewPath = AppDomain.CurrentDomain.BaseDirectory + @"\Data\"
                + comboBox1.SelectedItem.ToString() + @"\"
                + comboBox2.SelectedItem.ToString() + @"\"
                + new FileInfo(this.FileName).Name;
            if (File.Exists(NewPath))
            {
                MessageBox.Show("هناك ملف بنفس الاسم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            File.Copy(this.FileName, NewPath);
            MessageBox.Show("تم إضافة الدرس بنجاح", "اضافة درس", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            this.Close();
        }
    }
}
