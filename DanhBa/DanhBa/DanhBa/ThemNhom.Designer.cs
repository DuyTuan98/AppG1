namespace DanhBa
{
    partial class ThemNhom
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_tenNhom = new System.Windows.Forms.TextBox();
            this.button_Them = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhóm";
            // 
            // textBox_tenNhom
            // 
            this.textBox_tenNhom.Location = new System.Drawing.Point(201, 79);
            this.textBox_tenNhom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_tenNhom.Name = "textBox_tenNhom";
            this.textBox_tenNhom.Size = new System.Drawing.Size(76, 20);
            this.textBox_tenNhom.TabIndex = 1;
            this.textBox_tenNhom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(201, 116);
            this.button_Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(56, 19);
            this.button_Them.TabIndex = 2;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // ThemNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 184);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.textBox_tenNhom);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThemNhom";
            this.Text = "ThemNhom";
            this.Load += new System.EventHandler(this.ThemNhom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_tenNhom;
        private System.Windows.Forms.Button button_Them;
    }
}