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
    public partial class dsAdmin : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;

        public dsAdmin()
        {
            InitializeComponent();
        }

        private void txtsearchbar_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Ho_Ten like '%{0}%' AND Ten_DN like '{0}%'", txtsearchbar.Text);
            //dv.RowFilter = string.Format("Ten_DN like '%{0}%'", txtsearchbar.Text);
            dtgrdvdanhsach.DataSource = dv.ToTable();
        }

        private void btnthemsach_Click(object sender, EventArgs e)
        {
            frmThemAdmin f = new frmThemAdmin();
            f.Show();
        }

        private void btnxoaadmin_Click(object sender, EventArgs e)
        {

            var index = dtgrdvdanhsach.CurrentCell.RowIndex;
            if (index != null)
            {
                var id = dtgrdvdanhsach.Rows[index].Cells[0].Value;
                /// message box
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này? (Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Bạn vừa chọn nút YES, tôi sẽ xóa ngay đây!");
                    sql = "delete from DK_ADMIN where Ten_DN = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    int i = dtgrdvdanhsach.CurrentRow.Index;
                    dtgrdvdanhsach.Rows.RemoveAt(i);

                }
                else
                {
                    MessageBox.Show("Bạn đã hủy xóa admin!");
                }


            }
        }

        private void comLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comLoc.Text + " from DK_ADMIN ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = comLoc.Text;
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            sql = "Select * from DK_ADMIN " + " where " + comLoc.Text + "=N'" + comGT.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgrdvdanhsach.DataSource = dt;
            dtgrdvdanhsach.Refresh();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            sql = "Select * from DK_ADMIN";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgrdvdanhsach.DataSource = dt;
        }

        private void dsAdmin_Load(object sender, EventArgs e)
        {
            constr = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select * from DK_ADMIN";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgrdvdanhsach.DataSource = dt;
        }
    }
}
