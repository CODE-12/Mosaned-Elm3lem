using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MosanedElmo3lem.UI
{
    public partial class AddPrimary : Form
    {
        public AddPrimary()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPrimary_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("***بدون***");
            DirectoryInfo[] Dirs = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"\Data").GetDirectories();
            comboBox1.Items.AddRange(Dirs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || comboBox1.SelectedIndex == -1)
                    return;
                string father = comboBox1.SelectedItem.ToString() == "***بدون***" ? "" : comboBox1.SelectedItem.ToString() + @"\";
                string newDir = AppDomain.CurrentDomain.BaseDirectory + @"\Data\" + father + textBox1.Text;
                if (Directory.Exists(newDir))
                {
                    MessageBox.Show("هناك تصنيف بنفس الاسم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }
                Directory.CreateDirectory(newDir);
                MessageBox.Show("تم عمل التصنيف", "تم الانشاء بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                this.Close();
            }
            catch
            {
                MessageBox.Show("فشل عمل التصنيف", "فشل الانشاء", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }
    }
}
