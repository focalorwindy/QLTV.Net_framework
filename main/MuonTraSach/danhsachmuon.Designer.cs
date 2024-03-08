namespace quanlithuvientruongdaihoc
{
    partial class danhsachmuon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtslmuon = new System.Windows.Forms.TextBox();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.lblnv = new System.Windows.Forms.Label();
            this.lblslm = new System.Windows.Forms.Label();
            this.lblmasach = new System.Windows.Forms.Label();
            this.lblmaph = new System.Windows.Forms.Label();
            this.comTTmuon = new System.Windows.Forms.ComboBox();
            this.lblttmuon = new System.Windows.Forms.Label();
            this.dtptra = new System.Windows.Forms.DateTimePicker();
            this.dtpm = new System.Windows.Forms.DateTimePicker();
            this.txtsothe = new System.Windows.Forms.TextBox();
            this.lbldtra = new System.Windows.Forms.Label();
            this.lbldmuon = new System.Windows.Forms.Label();
            this.lblsothe = new System.Windows.Forms.Label();
            this.txtmaph = new System.Windows.Forms.TextBox();
            this.btnsave = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btncancel = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btndelete = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmaph);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.txtslmuon);
            this.groupBox1.Controls.Add(this.txtmasach);
            this.groupBox1.Controls.Add(this.lblnv);
            this.groupBox1.Controls.Add(this.lblslm);
            this.groupBox1.Controls.Add(this.lblmasach);
            this.groupBox1.Controls.Add(this.lblmaph);
            this.groupBox1.Controls.Add(this.comTTmuon);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.lblttmuon);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.dtptra);
            this.groupBox1.Controls.Add(this.dtpm);
            this.groupBox1.Controls.Add(this.txtsothe);
            this.groupBox1.Controls.Add(this.lbldtra);
            this.groupBox1.Controls.Add(this.lbldmuon);
            this.groupBox1.Controls.Add(this.lblsothe);
            this.groupBox1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1490, 684);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập phiếu mượn ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(1042, 276);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(378, 41);
            this.txtmanv.TabIndex = 8;
            // 
            // txtslmuon
            // 
            this.txtslmuon.Location = new System.Drawing.Point(357, 367);
            this.txtslmuon.Name = "txtslmuon";
            this.txtslmuon.Size = new System.Drawing.Size(392, 41);
            this.txtslmuon.TabIndex = 4;
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(357, 279);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(392, 41);
            this.txtmasach.TabIndex = 3;
            // 
            // lblnv
            // 
            this.lblnv.AutoSize = true;
            this.lblnv.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnv.Location = new System.Drawing.Point(814, 276);
            this.lblnv.Name = "lblnv";
            this.lblnv.Size = new System.Drawing.Size(200, 34);
            this.lblnv.TabIndex = 32;
            this.lblnv.Text = "Mã nhân viên:";
            // 
            // lblslm
            // 
            this.lblslm.AutoSize = true;
            this.lblslm.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblslm.Location = new System.Drawing.Point(97, 375);
            this.lblslm.Name = "lblslm";
            this.lblslm.Size = new System.Drawing.Size(222, 34);
            this.lblslm.TabIndex = 32;
            this.lblslm.Text = "Số lượng mượn:";
            // 
            // lblmasach
            // 
            this.lblmasach.AutoSize = true;
            this.lblmasach.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmasach.Location = new System.Drawing.Point(183, 283);
            this.lblmasach.Name = "lblmasach";
            this.lblmasach.Size = new System.Drawing.Size(136, 34);
            this.lblmasach.TabIndex = 32;
            this.lblmasach.Text = "Mã sách:";
            // 
            // lblmaph
            // 
            this.lblmaph.AutoSize = true;
            this.lblmaph.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaph.Location = new System.Drawing.Point(84, 102);
            this.lblmaph.Name = "lblmaph";
            this.lblmaph.Size = new System.Drawing.Size(235, 34);
            this.lblmaph.TabIndex = 32;
            this.lblmaph.Text = "Mã phiếu mượn: ";
            // 
            // comTTmuon
            // 
            this.comTTmuon.FormattingEnabled = true;
            this.comTTmuon.Items.AddRange(new object[] {
            "Đã trả",
            "Chưa trả"});
            this.comTTmuon.Location = new System.Drawing.Point(357, 454);
            this.comTTmuon.Name = "comTTmuon";
            this.comTTmuon.Size = new System.Drawing.Size(392, 42);
            this.comTTmuon.TabIndex = 31;
            this.comTTmuon.SelectedIndexChanged += new System.EventHandler(this.comTTmuon_SelectedIndexChanged);
            // 
            // lblttmuon
            // 
            this.lblttmuon.AutoSize = true;
            this.lblttmuon.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblttmuon.Location = new System.Drawing.Point(97, 467);
            this.lblttmuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblttmuon.Name = "lblttmuon";
            this.lblttmuon.Size = new System.Drawing.Size(222, 31);
            this.lblttmuon.TabIndex = 5;
            this.lblttmuon.Text = "Trạng thái mượn:";
            // 
            // dtptra
            // 
            this.dtptra.CustomFormat = "yyyy/MM/dd";
            this.dtptra.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptra.Location = new System.Drawing.Point(1042, 192);
            this.dtptra.Margin = new System.Windows.Forms.Padding(4);
            this.dtptra.Name = "dtptra";
            this.dtptra.Size = new System.Drawing.Size(378, 39);
            this.dtptra.TabIndex = 7;
            // 
            // dtpm
            // 
            this.dtpm.CustomFormat = "yyyy/MM/dd";
            this.dtpm.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpm.Location = new System.Drawing.Point(1042, 105);
            this.dtpm.Margin = new System.Windows.Forms.Padding(4);
            this.dtpm.Name = "dtpm";
            this.dtpm.Size = new System.Drawing.Size(378, 39);
            this.dtpm.TabIndex = 6;
            // 
            // txtsothe
            // 
            this.txtsothe.Location = new System.Drawing.Point(357, 189);
            this.txtsothe.Margin = new System.Windows.Forms.Padding(4);
            this.txtsothe.Name = "txtsothe";
            this.txtsothe.Size = new System.Drawing.Size(392, 41);
            this.txtsothe.TabIndex = 2;
            // 
            // lbldtra
            // 
            this.lbldtra.AutoSize = true;
            this.lbldtra.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtra.Location = new System.Drawing.Point(888, 198);
            this.lbldtra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldtra.Name = "lbldtra";
            this.lbldtra.Size = new System.Drawing.Size(126, 31);
            this.lbldtra.TabIndex = 3;
            this.lbldtra.Text = "Ngày trả:";
            this.lbldtra.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbldmuon
            // 
            this.lbldmuon.AutoSize = true;
            this.lbldmuon.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmuon.Location = new System.Drawing.Point(852, 109);
            this.lbldmuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldmuon.Name = "lbldmuon";
            this.lbldmuon.Size = new System.Drawing.Size(162, 31);
            this.lbldmuon.TabIndex = 2;
            this.lbldmuon.Text = "Ngày mượn:";
            // 
            // lblsothe
            // 
            this.lblsothe.AutoSize = true;
            this.lblsothe.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsothe.Location = new System.Drawing.Point(121, 194);
            this.lblsothe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsothe.Name = "lblsothe";
            this.lblsothe.Size = new System.Drawing.Size(198, 31);
            this.lblsothe.TabIndex = 0;
            this.lblsothe.Text = "Số thẻ độc giả:";
            // 
            // txtmaph
            // 
            this.txtmaph.Location = new System.Drawing.Point(357, 99);
            this.txtmaph.Name = "txtmaph";
            this.txtmaph.Size = new System.Drawing.Size(392, 41);
            this.txtmaph.TabIndex = 1;
            // 
            // btnsave
            // 
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.BorderColor = System.Drawing.Color.Silver;
            this.btnsave.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(223)))));
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(906, 597);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnsave.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnsave.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnsave.Size = new System.Drawing.Size(138, 52);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Lưu lại";
            this.btnsave.TextColor = System.Drawing.Color.White;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnokphieumuon_Click);
            // 
            // btncancel
            // 
            this.btncancel.BorderColor = System.Drawing.Color.Silver;
            this.btncancel.ButtonColor = System.Drawing.Color.Red;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold);
            this.btncancel.Location = new System.Drawing.Point(1282, 597);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btncancel.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btncancel.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btncancel.Size = new System.Drawing.Size(138, 52);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Hủy";
            this.btncancel.TextColor = System.Drawing.Color.White;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btnquaylaiphieumuon_Click);
            // 
            // btndelete
            // 
            this.btndelete.BorderColor = System.Drawing.Color.Silver;
            this.btndelete.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(224)))), ((int)(((byte)(148)))));
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold);
            this.btndelete.Location = new System.Drawing.Point(1094, 597);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btndelete.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btndelete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btndelete.Size = new System.Drawing.Size(138, 52);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Xóa hết";
            this.btndelete.TextColor = System.Drawing.Color.White;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btnhoantacphieumuon_Click);
            // 
            // danhsachmuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1578, 742);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "danhsachmuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm phiếu mượn trả sách";
            this.Load += new System.EventHandler(this.danhsachmuon_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.danhsachmuon_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtptra;
        private System.Windows.Forms.DateTimePicker dtpm;
        private System.Windows.Forms.Label lblttmuon;
        private System.Windows.Forms.TextBox txtsothe;
        private System.Windows.Forms.Label lbldtra;
        private System.Windows.Forms.Label lbldmuon;
        private System.Windows.Forms.Label lblsothe;
        private model.Button_WOC btncancel;
        private model.Button_WOC btndelete;
        private model.Button_WOC btnsave;
        private System.Windows.Forms.ComboBox comTTmuon;
        private System.Windows.Forms.Label lblnv;
        private System.Windows.Forms.Label lblslm;
        private System.Windows.Forms.Label lblmasach;
        private System.Windows.Forms.Label lblmaph;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtslmuon;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.TextBox txtmaph;
    }
}