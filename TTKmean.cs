using Accord.MachineLearning;
using QLNH.BLL;
using System;
using System.Collections.Generic;

namespace QLNH
{
    public class TTKmean
    {
        private CustomerBLL customerBLL;
        private KMeansClusterCollection clusters; // Lưu cụm sau khi huấn luyện

        public TTKmean(CustomerBLL customerBLL)
        {
            this.customerBLL = customerBLL;
        }

        /// <summary>
        /// Chuyển danh sách khách hàng thành mảng dữ liệu đầu vào cho K-Means.
        /// </summary>
        /// <param name="customers">Danh sách khách hàng</param>
        /// <returns>Mảng dữ liệu double[][]</returns>
        private double[][] PrepareData(List<BankCustomerChurnPrediction> customers)
        {
            var data = new List<double[]>();

            foreach (var customer in customers)
            {
                data.Add(new double[]
                {
                    customer.age ?? 0,
                    customer.tenure ?? 0,
                    customer.balance ?? 0,
                    customer.products_number ?? 0,
                    customer.credit_card.HasValue ? (customer.credit_card.Value == 1 ? 1 : 0) : 0,
                    customer.active_member.HasValue ? (customer.active_member.Value == 1 ? 1 : 0) : 0,
                    customer.estimated_salary ?? 0
                });
            }

            return data.ToArray();
        }

        /// <summary>
        /// Huấn luyện mô hình K-Means và lưu kết quả vào clusters.
        /// </summary>
        public void TrainKMeans()
        {
            var customers = customerBLL.GetAllCustomers();
            var data = PrepareData(customers);

            int k = 2; // Số cụm (Rời đi và Không rời đi)
            var kmeans = new KMeans(k);

            clusters = kmeans.Learn(data);

            Console.WriteLine("Huấn luyện K-Means thành công!");
        }

        /// <summary>
        /// Dự đoán khả năng rời đi của một khách hàng.
        /// </summary>
        /// <param name="customer">Khách hàng cần dự đoán</param>
        /// <returns>1 nếu rời đi, 0 nếu không rời đi</returns>
        public int PredictChurn(BankCustomerChurnPrediction customer)
        {
            if (clusters == null)
            {
                Console.WriteLine("Mô hình chưa được huấn luyện. Vui lòng huấn luyện trước khi dự đoán.");
                return -1;
            }

            double[] customerData = new double[]
            {
                customer.age ?? 0,
                customer.tenure ?? 0,
                customer.balance ?? 0,
                customer.products_number ?? 0,
                customer.credit_card.HasValue ? (customer.credit_card.Value == 1 ? 1 : 0) : 0,
                customer.active_member.HasValue ? (customer.active_member.Value == 1 ? 1 : 0) : 0,
                customer.estimated_salary ?? 0
            };

            int[] labels = clusters.Decide(new double[][] { customerData });

            // Giả định cụm 1 là "rời đi", cụm 0 là "không rời đi"
            int churnPrediction = labels[0] == 1 ? 1 : 0;

            Console.WriteLine($"Khách hàng {(churnPrediction == 1 ? "rời đi" : "không rời đi")}.");
            return churnPrediction;
        }

        /// <summary>
        /// Hiển thị thông tin về phân cụm và tính tổng sai số SSE.
        /// </summary>
        public void EvaluateClusters()
        {
            if (clusters == null)
            {
                Console.WriteLine("Mô hình chưa được huấn luyện. Vui lòng huấn luyện trước khi đánh giá.");
                return;
            }

            var customers = customerBLL.GetAllCustomers();
            var data = PrepareData(customers);

            int[] predictedLabels = clusters.Decide(data);
            double sse = CalculateSSE(data, predictedLabels, clusters.Centroids);

            Console.WriteLine("Tổng sai số (SSE): " + sse);
        }

        /// <summary>
        /// Tính SSE dựa trên kết quả cụm và tâm cụm.
        /// </summary>
        private double CalculateSSE(double[][] data, int[] labels, double[][] centroids)
        {
            double sse = 0;

            for (int i = 0; i < data.Length; i++)
            {
                var centroid = centroids[labels[i]];
                double distance = 0;

                for (int j = 0; j < data[i].Length; j++)
                {
                    distance += Math.Pow(data[i][j] - centroid[j], 2);
                }

                sse += distance;
            }

            return sse;
        }
    }
}
