namespace quanlithuvientruongdaihoc
{
    partial class Searchsach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgrdvdanhsach = new System.Windows.Forms.DataGridView();
            this.Ma_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_TL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngon_ngu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Trang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Lg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghi_Chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangtruocds = new FontAwesome.Sharp.IconButton();
            this.trangcuoids = new FontAwesome.Sharp.IconButton();
            this.trangdauds = new FontAwesome.Sharp.IconButton();
            this.trangsauds = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.comLoc = new System.Windows.Forms.ComboBox();
            this.txtsearchbar = new System.Windows.Forms.TextBox();
            this.button_WOC1 = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnthemsach = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnsuasach = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.button_WOC3 = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnxoasach = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnloc = new quanlithuvientruongdaihoc.model.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdvdanhsach
            // 
            this.dtgrdvdanhsach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrdvdanhsach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgrdvdanhsach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvdanhsach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrdvdanhsach.ColumnHeadersHeight = 29;
            this.dtgrdvdanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Sach,
            this.Ten_Sach,
            this.Ten_TL,
            this.Tacgia,
            this.NXB,
            this.Ngon_ngu,
            this.So_Trang,
            this.So_Lg,
            this.Ghi_Chu});
            this.dtgrdvdanhsach.Location = new System.Drawing.Point(50, 252);
            this.dtgrdvdanhsach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgrdvdanhsach.Name = "dtgrdvdanhsach";
            this.dtgrdvdanhsach.RowHeadersWidth = 51;
            this.dtgrdvdanhsach.RowTemplate.Height = 24;
            this.dtgrdvdanhsach.Size = new System.Drawing.Size(1253, 707);
            this.dtgrdvdanhsach.TabIndex = 0;
            this.dtgrdvdanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdvdanhsach_CellClick);
            this.dtgrdvdanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdvdanhsach_CellContentClick);
            // 
            // Ma_Sach
            // 
            this.Ma_Sach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ma_Sach.DataPropertyName = "Ma_Sach";
            this.Ma_Sach.HeaderText = "Mã sách";
            this.Ma_Sach.MinimumWidth = 9;
            this.Ma_Sach.Name = "Ma_Sach";
            this.Ma_Sach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Ten_Sach
            // 
            this.Ten_Sach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten_Sach.DataPropertyName = "Ten_Sach";
            this.Ten_Sach.HeaderText = "Tên sách";
            this.Ten_Sach.MinimumWidth = 9;
            this.Ten_Sach.Name = "Ten_Sach";
            // 
            // Ten_TL
            // 
            this.Ten_TL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten_TL.DataPropertyName = "Ten_TL";
            this.Ten_TL.HeaderText = "Thể loại";
            this.Ten_TL.MinimumWidth = 9;
            this.Ten_TL.Name = "Ten_TL";
            // 
            // Tacgia
            // 
            this.Tacgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tacgia.DataPropertyName = "Ten_TG";
            this.Tacgia.HeaderText = "Tác giả";
            this.Tacgia.MinimumWidth = 9;
            this.Tacgia.Name = "Tacgia";
            // 
            // NXB
            // 
            this.NXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NXB.DataPropertyName = "Ten_NXB";
            this.NXB.HeaderText = "NXB";
            this.NXB.MinimumWidth = 9;
            this.NXB.Name = "NXB";
            // 
            // Ngon_ngu
            // 
            this.Ngon_ngu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngon_ngu.DataPropertyName = "Ngon_Ngu";
            this.Ngon_ngu.HeaderText = "Ngôn ngữ";
            this.Ngon_ngu.MinimumWidth = 9;
            this.Ngon_ngu.Name = "Ngon_ngu";
            // 
            // So_Trang
            // 
            this.So_Trang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.So_Trang.DataPropertyName = "So_Trang";
            this.So_Trang.HeaderText = "Số trang";
            this.So_Trang.MinimumWidth = 9;
            this.So_Trang.Name = "So_Trang";
            // 
            // So_Lg
            // 
            this.So_Lg.DataPropertyName = "So_Lg";
            this.So_Lg.HeaderText = "Số lượng";
            this.So_Lg.MinimumWidth = 9;
            this.So_Lg.Name = "So_Lg";
            this.So_Lg.Width = 175;
            // 
            // Ghi_Chu
            // 
            this.Ghi_Chu.DataPropertyName = "Ghi_Chu";
            this.Ghi_Chu.HeaderText = "Ghi chú";
            this.Ghi_Chu.MinimumWidth = 9;
            this.Ghi_Chu.Name = "Ghi_Chu";
            this.Ghi_Chu.Width = 175;
            // 
            // trangtruocds
            // 
            this.trangtruocds.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trangtruocds.FlatAppearance.BorderSize = 0;
            this.trangtruocds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trangtruocds.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.trangtruocds.IconColor = System.Drawing.Color.Black;
            this.trangtruocds.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.trangtruocds.IconSize = 25;
            this.trangtruocds.Location = new System.Drawing.Point(594, 973);
            this.trangtruocds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trangtruocds.Name = "trangtruocds";
            this.trangtruocds.Size = new System.Drawing.Size(55, 26);
            this.trangtruocds.TabIndex = 11;
            this.trangtruocds.UseVisualStyleBackColor = true;
            this.trangtruocds.Click += new System.EventHandler(this.trangtruocds_Click);
            // 
            // trangcuoids
            // 
            this.trangcuoids.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trangcuoids.FlatAppearance.BorderSize = 0;
            this.trangcuoids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trangcuoids.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.trangcuoids.IconColor = System.Drawing.Color.Black;
            this.trangcuoids.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.trangcuoids.IconSize = 25;
            this.trangcuoids.Location = new System.Drawing.Point(740, 973);
            this.trangcuoids.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trangcuoids.Name = "trangcuoids";
            this.trangcuoids.Size = new System.Drawing.Size(55, 26);
            this.trangcuoids.TabIndex = 12;
            this.trangcuoids.UseVisualStyleBackColor = true;
            // 
            // trangdauds
            // 
            this.trangdauds.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trangdauds.FlatAppearance.BorderSize = 0;
            this.trangdauds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trangdauds.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.trangdauds.IconColor = System.Drawing.Color.Black;
            this.trangdauds.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.trangdauds.IconSize = 25;
            this.trangdauds.Location = new System.Drawing.Point(531, 973);
            this.trangdauds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trangdauds.Name = "trangdauds";
            this.trangdauds.Size = new System.Drawing.Size(55, 26);
            this.trangdauds.TabIndex = 13;
            this.trangdauds.UseVisualStyleBackColor = true;
            // 
            // trangsauds
            // 
            this.trangsauds.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trangsauds.FlatAppearance.BorderSize = 0;
            this.trangsauds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trangsauds.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.trangsauds.IconColor = System.Drawing.Color.Black;
            this.trangsauds.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.trangsauds.IconSize = 25;
            this.trangsauds.Location = new System.Drawing.Point(676, 973);
            this.trangsauds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trangsauds.Name = "trangsauds";
            this.trangsauds.Size = new System.Drawing.Size(55, 26);
            this.trangsauds.TabIndex = 14;
            this.trangsauds.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giá trị lọc:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bộ lọc:";
            // 
            // comGT
            // 
            this.comGT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comGT.DropDownHeight = 150;
            this.comGT.DropDownWidth = 180;
            this.comGT.FormattingEnabled = true;
            this.comGT.IntegralHeight = false;
            this.comGT.Location = new System.Drawing.Point(226, 180);
            this.comGT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comGT.MaxDropDownItems = 10;
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(214, 29);
            this.comGT.TabIndex = 6;
            this.comGT.SelectedIndexChanged += new System.EventHandler(this.comGT_SelectedIndexChanged);
            // 
            // comLoc
            // 
            this.comLoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comLoc.DropDownWidth = 180;
            this.comLoc.FormattingEnabled = true;
            this.comLoc.Items.AddRange(new object[] {
            "Ma_Sach",
            "Ten_Sach",
            "Ten_TL",
            "Ten_TG",
            "Ten_NXB",
            "Ngon_Ngu",
            "So_Trang",
            "So_Lg",
            "Ghi_Chu"});
            this.comLoc.Location = new System.Drawing.Point(226, 113);
            this.comLoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comLoc.Name = "comLoc";
            this.comLoc.Size = new System.Drawing.Size(214, 29);
            this.comLoc.TabIndex = 5;
            this.comLoc.SelectedIndexChanged += new System.EventHandler(this.comLoc_SelectedIndexChanged);
            // 
            // txtsearchbar
            // 
            this.txtsearchbar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsearchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchbar.Location = new System.Drawing.Point(226, 37);
            this.txtsearchbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsearchbar.Multiline = true;
            this.txtsearchbar.Name = "txtsearchbar";
            this.txtsearchbar.Size = new System.Drawing.Size(909, 49);
            this.txtsearchbar.TabIndex = 2;
            this.txtsearchbar.TextChanged += new System.EventHandler(this.txtsearchbar_TextChanged);
            this.txtsearchbar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearchbar_KeyPress);
            // 
            // button_WOC1
            // 
            this.button_WOC1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(223)))));
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(1144, 37);
            this.button_WOC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(165, 50);
            this.button_WOC1.TabIndex = 3;
            this.button_WOC1.Text = "Search";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // btnthemsach
            // 
            this.btnthemsach.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnthemsach.BorderColor = System.Drawing.Color.Transparent;
            this.btnthemsach.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(223)))));
            this.btnthemsach.FlatAppearance.BorderSize = 0;
            this.btnthemsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthemsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemsach.ForeColor = System.Drawing.Color.Transparent;
            this.btnthemsach.Location = new System.Drawing.Point(1370, 192);
            this.btnthemsach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthemsach.Name = "btnthemsach";
            this.btnthemsach.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnthemsach.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnthemsach.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnthemsach.Size = new System.Drawing.Size(168, 98);
            this.btnthemsach.TabIndex = 15;
            this.btnthemsach.Text = "Thêm";
            this.btnthemsach.TextColor = System.Drawing.Color.White;
            this.btnthemsach.UseVisualStyleBackColor = true;
            this.btnthemsach.Click += new System.EventHandler(this.btnthemsach_Click);
            // 
            // btnsuasach
            // 
            this.btnsuasach.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnsuasach.BorderColor = System.Drawing.Color.Transparent;
            this.btnsuasach.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(224)))), ((int)(((byte)(148)))));
            this.btnsuasach.FlatAppearance.BorderSize = 0;
            this.btnsuasach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuasach.Location = new System.Drawing.Point(1370, 349);
            this.btnsuasach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsuasach.Name = "btnsuasach";
            this.btnsuasach.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnsuasach.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnsuasach.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnsuasach.Size = new System.Drawing.Size(168, 98);
            this.btnsuasach.TabIndex = 17;
            this.btnsuasach.Text = "Sửa";
            this.btnsuasach.TextColor = System.Drawing.Color.White;
            this.btnsuasach.UseVisualStyleBackColor = true;
            this.btnsuasach.Click += new System.EventHandler(this.btnsuasach_Click);
            // 
            // button_WOC3
            // 
            this.button_WOC3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_WOC3.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC3.ButtonColor = System.Drawing.Color.Red;
            this.button_WOC3.FlatAppearance.BorderSize = 0;
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC3.Location = new System.Drawing.Point(485, 165);
            this.button_WOC3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC3.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC3.Size = new System.Drawing.Size(110, 52);
            this.button_WOC3.TabIndex = 10;
            this.button_WOC3.Text = "Hủy";
            this.button_WOC3.TextColor = System.Drawing.Color.White;
            this.button_WOC3.UseVisualStyleBackColor = true;
            this.button_WOC3.Click += new System.EventHandler(this.button_WOC3_Click);
            // 
            // btnxoasach
            // 
            this.btnxoasach.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnxoasach.BorderColor = System.Drawing.Color.Transparent;
            this.btnxoasach.ButtonColor = System.Drawing.Color.Red;
            this.btnxoasach.FlatAppearance.BorderSize = 0;
            this.btnxoasach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoasach.Location = new System.Drawing.Point(1370, 509);
            this.btnxoasach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoasach.Name = "btnxoasach";
            this.btnxoasach.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnxoasach.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnxoasach.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnxoasach.Size = new System.Drawing.Size(168, 98);
            this.btnxoasach.TabIndex = 16;
            this.btnxoasach.Text = "Xóa";
            this.btnxoasach.TextColor = System.Drawing.Color.White;
            this.btnxoasach.UseVisualStyleBackColor = true;
            this.btnxoasach.Click += new System.EventHandler(this.btnxoasach_Click);
            // 
            // btnloc
            // 
            this.btnloc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnloc.BorderColor = System.Drawing.Color.Transparent;
            this.btnloc.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(223)))));
            this.btnloc.FlatAppearance.BorderSize = 0;
            this.btnloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloc.Location = new System.Drawing.Point(485, 105);
            this.btnloc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnloc.Name = "btnloc";
            this.btnloc.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnloc.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnloc.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnloc.Size = new System.Drawing.Size(110, 52);
            this.btnloc.TabIndex = 9;
            this.btnloc.Text = "Lọc";
            this.btnloc.TextColor = System.Drawing.Color.White;
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // Searchsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1578, 1015);
            this.Controls.Add(this.dtgrdvdanhsach);
            this.Controls.Add(this.txtsearchbar);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.trangsauds);
            this.Controls.Add(this.btnthemsach);
            this.Controls.Add(this.comLoc);
            this.Controls.Add(this.trangtruocds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsuasach);
            this.Controls.Add(this.button_WOC3);
            this.Controls.Add(this.trangcuoids);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comGT);
            this.Controls.Add(this.btnxoasach);
            this.Controls.Add(this.btnloc);
            this.Controls.Add(this.trangdauds);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Searchsach";
            this.Text = "Sách trong thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Searchsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdvdanhsach;
        private FontAwesome.Sharp.IconButton trangtruocds;
        private FontAwesome.Sharp.IconButton trangcuoids;
        private FontAwesome.Sharp.IconButton trangdauds;
        private FontAwesome.Sharp.IconButton trangsauds;
        private model.Button_WOC btnthemsach;
        private model.Button_WOC btnxoasach;
        private model.Button_WOC btnsuasach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private model.Button_WOC btnloc;
        private System.Windows.Forms.ComboBox comGT;
        private model.Button_WOC button_WOC3;
        private System.Windows.Forms.ComboBox comLoc;
        private model.Button_WOC button_WOC1;
        private System.Windows.Forms.TextBox txtsearchbar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_TL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngon_ngu;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Trang;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Lg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghi_Chu;
    }
}