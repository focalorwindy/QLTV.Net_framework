
namespace quanlithuvientruongdaihoc
{
    partial class frmDocGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgrdvdanhsach = new System.Windows.Forms.DataGridView();
            this.So_The = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam_Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nghe_Nghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_Chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsearchbar = new System.Windows.Forms.TextBox();
            this.comLoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comGT = new System.Windows.Forms.ComboBox();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvdanhsach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdvdanhsach.ColumnHeadersHeight = 29;
            this.dtgrdvdanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.So_The,
            this.Ho_Ten,
            this.Nam_Sinh,
            this.Ngay_Cap,
            this.Nghe_Nghiep,
            this.Dia_Chi,
            this.SDT});
            this.dtgrdvdanhsach.Location = new System.Drawing.Point(45, 237);
            this.dtgrdvdanhsach.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrdvdanhsach.Name = "dtgrdvdanhsach";
            this.dtgrdvdanhsach.RowHeadersWidth = 51;
            this.dtgrdvdanhsach.RowTemplate.Height = 24;
            this.dtgrdvdanhsach.Size = new System.Drawing.Size(1432, 626);
            this.dtgrdvdanhsach.TabIndex = 19;
            // 
            // So_The
            // 
            this.So_The.DataPropertyName = "So_The";
            this.So_The.HeaderText = "Mã thẻ độc giả";
            this.So_The.MinimumWidth = 9;
            this.So_The.Name = "So_The";
            this.So_The.Width = 175;
            // 
            // Ho_Ten
            // 
            this.Ho_Ten.DataPropertyName = "Ho_Ten";
            this.Ho_Ten.HeaderText = "Họ và tên";
            this.Ho_Ten.MinimumWidth = 9;
            this.Ho_Ten.Name = "Ho_Ten";
            this.Ho_Ten.Width = 175;
            // 
            // Nam_Sinh
            // 
            this.Nam_Sinh.DataPropertyName = "Nam_Sinh";
            this.Nam_Sinh.HeaderText = "Năm sinh";
            this.Nam_Sinh.MinimumWidth = 9;
            this.Nam_Sinh.Name = "Nam_Sinh";
            this.Nam_Sinh.Width = 175;
            // 
            // Ngay_Cap
            // 
            this.Ngay_Cap.DataPropertyName = "Ngay_Cap";
            this.Ngay_Cap.HeaderText = "Ngày cấp thẻ";
            this.Ngay_Cap.MinimumWidth = 9;
            this.Ngay_Cap.Name = "Ngay_Cap";
            this.Ngay_Cap.Width = 175;
            // 
            // Nghe_Nghiep
            // 
            this.Nghe_Nghiep.DataPropertyName = "Nghe_Nghiep";
            this.Nghe_Nghiep.HeaderText = "Nghề nghiệp";
            this.Nghe_Nghiep.MinimumWidth = 9;
            this.Nghe_Nghiep.Name = "Nghe_Nghiep";
            this.Nghe_Nghiep.Width = 175;
            // 
            // Dia_Chi
            // 
            this.Dia_Chi.DataPropertyName = "Dia_Chi";
            this.Dia_Chi.HeaderText = "Địa chỉ";
            this.Dia_Chi.MinimumWidth = 9;
            this.Dia_Chi.Name = "Dia_Chi";
            this.Dia_Chi.Width = 175;
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
            this.txtsearchbar.Location = new System.Drawing.Point(289, 41);
            this.txtsearchbar.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearchbar.Multiline = true;
            this.txtsearchbar.Name = "txtsearchbar";
            this.txtsearchbar.Size = new System.Drawing.Size(909, 49);
            this.txtsearchbar.TabIndex = 20;
            this.txtsearchbar.TextChanged += new System.EventHandler(this.txtsearchbar_TextChanged);
            this.txtsearchbar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearchbar_KeyPress);
            // 
            // comLoc
            // 
            this.comLoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comLoc.DropDownWidth = 180;
            this.comLoc.FormattingEnabled = true;
            this.comLoc.Items.AddRange(new object[] {
            "So_The",
            "Ho_Ten",
            "Nam_Sinh",
            "Ngay_Cap",
            "Nghe_Nghiep",
            "Dia_Chi",
            "SDT"});
            this.comLoc.Location = new System.Drawing.Point(292, 131);
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
            this.label2.Location = new System.Drawing.Point(140, 171);
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
            this.label1.Location = new System.Drawing.Point(143, 135);
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
            this.comGT.Location = new System.Drawing.Point(292, 174);
            this.comGT.Margin = new System.Windows.Forms.Padding(4);
            this.comGT.MaxDropDownItems = 10;
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(214, 29);
            this.comGT.TabIndex = 23;
            // 
            // button_WOC1
            // 
            this.button_WOC1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(223)))));
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(1206, 40);
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
            this.btnthemsach.Location = new System.Drawing.Point(1507, 179);
            this.btnthemsach.Margin = new System.Windows.Forms.Padding(4);
            this.btnthemsach.Name = "btnthemsach";
            this.btnthemsach.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnthemsach.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnthemsach.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnthemsach.Size = new System.Drawing.Size(168, 98);
            this.btnthemsach.TabIndex = 28;
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
            this.btnsuasach.Location = new System.Drawing.Point(1507, 336);
            this.btnsuasach.Margin = new System.Windows.Forms.Padding(4);
            this.btnsuasach.Name = "btnsuasach";
            this.btnsuasach.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnsuasach.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnsuasach.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnsuasach.Size = new System.Drawing.Size(168, 98);
            this.btnsuasach.TabIndex = 30;
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
            this.button_WOC3.Location = new System.Drawing.Point(551, 168);
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
            this.btnxoasach.Location = new System.Drawing.Point(1507, 496);
            this.btnxoasach.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoasach.Name = "btnxoasach";
            this.btnxoasach.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnxoasach.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnxoasach.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnxoasach.Size = new System.Drawing.Size(168, 98);
            this.btnxoasach.TabIndex = 29;
            this.btnxoasach.Text = "Xóa";
            this.btnxoasach.TextColor = System.Drawing.Color.White;
            this.btnxoasach.UseVisualStyleBackColor = true;
            // 
            // btnloc
            // 
            this.btnloc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnloc.BorderColor = System.Drawing.Color.Transparent;
            this.btnloc.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(223)))));
            this.btnloc.FlatAppearance.BorderSize = 0;
            this.btnloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloc.Location = new System.Drawing.Point(551, 108);
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
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1703, 875);
            this.Controls.Add(this.dtgrdvdanhsach);
            this.Controls.Add(this.txtsearchbar);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.btnthemsach);
            this.Controls.Add(this.comLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsuasach);
            this.Controls.Add(this.button_WOC3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comGT);
            this.Controls.Add(this.btnxoasach);
            this.Controls.Add(this.btnloc);
            this.Name = "frmDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDocGia";
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgrdvdanhsach;
        private System.Windows.Forms.TextBox txtsearchbar;
        private model.Button_WOC button_WOC1;
        private model.Button_WOC btnthemsach;
        private System.Windows.Forms.ComboBox comLoc;
        private System.Windows.Forms.Label label2;
        private model.Button_WOC btnsuasach;
        private model.Button_WOC button_WOC3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comGT;
        private model.Button_WOC btnxoasach;
        private model.Button_WOC btnloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_The;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam_Sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nghe_Nghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_Chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}