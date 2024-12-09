namespace QLNH
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label credit_scoreLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label tenureLabel;
            System.Windows.Forms.Label balanceLabel;
            System.Windows.Forms.Label products_numberLabel;
            System.Windows.Forms.Label credit_cardLabel;
            System.Windows.Forms.Label active_memberLabel;
            System.Windows.Forms.Label estimated_salaryLabel;
            System.Windows.Forms.Label churnLabel;
            this.dataSet1 = new QLNH.DataSet1();
            this._Bank_Customer_Churn_Prediction__BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Bank_Customer_Churn_Prediction__TableAdapter = new QLNH.DataSet1TableAdapters._Bank_Customer_Churn_Prediction__TableAdapter();
            this.tableAdapterManager = new QLNH.DataSet1TableAdapters.TableAdapterManager();
            this._Bank_Customer_Churn_Prediction__BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this._Bank_Customer_Churn_Prediction__BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this._Bank_Customer_Churn_Prediction__DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_idTextBox = new System.Windows.Forms.TextBox();
            this.credit_scoreTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.tenureTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.products_numberTextBox = new System.Windows.Forms.TextBox();
            this.credit_cardTextBox = new System.Windows.Forms.TextBox();
            this.active_memberTextBox = new System.Windows.Forms.TextBox();
            this.estimated_salaryTextBox = new System.Windows.Forms.TextBox();
            this.churnTextBox = new System.Windows.Forms.TextBox();
            customer_idLabel = new System.Windows.Forms.Label();
            credit_scoreLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            tenureLabel = new System.Windows.Forms.Label();
            balanceLabel = new System.Windows.Forms.Label();
            products_numberLabel = new System.Windows.Forms.Label();
            credit_cardLabel = new System.Windows.Forms.Label();
            active_memberLabel = new System.Windows.Forms.Label();
            estimated_salaryLabel = new System.Windows.Forms.Label();
            churnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Bank_Customer_Churn_Prediction__BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Bank_Customer_Churn_Prediction__BindingNavigator)).BeginInit();
            this._Bank_Customer_Churn_Prediction__BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Bank_Customer_Churn_Prediction__DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _Bank_Customer_Churn_Prediction__BindingSource
            // 
            this._Bank_Customer_Churn_Prediction__BindingSource.DataMember = "\'Bank Customer Churn Prediction$\'";
            this._Bank_Customer_Churn_Prediction__BindingSource.DataSource = this.dataSet1;
            // 
            // _Bank_Customer_Churn_Prediction__TableAdapter
            // 
            this._Bank_Customer_Churn_Prediction__TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._Bank_Customer_Churn_Prediction__TableAdapter = this._Bank_Customer_Churn_Prediction__TableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = QLNH.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // _Bank_Customer_Churn_Prediction__BindingNavigator
            // 
            this._Bank_Customer_Churn_Prediction__BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this._Bank_Customer_Churn_Prediction__BindingNavigator.BindingSource = this._Bank_Customer_Churn_Prediction__BindingSource;
            this._Bank_Customer_Churn_Prediction__BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this._Bank_Customer_Churn_Prediction__BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this._Bank_Customer_Churn_Prediction__BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this._Bank_Customer_Churn_Prediction__BindingNavigatorSaveItem});
            this._Bank_Customer_Churn_Prediction__BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this._Bank_Customer_Churn_Prediction__BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._Bank_Customer_Churn_Prediction__BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._Bank_Customer_Churn_Prediction__BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._Bank_Customer_Churn_Prediction__BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._Bank_Customer_Churn_Prediction__BindingNavigator.Name = "_Bank_Customer_Churn_Prediction__BindingNavigator";
            this._Bank_Customer_Churn_Prediction__BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this._Bank_Customer_Churn_Prediction__BindingNavigator.Size = new System.Drawing.Size(1189, 25);
            this._Bank_Customer_Churn_Prediction__BindingNavigator.TabIndex = 0;
            this._Bank_Customer_Churn_Prediction__BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // _Bank_Customer_Churn_Prediction__BindingNavigatorSaveItem
            // 
            this._Bank_Customer_Churn_Prediction__BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._Bank_Customer_Churn_Prediction__BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("_Bank_Customer_Churn_Prediction__BindingNavigatorSaveItem.Image")));
            this._Bank_Customer_Churn_Prediction__BindingNavigatorSaveItem.Name = "_Bank_Customer_Churn_Prediction__BindingNavigatorSaveItem";
            this._Bank_Customer_Churn_Prediction__BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this._Bank_Customer_Churn_Prediction__BindingNavigatorSaveItem.Text = "Save Data";
            this._Bank_Customer_Churn_Prediction__BindingNavigatorSaveItem.Click += new System.EventHandler(this._Bank_Customer_Churn_Prediction__BindingNavigatorSaveItem_Click);
            // 
            // _Bank_Customer_Churn_Prediction__DataGridView
            // 
            this._Bank_Customer_Churn_Prediction__DataGridView.AutoGenerateColumns = false;
            this._Bank_Customer_Churn_Prediction__DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._Bank_Customer_Churn_Prediction__DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Bank_Customer_Churn_Prediction__DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this._Bank_Customer_Churn_Prediction__DataGridView.DataSource = this._Bank_Customer_Churn_Prediction__BindingSource;
            this._Bank_Customer_Churn_Prediction__DataGridView.Location = new System.Drawing.Point(0, 204);
            this._Bank_Customer_Churn_Prediction__DataGridView.Name = "_Bank_Customer_Churn_Prediction__DataGridView";
            this._Bank_Customer_Churn_Prediction__DataGridView.Size = new System.Drawing.Size(1112, 357);
            this._Bank_Customer_Churn_Prediction__DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "customer_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "customer_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "credit_score";
            this.dataGridViewTextBoxColumn2.HeaderText = "credit_score";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn3.HeaderText = "country";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "gender";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn5.HeaderText = "age";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tenure";
            this.dataGridViewTextBoxColumn6.HeaderText = "tenure";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "balance";
            this.dataGridViewTextBoxColumn7.HeaderText = "balance";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "products_number";
            this.dataGridViewTextBoxColumn8.HeaderText = "products_number";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "credit_card";
            this.dataGridViewTextBoxColumn9.HeaderText = "credit_card";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "active_member";
            this.dataGridViewTextBoxColumn10.HeaderText = "active_member";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "estimated_salary";
            this.dataGridViewTextBoxColumn11.HeaderText = "estimated_salary";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "churn";
            this.dataGridViewTextBoxColumn12.HeaderText = "churn";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(30, 52);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(64, 13);
            customer_idLabel.TabIndex = 2;
            customer_idLabel.Text = "customer id:";
            // 
            // customer_idTextBox
            // 
            this.customer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._Bank_Customer_Churn_Prediction__BindingSource, "customer_id", true));
            this.customer_idTextBox.Location = new System.Drawing.Point(100, 49);
            this.customer_idTextBox.Name = "customer_idTextBox";
            this.customer_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.customer_idTextBox.TabIndex = 3;
            // 
            // credit_scoreLabel
            // 
            credit_scoreLabel.AutoSize = true;
            credit_scoreLabel.Location = new System.Drawing.Point(113, 115);
            credit_scoreLabel.Name = "credit_scoreLabel";
            credit_scoreLabel.Size = new System.Drawing.Size(65, 13);
            credit_scoreLabel.TabIndex = 4;
            credit_scoreLabel.Text = "credit score:";
            // 
            // credit_scoreTextBox
            // 
            this.credit_scoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._Bank_Customer_Churn_Prediction__BindingSource, "credit_score", true));
            this.credit_scoreTextBox.Location = new System.Drawing.Point(184, 112);
            this.credit_scoreTextBox.Name = "credit_scoreTextBox";
            this.credit_scoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.credit_scoreTextBox.TabIndex = 5;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(372, 68);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(45, 13);
            countryLabel.TabIndex = 6;
            countryLabel.Text = "country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._Bank_Customer_Churn_Prediction__BindingSource, "country", true));
            this.countryTextBox.Location = new System.Drawing.Point(423, 65);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 7;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(409, 117);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(43, 13);
            genderLabel.TabIndex = 8;
            genderLabel.Text = "gender:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._Bank_Customer_Churn_Prediction__BindingSource, "gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(458, 114);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 20);
            this.genderTextBox.TabIndex = 9;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(661, 57);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(28, 13);
            ageLabel.TabIndex = 10;
            ageLabel.Text = "age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._Bank_Customer_Churn_Prediction__BindingSource, "age", true));
            this.ageTextBox.Location = new System.Drawing.Point(695, 54);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 11;
            // 
            // tenureLabel
            // 
            tenureLabel.AutoSize = true;
            tenureLabel.Location = new System.Drawing.Point(683, 105);
            tenureLabel.Name = "tenureLabel";
            tenureLabel.Size = new System.Drawing.Size(40, 13);
            tenureLabel.TabIndex = 12;
            tenureLabel.Text = "tenure:";
            // 
            // tenureTextBox
            // 
            this.tenureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._Bank_Customer_Churn_Prediction__BindingSource, "tenure", true));
            this.tenureTextBox.Location = new System.Drawing.Point(729, 102);
            this.tenureTextBox.Name = "tenureTextBox";
            this.tenureTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenureTextBox.TabIndex = 13;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new System.Drawing.Point(892, 58);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(48, 13);
            balanceLabel.TabIndex = 14;
            balanceLabel.Text = "balance:";
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._Bank_Customer_Churn_Prediction__BindingSource, "balance", true));
            this.balanceTextBox.Location = new System.Drawing.Point(946, 55);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.balanceTextBox.TabIndex = 15;
            // 
            // products_numberLabel
            // 
            products_numberLabel.AutoSize = true;
            products_numberLabel.Location = new System.Drawing.Point(925, 109);
            products_numberLabel.Name = "products_numberLabel";
            products_numberLabel.Size = new System.Drawing.Size(89, 13);
            products_numberLabel.TabIndex = 16;
            products_numberLabel.Text = "products number:";
            // 
            // products_numberTextBox
            // 
            this.products_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._Bank_Customer_Churn_Prediction__BindingSource, "products_number", true));
            this.products_numberTextBox.Location = new System.Drawing.Point(1020, 106);
            this.products_numberTextBox.Name = "products_numberTextBox";
            this.products_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.products_numberTextBox.TabIndex = 17;
            // 
            // credit_cardLabel
            // 
            credit_cardLabel.AutoSize = true;
            credit_cardLabel.Location = new System.Drawing.Point(230, 172);
            credit_cardLabel.Name = "credit_cardLabel";
            credit_cardLabel.Size = new System.Drawing.Size(60, 13);
            credit_cardLabel.TabIndex = 18;
            credit_cardLabel.Text = "credit card:";
            // 
            // credit_cardTextBox
            // 
            this.credit_cardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._Bank_Customer_Churn_Prediction__BindingSource, "credit_card", true));
            this.credit_cardTextBox.Location = new System.Drawing.Point(296, 169);
            this.credit_cardTextBox.Name = "credit_cardTextBox";
            this.credit_cardTextBox.Size = new System.Drawing.Size(100, 20);
            this.credit_cardTextBox.TabIndex = 19;
            // 
            // active_memberLabel
            // 
            active_memberLabel.AutoSize = true;
            active_memberLabel.Location = new System.Drawing.Point(522, 158);
            active_memberLabel.Name = "active_memberLabel";
            active_memberLabel.Size = new System.Drawing.Size(79, 13);
            active_memberLabel.TabIndex = 20;
            active_memberLabel.Text = "active member:";
            // 
            // active_memberTextBox
            // 
            this.active_memberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._Bank_Customer_Churn_Prediction__BindingSource, "active_member", true));
            this.active_memberTextBox.Location = new System.Drawing.Point(607, 155);
            this.active_memberTextBox.Name = "active_memberTextBox";
            this.active_memberTextBox.Size = new System.Drawing.Size(100, 20);
            this.active_memberTextBox.TabIndex = 21;
            // 
            // estimated_salaryLabel
            // 
            estimated_salaryLabel.AutoSize = true;
            estimated_salaryLabel.Location = new System.Drawing.Point(793, 158);
            estimated_salaryLabel.Name = "estimated_salaryLabel";
            estimated_salaryLabel.Size = new System.Drawing.Size(85, 13);
            estimated_salaryLabel.TabIndex = 22;
            estimated_salaryLabel.Text = "estimated salary:";
            // 
            // estimated_salaryTextBox
            // 
            this.estimated_salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._Bank_Customer_Churn_Prediction__BindingSource, "estimated_salary", true));
            this.estimated_salaryTextBox.Location = new System.Drawing.Point(884, 155);
            this.estimated_salaryTextBox.Name = "estimated_salaryTextBox";
            this.estimated_salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.estimated_salaryTextBox.TabIndex = 23;
            // 
            // churnLabel
            // 
            churnLabel.AutoSize = true;
            churnLabel.Location = new System.Drawing.Point(1026, 165);
            churnLabel.Name = "churnLabel";
            churnLabel.Size = new System.Drawing.Size(37, 13);
            churnLabel.TabIndex = 24;
            churnLabel.Text = "churn:";
            // 
            // churnTextBox
            // 
            this.churnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._Bank_Customer_Churn_Prediction__BindingSource, "churn", true));
            this.churnTextBox.Location = new System.Drawing.Point(1069, 162);
            this.churnTextBox.Name = "churnTextBox";
            this.churnTextBox.Size = new System.Drawing.Size(100, 20);
            this.churnTextBox.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 581);
            this.Controls.Add(churnLabel);
            this.Controls.Add(this.churnTextBox);
            this.Controls.Add(estimated_salaryLabel);
            this.Controls.Add(this.estimated_salaryTextBox);
            this.Controls.Add(active_memberLabel);
            this.Controls.Add(this.active_memberTextBox);
            this.Controls.Add(credit_cardLabel);
            this.Controls.Add(this.credit_cardTextBox);
            this.Controls.Add(products_numberLabel);
            this.Controls.Add(this.products_numberTextBox);
            this.Controls.Add(balanceLabel);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(tenureLabel);
            this.Controls.Add(this.tenureTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(credit_scoreLabel);
            this.Controls.Add(this.credit_scoreTextBox);
            this.Controls.Add(customer_idLabel);
            this.Controls.Add(this.customer_idTextBox);
            this.Controls.Add(this._Bank_Customer_Churn_Prediction__DataGridView);
            this.Controls.Add(this._Bank_Customer_Churn_Prediction__BindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Bank_Customer_Churn_Prediction__BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Bank_Customer_Churn_Prediction__BindingNavigator)).EndInit();
            this._Bank_Customer_Churn_Prediction__BindingNavigator.ResumeLayout(false);
            this._Bank_Customer_Churn_Prediction__BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Bank_Customer_Churn_Prediction__DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource _Bank_Customer_Churn_Prediction__BindingSource;
        private DataSet1TableAdapters._Bank_Customer_Churn_Prediction__TableAdapter _Bank_Customer_Churn_Prediction__TableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator _Bank_Customer_Churn_Prediction__BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton _Bank_Customer_Churn_Prediction__BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView _Bank_Customer_Churn_Prediction__DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TextBox customer_idTextBox;
        private System.Windows.Forms.TextBox credit_scoreTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox tenureTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox products_numberTextBox;
        private System.Windows.Forms.TextBox credit_cardTextBox;
        private System.Windows.Forms.TextBox active_memberTextBox;
        private System.Windows.Forms.TextBox estimated_salaryTextBox;
        private System.Windows.Forms.TextBox churnTextBox;
    }
}