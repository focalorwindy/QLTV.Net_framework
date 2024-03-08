using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace quanlithuvientruongdaihoc
{
    public partial class Nhapsach : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable dtTL = new DataTable();
        string sql, constr;
        public Nhapsach()
        {
            InitializeComponent();
        }

        private void Nhapsach_MdiChildActivate(object sender, EventArgs e)
        {

        }

        private void txtmasach_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void dtpnhapsach_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLTVsoftware;Integrated Security=True");
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm mới bản ghi này không?", "Xác nhận yêu cầu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                conn.Open();
                string mapn = txtmapn.Text;
                string tenpn = txttenpn.Text;
                string masach = txtmasach.Text;
                string ngaynhap = dtpnhapsach.Text;
                string manv = txtmanv.Text;
                string soluong = txtslnhap.Text;
                string ghichu = txtghichu.Text;

                string sql = "Select MaPN, Ma_Sach, Ma_NV from THEM_PN" +
                    " where MaPN='" + mapn + "' and Ma_Sach !='" + masach +"' and Ma_NV !='" + manv +"'" ;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == false)
                {
                    MessageBox.Show("Thêm mới sách thành công");
                    txtmapn.Focus();
                    string sqls = "Insert into THEM_PN" +
                            " Values ('" + mapn + "',N'" + tenpn + "','" + masach + "'," + soluong + ",'" + ngaynhap + "','" + manv + "',N'" + ghichu + "')";
                    SqlCommand comd = new SqlCommand(sqls,conn);
                    dta.Close();
                    SqlDataReader dtr = comd.ExecuteReader();
                    //comd.Connection = conn;
                    //comd.CommandText = sqls;
                    //comd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Thêm mới KHÔNG thành công. Mời bạn kiểm tra lại!");
                }

            }    
        }

        private void btnhoantac_Click(object sender, EventArgs e)
        {
            txtmapn.Clear();
            txttenpn.Clear();
            txtmasach.Clear();
            dtpnhapsach.ResetText();
            txtghichu.Clear();
            txtslnhap.Clear();
            txtmanv.Clear();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn ngừng thêm phiếu nhập","Xác nhận yêu cầu",MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            this.Close();
        }

        private void cmtloaisach_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Nhapsach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }

        private void Nhapsach_Load(object sender, EventArgs e)
        {
            constr = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            string sql = "Select ns.MaPN, TenPN, Ma_Sach, So_Luong_Nhap, Ngay_Nhap, Ma_NV, Ghi_Chu into THEM_PN " +
                "from NHAP_SACH ns join CT_NHAP_SACH ct on ns.MaPN = ct.MaPN";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
           // da.Fill(dt);
        }


    }
}
