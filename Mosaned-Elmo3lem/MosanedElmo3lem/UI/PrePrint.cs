using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MosanedElmo3lem.UI
{
    public partial class PrePrint : Form
    {
        /*
اختبارات قصيرة نظري-
البحوث والمشروعات-
التقارير العملية او التجارب العملية-
الملاحظة والمشاركة والتفاعل الصفي-
الواجبات والمهام الادائية-
ملف الاعمال-
اختبار نهائي عملي/شفهي-
         */
        public List<string> ColumnOfshortExam { get; set; } = new List<string>();
        public List<string> ColumnOfResarch { get; set; } = new List<string>();
        public List<string> ColumnOfReportAndTest { get; set; } = new List<string>();
        public List<string> ColumnOfActiveInClass { get; set; } = new List<string>();
        public List<string> ColumnOfHomeWork { get; set; } = new List<string>();
        public List<string> ColumnOfFileWork { get; set; } = new List<string>();
        public List<string> ColumnOfFinalTalk { get; set; } = new List<string>();
        public DataGridView MyResult;
        public PrePrint(DataGridView dgvPrinted)
        {
            InitializeComponent();
            MakeItClear(dgvPrinted);
            CreateDGVForPrint(dgvPrinted, out MyResult);
            DataTable Tbl = new DataTable();
            foreach (DataGridViewColumn item in MyResult.Columns)
            {
                Tbl.Columns.Add(item);
            }
            foreach (DataGridViewRow item in MyResult.Rows)
            {
                this.dataGridView1.Rows.Add(item);
            }
        }

        private void MakeItClear(DataGridView dGV)
        {
            foreach (DataGridViewColumn item in dGV.Columns)
            {
                if (item.Name.Contains("اختبارات قصيرة نظري"))
                {
                    ColumnOfshortExam.Add(item.Name);
                    continue;
                }
                else if (item.Name.Contains("البحوث والمشروعات"))
                {
                    ColumnOfResarch.Add(item.Name);
                    continue;
                }
                else if (item.Name.Contains("التقارير العملية او التجارب العملية"))
                {
                    ColumnOfReportAndTest.Add(item.Name);
                    continue;
                }
                else if (item.Name.Contains("الملاحظة والمشاركة والتفاعل الصفي"))
                {
                    ColumnOfActiveInClass.Add(item.Name);
                    continue;
                }
                else if (item.Name.Contains("الواجبات والمهام الادائية"))
                {
                    ColumnOfHomeWork.Add(item.Name);
                    continue;
                }
                else if (item.Name.Contains("ملف الاعمال"))
                {
                    ColumnOfFileWork.Add(item.Name);
                    continue;
                }
                else if (item.Name.Contains("اختبار نهائي عملي/شفهي"))
                {
                    ColumnOfFinalTalk.Add(item.Name);
                    continue;
                }

            }
        }

        private void CreateDGVForPrint(DataGridView dGV, out DataGridView result)
        {
            result = new DataGridView();
            result.Columns.Add(dGV.Columns[0].HeaderText, dGV.Columns[0].HeaderText);
            result.Columns.Add(dGV.Columns[1].HeaderText, dGV.Columns[1].HeaderText);
            result.Columns.Add("اختبارات قصيرة نظري", "اختبارات قصيرة نظري");
            result.Columns.Add("البحوث والمشروعات", "البحوث والمشروعات");
            result.Columns.Add("التقارير العملية او التجارب العملية", "التقارير العملية او التجارب العملية");
            result.Columns.Add("الملاحظة والمشاركة والتفاعل الصفي", "الملاحظة والمشاركة والتفاعل الصفي");
            result.Columns.Add("الواجبات والمهام الادائية", "الواجبات والمهام الادائية");
            result.Columns.Add("ملف الاعمال", "ملف الاعمال");
            result.Columns.Add("اختبار نهائي عملي/شفهي", "اختبار نهائي عملي/شفهي");
            //result.Columns.AddRange(new DataGridViewColumn[] {
            //    new DataGridViewColumn(new DataGridViewTextBoxCell()) { HeaderText = dGV.Columns[0].HeaderText,Name = "1" },
            //    new DataGridViewColumn(new DataGridViewTextBoxCell()) { HeaderText = dGV.Columns[1].HeaderText,Name = "2" },
            //    new DataGridViewColumn(new DataGridViewTextBoxCell()) { HeaderText = "اختبارات قصيرة نظري",Name = "3" },
            //    new DataGridViewColumn(new DataGridViewTextBoxCell()) { HeaderText = "البحوث والمشروعات" ,Name = "4"},
            //    new DataGridViewColumn(new DataGridViewTextBoxCell()) { HeaderText = "التقارير العملية او التجارب العملية" ,Name = "5"},
            //    new DataGridViewColumn(new DataGridViewTextBoxCell()) { HeaderText = "الملاحظة والمشاركة والتفاعل الصفي",Name = "6" },
            //    new DataGridViewColumn(new DataGridViewTextBoxCell()) { HeaderText = "الواجبات والمهام الادائية",Name = "7" },
            //    new DataGridViewColumn(new DataGridViewTextBoxCell()) { HeaderText = "ملف الاعمال",Name = "8"},
            //    new DataGridViewColumn(new DataGridViewTextBoxCell()) { HeaderText = "اختبار نهائي عملي/شفهي" ,Name = "9"} });
            foreach (DataGridViewRow item in dGV.Rows)
            {
                //short exam
                int n1 = 0;
                //research
                int n2 = 0;
                //reports
                int n3 = 0;
                //class active
                int n4 = 0;
                //homework
                int n5 = 0;
                //work file
                int n6 = 0;
                //talk exam
                int n7 = 0;

                #region LOOP IN COLUMNS
                foreach (DataGridViewColumn item2 in dGV.Columns)
                {
                    if (item2.Name.Contains("اختبارات قصيرة نظري"))
                    {
                        n1 += int.Parse(item.Cells[item2.Name].Value.ToString());
                        continue;
                    }
                    else if (item2.Name.Contains("البحوث والمشروعات"))
                    {
                        n2 += int.Parse(item.Cells[item2.Name].Value.ToString());
                        continue;
                    }
                    else if (item2.Name.Contains("التقارير العملية او التجارب العملية"))
                    {
                        n3 += int.Parse(item.Cells[item2.Name].Value.ToString());
                        continue;
                    }
                    else if (item2.Name.Contains("الملاحظة والمشاركة والتفاعل الصفي"))
                    {
                        n4 += int.Parse(item.Cells[item2.Name].Value.ToString());
                        continue;
                    }
                    else if (item2.Name.Contains("الواجبات والمهام الادائية"))
                    {
                        n5 += int.Parse(item.Cells[item2.Name].Value.ToString());
                        continue;
                    }
                    else if (item2.Name.Contains("ملف الاعمال"))
                    {
                        n6 += int.Parse(item.Cells[item2.Name].Value.ToString());
                        continue;
                    }
                    else if (item2.Name.Contains("اختبار نهائي عملي/شفهي"))
                    {
                        n7 += int.Parse(item.Cells[item2.Name].Value.ToString());
                        continue;
                    }
                }
                #endregion
                
                if(ColumnOfshortExam.Count > 0)
                    n1 /= ColumnOfshortExam.Count;
                if (ColumnOfResarch.Count > 0)
                    n2 /= ColumnOfResarch.Count;
                if (ColumnOfReportAndTest.Count > 0)
                    n3 /= ColumnOfReportAndTest.Count;
                if (ColumnOfActiveInClass.Count > 0)
                    n4 /= ColumnOfActiveInClass.Count;
                if (ColumnOfHomeWork.Count > 0)
                    n5 /= ColumnOfHomeWork.Count;
                if (ColumnOfFileWork.Count > 0)
                    n6 /= ColumnOfFileWork.Count;
                if (ColumnOfFinalTalk.Count > 0)
                    n7 /= ColumnOfFinalTalk.Count;

                result.Rows.Add(new string[] {
                    item.Cells[0].Value.ToString(),
                    item.Cells[0].Value.ToString(),
                    n1.ToString(),
                    n2.ToString(),
                    n3.ToString(),
                    n4.ToString(),
                    n5.ToString(),
                    n6.ToString(),
                    n7.ToString()
                });
            }
        }
    }
}
