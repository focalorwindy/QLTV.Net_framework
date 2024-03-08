using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace quanlithuvientruongdaihoc
{
    public partial class frmThemAdmin : Form
    {
        string tendangnhap="", tenadmin="", matkhau="", quyen="";

        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        //SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();

        string sql, sqls, constr;
        public frmThemAdmin()
        {
            InitializeComponent();
        }

       /* public frmThemAdmin(string tendangnhap, string tenadmin, string matkhau, string quyen)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.tenadmin = tenadmin;
            this.matkhau = matkhau;
            this.quyen = quyen;
        }*/

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn ngừng thêm Admin", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn thêm mới bản ghi này không?", "Xác nhận yêu cầu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //conn.Open();
                string dn = txtdn.Text;
                string mk = txtmk.Text;
                string hoten = txthoten.Text;
                string ngaysinh = dtpngaysinh.Text;
                string gioitinh = comgioitinh.Text;
                string email = txtemail.Text;
                string sdt = txtsdt.Text;

                sql = "Select Ten_DN from DK_ADMIN" +
                    " where Ten_DN='" + dn + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == false)
                {
                    MessageBox.Show("Thêm mới Admin thành công");
                    txtdn.Focus();
                    sqls = "Insert into DK_ADMIN " +
                            " Values ('" + dn + "','" + mk + "',N'" + hoten + "','" + ngaysinh + "',N'" + gioitinh + "','" + email + "','" + sdt + "')";
                    SqlCommand comd = new SqlCommand(sqls, conn);
                    dta.Close();
                    SqlDataReader dtr = comd.ExecuteReader();
                    //comd.Connection = conn;
                    //comd.CommandText = sqls;
                    //comd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Thêm mới KHÔNG thành công. Mời bạn kiểm tra lại thông tin!");
                }
            }
        }

        private void dtpngaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmThemAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }

        private void btnhoantac_Click(object sender, EventArgs e)
        {
            txtdn.Clear();
            txtmk.Clear();
            txthoten.Clear();
            comgioitinh.ResetText();
            txtemail.Clear();
            txtsdt.Clear();
            dtpngaysinh.ResetText();
        }

        private void frmThemAdmin_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-S8PUTIHQ;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }
    }
}
