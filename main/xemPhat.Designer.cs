
namespace quanlithuvientruongdaihoc
{
    partial class xemPhat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgrdvdanhsach = new System.Windows.Forms.DataGridView();
            this.txtsearchbar = new System.Windows.Forms.TextBox();
            this.trangsauds = new FontAwesome.Sharp.IconButton();
            this.comLoc = new System.Windows.Forms.ComboBox();
            this.trangtruocds = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.trangcuoids = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.trangdauds = new FontAwesome.Sharp.IconButton();
            this.button_WOC1 = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnthemsach = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnsuasach = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.button_WOC3 = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnxoasach = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnloc = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.MaPH_NP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_The = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ly_Do_Phat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh_Thuc_Phat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Nop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trang_Thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Mo_The = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvdanhsach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgrdvdanhsach.ColumnHeadersHeight = 29;
            this.dtgrdvdanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPH_NP,
            this.So_The,
            this.Ly_Do_Phat,
            this.Hinh_Thuc_Phat,
            this.Ngay_Nop,
            this.Trang_Thai,
            this.Ngay_Mo_The});
            this.dtgrdvdanhsach.Location = new System.Drawing.Point(72, 222);
            this.dtgrdvdanhsach.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrdvdanhsach.Name = "dtgrdvdanhsach";
            this.dtgrdvdanhsach.RowHeadersWidth = 51;
            this.dtgrdvdanhsach.RowTemplate.Height = 24;
            this.dtgrdvdanhsach.Size = new System.Drawing.Size(1334, 762);
            this.dtgrdvdanhsach.TabIndex = 19;
            // 
            // txtsearchbar
            // 
            this.txtsearchbar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsearchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchbar.Location = new System.Drawing.Point(238, 20);
            this.txtsearchbar.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearchbar.Multiline = true;
            this.txtsearchbar.Name = "txtsearchbar";
            this.txtsearchbar.Size = new System.Drawing.Size(909, 49);
            this.txtsearchbar.TabIndex = 20;
            this.txtsearchbar.TextChanged += new System.EventHandler(this.txtsearchbar_TextChanged);
            this.txtsearchbar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearchbar_KeyPress);
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
            this.trangsauds.Location = new System.Drawing.Point(690, 1031);
            this.trangsauds.Margin = new System.Windows.Forms.Padding(4);
            this.trangsauds.Name = "trangsauds";
            this.trangsauds.Size = new System.Drawing.Size(55, 26);
            this.trangsauds.TabIndex = 31;
            this.trangsauds.UseVisualStyleBackColor = true;
            // 
            // comLoc
            // 
            this.comLoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comLoc.DropDownWidth = 180;
            this.comLoc.FormattingEnabled = true;
            this.comLoc.Items.AddRange(new object[] {
            "MaPH_NP",
            "So_The",
            "Trang_Thai"});
            this.comLoc.Location = new System.Drawing.Point(238, 96);
            this.comLoc.Margin = new System.Windows.Forms.Padding(4);
            this.comLoc.Name = "comLoc";
            this.comLoc.Size = new System.Drawing.Size(214, 29);
            this.comLoc.TabIndex = 22;
            this.comLoc.SelectedIndexChanged += new System.EventHandler(this.comLoc_SelectedIndexChanged);
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
            this.trangtruocds.Location = new System.Drawing.Point(608, 1031);
            this.trangtruocds.Margin = new System.Windows.Forms.Padding(4);
            this.trangtruocds.Name = "trangtruocds";
            this.trangtruocds.Size = new System.Drawing.Size(55, 26);
            this.trangtruocds.TabIndex = 28;
            this.trangtruocds.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Giá trị lọc:";
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
            this.trangcuoids.Location = new System.Drawing.Point(754, 1031);
            this.trangcuoids.Margin = new System.Windows.Forms.Padding(4);
            this.trangcuoids.Name = "trangcuoids";
            this.trangcuoids.Size = new System.Drawing.Size(55, 26);
            this.trangcuoids.TabIndex = 29;
            this.trangcuoids.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 100);
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
            this.comGT.Location = new System.Drawing.Point(238, 163);
            this.comGT.Margin = new System.Windows.Forms.Padding(4);
            this.comGT.MaxDropDownItems = 10;
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(214, 29);
            this.comGT.TabIndex = 23;
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
            this.trangdauds.Location = new System.Drawing.Point(545, 1031);
            this.trangdauds.Margin = new System.Windows.Forms.Padding(4);
            this.trangdauds.Name = "trangdauds";
            this.trangdauds.Size = new System.Drawing.Size(55, 26);
            this.trangdauds.TabIndex = 30;
            this.trangdauds.UseVisualStyleBackColor = true;
            // 
            // button_WOC1
            // 
            this.button_WOC1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(223)))));
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(1156, 20);
            this.button_WOC1.Margin = new System.Windows.Forms.Padding(4);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(165, 50);
            this.button_WOC1.TabIndex = 21;
            this.button_WOC1.Text = "Search";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
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
            this.btnthemsach.Location = new System.Drawing.Point(1430, 236);
            this.btnthemsach.Margin = new System.Windows.Forms.Padding(4);
            this.btnthemsach.Name = "btnthemsach";
            this.btnthemsach.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnthemsach.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnthemsach.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnthemsach.Size = new System.Drawing.Size(168, 98);
            this.btnthemsach.TabIndex = 32;
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
            this.btnsuasach.Location = new System.Drawing.Point(1430, 393);
            this.btnsuasach.Margin = new System.Windows.Forms.Padding(4);
            this.btnsuasach.Name = "btnsuasach";
            this.btnsuasach.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnsuasach.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnsuasach.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnsuasach.Size = new System.Drawing.Size(168, 98);
            this.btnsuasach.TabIndex = 34;
            this.btnsuasach.Text = "Sửa";
            this.btnsuasach.TextColor = System.Drawing.Color.White;
            this.btnsuasach.UseVisualStyleBackColor = true;
            // 
            // button_WOC3
            // 
            this.button_WOC3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_WOC3.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC3.ButtonColor = System.Drawing.Color.Red;
            this.button_WOC3.FlatAppearance.BorderSize = 0;
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC3.Location = new System.Drawing.Point(497, 148);
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
            // btnxoasach
            // 
            this.btnxoasach.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnxoasach.BorderColor = System.Drawing.Color.Transparent;
            this.btnxoasach.ButtonColor = System.Drawing.Color.Red;
            this.btnxoasach.FlatAppearance.BorderSize = 0;
            this.btnxoasach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoasach.Location = new System.Drawing.Point(1430, 553);
            this.btnxoasach.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoasach.Name = "btnxoasach";
            this.btnxoasach.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnxoasach.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnxoasach.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnxoasach.Size = new System.Drawing.Size(168, 98);
            this.btnxoasach.TabIndex = 33;
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
            this.btnloc.Location = new System.Drawing.Point(497, 88);
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
            // MaPH_NP
            // 
            this.MaPH_NP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaPH_NP.DataPropertyName = "MaPH_NP";
            this.MaPH_NP.HeaderText = "Mã phiếu nộp phạt";
            this.MaPH_NP.MinimumWidth = 9;
            this.MaPH_NP.Name = "MaPH_NP";
            this.MaPH_NP.Width = 249;
            // 
            // So_The
            // 
            this.So_The.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.So_The.DataPropertyName = "So_The";
            this.So_The.HeaderText = "Mã thẻ độc giả";
            this.So_The.MinimumWidth = 9;
            this.So_The.Name = "So_The";
            this.So_The.Width = 209;
            // 
            // Ly_Do_Phat
            // 
            this.Ly_Do_Phat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ly_Do_Phat.DataPropertyName = "Ly_Do_Phat";
            this.Ly_Do_Phat.HeaderText = "Lý do phạt";
            this.Ly_Do_Phat.MinimumWidth = 9;
            this.Ly_Do_Phat.Name = "Ly_Do_Phat";
            this.Ly_Do_Phat.Width = 164;
            // 
            // Hinh_Thuc_Phat
            // 
            this.Hinh_Thuc_Phat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Hinh_Thuc_Phat.DataPropertyName = "Hinh_Thuc_Phat";
            this.Hinh_Thuc_Phat.HeaderText = "Hình thức phạt";
            this.Hinh_Thuc_Phat.MinimumWidth = 9;
            this.Hinh_Thuc_Phat.Name = "Hinh_Thuc_Phat";
            this.Hinh_Thuc_Phat.Width = 206;
            // 
            // Ngay_Nop
            // 
            this.Ngay_Nop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ngay_Nop.DataPropertyName = "Ngay_Nop";
            this.Ngay_Nop.HeaderText = "Ngày nộp";
            this.Ngay_Nop.MinimumWidth = 9;
            this.Ngay_Nop.Name = "Ngay_Nop";
            this.Ngay_Nop.Width = 153;
            // 
            // Trang_Thai
            // 
            this.Trang_Thai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Trang_Thai.DataPropertyName = "Trang_Thai";
            this.Trang_Thai.HeaderText = "Trạng thái";
            this.Trang_Thai.MinimumWidth = 9;
            this.Trang_Thai.Name = "Trang_Thai";
            this.Trang_Thai.Width = 160;
            // 
            // Ngay_Mo_The
            // 
            this.Ngay_Mo_The.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ngay_Mo_The.DataPropertyName = "Ngay_Mo_The";
            this.Ngay_Mo_The.HeaderText = "Ngày mở lại thẻ";
            this.Ngay_Mo_The.MinimumWidth = 9;
            this.Ngay_Mo_The.Name = "Ngay_Mo_The";
            this.Ngay_Mo_The.Width = 217;
            // 
            // xemPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1616, 1031);
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
            this.Name = "xemPhat";
            this.Text = "xemPhat";
            this.Load += new System.EventHandler(this.xemPhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgrdvdanhsach;
        private System.Windows.Forms.TextBox txtsearchbar;
        private model.Button_WOC button_WOC1;
        private FontAwesome.Sharp.IconButton trangsauds;
        private model.Button_WOC btnthemsach;
        private System.Windows.Forms.ComboBox comLoc;
        private FontAwesome.Sharp.IconButton trangtruocds;
        private System.Windows.Forms.Label label2;
        private model.Button_WOC btnsuasach;
        private model.Button_WOC button_WOC3;
        private FontAwesome.Sharp.IconButton trangcuoids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comGT;
        private model.Button_WOC btnxoasach;
        private model.Button_WOC btnloc;
        private FontAwesome.Sharp.IconButton trangdauds;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPH_NP;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_The;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ly_Do_Phat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh_Thuc_Phat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Nop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trang_Thai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Mo_The;
    }
}