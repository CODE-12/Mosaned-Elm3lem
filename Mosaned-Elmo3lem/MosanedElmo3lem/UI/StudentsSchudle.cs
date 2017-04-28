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
    public partial class StudentsSchudle : Form
    {

        private DataSet Pds = new DataSet("P_DS");

        public StudentsSchudle()
        {
            InitializeComponent();
            this.dataGridView1.EditingControlShowing += (a, b) => {
                if(this.dataGridView1.CurrentCell.ColumnIndex > 1)
                {
                    (b.Control as TextBox).KeyPress += (t, c) => {
                        if (!char.IsDigit(c.KeyChar) || (b.Control as TextBox).Text.Length > 1)
                            c.Handled = true;
                        if (c.KeyChar == '\b' || c.KeyChar == 127) // 127 == DEL
                            c.Handled = false;
                    };
                }
            };
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml"))
            {
                MessageBox.Show("الملفات المطلوبة غير موجودة سيتم إنشاء نسخ جديدة ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml", FileMode.OpenOrCreate);
                fs.Close();
                fs.Dispose();
                fs = null;
            }
            try
            {
                Pds.ReadXml(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml");
            }
            catch
            {
                if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml"))
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml");
                FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml", FileMode.OpenOrCreate);
                fs.Close();
                fs.Dispose();
                Pds.WriteXml(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml");
            }
        }

        private void StudentsSchudle_Load(object sender, EventArgs e)
        {
            
        }

        private void فتحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboSelector Slc = new ComboSelector();
            Slc.Text = "فتح شعبة";
            Slc.label1.Text = "اختر الشعبة المراد فتحها:-";
            for (int i = 0; i < this.Pds.Tables.Count; i++)
            {
                Slc.comboBox1.Items.Add(Pds.Tables[i].TableName);
            }
            Slc.button1.Text = "فتح";
            Slc.button1.Click += (Sen, Eve) => {
                if (Slc.comboBox1.SelectedIndex == -1)
                    return;
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                this.dataGridView1.Columns.Clear();
                //Pds.Tables[Slc.comboBox1.SelectedItem.ToString()].Columns[3].DataType = typeof(int);
                this.dataGridView1.DataSource = Pds.Tables[Slc.comboBox1.SelectedItem.ToString()];
                Slc.Close();
                Slc.Dispose();
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns[0].Width = 90;
                dataGridView1.Columns[1].Width = 300;
            };
            Slc.ShowDialog();

        }

        private void إغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                this.dataGridView1.Columns.Clear();
            }
            catch (Exception)
            {

            }
        }

        private void إضافةجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewSchudle Adns = new AddNewSchudle();
            Adns.button1.Click += (send, ever) => {
                if (string.IsNullOrWhiteSpace(Adns.textBox1.Text))
                    return;
                DataTable NTbl = new DataTable(Adns.textBox1.Text);
                NTbl.Columns.Add("الرقم الأكاديمي",typeof(int));
                NTbl.Columns.Add("اسم الطالب",typeof(string));
                this.Pds.Tables.Add(NTbl);
                Adns.Close();
                Adns.Dispose();
                MessageBox.Show("تم إضافة الفصل بنجاح", "إضافة فصل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            };
            Adns.ShowDialog();
        }

        private void حفظToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Pds != null)
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml"))
                {
                    foreach (DataTable item in Pds.Tables)
                    {
                        foreach (DataRow item2 in item.Rows)
                        {
                            for (int i = 0; i < item.Columns.Count; i++)
                            {
                                if (string.IsNullOrWhiteSpace(item2[i].ToString()))
                                    item2[i] = 0;
                            }
                        }
                    }
                    Pds.WriteXml(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml");
                    MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboSelector Dnls = new ComboSelector();
            Dnls.Text = "حذف شعبة";
            for (int i = 0; i < Pds.Tables.Count; i++)
            {
                Dnls.comboBox1.Items.Add(Pds.Tables[i].TableName);
            }
            Dnls.label1.Text = "إختر الشعبة المراد حذفها:-";
            Dnls.button1.Text = "حذف";
            Dnls.button1.Click += (Send, Ever) => {
                if (Dnls.comboBox1.SelectedIndex == -1)
                    return;
                Pds.Tables.Remove(Dnls.comboBox1.SelectedItem.ToString());
                MessageBox.Show("تم حذف الفصل بنجاح", "حذف فصل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                Dnls.Close();
            };
            Dnls.ShowDialog();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboSelector Slc = new ComboSelector();
            Slc.Text = "تعديل شعبة";
            Slc.button1.Text = "استمر";
            Slc.label1.Text = "إختر شعبة";
            for (int i = 0; i < Pds.Tables.Count; i++) 
                Slc.comboBox1.Items.Add(Pds.Tables[i].TableName);
            Slc.button1.Click += (sn, eve) => {
                EditClass EC = new EditClass();
                if (Slc.comboBox1.SelectedIndex == -1)
                    return;
                EC.label2.Text = Slc.comboBox1.SelectedItem.ToString();
                for (int i = 2; i < Pds.Tables[Slc.comboBox1.SelectedItem.ToString()].Columns.Count; i++)
                {
                    EC.listBox1.Items.Add(Pds.Tables[Slc.comboBox1.SelectedItem.ToString()].Columns[i].ColumnName);
                }
                EC.button6.Click += (sen, even) => {
                    if (MessageBox.Show("الحفظ سيؤدي لمحو جميع البيانات السابقة بالشعبة هل ترغب بالمتابعة؟", "هل تريد الحفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.No)
                        return;
                    Pds.Tables[Slc.comboBox1.SelectedItem.ToString()].Rows.Clear();
                    Pds.Tables[Slc.comboBox1.SelectedItem.ToString()].Columns.Clear();
                    Pds.Tables[Slc.comboBox1.SelectedItem.ToString()].Columns.Add("الرقم الأكاديمي", typeof(int));
                    Pds.Tables[Slc.comboBox1.SelectedItem.ToString()].Columns.Add("اسم الطالب", typeof(string));
                    for (int i = 0; i < EC.listBox1.Items.Count; i++)
                    {
                        Pds.Tables[Slc.comboBox1.SelectedItem.ToString()].Columns.Add(EC.listBox1.Items[i].ToString(), typeof(int));
                    }
                    MessageBox.Show("تم تعديل الشعبة", "تم تعديل الشعبة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    EC.Close();
                };
                EC.ShowDialog();
                Slc.Close();
            };
            Slc.ShowDialog();
        }

        private void إضافةطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            ComboSelector CS = new ComboSelector();
            CS.Text = "اختيار الشعبة";
            CS.label1.Text = "إختر شعبة";
            CS.button1.Text = "استمرار";
            for (int i = 0; i < Pds.Tables.Count; i++)
                CS.comboBox1.Items.Add(Pds.Tables[i].TableName);
            CS.button1.Click += (sen, eve) =>
            {
                if (CS.comboBox1.SelectedIndex == -1)
                    return;
                AddNewStudents Ad = new AddNewStudents();
                Ad.label2.Text = CS.comboBox1.SelectedItem.ToString();
                for (int i = 0; i < Pds.Tables[CS.comboBox1.SelectedItem.ToString()].Rows.Count; i++)
                    Ad.dataGridView1.Rows.Add(Pds.Tables[CS.comboBox1.SelectedItem.ToString()].Rows[i][0], Pds.Tables[CS.comboBox1.SelectedItem.ToString()].Rows[i][1]);
                Ad.button4.Click += (sender2, ever2) =>
                {
                    if (Ad.dataGridView1.Rows.Count == 0)
                        return;
                    if (MessageBox.Show("سيتم حذف جميع السجلات السابقة متابعة؟", "تعديل الطلاب", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) != DialogResult.Yes)
                        return;
                    Pds.Tables[CS.comboBox1.SelectedItem.ToString()].Rows.Clear();
                    for (int i = 0; i < Ad.dataGridView1.Rows.Count; i++)
                        Pds.Tables[CS.comboBox1.SelectedItem.ToString()].Rows.Add(Ad.dataGridView1.Rows[i].Cells[0].Value, Ad.dataGridView1.Rows[i].Cells[1].Value);
                    MessageBox.Show("تم تعديل الطلاب بنجاح", "تم الحفظ بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    Ad.Close();
                    Ad.Dispose();
                    Ad = null;
                };
                CS.Close();
                Ad.ShowDialog();
                CS.Dispose();
                CS = null;
            };
            CS.Show();
        }

        private void StudentsSchudle_Resize(object sender, EventArgs e)
        {
            try {
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns[0].Width = 90;
                dataGridView1.Columns[1].Width = 300;
            }
            catch  { }

        }

        private void نسخToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml"))
            {
                FolderBrowserDialog Fbd = new FolderBrowserDialog();
                if (Fbd.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml", Fbd.SelectedPath+$@"\{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.STU",true);
                    MessageBox.Show("تم النسخ بنجاح", "نسخ احتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            else
            {
                if (MessageBox.Show("لا توجد بيات هل تريد انشاء قاعدة جديدة؟", "لاتوجد بيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    File.Create(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml");
            }
        }

        private void إستعادةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            OpenFileDialog Opf = new OpenFileDialog();
            Opf.Title = "اختر قاعدة البيانات من فضلك";
            Opf.Filter = "نسخة اختياطية|*.STU";
            if (Opf.ShowDialog() != DialogResult.OK)
                return;
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml"))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml");
            File.Copy(Opf.FileName, AppDomain.CurrentDomain.BaseDirectory + @"\records.xml");
            MessageBox.Show("تم إستعادة النسخة بنجاح", "نسخ احتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            Pds = new DataSet("P_DS");
            Pds.ReadXml(AppDomain.CurrentDomain.BaseDirectory + @"\records.xml");
        }

        private void testPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.DataSource == null || this.dataGridView1.Rows.Count == 0)
                return;
            new UI.PrePrint(this.dataGridView1).Show();
        }
    }
}

