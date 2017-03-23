using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MosanedElmo3lem.UI
{
    public partial class PrepationViewer : Form
    {

        private DataSet Pds = new DataSet("P_DS");

        public PrepationViewer()
        {
            InitializeComponent();
            UpdateWork();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                try
                {
                    item.Cells[2].Value = DateTime.Parse(item.Cells[2].Value.ToString()).ToString("d/M/yyyy");
                }
                catch
                { break; }
            }
        }

        private void UpdateWork()
        {
            Pds = new DataSet("P_DS");
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml"))
            {
                FileStream Fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml", FileMode.Create);
                Fs.Close();
                Fs.Dispose();
                Fs = null;
                Pds.WriteXml(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml");
            }
            Pds.ReadXml(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml");
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            if (Pds.Tables.Count == 0)
            {
                Pds.Tables.Add();
                Pds.Tables[0].Columns.Add("العنوان", typeof(string));
                Pds.Tables[0].Columns.Add("ملاحظات", typeof(string));
                Pds.Tables[0].Columns.Add("التاريخ", typeof(DateTime));
                Pds.WriteXml(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml");
            }
            if (Pds.Tables[0].Columns.Count != 3)
            {
                if (!Pds.Tables[0].Columns.Contains("العنوان"))
                    Pds.Tables[0].Columns.Add("العنوان", typeof(string));
                if (!Pds.Tables[0].Columns.Contains("ملاحظات"))
                    Pds.Tables[0].Columns.Add("ملاحظات", typeof(string));
                if (!Pds.Tables[0].Columns.Contains("التاريخ"))
                    Pds.Tables[0].Columns.Add("التاريخ", typeof(DateTime));
            }

            dataGridView1.DataSource = Pds.Tables[0];
            
        }

        private void PrepationViewer_Load(object sender, EventArgs e)
        {

        }

        private void حفظToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml"))
            {
                File.Create(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml");
                Pds.WriteXml(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml");
                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            Pds.WriteXml(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml");
            MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 2)
                MessageBox.Show("الرجاء إدخال التارخ بصورة مناسبة\nمثال:2/2/2015\nاستخدم نفي التارخ المعتمد فالجهاز هجري\\ميلادي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void PrepationViewer_Resize(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = Convert.ToInt32(this.Width * 0.40) - 10;

            dataGridView1.Columns[1].Width = Convert.ToInt32(this.Width * 0.40) - 10;

            dataGridView1.Columns[2].Width = Convert.ToInt32(this.Width * 0.20) - 10;
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (dataGridView1.Columns.Count == 3)
            {
                dataGridView1.Columns[0].Width = Convert.ToInt32(this.Width * 0.40) - 10;

                dataGridView1.Columns[1].Width = Convert.ToInt32(this.Width * 0.40) - 10;

                dataGridView1.Columns[2].Width = Convert.ToInt32(this.Width * 0.20) - 10;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
                if (MessageBox.Show("هل تريد حذف " + dataGridView1.SelectedRows.Count + " سطر", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(item);
                    }
        }

        private void نسخاحتياطيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml"))
            {
                FolderBrowserDialog Fbd = new FolderBrowserDialog();
                if (Fbd.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml", Fbd.SelectedPath + $@"\{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.THU", true);
                    MessageBox.Show("تم النسخ بنجاح", "نسخ احتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            else
            {
                if (MessageBox.Show("لا توجد بيات هل تريد انشاء قاعدة جديدة؟", "لاتوجد بيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    File.Create(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml");
            }
        }

        private void إستعادةنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            OpenFileDialog Opf = new OpenFileDialog();
            Opf.Title = "اختر قاعدة البيانات من فضلك";
            Opf.Filter = "نسخة اختياطية|*.THU";
            if (Opf.ShowDialog() != DialogResult.OK)
                return;
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml"))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml");
            File.Copy(Opf.FileName, AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml");
            MessageBox.Show("تم إستعادة النسخة بنجاح", "نسخ احتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            Pds = new DataSet("P_DS");
            Pds.ReadXml(AppDomain.CurrentDomain.BaseDirectory + @"\prepation.xml");
            dataGridView1.DataSource = Pds.Tables[0];
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
        }
    }
}
