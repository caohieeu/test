using QLNH.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLNH
{
    public partial class QLNH1 : Form
    {
        private static CustomerBLL customerBLL = new CustomerBLL();
        TTKmean ttkmean = new TTKmean(customerBLL);
        TTID3 ttID3 = new TTID3(customerBLL);
        public QLNH1()
        {
            InitializeComponent();
        }

        private void QLNH1_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
        private void LoadCustomerData()
        {
            try
            {
                var customers = customerBLL.GetAllCustomers();

                dgrViewCus.DataSource = customers.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu khách hàng: " + ex.Message);
            }
        }
        private void btnHoc_Click(object sender, EventArgs e)
        {
            try
            {
                ttkmean.TrainKMeans();
                MessageBox.Show("Huấn luyện thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi huấn luyện: {ex.Message}");
            }
        }

        private void btnDuDoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtAge.Text, out int age) ||
                    !int.TryParse(txtTenure.Text, out int tenure) ||
                    !double.TryParse(txtBalance.Text, out double balance) ||
                    !int.TryParse(txtProductsNumber.Text, out int productsNumber) ||
                    !int.TryParse(txtCreditCard.Text, out int creditCard) ||
                    !int.TryParse(txtActiveMember.Text, out int activeMember) ||
                    !double.TryParse(txtEstimatedSalary.Text, out double estimatedSalary))
                {
                    MessageBox.Show("Vui lòng nhập đúng dữ liệu.");
                    return;
                }

                var newCustomer = new BankCustomerChurnPrediction
                {
                    age = age,
                    tenure = tenure,
                    balance = balance,
                    products_number = productsNumber,
                    credit_card = creditCard,
                    active_member = activeMember,
                    estimated_salary = estimatedSalary
                };

                int churnProbability = ttkmean.PredictChurn(newCustomer);

                if (churnProbability == 0)
                {
                    MessageBox.Show("Khách hàng không có khả năng rời đi.");
                }
                else
                {
                    MessageBox.Show("Khách hàng có khả năng rời đi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}");
            }

        }

        private void btnHocId3_Click(object sender, EventArgs e)
        {
            try
            {
                ttID3.TrainID3();
                MessageBox.Show("Huấn luyện thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi huấn luyện: {ex.Message}");
            }
        }

        private void btnDuDoanID3_Click(object sender, EventArgs e)
        {
            var newCustomer = new BankCustomerChurnPrediction
            {
                age = int.Parse(txtAge.Text),
                tenure = int.Parse(txtTenure.Text),
                balance = double.Parse(txtBalance.Text),
                products_number = int.Parse(txtProductsNumber.Text),
                credit_card = int.Parse(txtCreditCard.Text),
                active_member = int.Parse(txtActiveMember.Text),
                estimated_salary = double.Parse(txtEstimatedSalary.Text)
            };

            int prediction = ttID3.PredictChurn(newCustomer);
            

            MessageBox.Show(prediction == 1
                ? "Khách hàng có khả năng rời đi."
                : "Khách hàng không có khả năng rời đi."); 

        }

        private void dgrViewCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgrViewCus.Rows[e.RowIndex];

                // Truyền giá trị từ các cột vào các textbox
                txtCustomerId.Text = row.Cells["customer_id"].Value.ToString();
                txtCreditScore.Text = row.Cells["credit_score"].Value.ToString();
                txtCountry.Text = row.Cells["country"].Value.ToString();
                txtGender.Text = row.Cells["gender"].Value.ToString();
                txtAge.Text = row.Cells["age"].Value.ToString();
                txtTenure.Text = row.Cells["tenure"].Value.ToString();
                txtBalance.Text = row.Cells["balance"].Value.ToString();
                txtProductsNumber.Text = row.Cells["products_number"].Value.ToString();
                txtCreditCard.Text = row.Cells["credit_card"].Value.ToString();
                txtActiveMember.Text = row.Cells["active_member"].Value.ToString();
                txtEstimatedSalary.Text = row.Cells["estimated_salary"].Value.ToString();
                txtChurn.Text = row.Cells["churn"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var newCustomer = new BankCustomerChurnPrediction
                {
                    customer_id = int.Parse(txtCustomerId.Text),
                    credit_score = int.Parse(txtCreditScore.Text),
                    country = txtCountry.Text,
                    gender = txtGender.Text,
                    age = int.Parse(txtAge.Text),
                    tenure = int.Parse(txtTenure.Text),
                    balance = double.Parse(txtBalance.Text),
                    products_number = int.Parse(txtProductsNumber.Text),
                    credit_card = int.Parse(txtCreditCard.Text),
                    active_member = int.Parse(txtActiveMember.Text),
                    estimated_salary = double.Parse(txtEstimatedSalary.Text),
                    churn = int.Parse(txtChurn.Text)
                };

                customerBLL.AddCustomer(newCustomer);
                MessageBox.Show("Thêm khách hàng thành công!");
                LoadCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm khách hàng: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = int.Parse(txtCustomerId.Text);
                customerBLL.DeleteCustomer(customerId);
                MessageBox.Show("Xóa khách hàng thành công!");
                LoadCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa khách hàng: {ex.Message}");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var updatedCustomer = new BankCustomerChurnPrediction
                {
                    customer_id = int.Parse(txtCustomerId.Text),
                    credit_score = int.Parse(txtCreditScore.Text),
                    country = txtCountry.Text,
                    gender = txtGender.Text,
                    age = int.Parse(txtAge.Text),
                    tenure = int.Parse(txtTenure.Text),
                    balance = double.Parse(txtBalance.Text),
                    products_number = int.Parse(txtProductsNumber.Text),
                    credit_card = int.Parse(txtCreditCard.Text),
                    active_member = int.Parse(txtActiveMember.Text),
                    estimated_salary = double.Parse(txtEstimatedSalary.Text),
                    churn = int.Parse(txtChurn.Text)
                };

                customerBLL.UpdateCustomer(updatedCustomer);
                MessageBox.Show("Cập nhật khách hàng thành công!");
                LoadCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật khách hàng: {ex.Message}");
            }
        }
    }
}
