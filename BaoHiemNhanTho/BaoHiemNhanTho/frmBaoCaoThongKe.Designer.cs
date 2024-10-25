namespace BaoHiemNhanTho
{
    partial class frmBaoCaoThongKe
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalCustomers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalPremiumPaid = new System.Windows.Forms.TextBox();
            this.txtTotalPolicies = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPolicyCount = new System.Windows.Forms.TextBox();
            this.txtTotalClaims = new System.Windows.Forms.TextBox();
            this.txtTotalPremium = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(25, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 42);
            this.label7.TabIndex = 29;
            this.label7.Text = "Báo Cáo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(7, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 42);
            this.label1.TabIndex = 30;
            this.label1.Text = "Thống Kê";
            // 
            // txtTotalCustomers
            // 
            this.txtTotalCustomers.Location = new System.Drawing.Point(314, 38);
            this.txtTotalCustomers.Name = "txtTotalCustomers";
            this.txtTotalCustomers.Size = new System.Drawing.Size(488, 26);
            this.txtTotalCustomers.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tổng số khách hàng";
            // 
            // txtTotalPremiumPaid
            // 
            this.txtTotalPremiumPaid.Location = new System.Drawing.Point(314, 153);
            this.txtTotalPremiumPaid.Name = "txtTotalPremiumPaid";
            this.txtTotalPremiumPaid.Size = new System.Drawing.Size(488, 26);
            this.txtTotalPremiumPaid.TabIndex = 33;
            // 
            // txtTotalPolicies
            // 
            this.txtTotalPolicies.Location = new System.Drawing.Point(314, 91);
            this.txtTotalPolicies.Name = "txtTotalPolicies";
            this.txtTotalPolicies.Size = new System.Drawing.Size(488, 26);
            this.txtTotalPolicies.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tổng số hợp đồng bảo hiểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tổng số phí bảo hiểm đã thanh toán";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTotalPolicies);
            this.groupBox1.Controls.Add(this.txtTotalPremiumPaid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTotalCustomers);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(221, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 219);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo Cáo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.endDatePicker);
            this.groupBox2.Controls.Add(this.startDatePicker);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(221, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 219);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống Kê";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thời Gian Kết Thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thời Gian Bắt Đầu";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(23, 172);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(306, 26);
            this.endDatePicker.TabIndex = 1;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(23, 60);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(306, 26);
            this.startDatePicker.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(14, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 43);
            this.button1.TabIndex = 39;
            this.button1.Text = "Thực Hiện Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalPremium);
            this.groupBox3.Controls.Add(this.txtTotalClaims);
            this.groupBox3.Controls.Add(this.txtPolicyCount);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(562, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 219);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết Quả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số hợp đồng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Số yêu cầu bồi thường:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tổng phí bảo hiểm đã thanh toán:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPolicyCount
            // 
            this.txtPolicyCount.Location = new System.Drawing.Point(269, 53);
            this.txtPolicyCount.Name = "txtPolicyCount";
            this.txtPolicyCount.Size = new System.Drawing.Size(366, 26);
            this.txtPolicyCount.TabIndex = 3;
            // 
            // txtTotalClaims
            // 
            this.txtTotalClaims.Location = new System.Drawing.Point(269, 105);
            this.txtTotalClaims.Name = "txtTotalClaims";
            this.txtTotalClaims.Size = new System.Drawing.Size(366, 26);
            this.txtTotalClaims.TabIndex = 4;
            // 
            // txtTotalPremium
            // 
            this.txtTotalPremium.Location = new System.Drawing.Point(269, 171);
            this.txtTotalPremium.Name = "txtTotalPremium";
            this.txtTotalPremium.Size = new System.Drawing.Size(366, 26);
            this.txtTotalPremium.TabIndex = 5;
            // 
            // frmBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmBaoCaoThongKe";
            this.Text = "frmBaoCaoThongKe";
            this.Load += new System.EventHandler(this.frmBaoCaoThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalPremiumPaid;
        private System.Windows.Forms.TextBox txtTotalPolicies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotalPremium;
        private System.Windows.Forms.TextBox txtPolicyCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalClaims;
    }
}