namespace BaoHiemNhanTho
{
    partial class frmThongTinBaoHiemSoHuu
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
            this.dataGridViewInsurancePolicies = new System.Windows.Forms.DataGridView();
            this.comboBoxCustomers = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsurancePolicies)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInsurancePolicies
            // 
            this.dataGridViewInsurancePolicies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInsurancePolicies.Location = new System.Drawing.Point(23, 140);
            this.dataGridViewInsurancePolicies.Name = "dataGridViewInsurancePolicies";
            this.dataGridViewInsurancePolicies.RowHeadersWidth = 51;
            this.dataGridViewInsurancePolicies.RowTemplate.Height = 24;
            this.dataGridViewInsurancePolicies.Size = new System.Drawing.Size(765, 298);
            this.dataGridViewInsurancePolicies.TabIndex = 0;
            // 
            // comboBoxCustomers
            // 
            this.comboBoxCustomers.FormattingEnabled = true;
            this.comboBoxCustomers.Location = new System.Drawing.Point(144, 90);
            this.comboBoxCustomers.Name = "comboBoxCustomers";
            this.comboBoxCustomers.Size = new System.Drawing.Size(354, 24);
            this.comboBoxCustomers.TabIndex = 1;
            this.comboBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomers_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Location = new System.Drawing.Point(855, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 401);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(26, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "      Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(26, 322);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 52);
            this.button7.TabIndex = 4;
            this.button7.Text = "Lưu";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(26, 146);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 52);
            this.button8.TabIndex = 3;
            this.button8.Text = "Sửa";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(26, 88);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 52);
            this.button9.TabIndex = 2;
            this.button9.Text = "Xóa";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(26, 21);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(133, 52);
            this.button11.TabIndex = 0;
            this.button11.Text = "Thêm";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // frmThongTinBaoHiemSoHuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBoxCustomers);
            this.Controls.Add(this.dataGridViewInsurancePolicies);
            this.Name = "frmThongTinBaoHiemSoHuu";
            this.Text = "frmThongTinBaoHiemSoHuu";
            this.Load += new System.EventHandler(this.frmThongTinBaoHiemSoHuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsurancePolicies)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInsurancePolicies;
        private System.Windows.Forms.ComboBox comboBoxCustomers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
    }
}