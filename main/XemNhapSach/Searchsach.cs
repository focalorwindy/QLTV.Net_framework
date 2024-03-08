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
    public partial class Searchsach : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;


        private void Searchsach_Load(object sender, EventArgs e)
        {
            constr = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            string sql = "Select S.Ma_Sach, S.Ten_Sach, TL.Ten_TL, TG.Ten_TG, Ten_NXB, Ngon_Ngu, So_Trang, Nam_XB, So_Lg, S.Ghi_Chu " +
                "from SACH S join TAC_GIA TG on S.Ma_TG=TG.Ma_TG " +
                "join THE_LOAI TL on S.Ma_TL=TL.Ma_TL " +
                "join NXB on S.Ma_NXB=NXB.Ma_NXB";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgrdvdanhsach.DataSource = dt;
        }

        private void txtsearchbar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Ten_Sach like '%{0}%'", txtsearchbar.Text);
                dtgrdvdanhsach.DataSource = dv.ToTable();
            }
        }


        private void txtsearchbar_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Ten_Sach like '%{0}%'", txtsearchbar.Text);
            dtgrdvdanhsach.DataSource = dv.ToTable();
        }

        private void button_WOC3_Click(object sender, EventArgs e)// hủylọc
        {
            string sql = "Select S.Ma_Sach, S.Ten_Sach, TL.Ten_TL, TG.Ten_TG, Ten_NXB, Ngon_Ngu, So_Trang, Nam_XB, So_Lg, S.Ghi_Chu " +
                "from SACH S join TAC_GIA TG on S.Ma_TG=TG.Ma_TG " +
                "join THE_LOAI TL on S.Ma_TL=TL.Ma_TL " +
                "join NXB on S.Ma_NXB=NXB.Ma_NXB";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgrdvdanhsach.DataSource = dt;
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
                    sql = "delete from SACH where Ma_Sach = '" + id + "'";
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

        private void dtgrdvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthemsach_Click(object sender, EventArgs e)
        {
           addBook frmthemsach=new addBook();
           frmthemsach.Show();
        }

        private void btnrfbangsach_Click(object sender, EventArgs e)
        {

        }

        private void dtgrdvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtlocsach_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void btnsuasach_Click(object sender, EventArgs e)
        {
            
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            sql = "Select S.Ma_Sach, S.Ten_Sach,  TL.Ten_TL, TG.Ten_TG, Ten_NXB, Ngon_Ngu, So_Trang, Nam_XB, So_Lg, S.Ghi_Chu" +
                 " from SACH S join TAC_GIA TG on S.Ma_TG=TG.Ma_TG " +
                 "join THE_LOAI TL on S.Ma_TL=TL.Ma_TL " +
                 "join NXB on S.Ma_NXB=NXB.Ma_NXB " + " where " + comLoc.Text + "=N'" + comGT.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgrdvdanhsach.DataSource = dt;
            dtgrdvdanhsach.Refresh();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void comLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comLoc.Text + " from SACH S join TAC_GIA TG on S.Ma_TG=TG.Ma_TG " +
                "join THE_LOAI TL on S.Ma_TL=TL.Ma_TL " +
                "join NXB on S.Ma_NXB=NXB.Ma_NXB  ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = comLoc.Text;
        }

        private void comGT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trangtruocds_Click(object sender, EventArgs e)
        {

        }

        public Searchsach()
        {
            InitializeComponent();
        }
    }
}
