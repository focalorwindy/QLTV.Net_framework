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
    public partial class frmThemPhat : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        public frmThemPhat()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string maph = txtmaphp.Text;
            string sothe = txtsothe.Text;
            string lydo = txtlydo.Text;
            string hinhthuc = txthtp.Text;
            string ngaynop = dtpngaynop.Text;
            string trangthai = comtt.Text;
            string nmothe = dtpmothe.Text;

            sql = "Select MaPH_NP from PHIEU_NOP_PHAT" +
                " where MaPH_NP= '" + maph + "' or So_The != '" + sothe + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == false && MessageBox.Show("Bạn có chắc chắn muốn thêm mới bản ghi này không?", "Xác nhận yêu cầu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới phiếu phạt thành công");
                txtmaphp.Focus();
                string sqls = "Insert into PHIEU_NOP_PHAT " +
                        " Values ('" + maph + "','" + sothe + "',N'" + lydo + "',N'" + hinhthuc + "','" + ngaynop + "',N'" + trangthai + "','" + nmothe + "')";
                SqlCommand comd = new SqlCommand(sqls, conn);
                dta.Close();
                SqlDataReader dtr = comd.ExecuteReader();
            }
            else
            {
                MessageBox.Show("Thêm mới không thành công. Mời bạn kiểm tra lại thông tin!");
            }
        }

        private void btnhoantac_Click(object sender, EventArgs e)
        {
            txthtp.Clear();
            txtlydo.Clear();
            txtmaphp.Clear();
            txtsothe.Clear();
            dtpmothe.ResetText();
            dtpngaynop.ResetText();
            comtt.ResetText();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn ngừng thêm phiếu phạt", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void frmThemPhat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }

        private void frmThemPhat_Load(object sender, EventArgs e)
        {
            constr = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }
    }
}
