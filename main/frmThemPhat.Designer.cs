
namespace quanlithuvientruongdaihoc
{
    partial class frmThemPhat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmaphp = new System.Windows.Forms.TextBox();
            this.txtsothe = new System.Windows.Forms.TextBox();
            this.txtlydo = new System.Windows.Forms.TextBox();
            this.txthtp = new System.Windows.Forms.TextBox();
            this.dtpngaynop = new System.Windows.Forms.DateTimePicker();
            this.dtpmothe = new System.Windows.Forms.DateTimePicker();
            this.comtt = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnquaylai = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnok = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.btnhoantac = new quanlithuvientruongdaihoc.model.Button_WOC();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(74, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu phạt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(59, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã thẻ độc giả:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(124, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lý do phạt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(57, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hình thức phạt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(805, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày nộp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(771, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "Trạng thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(688, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày mở lại thẻ:";
            // 
            // txtmaphp
            // 
            this.txtmaphp.Location = new System.Drawing.Point(359, 81);
            this.txtmaphp.Name = "txtmaphp";
            this.txtmaphp.Size = new System.Drawing.Size(295, 57);
            this.txtmaphp.TabIndex = 1;
            // 
            // txtsothe
            // 
            this.txtsothe.Location = new System.Drawing.Point(359, 196);
            this.txtsothe.Name = "txtsothe";
            this.txtsothe.Size = new System.Drawing.Size(295, 57);
            this.txtsothe.TabIndex = 2;
            // 
            // txtlydo
            // 
            this.txtlydo.Location = new System.Drawing.Point(359, 294);
            this.txtlydo.Multiline = true;
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new System.Drawing.Size(295, 59);
            this.txtlydo.TabIndex = 3;
            // 
            // txthtp
            // 
            this.txthtp.Location = new System.Drawing.Point(359, 409);
            this.txthtp.Multiline = true;
            this.txthtp.Name = "txthtp";
            this.txthtp.Size = new System.Drawing.Size(295, 59);
            this.txthtp.TabIndex = 4;
            // 
            // dtpngaynop
            // 
            this.dtpngaynop.CustomFormat = "dd/MM/yyyy";
            this.dtpngaynop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaynop.Location = new System.Drawing.Point(999, 89);
            this.dtpngaynop.Name = "dtpngaynop";
            this.dtpngaynop.Size = new System.Drawing.Size(338, 57);
            this.dtpngaynop.TabIndex = 5;
            // 
            // dtpmothe
            // 
            this.dtpmothe.CustomFormat = "dd/MM/yyyy";
            this.dtpmothe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpmothe.Location = new System.Drawing.Point(999, 303);
            this.dtpmothe.Name = "dtpmothe";
            this.dtpmothe.Size = new System.Drawing.Size(338, 57);
            this.dtpmothe.TabIndex = 7;
            // 
            // comtt
            // 
            this.comtt.FormattingEnabled = true;
            this.comtt.Items.AddRange(new object[] {
            "Đã nộp phạt",
            "Chưa nộp phạt"});
            this.comtt.Location = new System.Drawing.Point(997, 196);
            this.comtt.Name = "comtt";
            this.comtt.Size = new System.Drawing.Size(340, 58);
            this.comtt.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnquaylai);
            this.groupBox1.Controls.Add(this.comtt);
            this.groupBox1.Controls.Add(this.btnok);
            this.groupBox1.Controls.Add(this.dtpmothe);
            this.groupBox1.Controls.Add(this.btnhoantac);
            this.groupBox1.Controls.Add(this.dtpngaynop);
            this.groupBox1.Controls.Add(this.txthtp);
            this.groupBox1.Controls.Add(this.txtlydo);
            this.groupBox1.Controls.Add(this.txtsothe);
            this.groupBox1.Controls.Add(this.txtmaphp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(87, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1380, 671);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm phiếu phạt";
            // 
            // btnquaylai
            // 
            this.btnquaylai.BorderColor = System.Drawing.Color.Silver;
            this.btnquaylai.ButtonColor = System.Drawing.Color.Red;
            this.btnquaylai.FlatAppearance.BorderSize = 0;
            this.btnquaylai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquaylai.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnquaylai.Location = new System.Drawing.Point(1199, 563);
            this.btnquaylai.Margin = new System.Windows.Forms.Padding(4);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnquaylai.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnquaylai.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnquaylai.Size = new System.Drawing.Size(138, 52);
            this.btnquaylai.TabIndex = 10;
            this.btnquaylai.Text = "Hủy";
            this.btnquaylai.TextColor = System.Drawing.Color.White;
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btnok
            // 
            this.btnok.AutoSize = true;
            this.btnok.BackColor = System.Drawing.Color.Transparent;
            this.btnok.BorderColor = System.Drawing.Color.Silver;
            this.btnok.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(223)))));
            this.btnok.FlatAppearance.BorderSize = 0;
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(831, 563);
            this.btnok.Margin = new System.Windows.Forms.Padding(4);
            this.btnok.Name = "btnok";
            this.btnok.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnok.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnok.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnok.Size = new System.Drawing.Size(138, 52);
            this.btnok.TabIndex = 8;
            this.btnok.Text = "Lưu lại";
            this.btnok.TextColor = System.Drawing.Color.White;
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnhoantac
            // 
            this.btnhoantac.BorderColor = System.Drawing.Color.Silver;
            this.btnhoantac.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(224)))), ((int)(((byte)(148)))));
            this.btnhoantac.FlatAppearance.BorderSize = 0;
            this.btnhoantac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhoantac.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnhoantac.Location = new System.Drawing.Point(1016, 563);
            this.btnhoantac.Margin = new System.Windows.Forms.Padding(4);
            this.btnhoantac.Name = "btnhoantac";
            this.btnhoantac.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnhoantac.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnhoantac.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnhoantac.Size = new System.Drawing.Size(138, 52);
            this.btnhoantac.TabIndex = 9;
            this.btnhoantac.Text = "Xóa hết";
            this.btnhoantac.TextColor = System.Drawing.Color.White;
            this.btnhoantac.UseVisualStyleBackColor = true;
            this.btnhoantac.Click += new System.EventHandler(this.btnhoantac_Click);
            // 
            // frmThemPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1499, 816);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmThemPhat";
            this.Text = "frmThemPhat";
            this.Load += new System.EventHandler(this.frmThemPhat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmThemPhat_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmaphp;
        private System.Windows.Forms.TextBox txtsothe;
        private System.Windows.Forms.TextBox txtlydo;
        private System.Windows.Forms.TextBox txthtp;
        private System.Windows.Forms.DateTimePicker dtpngaynop;
        private System.Windows.Forms.DateTimePicker dtpmothe;
        private System.Windows.Forms.ComboBox comtt;
        private System.Windows.Forms.GroupBox groupBox1;
        private model.Button_WOC btnquaylai;
        private model.Button_WOC btnok;
        private model.Button_WOC btnhoantac;
    }
}