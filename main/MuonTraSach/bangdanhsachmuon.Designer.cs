namespace quanlithuvientruongdaihoc
{
    partial class bangdanhsachmuon
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
            this.MaPH_MT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_The = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Muon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Tra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Luong_Muon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsearchdsmuon = new System.Windows.Forms.TextBox();
            this.comLoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.button_WOC3 = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnloc = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnxoasach = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnthemmuonsach = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnsuattms = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.searchdsmuon = new quanlithuvientruongdaihoc.model.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdvdanhsach
            // 
            this.dtgrdvdanhsach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrdvdanhsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgrdvdanhsach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgrdvdanhsach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgrdvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvdanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPH_MT,
            this.So_The,
            this.Ho_Ten,
            this.Ma_Sach,
            this.Ngay_Muon,
            this.Ngay_Tra,
            this.So_Luong_Muon,
            this.Ma_NV});
            this.dtgrdvdanhsach.Location = new System.Drawing.Point(62, 238);
            this.dtgrdvdanhsach.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrdvdanhsach.Name = "dtgrdvdanhsach";
            this.dtgrdvdanhsach.RowHeadersWidth = 51;
            this.dtgrdvdanhsach.RowTemplate.Height = 24;
            this.dtgrdvdanhsach.Size = new System.Drawing.Size(1287, 683);
            this.dtgrdvdanhsach.TabIndex = 0;
            this.dtgrdvdanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvdsmuon_CellContentClick);
            // 
            // MaPH_MT
            // 
            this.MaPH_MT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaPH_MT.DataPropertyName = "MaPH_MT";
            this.MaPH_MT.HeaderText = "Mã phiếu";
            this.MaPH_MT.MinimumWidth = 6;
            this.MaPH_MT.Name = "MaPH_MT";
            this.MaPH_MT.Width = 127;
            // 
            // So_The
            // 
            this.So_The.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.So_The.DataPropertyName = "So_The";
            this.So_The.HeaderText = "Mã thẻ độc giả";
            this.So_The.MinimumWidth = 9;
            this.So_The.Name = "So_The";
            this.So_The.Width = 153;
            // 
            // Ho_Ten
            // 
            this.Ho_Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ho_Ten.DataPropertyName = "Ho_Ten";
            this.Ho_Ten.HeaderText = "Họ và tên độc giả";
            this.Ho_Ten.MinimumWidth = 6;
            this.Ho_Ten.Name = "Ho_Ten";
            this.Ho_Ten.Width = 147;
            // 
            // Ma_Sach
            // 
            this.Ma_Sach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ma_Sach.DataPropertyName = "Ma_Sach";
            this.Ma_Sach.HeaderText = "Mã sách";
            this.Ma_Sach.MinimumWidth = 6;
            this.Ma_Sach.Name = "Ma_Sach";
            this.Ma_Sach.Width = 99;
            // 
            // Ngay_Muon
            // 
            this.Ngay_Muon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ngay_Muon.DataPropertyName = "Ngay_Muon";
            this.Ngay_Muon.HeaderText = "Ngày mượn";
            this.Ngay_Muon.MinimumWidth = 6;
            this.Ngay_Muon.Name = "Ngay_Muon";
            this.Ngay_Muon.Width = 99;
            // 
            // Ngay_Tra
            // 
            this.Ngay_Tra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ngay_Tra.DataPropertyName = "Ngay_Tra";
            this.Ngay_Tra.HeaderText = "Ngày trả";
            this.Ngay_Tra.MinimumWidth = 9;
            this.Ngay_Tra.Name = "Ngay_Tra";
            this.Ngay_Tra.Width = 99;
            // 
            // So_Luong_Muon
            // 
            this.So_Luong_Muon.DataPropertyName = "So_Luong";
            this.So_Luong_Muon.HeaderText = "Số lượng mượn";
            this.So_Luong_Muon.MinimumWidth = 6;
            this.So_Luong_Muon.Name = "So_Luong_Muon";
            this.So_Luong_Muon.Width = 133;
            // 
            // Ma_NV
            // 
            this.Ma_NV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ma_NV.DataPropertyName = "Ma_NV";
            this.Ma_NV.HeaderText = "Mã nhân viên";
            this.Ma_NV.MinimumWidth = 9;
            this.Ma_NV.Name = "Ma_NV";
            this.Ma_NV.Width = 129;
            // 
            // txtsearchdsmuon
            // 
            this.txtsearchdsmuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsearchdsmuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchdsmuon.Location = new System.Drawing.Point(179, 47);
            this.txtsearchdsmuon.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearchdsmuon.Multiline = true;
            this.txtsearchdsmuon.Name = "txtsearchdsmuon";
            this.txtsearchdsmuon.Size = new System.Drawing.Size(909, 49);
            this.txtsearchdsmuon.TabIndex = 4;
            // 
            // comLoc
            // 
            this.comLoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comLoc.DropDownWidth = 180;
            this.comLoc.FormattingEnabled = true;
            this.comLoc.Items.AddRange(new object[] {
            "MaPH_MT",
            "So_The",
            "Ho_Ten",
            "Ma_Sach",
            "Ma_NV",
            "Trang_Thai"});
            this.comLoc.Location = new System.Drawing.Point(219, 115);
            this.comLoc.Margin = new System.Windows.Forms.Padding(4);
            this.comLoc.Name = "comLoc";
            this.comLoc.Size = new System.Drawing.Size(214, 29);
            this.comLoc.TabIndex = 22;
            this.comLoc.SelectedIndexChanged += new System.EventHandler(this.comLoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Giá trị lọc:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Bộ lọc:";
            // 
            // comGT
            // 
            this.comGT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comGT.DropDownHeight = 150;
            this.comGT.DropDownWidth = 180;
            this.comGT.FormattingEnabled = true;
            this.comGT.IntegralHeight = false;
            this.comGT.Location = new System.Drawing.Point(219, 182);
            this.comGT.Margin = new System.Windows.Forms.Padding(4);
            this.comGT.MaxDropDownItems = 10;
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(214, 29);
            this.comGT.TabIndex = 23;
            // 
            // button_WOC3
            // 
            this.button_WOC3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_WOC3.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC3.ButtonColor = System.Drawing.Color.Red;
            this.button_WOC3.FlatAppearance.BorderSize = 0;
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC3.Location = new System.Drawing.Point(478, 167);
            this.button_WOC3.Margin = new System.Windows.Forms.Padding(4);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC3.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC3.Size = new System.Drawing.Size(110, 52);
            this.button_WOC3.TabIndex = 27;
            this.button_WOC3.Text = "Hủy";
            this.button_WOC3.TextColor = System.Drawing.Color.White;
            this.button_WOC3.UseVisualStyleBackColor = true;
            this.button_WOC3.Click += new System.EventHandler(this.button_WOC3_Click);
            // 
            // btnloc
            // 
            this.btnloc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnloc.BorderColor = System.Drawing.Color.Transparent;
            this.btnloc.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(223)))));
            this.btnloc.FlatAppearance.BorderSize = 0;
            this.btnloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloc.Location = new System.Drawing.Point(478, 107);
            this.btnloc.Margin = new System.Windows.Forms.Padding(4);
            this.btnloc.Name = "btnloc";
            this.btnloc.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnloc.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnloc.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnloc.Size = new System.Drawing.Size(110, 52);
            this.btnloc.TabIndex = 26;
            this.btnloc.Text = "Lọc";
            this.btnloc.TextColor = System.Drawing.Color.White;
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // btnxoasach
            // 
            this.btnxoasach.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnxoasach.BorderColor = System.Drawing.Color.Transparent;
            this.btnxoasach.ButtonColor = System.Drawing.Color.Red;
            this.btnxoasach.FlatAppearance.BorderSize = 0;
            this.btnxoasach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoasach.Location = new System.Drawing.Point(1370, 537);
            this.btnxoasach.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoasach.Name = "btnxoasach";
            this.btnxoasach.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnxoasach.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnxoasach.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnxoasach.Size = new System.Drawing.Size(168, 98);
            this.btnxoasach.TabIndex = 21;
            this.btnxoasach.Text = "Xóa";
            this.btnxoasach.TextColor = System.Drawing.Color.White;
            this.btnxoasach.UseVisualStyleBackColor = true;
            this.btnxoasach.Click += new System.EventHandler(this.btnxoasach_Click);
            // 
            // btnthemmuonsach
            // 
            this.btnthemmuonsach.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnthemmuonsach.BorderColor = System.Drawing.Color.Transparent;
            this.btnthemmuonsach.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(223)))));
            this.btnthemmuonsach.FlatAppearance.BorderSize = 0;
            this.btnthemmuonsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthemmuonsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemmuonsach.ForeColor = System.Drawing.Color.Transparent;
            this.btnthemmuonsach.Location = new System.Drawing.Point(1370, 211);
            this.btnthemmuonsach.Margin = new System.Windows.Forms.Padding(4);
            this.btnthemmuonsach.Name = "btnthemmuonsach";
            this.btnthemmuonsach.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnthemmuonsach.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnthemmuonsach.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnthemmuonsach.Size = new System.Drawing.Size(168, 98);
            this.btnthemmuonsach.TabIndex = 18;
            this.btnthemmuonsach.Text = "Thêm";
            this.btnthemmuonsach.TextColor = System.Drawing.Color.White;
            this.btnthemmuonsach.UseVisualStyleBackColor = true;
            this.btnthemmuonsach.Click += new System.EventHandler(this.btnthemmuonsach_Click);
            // 
            // btnsuattms
            // 
            this.btnsuattms.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnsuattms.BorderColor = System.Drawing.Color.Transparent;
            this.btnsuattms.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(224)))), ((int)(((byte)(148)))));
            this.btnsuattms.FlatAppearance.BorderSize = 0;
            this.btnsuattms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuattms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuattms.Location = new System.Drawing.Point(1370, 374);
            this.btnsuattms.Margin = new System.Windows.Forms.Padding(4);
            this.btnsuattms.Name = "btnsuattms";
            this.btnsuattms.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnsuattms.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnsuattms.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnsuattms.Size = new System.Drawing.Size(168, 98);
            this.btnsuattms.TabIndex = 20;
            this.btnsuattms.Text = "Sửa";
            this.btnsuattms.TextColor = System.Drawing.Color.White;
            this.btnsuattms.UseVisualStyleBackColor = true;
            this.btnsuattms.Click += new System.EventHandler(this.btnsuattms_Click);
            // 
            // searchdsmuon
            // 
            this.searchdsmuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchdsmuon.BorderColor = System.Drawing.Color.Transparent;
            this.searchdsmuon.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(223)))));
            this.searchdsmuon.FlatAppearance.BorderSize = 0;
            this.searchdsmuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchdsmuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchdsmuon.Location = new System.Drawing.Point(1097, 47);
            this.searchdsmuon.Margin = new System.Windows.Forms.Padding(4);
            this.searchdsmuon.Name = "searchdsmuon";
            this.searchdsmuon.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.searchdsmuon.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.searchdsmuon.OnHoverTextColor = System.Drawing.Color.Gray;
            this.searchdsmuon.Size = new System.Drawing.Size(165, 50);
            this.searchdsmuon.TabIndex = 5;
            this.searchdsmuon.Text = "Search";
            this.searchdsmuon.TextColor = System.Drawing.Color.White;
            this.searchdsmuon.UseVisualStyleBackColor = true;
            // 
            // bangdanhsachmuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1578, 1015);
            this.Controls.Add(this.comLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_WOC3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comGT);
            this.Controls.Add(this.btnloc);
            this.Controls.Add(this.btnxoasach);
            this.Controls.Add(this.btnthemmuonsach);
            this.Controls.Add(this.btnsuattms);
            this.Controls.Add(this.txtsearchdsmuon);
            this.Controls.Add(this.searchdsmuon);
            this.Controls.Add(this.dtgrdvdanhsach);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bangdanhsachmuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách mượn";
            this.Load += new System.EventHandler(this.bangdanhsachmuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdvdanhsach;
        private System.Windows.Forms.TextBox txtsearchdsmuon;
        private model.Button_WOC searchdsmuon;
        private model.Button_WOC btnthemmuonsach;
        private model.Button_WOC btnsuattms;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPH_MT;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_The;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Muon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Tra;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Luong_Muon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NV;
        private model.Button_WOC btnxoasach;
        private System.Windows.Forms.ComboBox comLoc;
        private System.Windows.Forms.Label label2;
        private model.Button_WOC button_WOC3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comGT;
        private model.Button_WOC btnloc;
    }
}