namespace DanhBa
{
    partial class DanhBa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhBa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_diaChi = new System.Windows.Forms.TextBox();
            this.textBox_soDienThoai = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_ten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_lienLac = new System.Windows.Forms.DataGridView();
            this.TenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_nhom = new System.Windows.Forms.DataGridView();
            this.tennhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_nhom = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_themNhom = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_xoaNhom = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_themLienLac = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_xoaLienLac = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingSource_lienLac = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lienLac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_nhom)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_lienLac)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView_lienLac);
            this.panel1.Controls.Add(this.dataGridView_nhom);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 552);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_diaChi);
            this.panel2.Controls.Add(this.textBox_soDienThoai);
            this.panel2.Controls.Add(this.textBox_email);
            this.panel2.Controls.Add(this.textBox_ten);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(200, 321);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 223);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox_diaChi
            // 
            this.textBox_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_diaChi.Location = new System.Drawing.Point(236, 155);
            this.textBox_diaChi.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_diaChi.Name = "textBox_diaChi";
            this.textBox_diaChi.ReadOnly = true;
            this.textBox_diaChi.Size = new System.Drawing.Size(175, 32);
            this.textBox_diaChi.TabIndex = 7;
            this.textBox_diaChi.TextChanged += new System.EventHandler(this.textBox_diaChi_TextChanged);
            // 
            // textBox_soDienThoai
            // 
            this.textBox_soDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_soDienThoai.Location = new System.Drawing.Point(236, 117);
            this.textBox_soDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_soDienThoai.Name = "textBox_soDienThoai";
            this.textBox_soDienThoai.ReadOnly = true;
            this.textBox_soDienThoai.Size = new System.Drawing.Size(175, 32);
            this.textBox_soDienThoai.TabIndex = 6;
            this.textBox_soDienThoai.TextChanged += new System.EventHandler(this.textBox_soDienThoai_TextChanged);
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(236, 79);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.ReadOnly = true;
            this.textBox_email.Size = new System.Drawing.Size(175, 32);
            this.textBox_email.TabIndex = 5;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // textBox_ten
            // 
            this.textBox_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ten.Location = new System.Drawing.Point(236, 41);
            this.textBox_ten.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ten.Name = "textBox_ten";
            this.textBox_ten.ReadOnly = true;
            this.textBox_ten.Size = new System.Drawing.Size(175, 32);
            this.textBox_ten.TabIndex = 4;
            this.textBox_ten.TextChanged += new System.EventHandler(this.textBox_ten_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên gọi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView_lienLac
            // 
            this.dataGridView_lienLac.AllowUserToAddRows = false;
            this.dataGridView_lienLac.AllowUserToDeleteRows = false;
            this.dataGridView_lienLac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_lienLac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lienLac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenGoi,
            this.Email,
            this.SoDienThoai});
            this.dataGridView_lienLac.Location = new System.Drawing.Point(200, 29);
            this.dataGridView_lienLac.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_lienLac.Name = "dataGridView_lienLac";
            this.dataGridView_lienLac.ReadOnly = true;
            this.dataGridView_lienLac.RowHeadersWidth = 51;
            this.dataGridView_lienLac.RowTemplate.Height = 24;
            this.dataGridView_lienLac.Size = new System.Drawing.Size(553, 288);
            this.dataGridView_lienLac.TabIndex = 2;
            this.dataGridView_lienLac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_lienLac_CellClick);
            this.dataGridView_lienLac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_lienLac_CellContentClick);
            // 
            // TenGoi
            // 
            this.TenGoi.DataPropertyName = "TenLienLac";
            this.TenGoi.HeaderText = "Tên gọi";
            this.TenGoi.MinimumWidth = 6;
            this.TenGoi.Name = "TenGoi";
            this.TenGoi.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // dataGridView_nhom
            // 
            this.dataGridView_nhom.AllowUserToAddRows = false;
            this.dataGridView_nhom.AllowUserToDeleteRows = false;
            this.dataGridView_nhom.AutoGenerateColumns = false;
            this.dataGridView_nhom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_nhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tennhom});
            this.dataGridView_nhom.DataSource = this.bindingSource_nhom;
            this.dataGridView_nhom.Location = new System.Drawing.Point(8, 29);
            this.dataGridView_nhom.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_nhom.Name = "dataGridView_nhom";
            this.dataGridView_nhom.ReadOnly = true;
            this.dataGridView_nhom.RowHeadersWidth = 51;
            this.dataGridView_nhom.RowTemplate.Height = 24;
            this.dataGridView_nhom.Size = new System.Drawing.Size(188, 516);
            this.dataGridView_nhom.TabIndex = 1;
            this.dataGridView_nhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_nhom_CellClick);
            this.dataGridView_nhom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_nhom_CellContentClick);
            // 
            // tennhom
            // 
            this.tennhom.DataPropertyName = "TenNhom";
            this.tennhom.HeaderText = "Tên nhóm";
            this.tennhom.MinimumWidth = 6;
            this.tennhom.Name = "tennhom";
            this.tennhom.ReadOnly = true;
            // 
            // bindingSource_nhom
            // 
            this.bindingSource_nhom.CurrentChanged += new System.EventHandler(this.bindingSource_nhom_CurrentChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton_themNhom,
            this.toolStripButton2,
            this.toolStripButton_xoaNhom,
            this.toolStripButton3,
            this.toolStripButton_themLienLac,
            this.toolStripButton4,
            this.toolStripButton_xoaLienLac,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton_themNhom
            // 
            this.toolStripButton_themNhom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_themNhom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_themNhom.Image")));
            this.toolStripButton_themNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_themNhom.Name = "toolStripButton_themNhom";
            this.toolStripButton_themNhom.Size = new System.Drawing.Size(77, 24);
            this.toolStripButton_themNhom.Text = "Thêm nhóm";
            this.toolStripButton_themNhom.Click += new System.EventHandler(this.toolStripButton_themNhom_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton_xoaNhom
            // 
            this.toolStripButton_xoaNhom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_xoaNhom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_xoaNhom.Image")));
            this.toolStripButton_xoaNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_xoaNhom.Name = "toolStripButton_xoaNhom";
            this.toolStripButton_xoaNhom.Size = new System.Drawing.Size(66, 24);
            this.toolStripButton_xoaNhom.Text = "Xóa nhóm";
            this.toolStripButton_xoaNhom.Click += new System.EventHandler(this.toolStripButton_xoaNhom_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton_themLienLac
            // 
            this.toolStripButton_themLienLac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_themLienLac.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_themLienLac.Image")));
            this.toolStripButton_themLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_themLienLac.Name = "toolStripButton_themLienLac";
            this.toolStripButton_themLienLac.Size = new System.Drawing.Size(82, 24);
            this.toolStripButton_themLienLac.Text = "Thêm liên lạc";
            this.toolStripButton_themLienLac.Click += new System.EventHandler(this.toolStripButton_themLienLac_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton_xoaLienLac
            // 
            this.toolStripButton_xoaLienLac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_xoaLienLac.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_xoaLienLac.Image")));
            this.toolStripButton_xoaLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_xoaLienLac.Name = "toolStripButton_xoaLienLac";
            this.toolStripButton_xoaLienLac.Size = new System.Drawing.Size(71, 24);
            this.toolStripButton_xoaLienLac.Text = "Xóa liên lạc";
            this.toolStripButton_xoaLienLac.Click += new System.EventHandler(this.toolStripButton_xoaLienLac_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.6F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(113, 27);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 24);
            this.toolStripLabel1.Text = "Nhập từ cần tìm";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // bindingSource_lienLac
            // 
            this.bindingSource_lienLac.CurrentChanged += new System.EventHandler(this.bindingSource_lienLac_CurrentChanged);
            // 
            // DanhBa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 552);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DanhBa";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lienLac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_nhom)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_lienLac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_themNhom;
        private System.Windows.Forms.ToolStripButton toolStripButton_xoaNhom;
        private System.Windows.Forms.ToolStripButton toolStripButton_themLienLac;
        private System.Windows.Forms.ToolStripButton toolStripButton_xoaLienLac;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_diaChi;
        private System.Windows.Forms.TextBox textBox_soDienThoai;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_ten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_lienLac;
        private System.Windows.Forms.DataGridView dataGridView_nhom;
        private System.Windows.Forms.BindingSource bindingSource_nhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhom;
        private System.Windows.Forms.BindingSource bindingSource_lienLac;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

