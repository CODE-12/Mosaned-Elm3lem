using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace MosanedElmo3alem.Classes
{
    public enum ExtensionIcon
    {
        PDF
        ,
        PPTX
        ,
        DOCX
        ,
        UnKnown
    }
    public class FileImagine
    {
        public string FilePath { get; set; }

        public string FileName { get; set; }

        public ExtensionIcon IconType { get; set; }

        public FileImagine(FileInfo Myfil)
        {
            this.FilePath = Myfil.FullName;
            this.FileName = Myfil.Name;
            switch (Myfil.Extension.ToUpper())
            {
                case ".PPTX":
                    this.IconType = ExtensionIcon.PPTX;
                    break;
                case ".DOCX":
                    this.IconType = ExtensionIcon.DOCX;
                    break;
                case ".PDF":
                    this.IconType = ExtensionIcon.PDF;
                    break;
                default:
                    this.IconType = ExtensionIcon.UnKnown;
                    break;
            }
        }

        public void StartFile()
        {
            try
            {
                Process.Start(this.FilePath);
            }
            catch
            {
                MessageBox.Show("فشل تشغيل " + this.FileName, "خطأ في التشغيل", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }
    }
}
