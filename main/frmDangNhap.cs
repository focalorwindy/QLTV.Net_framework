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
    public partial class frmDangNhap : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();

        string sql, constr;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            sql = "Select * from DK_ADMIN where " +
                "Ten_DN='" + txtdangnhap.Text + "' and Mat_Khau='" + txtmatkhau.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                //GỌI FORM HOME RA
                Home frmhome = new Home();
                frmhome.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công! Sai tên đăng nhập hoặc mật khẩu.");
            }
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtmatkhau_TextChanged_1(object sender, EventArgs e)
        {
            if (txtmatkhau.Text != " ")
            {
                txtmatkhau.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                //Hides Textbox password
                txtmatkhau.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-S8PUTIHQ;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }
    }
}
