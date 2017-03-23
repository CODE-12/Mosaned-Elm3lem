using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MosanedElmo3alem.Classes
{
    public class PrimarySection : HelperSection
    {
        public string SectionName { get; set; }

        public string SectionPath { get; set; }

        public List<SubSection> ChildsSection { get; set; }

        public bool HaveChild { get { return ChildsSection.Count > 0; } }

        public PrimarySection(DirectoryInfo Dirinf)
        {
            this.ChildsSection = new List<SubSection>();
            this.SectionName = Dirinf.Name;
            this.SectionPath = Dirinf.FullName;
            Initilize(Dirinf);
        }

        private void Initilize(DirectoryInfo MyDir)
        {
            // Add Sub Section To ChildSection
            DirectoryInfo[] Dirs = MyDir.GetDirectories();
            foreach (DirectoryInfo item in Dirs)
            {
                this.ChildsSection.Add(new SubSection(this, item));
            }
        }
    }
}