using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.BLL
{
    public class CustomerDAL
    {
        public QLNHDataContext db; 

        // Lấy danh sách khách hàng
        public CustomerDAL(QLNHDataContext db)
        {
            this.db = db;
        }
        public List<BankCustomerChurnPrediction> GetAllCustomers()
        {
            return db.BankCustomerChurnPredictions.ToList();
        }

        // Thêm khách hàng mới
        public void AddCustomer(BankCustomerChurnPrediction customer)
        {
            db.BankCustomerChurnPredictions.InsertOnSubmit(customer);
            db.SubmitChanges();
        }

        // Xóa khách hàng
        public void DeleteCustomer(int customerId)
        {
            var customer = db.BankCustomerChurnPredictions.FirstOrDefault(c => c.customer_id == customerId);
            if (customer != null)
            {
                db.BankCustomerChurnPredictions.DeleteOnSubmit(customer); // Sử dụng DeleteOnSubmit
                db.SubmitChanges(); 
            }
        }


        // Cập nhật thông tin khách hàng
        public void UpdateCustomer(BankCustomerChurnPrediction updatedCustomer)
        {
            var customer = db.BankCustomerChurnPredictions.FirstOrDefault(c => c.customer_id == updatedCustomer.customer_id);
            if (customer != null)
            {
                customer.credit_score = updatedCustomer.credit_score;
                customer.country = updatedCustomer.country;
                customer.gender = updatedCustomer.gender;
                customer.age = updatedCustomer.age;
                customer.tenure = updatedCustomer.tenure;
                customer.balance = updatedCustomer.balance;
                customer.products_number = updatedCustomer.products_number;
                customer.credit_card = updatedCustomer.credit_card;
                customer.active_member = updatedCustomer.active_member;
                customer.estimated_salary = updatedCustomer.estimated_salary;
                customer.churn = updatedCustomer.churn;

                db.SubmitChanges();
            }
        }
    }
}
