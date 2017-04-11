namespace MosanedElmo3lem.UI
{
    partial class PrepationViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrepationViewer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.عامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حفظToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.نسخاحتياطيToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إستعادةنسخةاحتياطيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(484, 387);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عامToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // عامToolStripMenuItem
            // 
            this.عامToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حفظToolStripMenuItem,
            this.toolStripSeparator1,
            this.حذفToolStripMenuItem,
            this.toolStripSeparator2,
            this.نسخاحتياطيToolStripMenuItem,
            this.إستعادةنسخةاحتياطيةToolStripMenuItem});
            this.عامToolStripMenuItem.Name = "عامToolStripMenuItem";
            this.عامToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.عامToolStripMenuItem.Text = "عام";
            // 
            // حفظToolStripMenuItem
            // 
            this.حفظToolStripMenuItem.Name = "حفظToolStripMenuItem";
            this.حفظToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.حفظToolStripMenuItem.Text = "حفظ";
            this.حفظToolStripMenuItem.Click += new System.EventHandler(this.حفظToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // نسخاحتياطيToolStripMenuItem
            // 
            this.نسخاحتياطيToolStripMenuItem.Name = "نسخاحتياطيToolStripMenuItem";
            this.نسخاحتياطيToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.نسخاحتياطيToolStripMenuItem.Text = "نسخ احتياطي";
            this.نسخاحتياطيToolStripMenuItem.Click += new System.EventHandler(this.نسخاحتياطيToolStripMenuItem_Click);
            // 
            // إستعادةنسخةاحتياطيةToolStripMenuItem
            // 
            this.إستعادةنسخةاحتياطيةToolStripMenuItem.Name = "إستعادةنسخةاحتياطيةToolStripMenuItem";
            this.إستعادةنسخةاحتياطيةToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.إستعادةنسخةاحتياطيةToolStripMenuItem.Text = "إستعادة نسخة احتياطية";
            this.إستعادةنسخةاحتياطيةToolStripMenuItem.Click += new System.EventHandler(this.إستعادةنسخةاحتياطيةToolStripMenuItem_Click);
            // 
            // PrepationViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrepationViewer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المذكرة";
            this.Load += new System.EventHandler(this.PrepationViewer_Load);
            this.Resize += new System.EventHandler(this.PrepationViewer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem عامToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حفظToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem نسخاحتياطيToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إستعادةنسخةاحتياطيةToolStripMenuItem;
    }
}