//using Accord.MachineLearning;
//using QLNH.BLL;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace QLNH
//{
//    public class CustomerChurnPrediction
//    {

//        private CustomerBLL customerBLL;
//        public CustomerChurnPrediction(CustomerBLL customerBLL)
//        {
//            this.customerBLL = customerBLL;
//        }
//        public double[][] PrepareData(List<_Bank_Customer_Churn_Prediction__> customers)
//        {
//            List<double[]> data = new List<double[]>();

//            foreach (var customer in customers)
//            {
//                data.Add(new double[]
//                {
//                    customer.age ?? 0,
//                    customer.tenure ?? 0,
//                    customer.balance ?? 0,
//                    customer.products_number ?? 0,
//                    customer.credit_card.HasValue ? (customer.credit_card.Value == 1 ? 1 : 0) : 0,
//                    customer.active_member.HasValue ? (customer.active_member.Value == 1 ? 1 : 0) : 0,
//                    customer.estimated_salary ?? 0     
//                });
//            }

//            return data.ToArray();
//        }

//        public void TrainKMeansAndPredict()
//        {
//            var customers = customerBLL.GetAllCustomers();
//            var data = PrepareData(customers);

//            int k = 2; 

//            var kmeans = new KMeans(k);

//            var clusters = kmeans.Learn(data);

//            int[] predictedLabels = clusters.Decide(data);

//            double sse = 0;
//            double totalDistance = 0;

//            for (int i = 0; i < data.Length; i++)
//            {
//                var centroid = clusters.Centroids[predictedLabels[i]];  
//                double distance = 0;

//                for (int j = 0; j < data[i].Length; j++)
//                {
//                    distance += Math.Pow(data[i][j] - centroid[j], 2);
//                }

//                sse += distance;
//            }

//            double[] globalCentroid = new double[data[0].Length];
//            for (int i = 0; i < data.Length; i++)
//            {
//                for (int j = 0; j < data[i].Length; j++)
//                {
//                    globalCentroid[j] += data[i][j];
//                }
//            }

//            for (int j = 0; j < globalCentroid.Length; j++)
//            {
//                globalCentroid[j] /= data.Length; 
//            }

//            double totalIdealDistance = 0;
//            for (int i = 0; i < data.Length; i++)
//            {
//                double idealDistance = 0;
//                for (int j = 0; j < data[i].Length; j++)
//                {
//                    idealDistance += Math.Pow(data[i][j] - globalCentroid[j], 2);
//                }
//                totalIdealDistance += idealDistance;
//            }

//            // Tính phần trăm sai số (SSE%)
//            double ssePercentage = (sse / totalIdealDistance);

//            // Hiển thị kết quả phân nhóm và SSE
//            //Console.WriteLine("Dự đoán phân nhóm khách hàng:");
//            //for (int i = 0; i < predictedLabels.Length; i++)
//            //{
//            //    Console.WriteLine("Khách hàng " + customers[i].customer_id + " phân nhóm: " + predictedLabels[i]);
//            //}

//            // Hiển thị tổng sai số (SSE) và phần trăm sai số (SSE%)
//            Console.WriteLine("Tổng sai số (SSE): " + sse);
//            Console.WriteLine("Phần trăm sai số (SSE%): " + ssePercentage + "%");
//        }

//    }
//}
