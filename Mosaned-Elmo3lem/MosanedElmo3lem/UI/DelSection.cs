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
    public partial class DelSection : Form
    {
        public DelSection()
        {
            InitializeComponent();
        }

        private void DelSection_Load(object sender, EventArgs e)
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
            DirectoryInfo[] Dirs = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"\Data\" + this.comboBox1.SelectedItem.ToString()).GetDirectories();
            foreach (DirectoryInfo item in Dirs)
            {
                this.comboBox2.Items.Add(item.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == false || this.comboBox1.SelectedIndex == -1)
                return;
            string DelerDir = AppDomain.CurrentDomain.BaseDirectory + @"\Data\" + comboBox1.SelectedItem.ToString();
            if (comboBox2.SelectedIndex != -1)
                DelerDir += @"\" + comboBox2.SelectedItem.ToString();
            Directory.Delete(DelerDir, true);
            MessageBox.Show("تم حذف التصنيف بنجاح", "حذف تصنيف", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            this.Close();
        }

    }
}
