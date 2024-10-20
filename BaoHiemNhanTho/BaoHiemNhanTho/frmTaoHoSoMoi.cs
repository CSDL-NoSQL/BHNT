using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoHiemNhanTho
{
    public partial class frmTaoHoSoMoi : Form
    {
        // Các thuộc tính để lưu thông tin khách hàng
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public frmTaoHoSoMoi()
        {
            InitializeComponent();
        }

        private void frmTaoHoSoMoi_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin khách hàng lên các TextBox
            txtCustomerID.Text = CustomerId;
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
            txtGender.Text = Gender;
            txtPhone.Text = Phone;
            txtEmail.Text = Email;
            txtStreet.Text = Street;
            txtCity.Text = City;
            txtCountry.Text = Country;
        }
    }
}
