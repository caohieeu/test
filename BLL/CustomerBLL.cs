using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.BLL
{
    public class CustomerBLL
    {
        private static QLNHDataContext db = new QLNHDataContext();
        CustomerDAL cs = new CustomerDAL(db);
        public List<BankCustomerChurnPrediction> GetAllCustomers()
        {
            return cs.GetAllCustomers();
        }

        public void AddCustomer(BankCustomerChurnPrediction customer)
        {
            cs.AddCustomer(customer);
        }

        public void DeleteCustomer(int customerId)
        {
            cs.DeleteCustomer(customerId);
        }

        public void UpdateCustomer(BankCustomerChurnPrediction updatedCustomer)
        {
            cs.UpdateCustomer(updatedCustomer);
        }
    }
}
