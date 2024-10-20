using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BaoHiemNhanTho
{
    public partial class frmKhachHang : Form
    {
        private IMongoCollection<Customer> _customerCollection;

        public frmKhachHang()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("BHNT");
            _customerCollection = database.GetCollection<Customer>("BaoHiemNhanTho");
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            // Lấy tất cả khách hàng từ MongoDB
            var customers = _customerCollection.Find(_ => true).ToList();

            // Chuyển danh sách khách hàng vào DataGridView
            dgvDSKhachHang.DataSource = customers.Select(c => new
            {
                CustomerId = c.customerId,
                FullName = c.name.firstName + " " + c.name.lastName,
                Gender = c.gender,
                Phone = c.phoneNumber,
                Email = c.email,
                Address = c.address.street + ", " + c.address.city + ", " + c.address.country
            }).ToList();
        }

        private void dgvDSKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvDSKhachHang.SelectedRows.Count > 0)
            {
                // Lấy hàng đã chọn
                var selectedRow = dgvDSKhachHang.SelectedRows[0].DataBoundItem;

                // Chuyển đổi và lấy thông tin
                if (selectedRow != null)
                {
                    // Chuyển đổi về dynamic để lấy các giá trị
                    var customer = (dynamic)selectedRow;

                    // Gán giá trị vào các TextBox
                    txtCustomerID.Text = customer.CustomerId;
                    txtFirstName.Text = customer.FullName.Split(' ')[0]; // Lấy tên
                    txtLastName.Text = customer.FullName.Split(' ')[1] + ' ' + customer.FullName.Split(' ')[2]; // Lấy họ

                    txtGender.Text = customer.Gender;
                    txtPhone.Text = customer.Phone;
                    txtEmail.Text = customer.Email;

                    // Tách địa chỉ
                    var addressParts = customer.Address.Split(',');
                    if (addressParts.Length == 3)
                    {
                        txtStreet.Text = addressParts[0].Trim(); // Đường
                        txtCity.Text = addressParts[1].Trim();   // Thành phố
                        txtCountry.Text = addressParts[2].Trim(); // Quốc gia
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvDSKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không làm gì thêm nếu không có hàng nào được chọn
            }

            // Lấy hàng đã chọn
            var selectedRow = dgvDSKhachHang.SelectedRows[0].DataBoundItem;

            // Chuyển đổi về dynamic để lấy thông tin
            if (selectedRow != null)
            {
                var customer = (dynamic)selectedRow;

                // Tạo instance của frmTaoHoSoMoi và truyền thông tin khách hàng
                frmTaoHoSoMoi formttnv = new frmTaoHoSoMoi
                {
                    CustomerId = customer.CustomerId,
                    FirstName = customer.FullName.Split(' ')[0], // Lấy họ
                    LastName= customer.FullName.Split(' ')[1] + ' ' + customer.FullName.Split(' ')[2], // Lấy họ
                    Gender = customer.Gender,
                    Phone = customer.Phone,
                    Email = customer.Email,
                    Street = customer.Address.Split(',')[0].Trim(),
                    City = customer.Address.Split(',')[1].Trim(),
                    Country = customer.Address.Split(',')[2].Trim()
                };

                formttnv.ShowDialog(); // Hiện form như một cửa sổ con (modal)
            }
        }

    }
}
