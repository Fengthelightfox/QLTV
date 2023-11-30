namespace Quan_ly_thu_vien
{
    partial class Tim_kiem
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
            this.Searchbox = new System.Windows.Forms.GroupBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttcb = new System.Windows.Forms.ComboBox();
            this.tlcb = new System.Windows.Forms.ComboBox();
            this.tstb = new System.Windows.Forms.TextBox();
            this.mstb = new System.Windows.Forms.TextBox();
            this.resultbox = new System.Windows.Forms.GroupBox();
            this.borrowbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Searchbox.SuspendLayout();
            this.resultbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchbox
            // 
            this.Searchbox.Controls.Add(this.searchbtn);
            this.Searchbox.Controls.Add(this.label4);
            this.Searchbox.Controls.Add(this.label3);
            this.Searchbox.Controls.Add(this.label2);
            this.Searchbox.Controls.Add(this.label1);
            this.Searchbox.Controls.Add(this.ttcb);
            this.Searchbox.Controls.Add(this.tlcb);
            this.Searchbox.Controls.Add(this.tstb);
            this.Searchbox.Controls.Add(this.mstb);
            this.Searchbox.Location = new System.Drawing.Point(38, 33);
            this.Searchbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Searchbox.Size = new System.Drawing.Size(676, 116);
            this.Searchbox.TabIndex = 0;
            this.Searchbox.TabStop = false;
            this.Searchbox.Text = "Tìm Kiếm";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(573, 31);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(56, 19);
            this.searchbtn.TabIndex = 8;
            this.searchbtn.Text = "Tìm Kiếm";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tình Trạng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thể Loại: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Sách:";
            // 
            // ttcb
            // 
            this.ttcb.FormattingEnabled = true;
            this.ttcb.Items.AddRange(new object[] {
            "Mới",
            "Cũ"});
            this.ttcb.Location = new System.Drawing.Point(416, 68);
            this.ttcb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ttcb.Name = "ttcb";
            this.ttcb.Size = new System.Drawing.Size(92, 21);
            this.ttcb.TabIndex = 3;
            // 
            // tlcb
            // 
            this.tlcb.FormattingEnabled = true;
            this.tlcb.Items.AddRange(new object[] {
            "Tiểu thuyết",
            "Tâm lý học",
            "Trinh thám",
            "Khoa học viễn tưởng",
            "Phát triển cá nhân",
            "Tiểu thuyết kì ảo",
            "Tiểu thuyết lãng mạn",
            "Hồi ký",
            "Thơ",
            "Quản lý kinh doanh"});
            this.tlcb.Location = new System.Drawing.Point(159, 68);
            this.tlcb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlcb.Name = "tlcb";
            this.tlcb.Size = new System.Drawing.Size(92, 21);
            this.tlcb.TabIndex = 2;
            // 
            // tstb
            // 
            this.tstb.Location = new System.Drawing.Point(416, 31);
            this.tstb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tstb.Name = "tstb";
            this.tstb.Size = new System.Drawing.Size(92, 20);
            this.tstb.TabIndex = 1;
            // 
            // mstb
            // 
            this.mstb.Location = new System.Drawing.Point(159, 31);
            this.mstb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mstb.Name = "mstb";
            this.mstb.Size = new System.Drawing.Size(92, 20);
            this.mstb.TabIndex = 0;
            // 
            // resultbox
            // 
            this.resultbox.Controls.Add(this.borrowbtn);
            this.resultbox.Controls.Add(this.dataGridView1);
            this.resultbox.Location = new System.Drawing.Point(38, 154);
            this.resultbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultbox.Name = "resultbox";
            this.resultbox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultbox.Size = new System.Drawing.Size(676, 299);
            this.resultbox.TabIndex = 1;
            this.resultbox.TabStop = false;
            this.resultbox.Text = "Kết quả tìm kiếm";
            // 
            // borrowbtn
            // 
            this.borrowbtn.Location = new System.Drawing.Point(304, 259);
            this.borrowbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.borrowbtn.Name = "borrowbtn";
            this.borrowbtn.Size = new System.Drawing.Size(56, 19);
            this.borrowbtn.TabIndex = 5;
            this.borrowbtn.Text = "Mượn";
            this.borrowbtn.UseVisualStyleBackColor = true;
            this.borrowbtn.Click += new System.EventHandler(this.borrowbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(592, 184);
            this.dataGridView1.TabIndex = 4;
            // 
            // Tim_kiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 463);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.Searchbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tim_kiem";
            this.Text = "Tìm kiếm sách";
            this.Searchbox.ResumeLayout(false);
            this.Searchbox.PerformLayout();
            this.resultbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Searchbox;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ttcb;
        private System.Windows.Forms.ComboBox tlcb;
        private System.Windows.Forms.TextBox tstb;
        private System.Windows.Forms.TextBox mstb;
        private System.Windows.Forms.GroupBox resultbox;
        private System.Windows.Forms.Button borrowbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
