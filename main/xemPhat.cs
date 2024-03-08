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
    public partial class xemPhat : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        public xemPhat()
        {
            InitializeComponent();
        }

        private void txtsearchbar_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("MaPH_NP like '{0}%' or So_The like '{%0%}'", txtsearchbar.Text);
            dtgrdvdanhsach.DataSource = dv.ToTable();
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            sql = "Select * from PHIEU_NOP_PHAT " + " where " + comLoc.Text + "=N'" + comGT.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgrdvdanhsach.DataSource = dt;
            dtgrdvdanhsach.Refresh();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            string sql = "Select * from PHIEU_NOP_PHAT";
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
                dv.RowFilter = string.Format("MaPH_NP like '{0}%' or So_The like '{%0%}'", txtsearchbar.Text);
                dtgrdvdanhsach.DataSource = dv.ToTable();
            }
        }

        private void comLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comLoc.Text + " from PHIEU_NOP_PHAT ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = comLoc.Text;
        }

        private void btnthemsach_Click(object sender, EventArgs e)
        {
            frmThemPhat frmthemphat = new frmThemPhat();
            frmthemphat.Show();
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
                    sql = "delete from PHIEU_NOP_PHAT " +
                        "where MaPH_NP = '" + id + "'";
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

        private void xemPhat_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-S8PUTIHQ;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            string sql = "Select * from PHIEU_NOP_PHAT"; 
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgrdvdanhsach.DataSource = dt;
        }
    }
}
