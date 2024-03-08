using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlithuvientruongdaihoc
{
    public partial class addBook : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        public addBook()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string masach = txtmasach.Text;
            string tensach = txttensach.Text;
            string matl = txtmatl.Text;
            string manxb = txtmanxb.Text;
            string matg = txtmatg.Text;
            string ngonngu = txtngonngu.Text;
            string giabia = txtgiabia.Text;
            string sotrang = txtsotrang.Text;
            string namxb = txtnamxb.Text;
            string sl = txtsoluong.Text;
            string ghichu = txtghichu.Text;


            sql = "Select Ma_Sach from SACH" +
                " where Ma_Sach='" + masach + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == false && MessageBox.Show("Bạn có chắc chắn muốn thêm mới bản ghi này không?", "Xác nhận yêu cầu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới sách thành công");
                txtmasach.Focus();
                string sqls = "Insert into SACH " +
                        " Values ('" + masach + "',N'" + tensach + "','" + matl + "','" + manxb + "','" + matg + "',N'" + ngonngu + "'," + giabia + "," + sotrang + "," + namxb + ","+ sl + ",N'"+ ghichu + "')";
                SqlCommand comd = new SqlCommand(sqls, conn);
                dta.Close();
                SqlDataReader dtr = comd.ExecuteReader();
            }
            else
            {
                MessageBox.Show("Thêm mới sách không thành công. Mời bạn kiểm tra lại thông tin!");
            }
        }

        private void btnhoantac_Click(object sender, EventArgs e)
        {
            txtmasach.Clear();
            txttensach.Clear();
            txtmatg.Clear();
            txtmatl.Clear();
            txtnamxb.Clear();
            txtngonngu.Clear();
            txtsoluong.Clear();
            txtsotrang.Clear();
            txtnamxb.Clear();
            txtgiabia.Clear();
            txtghichu.Clear();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn ngừng thêm thông tin sách", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void addBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }

        private void addBook_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-S8PUTIHQ;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }
    }
}
