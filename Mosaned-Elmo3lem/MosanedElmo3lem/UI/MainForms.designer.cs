namespace MosanedElmo3lem.UI
{
    partial class MainForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForms));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.place3 = new System.Windows.Forms.PictureBox();
            this.place2 = new System.Windows.Forms.PictureBox();
            this.place1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.place3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.place2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.place1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "المفكرة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ملف الإنجاز \\ أرشيف الدروس";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "سجل المتابعة";
            // 
            // place3
            // 
            this.place3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place3.Image = global::MosanedElmo3lem.Properties.Resources._7;
            this.place3.Location = new System.Drawing.Point(494, 12);
            this.place3.Name = "place3";
            this.place3.Size = new System.Drawing.Size(221, 254);
            this.place3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.place3.TabIndex = 2;
            this.place3.TabStop = false;
            this.place3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.place3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseClick);
            this.place3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.place3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // place2
            // 
            this.place2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place2.Image = global::MosanedElmo3lem.Properties.Resources._8;
            this.place2.Location = new System.Drawing.Point(252, 12);
            this.place2.Name = "place2";
            this.place2.Size = new System.Drawing.Size(236, 249);
            this.place2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.place2.TabIndex = 1;
            this.place2.TabStop = false;
            this.place2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.place2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseClick);
            this.place2.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.place2.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // place1
            // 
            this.place1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place1.Image = global::MosanedElmo3lem.Properties.Resources._1;
            this.place1.Location = new System.Drawing.Point(12, 12);
            this.place1.Name = "place1";
            this.place1.Size = new System.Drawing.Size(234, 249);
            this.place1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.place1.TabIndex = 0;
            this.place1.TabStop = false;
            this.place1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.place1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseClick);
            this.place1.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.place1.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(734, 304);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.place3);
            this.Controls.Add(this.place2);
            this.Controls.Add(this.place1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForms";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مساند المعلم";
            this.Load += new System.EventHandler(this.MainForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.place3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.place2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.place1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox place1;
        private System.Windows.Forms.PictureBox place2;
        private System.Windows.Forms.PictureBox place3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}