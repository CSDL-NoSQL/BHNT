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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxCustomers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsurancePolicies)).BeginInit();
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
            this.comboBoxCustomers.Location = new System.Drawing.Point(23, 93);
            this.comboBoxCustomers.Name = "comboBoxCustomers";
            this.comboBoxCustomers.Size = new System.Drawing.Size(354, 24);
            this.comboBoxCustomers.TabIndex = 1;
            this.comboBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomers_SelectedIndexChanged);
            // 
            // frmThongTinBaoHiemSoHuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 450);
            this.Controls.Add(this.comboBoxCustomers);
            this.Controls.Add(this.dataGridViewInsurancePolicies);
            this.Name = "frmThongTinBaoHiemSoHuu";
            this.Text = "frmThongTinBaoHiemSoHuu";
            this.Load += new System.EventHandler(this.frmThongTinBaoHiemSoHuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsurancePolicies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInsurancePolicies;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxCustomers;
    }
}