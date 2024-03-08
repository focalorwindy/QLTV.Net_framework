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
    public partial class Docgia : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataSet dataset = new DataSet();
        themdocgia tdg = new themdocgia();
        string sql, constr;
        int i;

        private void Docgia_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-S8PUTIHQ;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql= "Select So_The, Ho_Ten, Nam_Sinh, Ngay_Cap, Nghe_Nghiep, Dia_Chi, SDT from DOC_GIA";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgdvthanhvien.DataSource = dt;
        }

        private void txtsearchbarTV_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Ho_Ten like '%{0}%'", txtsearchbarTV.Text);
            dv.RowFilter = string.Format("So_The like '%{0}%'", txtsearchbarTV.Text);
            dtgdvthanhvien.DataSource = dv.ToTable();
        }

        private void btnthemmoiTV_Click(object sender, EventArgs e)
        {
            i = dtgdvthanhvien.RowCount;
            dtgdvthanhvien.CurrentCell = dtgdvthanhvien[0, i - 1];
            themdocgia themtv = new themdocgia();
            themtv.Show();
        }

        private void btnsuaTV_Click(object sender, EventArgs e)
        {

            try
            {
                cmd.Connection = conn;
                themdocgia them = new themdocgia();
                for (i = 0; i <= dtgdvthanhvien.RowCount - 2; i++)
                {
                    them.txtsothe.Text = dtgdvthanhvien.Rows[i].Cells["So_The"].Value.ToString();
                    them.txthoten.Text = dtgdvthanhvien.Rows[i].Cells["Ho_Ten"].Value.ToString();
                    them.txtnamsinh.Text = dtgdvthanhvien.Rows[i].Cells["Nam_Sinh"].Value.ToString();
                    them.dttbngaycapthe.Text = dtgdvthanhvien.Rows[i].Cells["Ngay_Cap"].Value.ToString();
                    them.txtnghenghiep.Text = dtgdvthanhvien.Rows[i].Cells["Nghe_Nghiep"].Value.ToString();
                    them.txtdiachi.Text = dtgdvthanhvien.Rows[i].Cells["Dia_Chi"].Value.ToString();
                    them.txtsdt.Text = dtgdvthanhvien.Rows[i].Cells["SDT"].Value.ToString();
                    sql = "Update DOC_GIA set Ho_Ten = N'" + them.txthoten.Text + "', Nam_Sinh=N'" + them.txtnamsinh.Text + "',Ngay_Cap=N'" + them.dttbngaycapthe.Text
                        + "',Nghe_Nghiep=N'" + them.txtnghenghiep.Text + "',Dia_Chi=N'" + them.txtdiachi.Text + "',SDT=N'" + them.txtsdt.Text
                        + "'where So_The= '" + them.txtsothe.Text + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thành công");
            }
        }

        private void btnxoaTV_Click(object sender, EventArgs e)
        {
            var index = dtgdvthanhvien.CurrentCell.RowIndex;
            if (index != null)
            {
                var id = dtgdvthanhvien.Rows[index].Cells[0].Value;
                /// message booxx
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này? (Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Bạn vừa chọn nút YES, tôi sẽ xóa ngay đây!");
                    sql = "delete from SACH where Ma_Sach = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    i = dtgdvthanhvien.CurrentRow.Index;
                    dtgdvthanhvien.Rows.RemoveAt(i);

                }
                else
                {
                    MessageBox.Show("Bạn đã chọn NO, vậy chào nhé!");
                }


            }
        }

        private void trangdauTV_Click(object sender, EventArgs e)
        {
            dtgdvthanhvien.CurrentCell = dtgdvthanhvien[0, 0];
        }

        private void trangtruocTV_Click(object sender, EventArgs e)
        {
            i = dtgdvthanhvien.CurrentRow.Index;
            if (i == 0)
            {
                dtgdvthanhvien.CurrentCell = dtgdvthanhvien[0, dtgdvthanhvien.RowCount - 1];
            }
            else
            {
                dtgdvthanhvien.CurrentCell = dtgdvthanhvien[0, i - 1];
            }
        }

        private void trangsauTV_Click(object sender, EventArgs e)
        {
            i = dtgdvthanhvien.CurrentRow.Index;
            if (i == dtgdvthanhvien.RowCount - 1)
            {
                dtgdvthanhvien.CurrentCell = dtgdvthanhvien[0, 0];
            }
            if (i < dtgdvthanhvien.RowCount - 1)
            {
                dtgdvthanhvien.CurrentCell = dtgdvthanhvien[0, i + 1];
            }
        }

        private void trangcuoiTV_Click(object sender, EventArgs e)
        {
            i = dtgdvthanhvien.RowCount;
            dtgdvthanhvien.CurrentCell = dtgdvthanhvien[0, i - 1];
        }

        private void btnxoaTV_MouseClick(object sender, MouseEventArgs e)
        {
 
        }

        public Docgia()
        {
            InitializeComponent();
        }
        
    }
}
