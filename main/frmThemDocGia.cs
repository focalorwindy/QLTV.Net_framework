using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace quanlithuvientruongdaihoc
{
    public partial class frmThemDocGia : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        public frmThemDocGia()
        {
            InitializeComponent();
        }

        private void btnhoantac_Click(object sender, EventArgs e)
        {
            txtdiachi.Clear();
            txthoten.Clear();
            txtsothe.Clear();
            txtsdt.Clear();
            dtpngaycap.ResetText();
            txtnamsinh.Clear();
            txtnghenghiep.Clear();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn ngừng thêm độc giả", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void frmThemDocGia_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-S8PUTIHQ;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }

        private void frmThemDocGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string sothe = txtsothe.Text;
            string hoten = txthoten.Text;
            string namsinh = txtnamsinh.Text;
            string ngaycap = dtpngaycap.Text;
            string nghenghiep = txtnghenghiep.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;

            sql = "Select So_The from DOC_GIA" +
                " where So_The='" + sothe + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == false && MessageBox.Show("Bạn có chắc chắn muốn thêm mới bản ghi này không?", "Xác nhận yêu cầu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới độc giả thành công");
                txtsothe.Focus();
                string sqls = "Insert into DOC_GIA " +
                        " Values ('" + sothe + "',N'" + hoten + "'," + namsinh + ",'" + ngaycap + "',N'" + nghenghiep + "',N'" + diachi + "','" + sdt + "')";
                SqlCommand comd = new SqlCommand(sqls, conn);
                dta.Close();
                SqlDataReader dtr = comd.ExecuteReader();
            }
            else
            {
                MessageBox.Show("Thêm mới độc giả không thành công. Mời bạn kiểm tra lại thông tin!");
            }
        }
           
        }
    }

