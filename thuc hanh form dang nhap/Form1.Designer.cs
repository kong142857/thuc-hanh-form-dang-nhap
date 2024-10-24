namespace thuc_hanh_form_dang_nhap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDangnhap = new Button();
            btnThoat = new Button();
            txtTen = new TextBox();
            txtMatkhau = new TextBox();
            lblTen = new Label();
            lblMatkhau = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnDangnhap
            // 
            btnDangnhap.Font = new Font("Segoe UI", 10F);
            btnDangnhap.Location = new Point(105, 14);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(90, 30);
            btnDangnhap.TabIndex = 0;
            btnDangnhap.Text = "Dang nhap";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10F);
            btnThoat.Location = new Point(238, 14);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(70, 30);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 10F);
            txtTen.Location = new Point(145, 20);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(240, 25);
            txtTen.TabIndex = 2;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Font = new Font("Segoe UI", 10F);
            txtMatkhau.Location = new Point(145, 72);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(240, 25);
            txtMatkhau.TabIndex = 3;
            txtMatkhau.TextChanged += txtMatkhau_TextChanged;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 12F);
            lblTen.Location = new Point(79, 20);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(36, 21);
            lblTen.TabIndex = 4;
            lblTen.Text = "Ten:";
            lblTen.Click += lblTen_Click;
            // 
            // lblMatkhau
            // 
            lblMatkhau.AutoSize = true;
            lblMatkhau.Font = new Font("Segoe UI", 10F);
            lblMatkhau.Location = new Point(44, 75);
            lblMatkhau.Name = "lblMatkhau";
            lblMatkhau.Size = new Size(71, 19);
            lblMatkhau.TabIndex = 5;
            lblMatkhau.Text = "Mat khau:";
            lblMatkhau.Click += lblMatkhau_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTen);
            panel1.Controls.Add(lblMatkhau);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(txtMatkhau);
            panel1.Location = new Point(28, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 123);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnDangnhap);
            panel2.Location = new Point(28, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 61);
            panel2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 235);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnDangnhap;
        private Button btnThoat;
        private TextBox txtTen;
        private TextBox txtMatkhau;
        private Label lblTen;
        private Label lblMatkhau;
        private Panel panel1;
        private Panel panel2;
    }
}
