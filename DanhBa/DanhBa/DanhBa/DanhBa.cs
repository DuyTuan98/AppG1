using DanhBa.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhBa
{
    public partial class DanhBa : Form
    {
        public static string pathDataGroup;
        public static string pathDataContact;
        public static List<Nhom> listNhom;
        
        public DanhBa()
        {
            InitializeComponent();
            
            pathDataGroup = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\")) + @"Data\nhom.data";
            pathDataContact = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\")) + @"Data\lienlac.data";

            loadNhom();
            if (dataGridView_nhom.Rows.Count > 0)
                dataGridView_nhom.Rows[0].Selected = false;
        }
        void loadNhom()
        {
            listNhom = Nhom.getListNhom(pathDataGroup);

            bindingSource_nhom.DataSource = listNhom;
            dataGridView_nhom.DataSource = bindingSource_nhom;
        }
        private void dataGridView_nhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingSource_lienLac.DataSource = LienLac.getContactList(pathDataContact, (bindingSource_nhom.Current as Nhom).MaNhom);
            dataGridView_lienLac.DataSource = bindingSource_lienLac;
            if(dataGridView_lienLac.Rows.Count>0)
                dataGridView_lienLac.Rows[0].Selected = false;
        }

        private void dataGridView_lienLac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ten.Text = (bindingSource_lienLac.Current as LienLac).TenLienLac;
            textBox_email.Text = (bindingSource_lienLac.Current as LienLac).Email;
            textBox_soDienThoai.Text = (bindingSource_lienLac.Current as LienLac).SoDienThoai;
            textBox_diaChi.Text = (bindingSource_lienLac.Current as LienLac).DiaChi;
        }

        private void toolStripButton_xoaNhom_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton_xoaLienLac_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_themLienLac_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_themNhom_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView_lienLac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_diaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_soDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_nhom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource_nhom_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource_lienLac_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
