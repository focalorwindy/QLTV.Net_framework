using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace quanlithuvientruongdaihoc
{

    public partial class Home : Form
    {
        private int bordersize = 3;
        private Size formsize;
        private Form activeForm;
        private Button currentButton ;
        public Home()
        {
            InitializeComponent();
            CollapseMenu();
            hidesubmenu();
            Csdesing();
            this.Padding = new Padding(bordersize);
            this.BackColor = Color.FromArgb(98, 102, 244);
            btnclosechildF.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            // ReleaseCapture();
            // SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Csdesing()
        {
            pnmuonsachsubmenu.Visible = false;
            pnsubmenuthongke.Visible = false;
        }
        private void hidesubmenu()
        {
            if (pnmuonsachsubmenu.Visible == true)
                pnmuonsachsubmenu.Visible = false;
            if (pnsubmenuthongke.Visible == true)
                pnsubmenuthongke.Visible = false;
        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

        }
        private void CollapseMenu()
        {
            if (this.pnmenu.Width > 190)
            {
                pnmenu.Width = 60;
                btnhome.Width = btnhome.MinimumSize.Width;
                btnhome.Dock = DockStyle.Top;
                foreach (Button menubutton in pnmenu.Controls.OfType<Button>())
                {
                    menubutton.Text = "";
                    menubutton.ImageAlign = ContentAlignment.MiddleCenter;
                    menubutton.Padding = new Padding(0, 0, 0, 0);
                }
            }
            else
            {
                pnmenu.Width = 200;
                btnhome.Width = btnhome.MaximumSize.Width;
                foreach (Button menubutton in pnmenu.Controls.OfType<Button>())
                {
                    menubutton.Text = "   " + menubutton.Tag.ToString();
                    menubutton.ImageAlign = ContentAlignment.MiddleLeft;
                    menubutton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        private void btnmuonsach_Click(object sender, EventArgs e)
        {
            showsubmenu(pnmuonsachsubmenu);
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            showsubmenu(pnsubmenuthongke);
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void pntitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != bordersize)
                        this.Padding = new Padding(bordersize);
                    break;
            }
        }

        private void icontaskbar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconzoom_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formsize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formsize;
            }

        }

        private void iconexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnchildform.Controls.Add(childForm);
            this.pnchildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            titlebar.Text = childForm.Text;
            btnclosechildF.Visible = true;
        }

        private void btnnhapsach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Searchsach());
            
        }

        private void btntaikhoan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnclosechildF_Click(object sender, EventArgs e)
        {
            
            if (activeForm != null) ;
            activeForm.Close();
            annut();
        }
        private void annut()
        {
            titlebar.Text = "HOME";
            btnclosechildF.Visible = false;
            currentButton = null;
        }

        private void btndsmuon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new bangdanhsachmuon());
        }

        private void pnchildform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncaidat_Click(object sender, EventArgs e)
        {

        }

        private void btnhelp_Click(object sender, EventArgs e)
        {

        }
    }
}
