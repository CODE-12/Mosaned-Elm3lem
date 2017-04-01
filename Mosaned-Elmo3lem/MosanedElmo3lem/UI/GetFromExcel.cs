using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MosanedElmo3lem.UI
{
    public partial class GetFromExcel : Form
    {
        string Path;
        public GetFromExcel(string P)
        {
            InitializeComponent();
            Path = P;
        }
        
        private void GetFromExcel_Load(object sender, EventArgs e)
        {
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(Path, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                int col = 0;
                int row = 0;
                for (int i = 1; i < 30; i++)
                {
                    for (int i2 = 1; i2 < 30; i2++)
                    {
                        if (Convert.ToString(xlWorkSheet.Cells[i, i2].Value2) == "اسم الطالب")
                        {
                            col = i2;
                            row = i;
                            goto lbl;
                        }
                    }
                }
                throw new Exception("فشل الاستيراد الرجاء التأكد من الملف");
                lbl:;
                for (int i = row; i < xlWorkSheet.Rows.Count; i++)
                {
                    if (string.IsNullOrWhiteSpace(Convert.ToString(xlWorkSheet.Cells[i + 1, col].Value)) || string.IsNullOrWhiteSpace(Convert.ToString(xlWorkSheet.Cells[i + 1, col + 1].Value)))
                        return;
                    dataGridView1.Rows.Add(Convert.ToString(xlWorkSheet.Cells[i + 1, col + 1].Value), Convert.ToString(xlWorkSheet.Cells[i + 1, col].Value));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
