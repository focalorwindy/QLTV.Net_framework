
namespace quanlithuvientruongdaihoc.XemNhapSach
{
    partial class dsAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgrdvdanhsach = new System.Windows.Forms.DataGridView();
            this.Ten_DN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioi_Tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsearchbar = new System.Windows.Forms.TextBox();
            this.btnthemadmin = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnsuaadmin = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnxoaadmin = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.button_WOC1 = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.comLoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_WOC3 = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.btnloc = new quanlithuvientruongdaihoc.model.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdvdanhsach
            // 
            this.dtgrdvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvdanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten_DN,
            this.Ho_Ten,
            this.Ngay_Sinh,
            this.Gioi_Tinh,
            this.Email,
            this.SDT});
            this.dtgrdvdanhsach.Location = new System.Drawing.Point(53, 244);
            this.dtgrdvdanhsach.Name = "dtgrdvdanhsach";
            this.dtgrdvdanhsach.RowHeadersWidth = 72;
            this.dtgrdvdanhsach.RowTemplate.Height = 33;
            this.dtgrdvdanhsach.Size = new System.Drawing.Size(1293, 540);
            this.dtgrdvdanhsach.TabIndex = 1;
            // 
            // Ten_DN
            // 
            this.Ten_DN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ten_DN.DataPropertyName = "Ten_DN";
            this.Ten_DN.HeaderText = "Tên đăng nhập";
            this.Ten_DN.MinimumWidth = 9;
            this.Ten_DN.Name = "Ten_DN";
            this.Ten_DN.Width = 135;
            // 
            // Ho_Ten
            // 
            this.Ho_Ten.DataPropertyName = "Ho_Ten";
            this.Ho_Ten.HeaderText = "Họ và tên";
            this.Ho_Ten.MinimumWidth = 9;
            this.Ho_Ten.Name = "Ho_Ten";
            this.Ho_Ten.Width = 175;
            // 
            // Ngay_Sinh
            // 
            this.Ngay_Sinh.DataPropertyName = "Ngay_Sinh";
            this.Ngay_Sinh.HeaderText = "Ngày sinh";
            this.Ngay_Sinh.MinimumWidth = 9;
            this.Ngay_Sinh.Name = "Ngay_Sinh";
            this.Ngay_Sinh.Width = 175;
            // 
            // Gioi_Tinh
            // 
            this.Gioi_Tinh.DataPropertyName = "Gioi_Tinh";
            this.Gioi_Tinh.HeaderText = "Giới tính";
            this.Gioi_Tinh.MinimumWidth = 9;
            this.Gioi_Tinh.Name = "Gioi_Tinh";
            this.Gioi_Tinh.Width = 175;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 9;
            this.Email.Name = "Email";
            this.Email.Width = 175;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 9;
            this.SDT.Name = "SDT";
            this.SDT.Width = 175;
            // 
            // txtsearchbar
            // 
            this.txtsearchbar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsearchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchbar.Location = new System.Drawing.Point(194, 37);
            this.txtsearchbar.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearchbar.Multiline = true;
            this.txtsearchbar.Name = "txtsearchbar";
            this.txtsearchbar.Size = new System.Drawing.Size(909, 49);
            this.txtsearchbar.TabIndex = 4;
            this.txtsearchbar.TextChanged += new System.EventHandler(this.txtsearchbar_TextChanged);
            // 
            // btnthemadmin
            // 
            this.btnthemadmin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnthemadmin.BorderColor = System.Drawing.Color.Transparent;
            this.btnthemadmin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(223)))));
            this.btnthemadmin.FlatAppearance.BorderSize = 0;
            this.btnthemadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthemadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemadmin.ForeColor = System.Drawing.Color.Transparent;
            this.btnthemadmin.Location = new System.Drawing.Point(1404, 222);
            this.btnthemadmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnthemadmin.Name = "btnthemadmin";
            this.btnthemadmin.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnthemadmin.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnthemadmin.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnthemadmin.Size = new System.Drawing.Size(168, 98);
            this.btnthemadmin.TabIndex = 18;
            this.btnthemadmin.Text = "Thêm";
            this.btnthemadmin.TextColor = System.Drawing.Color.White;
            this.btnthemadmin.UseVisualStyleBackColor = true;
            this.btnthemadmin.Click += new System.EventHandler(this.btnthemsach_Click);
            // 
            // btnsuaadmin
            // 
            this.btnsuaadmin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnsuaadmin.BorderColor = System.Drawing.Color.Transparent;
            this.btnsuaadmin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(224)))), ((int)(((byte)(148)))));
            this.btnsuaadmin.FlatAppearance.BorderSize = 0;
            this.btnsuaadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuaadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuaadmin.Location = new System.Drawing.Point(1404, 379);
            this.btnsuaadmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnsuaadmin.Name = "btnsuaadmin";
            this.btnsuaadmin.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnsuaadmin.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnsuaadmin.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnsuaadmin.Size = new System.Drawing.Size(168, 98);
            this.btnsuaadmin.TabIndex = 20;
            this.btnsuaadmin.Text = "Sửa";
            this.btnsuaadmin.TextColor = System.Drawing.Color.White;
            this.btnsuaadmin.UseVisualStyleBackColor = true;
            // 
            // btnxoaadmin
            // 
            this.btnxoaadmin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnxoaadmin.BorderColor = System.Drawing.Color.Transparent;
            this.btnxoaadmin.ButtonColor = System.Drawing.Color.Red;
            this.btnxoaadmin.FlatAppearance.BorderSize = 0;
            this.btnxoaadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoaadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoaadmin.Location = new System.Drawing.Point(1404, 539);
            this.btnxoaadmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoaadmin.Name = "btnxoaadmin";
            this.btnxoaadmin.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnxoaadmin.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnxoaadmin.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnxoaadmin.Size = new System.Drawing.Size(168, 98);
            this.btnxoaadmin.TabIndex = 19;
            this.btnxoaadmin.Text = "Xóa";
            this.btnxoaadmin.TextColor = System.Drawing.Color.White;
            this.btnxoaadmin.UseVisualStyleBackColor = true;
            this.btnxoaadmin.Click += new System.EventHandler(this.btnxoaadmin_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(223)))));
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(1112, 37);
            this.button_WOC1.Margin = new System.Windows.Forms.Padding(4);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(165, 50);
            this.button_WOC1.TabIndex = 5;
            this.button_WOC1.Text = "Search";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            // 
            // comLoc
            // 
            this.comLoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comLoc.DropDownWidth = 180;
            this.comLoc.FormattingEnabled = true;
            this.comLoc.Items.AddRange(new object[] {
            "Ten_DN",
            "Ho_Ten",
            "Gioi_Tinh"});
            this.comLoc.Location = new System.Drawing.Point(235, 116);
            this.comLoc.Margin = new System.Windows.Forms.Padding(4);
            this.comLoc.Name = "comLoc";
            this.comLoc.Size = new System.Drawing.Size(214, 29);
            this.comLoc.TabIndex = 21;
            this.comLoc.SelectedIndexChanged += new System.EventHandler(this.comLoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Giá trị lọc:";
            // 
            // button_WOC3
            // 
            this.button_WOC3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_WOC3.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC3.ButtonColor = System.Drawing.Color.Red;
            this.button_WOC3.FlatAppearance.BorderSize = 0;
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC3.Location = new System.Drawing.Point(494, 168);
            this.button_WOC3.Margin = new System.Windows.Forms.Padding(4);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC3.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC3.Size = new System.Drawing.Size(110, 52);
            this.button_WOC3.TabIndex = 26;
            this.button_WOC3.Text = "Hủy";
            this.button_WOC3.TextColor = System.Drawing.Color.White;
            this.button_WOC3.UseVisualStyleBackColor = true;
            this.button_WOC3.Click += new System.EventHandler(this.button_WOC3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bộ lọc:";
            // 
            // comGT
            // 
            this.comGT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comGT.DropDownHeight = 150;
            this.comGT.DropDownWidth = 180;
            this.comGT.FormattingEnabled = true;
            this.comGT.IntegralHeight = false;
            this.comGT.Location = new System.Drawing.Point(235, 183);
            this.comGT.Margin = new System.Windows.Forms.Padding(4);
            this.comGT.MaxDropDownItems = 10;
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(214, 29);
            this.comGT.TabIndex = 22;
            // 
            // btnloc
            // 
            this.btnloc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnloc.BorderColor = System.Drawing.Color.Transparent;
            this.btnloc.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(223)))));
            this.btnloc.FlatAppearance.BorderSize = 0;
            this.btnloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloc.Location = new System.Drawing.Point(494, 108);
            this.btnloc.Margin = new System.Windows.Forms.Padding(4);
            this.btnloc.Name = "btnloc";
            this.btnloc.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnloc.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnloc.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnloc.Size = new System.Drawing.Size(110, 52);
            this.btnloc.TabIndex = 25;
            this.btnloc.Text = "Lọc";
            this.btnloc.TextColor = System.Drawing.Color.White;
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // dsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1628, 844);
            this.Controls.Add(this.comLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_WOC3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comGT);
            this.Controls.Add(this.btnloc);
            this.Controls.Add(this.btnthemadmin);
            this.Controls.Add(this.btnsuaadmin);
            this.Controls.Add(this.btnxoaadmin);
            this.Controls.Add(this.txtsearchbar);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.dtgrdvdanhsach);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "dsAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách Admin";
            this.Load += new System.EventHandler(this.dsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgrdvdanhsach;
        private System.Windows.Forms.TextBox txtsearchbar;
        private model.Button_WOC button_WOC1;
        private model.Button_WOC btnthemadmin;
        private model.Button_WOC btnsuaadmin;
        private model.Button_WOC btnxoaadmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_DN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioi_Tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.ComboBox comLoc;
        private System.Windows.Forms.Label label2;
        private model.Button_WOC button_WOC3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comGT;
        private model.Button_WOC btnloc;
    }
}