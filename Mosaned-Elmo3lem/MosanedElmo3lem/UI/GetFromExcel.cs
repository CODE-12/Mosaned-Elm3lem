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

        List<char> Chr = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
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
                string Col = "";
                int Row = 0;
                for (int i = 1; i < xlWorkSheet.Rows.Count; i++)
                {
                    if (i > 100) break;
                    try
                    {
                        if (xlWorkSheet.Cells[i, "T"].Value.ToString() == "اسم الطالب")
                        {
                            Col = "T";
                            Row = i;
                        }
                        if (xlWorkSheet.Cells[i, "U"].Value.ToString() == "اسم الطالب")
                        {
                            Col = "U";
                            Row = i;
                        }
                        if (xlWorkSheet.Cells[i, "V"].Value.ToString() == "اسم الطالب")
                        {
                            Col = "V";
                            Row = i;
                        }
                        if (xlWorkSheet.Cells[i, "W"].Value.ToString() == "اسم الطالب")
                        {
                            Col = "W";
                            Row = i;
                        }
                        if (xlWorkSheet.Cells[i, "X"].Value.ToString() == "اسم الطالب")
                        {
                            Col = "X";
                            Row = i;
                        }
                        if (xlWorkSheet.Cells[i, "Y"].Value.ToString() == "اسم الطالب")
                        {
                            Col = "Y";
                            Row = i;
                        }
                        if (xlWorkSheet.Cells[i, "Z"].Value.ToString() == "اسم الطالب")
                        {
                            Col = "Z";
                            Row = i;
                        }
                    }
                    catch
                    { }
                }
                MessageBox.Show($"Row = {Row} And Col = {Col}");
                return;
                for (int i = 0; i < xlWorkSheet.Rows.Count; i++)
                {
                    if (i > 60)
                        break;
                    if (xlWorkSheet.Cells[i + 1, "W"].Value == null || xlWorkSheet.Cells[i + 1, "V"].Value == null)
                        continue;
                    dataGridView1.Rows.Add(xlWorkSheet.Cells[i + 1, Col].Value, xlWorkSheet.Cells[i + 1, ""].Value);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("لم يتم تثبيت Excel في الجهاز", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
