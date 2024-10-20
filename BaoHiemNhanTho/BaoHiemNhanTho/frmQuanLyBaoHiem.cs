using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BaoHiemNhanTho
{
    public partial class frmQuanLyBaoHiem : Form
    {
        private IMongoCollection<Customer> _customerCollection;

        public frmQuanLyBaoHiem()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("BHNT");
            _customerCollection = database.GetCollection<Customer>("BaoHiemNhanTho");
        }

        private void LoadInsurancePolicies()
        {
            // Lấy tất cả khách hàng từ MongoDB
            var customers = _customerCollection.Find(_ => true).ToList();

            // Lấy danh sách tất cả các bảo hiểm từ khách hàng
            var insurancePolicies = customers
                .SelectMany(c => c.insurancePolicies) // Duyệt qua các khách hàng và lấy các bảo hiểm
                .ToList();

            // Chuyển danh sách bảo hiểm vào DataGridView
            dataGridView1.DataSource = insurancePolicies.Select(p => new
            {
                PolicyId = p.policyId,
                PolicyNumber = p.policyNumber,
                PolicyType = p.policyType,
                StartDate = p.startDate.ToShortDateString(),
                EndDate = p.endDate.ToShortDateString(),
                Premium = p.premium,
                CoverageAmount = p.coverageAmount
            }).ToList();
        }

        private void frmQuanLyBaoHiem_Load_1(object sender, EventArgs e)
        {
            LoadInsurancePolicies();
        }
    }
}
