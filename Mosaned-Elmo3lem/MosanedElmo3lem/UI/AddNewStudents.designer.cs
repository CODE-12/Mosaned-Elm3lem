namespace MosanedElmo3lem.UI
{
    partial class AddNewStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewStudents));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "الشعبة:-";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(67, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "الرقم الأكاديمي:-";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 53);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 53);
            this.textBox2.MaxLength = 150;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 23);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "الاسم:-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "الطلاب:-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentAcc,
            this.StudentName});
            this.dataGridView1.Location = new System.Drawing.Point(5, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(464, 228);
            this.dataGridView1.TabIndex = 8;
            // 
            // StudentAcc
            // 
            this.StudentAcc.FillWeight = 47.71573F;
            this.StudentAcc.HeaderText = "الرقم الأكاديمي";
            this.StudentAcc.Name = "StudentAcc";
            this.StudentAcc.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.FillWeight = 152.2843F;
            this.StudentName.HeaderText = "اسم الطالب";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "استيراد من اكسل";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(5, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "حفظ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AddNewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(481, 388);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewStudents";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة طلاب";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button4;
    }
}