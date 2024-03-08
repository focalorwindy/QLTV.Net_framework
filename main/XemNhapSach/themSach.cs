using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlithuvientruongdaihoc.XemNhapSach
{
    public partial class themSach : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        public themSach()
        {
            InitializeComponent();
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

        private void themSach_MdiChildActivate(object sender, EventArgs e)
        {

        }

        private void themSach_Load(object sender, EventArgs e)
        {
            constr = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }

        private void themSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm mới bản ghi này không?", "Xác nhận yêu cầu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //btnok.Enabled = false;
                txtmasach.Focus();
                sql = "Insert into SACH " +
                        " Values ('" + txtmasach.Text + "',N'" + txttensach.Text + "','" + txtmatl.Text + "','" + txtmanxb.Text + "','" + txtmatg.Text + "',N'" + txtngonngu.Text + "'," + txtgiabia.Text + "," + txtsotrang.Text + "," + txtnamxb.Text + "," + txtsoluong.Text + ",N'" + txtghichu.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
