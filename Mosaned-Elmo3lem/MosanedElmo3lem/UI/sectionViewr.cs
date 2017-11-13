using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MosanedElmo3alem.Classes;

namespace MosanedElmo3lem.UI
{
    public partial class sectionViewr : Form
    {
        public sectionViewr()
        {
            InitializeComponent();
        }

        private void sectionViewr_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data"))
                if (MessageBox.Show("لاتوجد بيانات هل تريد إنشاء نسخة جديدة؟", "خطأ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Cancel)
                    return;
                else
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data");
            DirectoryInfo Dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"\Data");
            DirectoryInfo[] dirs = Dir.GetDirectories();
            PrimarySection[] Prim = new PrimarySection[dirs.Length];
            for (int i = 0; i < dirs.Length; i++)
            {
                Prim[i] = new PrimarySection(dirs[i]);
            }
            treeView1.Nodes.Add("الرئيسية");
            for (int i = 0; i < Prim.Length; i++)
            {
                this.treeView1.Nodes[0].Nodes.Add(Prim[i].SectionName, Prim[i].SectionName, 0, 1);
                //append sub sections
                for (int m = 0; m < Prim[i].ChildsSection.Count; m++)
                {
                    treeView1.Nodes[0].Nodes[i].Nodes.Add(Prim[i].ChildsSection[m].SectionName, Prim[i].ChildsSection[m].SectionName, 0, 1);
                    for (int n = 0; n < Prim[i].ChildsSection[m].Childs.Count; n++)
                    {
                        int pic;
                        switch (Prim[i].ChildsSection[m].Childs[n].IconType)
                        {
                            case ExtensionIcon.PDF:
                                pic = 3;
                                break;
                            case ExtensionIcon.PPTX:
                                pic = 4;
                                break;
                            case ExtensionIcon.DOCX:
                                pic = 2;
                                break;
                            default:
                                pic = 5;
                                break;
                        }
                        treeView1.Nodes[0].Nodes[i].Nodes[m].Nodes.Add(RemoveExtension(Prim[i].ChildsSection[m].Childs[n].FileName), RemoveExtension(Prim[i].ChildsSection[m].Childs[n].FileName), pic, pic);
                    }
                }
            }
        }

        private string RemoveExtension(string Input)
        {
            int PointOfDot = Input.LastIndexOf('.');
            StringBuilder Sb = new StringBuilder();
            for (int i = 0; i < PointOfDot; i++)
            {
                Sb.Append(Input[i]);
            }
            return Sb.ToString();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Parent.Parent.Parent.Text == "الرئيسية")
                {
                    string Extension = "";
                    string path = Path.GetFullPath(@"Data\" + e.Node.Parent.Parent.Text + @"\" + e.Node.Parent.Text + @"\" + e.Node.Text);
                    DirectoryInfo dInf = new DirectoryInfo(Path.GetDirectoryName(path));
                    foreach (var item in dInf.GetFiles())
                    {
                        if (item.Name.StartsWith(e.Node.Text))
                        {
                            Extension = Path.GetExtension(item.FullName);
                            break;
                        }
                    }

                    path += Extension;
                    if (File.Exists(path))
                        Run(path);
                    else
                        MessageBox.Show("الملف غير موجود!!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPrimary pr = new AddPrimary();
            pr.ShowDialog();
            treeView1.Nodes[0].Remove();
            sectionViewr_Load(this, EventArgs.Empty);
        }

        private void Run(string SPath)
        {
            //SPath = AppDomain.CurrentDomain.BaseDirectory + @"\Data\" + SPath;
            try
            {
                if (string.IsNullOrWhiteSpace(SPath))
                    return;
                System.Diagnostics.Process.Start(SPath);           
            }
            catch (Exception)
            {
                MessageBox.Show("خطأ لايمكن فتح الملف", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addLessonse f = new addLessonse();
            f.ShowDialog();
            this.treeView1.Nodes.Clear();
            sectionViewr_Load(this, EventArgs.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DelSection().ShowDialog();
            this.treeView1.Nodes.Clear();
            sectionViewr_Load(this, EventArgs.Empty);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode.Parent.Parent.Parent.Text != "الرئيسية")
                {
                    MessageBox.Show("الرجاء تحديد ملف للحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                } 
                string Extension = "";
                switch (treeView1.SelectedNode.ImageIndex)
                {
                    case 0:
                        return;
                    case 1:
                        return;
                    case 2:
                        Extension = ".docx";
                        break;
                    case 3:
                        Extension = ".pdf";
                        break;
                    case 4:
                        Extension = ".pptx";
                        break;
                }
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\" + treeView1.SelectedNode.Parent.Parent.Text + @"\" + treeView1.SelectedNode.Parent.Text + @"\" + treeView1.SelectedNode.Text + Extension);
                MessageBox.Show("تم حذف الملف بنجاح", "تم حذف الملف", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                treeView1.Nodes.Clear();
                sectionViewr_Load(this, EventArgs.Empty);
            }
            catch
            {
                MessageBox.Show("الرجاء تحديد ملف للحذف و التاكد من أن الملف مغلق", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
        }
    }
}
