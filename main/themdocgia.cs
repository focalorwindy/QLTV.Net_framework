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
    public partial class themdocgia : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        public themdocgia()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm mới bản ghi này không?", "Xác nhận yêu cầu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //btnok.Enabled = false;
                txthoten.Focus();
                sql = "Insert into DOC_GIA (So_The, Ho_Ten, Nam_Sinh, Ngay_Cap, Nghe_Nghiep, Dia_Chi, SDT)" +
                        " Values ('" + txtsothe.Text + "',N'" + txthoten.Text + "'," + txtnamsinh.Text + ",'" + dttbngaycapthe.Text + "',N'" + txtnghenghiep.Text + "',N'" + txtdiachi.Text + "','" + txtsdt.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
        }

        private void btnhoantac_Click(object sender, EventArgs e)
        {
            txthoten.Clear();
            txtdiachi.Clear();
            txtnamsinh.Clear();
            txtnghenghiep.Clear();
            txtsdt.Clear();
            txtsothe.Clear();
            dttbngaycapthe.ResetText();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn ngừng thêm độc giả", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void themdocgia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }

        private void dttbngaycapthe_ValueChanged(object sender, EventArgs e)
        {

        }

        private void themdocgia_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-S8PUTIHQ;Initial Catalog=QLTVsoftware;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }
    }
}
