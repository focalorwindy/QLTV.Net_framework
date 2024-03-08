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
    public partial class bangdanhsachmuon : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;

        private void bangdanhsachmuon_Load(object sender, EventArgs e)
        {
            constr = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select pmt.MAPH_MT, pmt.So_The, Ho_Ten, Ma_Sach, So_Luong, Ma_NV, Trang_Thai, Ngay_Muon, Ngay_Tra from " +
                "THEM_PMT pmt join DOC_GIA dg on pmt.So_The = dg.So_The";
                
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgrdvdanhsach.DataSource = dt;
        }

        private void dtgvdsmuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthemmuonsach_Click(object sender, EventArgs e)
        {
            danhsachmuon f = new danhsachmuon();
            f.Show();
        }

        private void btnsuattms_Click(object sender, EventArgs e)
        {

        }

        private void btnxoasach_Click(object sender, EventArgs e)
        {


            var index = dtgrdvdanhsach.CurrentCell.RowIndex;
            if (index != null)
            {
                var id = dtgrdvdanhsach.Rows[index].Cells[0].Value;
                /// message booxx
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này? (Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Bạn vừa chọn nút YES, tôi sẽ xóa ngay đây!");
                    sql = "delete from THEM_PMT " +
                        "where MaPH_MT = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    i = dtgrdvdanhsach.CurrentRow.Index;
                    dtgrdvdanhsach.Rows.RemoveAt(i);

                }
                else
                {
                    MessageBox.Show("Bạn đã chọn NO, vậy chào nhé!");
                }


            }
        }

        private void comLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comLoc.Text + " from THEM_PMT";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = comLoc.Text;
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            sql = "Select pmt.MAPH_MT, pmt.So_The, Ho_Ten, Ma_Sach, So_Luong, Ma_NV, Trang_Thai, Ngay_Muon, Ngay_Tra from " +
                "THEM_PMT pmt join DOC_GIA dg on pmt.So_The = dg.So_The " + " where " + comLoc.Text + "=N'" + comGT.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgrdvdanhsach.DataSource = dt;
            dtgrdvdanhsach.Refresh();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            sql = "select pmt.MAPH_MT, pmt.So_The, Ho_Ten, Ma_Sach, So_Luong, Ma_NV, Trang_Thai, Ngay_Muon, Ngay_Tra from " +
                "THEM_PMT pmt join DOC_GIA dg on pmt.So_The = dg.So_The";

            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgrdvdanhsach.DataSource = dt;
        }

        public bangdanhsachmuon()
        {
            InitializeComponent();
        }
    }
}
