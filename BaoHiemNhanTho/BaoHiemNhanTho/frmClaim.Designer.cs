﻿namespace BaoHiemNhanTho
{
    partial class frmClaim
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
            this.comboBoxKhachHang = new System.Windows.Forms.ComboBox();
            this.dataGridViewInsurancePolicies = new System.Windows.Forms.DataGridView();
            this.dataGridViewClaim = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpDateOfClaim = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClaimAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaimNumber = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAddBeneficiary = new System.Windows.Forms.Button();
            this.buttonEditBeneficiary = new System.Windows.Forms.Button();
            this.buttonDeleteBeneficiary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsurancePolicies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClaim)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxKhachHang
            // 
            this.comboBoxKhachHang.FormattingEnabled = true;
            this.comboBoxKhachHang.Location = new System.Drawing.Point(51, 306);
            this.comboBoxKhachHang.Name = "comboBoxKhachHang";
            this.comboBoxKhachHang.Size = new System.Drawing.Size(335, 24);
            this.comboBoxKhachHang.TabIndex = 0;
            this.comboBoxKhachHang.SelectedIndexChanged += new System.EventHandler(this.comboBoxKhachHang_SelectedIndexChanged);
            // 
            // dataGridViewInsurancePolicies
            // 
            this.dataGridViewInsurancePolicies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInsurancePolicies.Location = new System.Drawing.Point(51, 336);
            this.dataGridViewInsurancePolicies.Name = "dataGridViewInsurancePolicies";
            this.dataGridViewInsurancePolicies.RowHeadersWidth = 51;
            this.dataGridViewInsurancePolicies.RowTemplate.Height = 24;
            this.dataGridViewInsurancePolicies.Size = new System.Drawing.Size(569, 259);
            this.dataGridViewInsurancePolicies.TabIndex = 1;
            this.dataGridViewInsurancePolicies.SelectionChanged += new System.EventHandler(this.dataGridViewInsurancePolicies_SelectionChanged);
            // 
            // dataGridViewClaim
            // 
            this.dataGridViewClaim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClaim.Location = new System.Drawing.Point(626, 336);
            this.dataGridViewClaim.Name = "dataGridViewClaim";
            this.dataGridViewClaim.RowHeadersWidth = 51;
            this.dataGridViewClaim.RowTemplate.Height = 24;
            this.dataGridViewClaim.Size = new System.Drawing.Size(490, 259);
            this.dataGridViewClaim.TabIndex = 2;
            this.dataGridViewClaim.SelectionChanged += new System.EventHandler(this.dataGridViewClaim_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpDateOfClaim);
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtStatus);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtClaimAmount);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtClaimNumber);
            this.groupBox3.Location = new System.Drawing.Point(644, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 234);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dtpDateOfClaim
            // 
            this.dtpDateOfClaim.Location = new System.Drawing.Point(186, 79);
            this.dtpDateOfClaim.Name = "dtpDateOfClaim";
            this.dtpDateOfClaim.Size = new System.Drawing.Size(200, 22);
            this.dtpDateOfClaim.TabIndex = 28;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(186, 202);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "txtDescription";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(186, 161);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 22);
            this.txtStatus.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "txtStatus";
            // 
            // txtClaimAmount
            // 
            this.txtClaimAmount.Location = new System.Drawing.Point(186, 122);
            this.txtClaimAmount.Name = "txtClaimAmount";
            this.txtClaimAmount.Size = new System.Drawing.Size(100, 22);
            this.txtClaimAmount.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "txtClaimAmount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "txtDateOfClaim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "txtClaimNumber";
            // 
            // txtClaimNumber
            // 
            this.txtClaimNumber.Location = new System.Drawing.Point(186, 41);
            this.txtClaimNumber.Name = "txtClaimNumber";
            this.txtClaimNumber.Size = new System.Drawing.Size(100, 22);
            this.txtClaimNumber.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddBeneficiary);
            this.groupBox2.Controls.Add(this.buttonEditBeneficiary);
            this.groupBox2.Controls.Add(this.buttonDeleteBeneficiary);
            this.groupBox2.Location = new System.Drawing.Point(1238, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 234);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // buttonAddBeneficiary
            // 
            this.buttonAddBeneficiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAddBeneficiary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddBeneficiary.Location = new System.Drawing.Point(26, 36);
            this.buttonAddBeneficiary.Name = "buttonAddBeneficiary";
            this.buttonAddBeneficiary.Size = new System.Drawing.Size(149, 52);
            this.buttonAddBeneficiary.TabIndex = 6;
            this.buttonAddBeneficiary.Text = "Thêm Bồi Thường";
            this.buttonAddBeneficiary.UseVisualStyleBackColor = true;
            this.buttonAddBeneficiary.Click += new System.EventHandler(this.buttonAddBeneficiary_Click);
            // 
            // buttonEditBeneficiary
            // 
            this.buttonEditBeneficiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonEditBeneficiary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditBeneficiary.Location = new System.Drawing.Point(26, 94);
            this.buttonEditBeneficiary.Name = "buttonEditBeneficiary";
            this.buttonEditBeneficiary.Size = new System.Drawing.Size(133, 52);
            this.buttonEditBeneficiary.TabIndex = 3;
            this.buttonEditBeneficiary.Text = "Sửa Bồi Thường";
            this.buttonEditBeneficiary.UseVisualStyleBackColor = true;
            this.buttonEditBeneficiary.Click += new System.EventHandler(this.buttonEditBeneficiary_Click);
            // 
            // buttonDeleteBeneficiary
            // 
            this.buttonDeleteBeneficiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDeleteBeneficiary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteBeneficiary.Location = new System.Drawing.Point(26, 152);
            this.buttonDeleteBeneficiary.Name = "buttonDeleteBeneficiary";
            this.buttonDeleteBeneficiary.Size = new System.Drawing.Size(133, 52);
            this.buttonDeleteBeneficiary.TabIndex = 2;
            this.buttonDeleteBeneficiary.Text = "Xóa Bồi Thường";
            this.buttonDeleteBeneficiary.UseVisualStyleBackColor = true;
            this.buttonDeleteBeneficiary.Click += new System.EventHandler(this.buttonDeleteBeneficiary_Click);
            // 
            // frmClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 929);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridViewClaim);
            this.Controls.Add(this.dataGridViewInsurancePolicies);
            this.Controls.Add(this.comboBoxKhachHang);
            this.Name = "frmClaim";
            this.Text = "frmClaim";
            this.Load += new System.EventHandler(this.frmClaim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsurancePolicies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClaim)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKhachHang;
        private System.Windows.Forms.DataGridView dataGridViewInsurancePolicies;
        private System.Windows.Forms.DataGridView dataGridViewClaim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtClaimAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaimNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAddBeneficiary;
        private System.Windows.Forms.Button buttonEditBeneficiary;
        private System.Windows.Forms.Button buttonDeleteBeneficiary;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateOfClaim;
    }
}