using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BaoHiemNhanTho
{
    public partial class frmThongTinNguoiThan : Form
    {
        private IMongoCollection<Customer> _customerCollection;
        private List<Customer> _customers;

        public frmThongTinNguoiThan()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("BHNT");
            _customerCollection = database.GetCollection<Customer>("BaoHiemNhanTho");
        }

        private void frmThongTinNguoiThan_Load(object sender, EventArgs e)
        {
            LoadCustomersIntoComboBox();
        }

        private void LoadCustomersIntoComboBox()
        {
            // Lấy tất cả khách hàng từ MongoDB
            _customers = _customerCollection.Find(_ => true).ToList();

            // Hiển thị danh sách khách hàng trong ComboBox
            comboBoxKhachHang.DataSource = _customers.Select(c => new
            {
                Display = c.name.firstName + " " + c.name.lastName + " - " + c.phoneNumber,
                Value = c.customerId
            }).ToList();

            comboBoxKhachHang.DisplayMember = "Display";
            comboBoxKhachHang.ValueMember = "Value";
        }

        private void comboBoxKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy customerId từ ComboBox khi người dùng chọn
            var selectedCustomerId = comboBoxKhachHang.SelectedValue?.ToString();

            // Hiển thị danh sách người thân trong DataGridView
            if (selectedCustomerId != null)
            {
                var selectedCustomer = _customers.FirstOrDefault(c => c.customerId == selectedCustomerId);

                if (selectedCustomer != null)
                {
                    var beneficiaries = selectedCustomer.insurancePolicies
                        .SelectMany(p => p.beneficiaries)
                        .Select(b => new
                        {
                            Name = b.name,
                            Relationship = b.relationship,
                            Percentage = b.percentage
                        })
                        .ToList();

                    dataGridViewNguoiThan.DataSource = beneficiaries;
                }
            }
        }
    }
}
