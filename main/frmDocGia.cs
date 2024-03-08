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
    public partial class frmDocGia : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void txtsearchbar_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("So_The like '{0}%' or Ho_Ten like '%{0}%'", txtsearchbar.Text);
            //dv.RowFilter = string.Format("Ho_Ten like '%{0}%'", txtsearchbar.Text);
            dtgrdvdanhsach.DataSource = dv.ToTable();
        }

        private void txtsearchbar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("So_The like '{0}%' or Ho_Ten like '%{0}%'", txtsearchbar.Text);
                //dv.RowFilter = string.Format("Ho_Ten like '%{0}%'", txtsearchbar.Text);
                dtgrdvdanhsach.DataSource = dv.ToTable();
            }    
                
        }

        private void btnsuasach_Click(object sender, EventArgs e)
        {
            dkthanhvien dk = new dkthanhvien();
            
           
            
            /*cmd.Connection = conn;
            frmThemDocGia them = new frmThemDocGia();
            

            for (i = 0; i <= dtgrdvdanhsach.RowCount - 2; i++)
            {
                them.txtsothe = dtgrdvdanhsach.Rows[i].Cells["So_The"].Value.ToString();
                them.txthoten.Text = dtgrdvdanhsach.Rows[i].Cells["Ho_Ten"].Value.ToString();
                them.txtnamsinh.Text = dtgrdvdanhsach.Rows[i].Cells["Nam_Sinh"].Value.ToString();
                them.dttbngaycapthe.Text = dtgrdvdanhsach.Rows[i].Cells["Ngay_Cap"].Value.ToString();
                them.txtnghenghiep.Text = dtgrdvdanhsach.Rows[i].Cells["Nghe_Nghiep"].Value.ToString();
                them.txtdiachi.Text = dtgrdvdanhsach.Rows[i].Cells["Dia_Chi"].Value.ToString();
                them.txtsdt.Text = dtgrdvdanhsach.Rows[i].Cells["SDT"].Value.ToString();
                sql = "Update DOC_GIA set Ho_Ten = N'" + them.txthoten.Text + "', Nam_Sinh=N'" + them.txtnamsinh.Text + "',Ngay_Cap=N'" + them.dttbngaycapthe.Text
                    + "',Nghe_Nghiep=N'" + them.txtnghenghiep.Text + "',Dia_Chi=N'" + them.txtdiachi.Text + "',SDT=N'" + them.txtsdt.Text
                    + "'where So_The= '" + them.txtsothe.Text + "'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            } */

            /*sql = "Update DOC_GIA set So_The = '" + txtsothe.Text + "', Dvt=N'" + txtDvt + ",SanXuat=N'" + txtSanXuat.Text + "'"
                    + "where MaHH= '" + txtMaHH.Text + "'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            i = dtgrdvdanhsach.CurrentRow.Index;
            dtgrdvdanhsach.Rows[i].Cells["So_The"].Value = txtsothe.Text;
            dtgrdvdanhsach.Rows[i].Cells["Ho_Ten"].Value = dtgrdvdanhsach.CurrentCell.Value;
            dtgrdvdanhsach.Rows[i].Cells["Nam_Sinh"].Value = txtTenHH.Text;
            dtgrdvdanhsach.Rows[i].Cells["Nghe_Nghiep"].Value = txtDvt.Text;
            dtgrdvdanhsach.Rows[i].Cells["Ngay_Cap"].Value = txtSanXuat.Text;
            dtgrdvdanhsach.Rows[i].Cells["Dia_Chi"].Value = txtSanXuat.Text;
            dtgrdvdanhsach.Rows[i].Cells["SDT"].Value = txtSanXuat.Text;*/
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            sql = "Select * from DOC_GIA " + "where " + comLoc.Text + "=N'" + comGT.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgrdvdanhsach.DataSource = dt;
            dtgrdvdanhsach.Refresh();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            string sql = "Select * from DOC_GIA";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgrdvdanhsach.DataSource = dt;
        }

        private void comLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comLoc.Text + " From DOC_GIA";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = comLoc.Text;
        }

        private void btnthemsach_Click(object sender, EventArgs e)
        {
            frmThemDocGia f = new frmThemDocGia();
            f.Show();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            constr = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            string sql = "Select * from DOC_GIA";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgrdvdanhsach.DataSource = dt;
        }
    }
}
