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
    public partial class danhsachmuon : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable dtMaph = new DataTable();
        string sql, constr;
        public danhsachmuon()
        {
            InitializeComponent();
        }

        private void danhsachmuon_Load(object sender, EventArgs e)
        {
            constr = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            string sql = "Select pmt.MaPH_MT, So_The, Ma_Sach, So_Luong, Trang_Thai, Ngay_Muon, Ngay_Tra, Ma_NV into THEM_PMT " +
                " from PHIEU_MUON_TRA pmt join CT_PHIEU_MUON_TRA ct" +
                " on pmt.MaPH_MT = ct.MaPH_MT";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            //da.Fill(dt);
            
        }

        private void danhsachmuon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }

        private void btnquaylaiphieumuon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn ngừng cập nhật phiếu mượn", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnhoantacphieumuon_Click(object sender, EventArgs e)
        {
            txtmaph.ResetText();
            txtsothe.Clear();
            txtmasach.Clear();
            txtslmuon.Clear();
            comTTmuon.ResetText();
            dtpm.ResetText();
            dtptra.ResetText();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtvtm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmasachm_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*string ma = txtmasachm.Text;
            sql= "select *"
            if()*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comTTmuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnokphieumuon_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-S8PUTIHQ;Initial Catalog=QLTVsoftware;Integrated Security=True");
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm mới bản ghi này không?", "Xác nhận yêu cầu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                conn.Open();
                string mapmt = txtmaph.Text;
                string sothe = txtsothe.Text;
                string masach = txtmasach.Text;
                string slmuon = txtslmuon.Text;
                string ngaymuon = dtpm.Text;
                string ngaytra = dtptra.Text;
                string trangthai = comTTmuon.Text;
                string manv = txtmanv.Text;

         
                /*sql = "Select s.Ma_Sach, Ma_NV, So_The, So_Lg, So_Luong from THEM_PMT" +
                    " join SACH s on s.Ma_Sach = THEM_PMT.Ma_Sach" +
                    " where s.Ma_Sach ='" + masach + "' and Ma_NV ='" + manv + "' and So_The ='" + sothe + "' and So_Lg - " + slmuon +">= 0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();*/

                //if (dta.Read() == true)
                //{
                    MessageBox.Show("Thêm mới phiếu mượn thành công");
                    txtmaph.Focus();
                    string sql = "Insert into THEM_PMT " +
                            " Values ('" + mapmt + "','" + sothe + "','" + masach + "'," + slmuon + ",N'" + trangthai + "','" + ngaymuon + "','" + ngaytra + "','" + manv + "')";
                    //SqlCommand comd = new SqlCommand(sqls, conn);
                    //dta.Close();
                    //SqlDataReader dtr = comd.ExecuteReader();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
               // }
               //else
               //{
               //     MessageBox.Show("Thêm mới KHÔNG thành công. Mời bạn kiểm tra lại!");
               //}
            }
        }
    }
}
