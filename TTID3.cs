using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning;
using System;
using System.Collections.Generic;
using QLNH.BLL;

namespace QLNH
{
    public class TTID3
    {
        private CustomerBLL customerBLL;
        private DecisionTree tree;

        public TTID3(CustomerBLL customerBLL)
        {
            this.customerBLL = customerBLL;
        }

        /// <summary>
        /// Chuyển đổi dữ liệu khách hàng thành các nhãn rời rạc (discrete categories).
        /// </summary>
        private Tuple<int[][], int[]> PrepareData(List<BankCustomerChurnPrediction> customers)
        {
            var data = new List<int[]>();
            var labels = new List<int>();

            foreach (var customer in customers)
            {
                // Phân loại dữ liệu (binning)
                int ageCategory = customer.age < 18 ? 0 : customer.age <= 25 ? 1 : customer.age <= 50 ? 2 : 3;
                int tenureCategory = customer.tenure <= 3 ? 0 : customer.tenure <= 6 ? 1 : 2;
                int balanceCategory = customer.balance < 20000 ? 0 : customer.balance <= 50000 ? 1 : customer.balance <= 100000 ? 2 : 3;
                int salaryCategory = customer.estimated_salary < 30000 ? 0 : customer.estimated_salary <= 60000 ? 1 : 2;

                int productNumber = customer.products_number.HasValue && customer.products_number.Value >= 1 && customer.products_number.Value <= 3
                    ? (int)customer.products_number.Value - 1 : 0;
                int creditCard = customer.credit_card.HasValue ? (customer.credit_card.Value == 1 ? 1 : 0) : 0;
                int activeMember = customer.active_member.HasValue ? (customer.active_member.Value == 1 ? 1 : 0) : 0;

                data.Add(new int[]
                {
                    ageCategory,
                    tenureCategory,
                    balanceCategory,
                    productNumber,
                    creditCard,
                    activeMember,
                    salaryCategory
                });

                labels.Add(customer.churn.HasValue && customer.churn.Value == 1 ? 1 : 0);
            }

            return Tuple.Create(data.ToArray(), labels.ToArray());
        }

        /// <summary>
        /// Huấn luyện cây quyết định bằng thuật toán ID3.
        /// </summary>
        public void TrainID3()
        {
            var customers = customerBLL.GetAllCustomers();
            var result = PrepareData(customers);

            // Dữ liệu đầu vào và nhãn
            var inputs = result.Item1;
            var outputs = result.Item2;

            // Định nghĩa các thuộc tính
            var attributes = new[]
            {
                new DecisionVariable("age", 4),               // 4 giá trị: 0, 1, 2, 3
                new DecisionVariable("tenure", 3),           // 3 giá trị: 0, 1, 2
                new DecisionVariable("balance", 4),          // 4 giá trị: 0, 1, 2, 3
                new DecisionVariable("products_number", 3),  // 3 giá trị: 0, 1, 2
                new DecisionVariable("credit_card", 2),      // 2 giá trị: 0, 1
                new DecisionVariable("active_member", 2),    // 2 giá trị: 0, 1
                new DecisionVariable("estimated_salary", 3)  // 3 giá trị: 0, 1, 2
            };

            // Tạo cây quyết định
            tree = new DecisionTree(attributes, 2);

            // Huấn luyện cây bằng thuật toán ID3
            var teacher = new ID3Learning(tree);
            teacher.Run(inputs, outputs);

            Console.WriteLine("Cây quyết định đã được huấn luyện thành công.");
        }

        /// <summary>
        /// Dự đoán khả năng rời đi của một khách hàng.
        /// </summary>
        public int PredictChurn(BankCustomerChurnPrediction customer)
        {
            if (tree == null)
            {
                Console.WriteLine("Cây quyết định chưa được huấn luyện.");
                return -1;
            }

            // Phân loại dữ liệu đầu vào
            int ageCategory = customer.age < 18 ? 0 : customer.age <= 25 ? 1 : customer.age <= 50 ? 2 : 3;
            int tenureCategory = customer.tenure <= 3 ? 0 : customer.tenure <= 6 ? 1 : 2;
            int balanceCategory = customer.balance < 20000 ? 0 : customer.balance <= 50000 ? 1 : customer.balance <= 100000 ? 2 : 3;
            int salaryCategory = customer.estimated_salary < 30000 ? 0 : customer.estimated_salary <= 60000 ? 1 : 2;

            int productNumber = customer.products_number.HasValue && customer.products_number.Value >= 1 && customer.products_number.Value <= 3
                    ? (int)customer.products_number.Value - 1 : 0;
            int creditCard = customer.credit_card.HasValue ? (customer.credit_card.Value == 1 ? 1 : 0) : 0;
            int activeMember = customer.active_member.HasValue ? (customer.active_member.Value == 1 ? 1 : 0) : 0;

            int[] input = new int[]
            {
                ageCategory,
                tenureCategory,
                balanceCategory,
                productNumber,
                creditCard,
                activeMember,
                salaryCategory
            };

            // Dự đoán nhãn
            int label = tree.Decide(input);
            return label;
        }

        /// <summary>
        /// Hiển thị cấu trúc cây quyết định.
        /// </summary>
        public string DisplayTree()
        {
            if (tree == null)
            {
                Console.WriteLine("Cây quyết định chưa được huấn luyện.");
                return null;
            }

            Console.WriteLine("Cấu trúc cây quyết định:");
            Console.WriteLine(tree.ToString());
            return tree.ToString();
        }
    }
}
