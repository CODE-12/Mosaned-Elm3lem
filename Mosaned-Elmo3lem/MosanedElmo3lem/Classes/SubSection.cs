using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MosanedElmo3alem.Classes
{
    public class SubSection
    {
        public string SectionName { get; set; }

        public string SectionPath { get; set; }

        public HelperSection Parent { get; private set; }

        public List<FileImagine> Childs { get; set; }

        public bool HaveChild { get { return Childs.Count > 0; } }

        public SubSection(PrimarySection TheParent, DirectoryInfo DirInf)
        {
            this.Childs = new List<FileImagine>();
            this.Parent = TheParent;
            this.SectionPath = DirInf.FullName;
            this.SectionName = DirInf.Name;
            Initilize(DirInf);
        }

        private void Initilize(DirectoryInfo MyDir)
        {
            // Add Childs
            FileInfo[] FileNest = MyDir.GetFiles();
            foreach (FileInfo item in FileNest)
            {
                //if (item.Extension.ToUpper() == ".PPTX" || item.Extension.ToUpper() == ".PDF" || item.Extension.ToUpper() == ".DOCX")
                    this.Childs.Add(new FileImagine(item));
            }
        }
    }
}
