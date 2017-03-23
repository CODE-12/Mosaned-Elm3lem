using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Net.Mail;

namespace MosanedElmo3lem.UI
{
    public partial class SectionsBackupAndRestore : Form
    {
        public SectionsBackupAndRestore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data"))
            {
                MessageBox.Show("لا توجد بيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            FolderBrowserDialog Fbd = new FolderBrowserDialog();
            if (Fbd.ShowDialog() != DialogResult.OK)
                return;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string FromAdd = "Ramromi@gmai.com";
            const string FromPass = "05050505050505050";
            MailAddress From = new MailAddress(FromAdd);
            MailAddress To = new MailAddress("");
            MailMessage Msg = new MailMessage(From, To);
            Attachment Attach = new Attachment(@"C:\Users\user\Documents\F\MosanedElmo3alem\MosanedElmo3alem\bin\Debug\records.xml");
            Msg.Attachments.Add(Attach);
            Msg.Subject = "مساند المعلم";
            Msg.Body = "تم ارسال ملف لك من قبل برنامج مساند المعلم";
            SmtpClient Smtp = new SmtpClient("589", 3006);
            Smtp.Send(Msg);
        }
    }
}
