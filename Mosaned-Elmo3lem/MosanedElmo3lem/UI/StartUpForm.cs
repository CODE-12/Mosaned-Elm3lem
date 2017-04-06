using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MosanedElmo3lem.UI
{
    public partial class StartUpForm : MaterialForm
    {
        public StartUpForm()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Red400, Primary.Red600, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            PrepationViewer p = new PrepationViewer();
            p.ShowDialog();
            p.Dispose();
            p = null;
        }
    }
}
