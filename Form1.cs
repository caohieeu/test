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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _Bank_Customer_Churn_Prediction__BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._Bank_Customer_Churn_Prediction__BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.__Bank_Customer_Churn_Prediction__' table. You can move, or remove it, as needed.
            this._Bank_Customer_Churn_Prediction__TableAdapter.Fill(this.dataSet1.@__Bank_Customer_Churn_Prediction__);

        }
    }
}
