namespace DrivingMissDaisy
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
            System.Windows.Forms.Label driver_NameLabel;
            System.Windows.Forms.Label driver_PhoneLabel;
            System.Windows.Forms.Label capacity_NumberLabel;
            System.Windows.Forms.Label capacity_TypeLabel;
            System.Windows.Forms.Label available_DateLabel;
            System.Windows.Forms.Label equipmentLabel;
            System.Windows.Forms.Label available_CityLabel;
            System.Windows.Forms.Label available_StateLabel;
            System.Windows.Forms.Label fedex_DriverLabel;
            System.Windows.Forms.Label desired_CityLabel;
            System.Windows.Forms.Label desired_StateLabel;
            System.Windows.Forms.Label commentsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dab1DataSet = new DrivingMissDaisy.Dab1DataSet();
            this.dab1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driversTableAdapter = new DrivingMissDaisy.Dab1DataSetTableAdapters.DriversTableAdapter();
            this.tableAdapterManager = new DrivingMissDaisy.Dab1DataSetTableAdapters.TableAdapterManager();
            this.driversDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_NameTextBox = new System.Windows.Forms.TextBox();
            this.driver_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.capacity_NumberTextBox = new System.Windows.Forms.TextBox();
            this.capacity_TypeTextBox = new System.Windows.Forms.TextBox();
            this.available_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.equipmentTextBox = new System.Windows.Forms.TextBox();
            this.available_CityTextBox = new System.Windows.Forms.TextBox();
            this.available_StateTextBox = new System.Windows.Forms.TextBox();
            this.fedex_DriverTextBox = new System.Windows.Forms.TextBox();
            this.desired_CityTextBox = new System.Windows.Forms.TextBox();
            this.desired_StateTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            driver_NameLabel = new System.Windows.Forms.Label();
            driver_PhoneLabel = new System.Windows.Forms.Label();
            capacity_NumberLabel = new System.Windows.Forms.Label();
            capacity_TypeLabel = new System.Windows.Forms.Label();
            available_DateLabel = new System.Windows.Forms.Label();
            equipmentLabel = new System.Windows.Forms.Label();
            available_CityLabel = new System.Windows.Forms.Label();
            available_StateLabel = new System.Windows.Forms.Label();
            fedex_DriverLabel = new System.Windows.Forms.Label();
            desired_CityLabel = new System.Windows.Forms.Label();
            desired_StateLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dab1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dab1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // driver_NameLabel
            // 
            driver_NameLabel.AutoSize = true;
            driver_NameLabel.Location = new System.Drawing.Point(251, 48);
            driver_NameLabel.Name = "driver_NameLabel";
            driver_NameLabel.Size = new System.Drawing.Size(69, 13);
            driver_NameLabel.TabIndex = 3;
            driver_NameLabel.Text = "Driver Name:";
            // 
            // driver_PhoneLabel
            // 
            driver_PhoneLabel.AutoSize = true;
            driver_PhoneLabel.Location = new System.Drawing.Point(248, 80);
            driver_PhoneLabel.Name = "driver_PhoneLabel";
            driver_PhoneLabel.Size = new System.Drawing.Size(72, 13);
            driver_PhoneLabel.TabIndex = 5;
            driver_PhoneLabel.Text = "Driver Phone:";
            // 
            // capacity_NumberLabel
            // 
            capacity_NumberLabel.AutoSize = true;
            capacity_NumberLabel.Location = new System.Drawing.Point(229, 116);
            capacity_NumberLabel.Name = "capacity_NumberLabel";
            capacity_NumberLabel.Size = new System.Drawing.Size(91, 13);
            capacity_NumberLabel.TabIndex = 7;
            capacity_NumberLabel.Text = "Capacity Number:";
            // 
            // capacity_TypeLabel
            // 
            capacity_TypeLabel.AutoSize = true;
            capacity_TypeLabel.Location = new System.Drawing.Point(242, 142);
            capacity_TypeLabel.Name = "capacity_TypeLabel";
            capacity_TypeLabel.Size = new System.Drawing.Size(78, 13);
            capacity_TypeLabel.TabIndex = 9;
            capacity_TypeLabel.Text = "Capacity Type:";
            // 
            // available_DateLabel
            // 
            available_DateLabel.AutoSize = true;
            available_DateLabel.Location = new System.Drawing.Point(503, 84);
            available_DateLabel.Name = "available_DateLabel";
            available_DateLabel.Size = new System.Drawing.Size(79, 13);
            available_DateLabel.TabIndex = 11;
            available_DateLabel.Text = "Available Date:";
            // 
            // equipmentLabel
            // 
            equipmentLabel.AutoSize = true;
            equipmentLabel.Location = new System.Drawing.Point(471, 131);
            equipmentLabel.Name = "equipmentLabel";
            equipmentLabel.Size = new System.Drawing.Size(60, 13);
            equipmentLabel.TabIndex = 13;
            equipmentLabel.Text = "Equipment:";
            // 
            // available_CityLabel
            // 
            available_CityLabel.AutoSize = true;
            available_CityLabel.Location = new System.Drawing.Point(458, 44);
            available_CityLabel.Name = "available_CityLabel";
            available_CityLabel.Size = new System.Drawing.Size(73, 13);
            available_CityLabel.TabIndex = 15;
            available_CityLabel.Text = "Available City:";
            // 
            // available_StateLabel
            // 
            available_StateLabel.AutoSize = true;
            available_StateLabel.Location = new System.Drawing.Point(645, 45);
            available_StateLabel.Name = "available_StateLabel";
            available_StateLabel.Size = new System.Drawing.Size(81, 13);
            available_StateLabel.TabIndex = 17;
            available_StateLabel.Text = "Available State:";
            // 
            // fedex_DriverLabel
            // 
            fedex_DriverLabel.AutoSize = true;
            fedex_DriverLabel.Location = new System.Drawing.Point(673, 131);
            fedex_DriverLabel.Name = "fedex_DriverLabel";
            fedex_DriverLabel.Size = new System.Drawing.Size(70, 13);
            fedex_DriverLabel.TabIndex = 19;
            fedex_DriverLabel.Text = "Fedex Driver:";
            // 
            // desired_CityLabel
            // 
            desired_CityLabel.AutoSize = true;
            desired_CityLabel.Location = new System.Drawing.Point(465, 173);
            desired_CityLabel.Name = "desired_CityLabel";
            desired_CityLabel.Size = new System.Drawing.Size(66, 13);
            desired_CityLabel.TabIndex = 21;
            desired_CityLabel.Text = "Desired City:";
            // 
            // desired_StateLabel
            // 
            desired_StateLabel.AutoSize = true;
            desired_StateLabel.Location = new System.Drawing.Point(669, 176);
            desired_StateLabel.Name = "desired_StateLabel";
            desired_StateLabel.Size = new System.Drawing.Size(74, 13);
            desired_StateLabel.TabIndex = 23;
            desired_StateLabel.Text = "Desired State:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(271, 221);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(59, 13);
            commentsLabel.TabIndex = 25;
            commentsLabel.Text = "Comments:";
            // 
            // dab1DataSet
            // 
            this.dab1DataSet.DataSetName = "Dab1DataSet";
            this.dab1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dab1DataSetBindingSource
            // 
            this.dab1DataSetBindingSource.DataSource = this.dab1DataSet;
            this.dab1DataSetBindingSource.Position = 0;
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.dab1DataSet;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DriversTableAdapter = this.driversTableAdapter;
            this.tableAdapterManager.UpdateOrder = DrivingMissDaisy.Dab1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // driversDataGridView
            // 
            this.driversDataGridView.AutoGenerateColumns = false;
            this.driversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driversDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.driversDataGridView.DataSource = this.driversBindingSource;
            this.driversDataGridView.Location = new System.Drawing.Point(19, 317);
            this.driversDataGridView.Name = "driversDataGridView";
            this.driversDataGridView.Size = new System.Drawing.Size(1255, 268);
            this.driversDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DriverAA_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "DriverAA_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Driver_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Driver_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Driver_Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Driver_Phone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Capacity_Number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Capacity_Number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Capacity_Type";
            this.dataGridViewTextBoxColumn5.HeaderText = "Capacity_Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Available_Date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Available_Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Equipment";
            this.dataGridViewTextBoxColumn7.HeaderText = "Equipment";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Available_City";
            this.dataGridViewTextBoxColumn8.HeaderText = "Available_City";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Available_State";
            this.dataGridViewTextBoxColumn9.HeaderText = "Available_State";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Fedex_Driver";
            this.dataGridViewTextBoxColumn10.HeaderText = "Fedex_Driver";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Desired_City";
            this.dataGridViewTextBoxColumn11.HeaderText = "Desired_City";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Desired_State";
            this.dataGridViewTextBoxColumn12.HeaderText = "Desired_State";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn13.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // driver_NameTextBox
            // 
            this.driver_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Driver_Name", true));
            this.driver_NameTextBox.Location = new System.Drawing.Point(326, 48);
            this.driver_NameTextBox.Name = "driver_NameTextBox";
            this.driver_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.driver_NameTextBox.TabIndex = 4;
            // 
            // driver_PhoneTextBox
            // 
            this.driver_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Driver_Phone", true));
            this.driver_PhoneTextBox.Location = new System.Drawing.Point(326, 77);
            this.driver_PhoneTextBox.Name = "driver_PhoneTextBox";
            this.driver_PhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.driver_PhoneTextBox.TabIndex = 6;
            // 
            // capacity_NumberTextBox
            // 
            this.capacity_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Capacity_Number", true));
            this.capacity_NumberTextBox.Location = new System.Drawing.Point(326, 113);
            this.capacity_NumberTextBox.Name = "capacity_NumberTextBox";
            this.capacity_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacity_NumberTextBox.TabIndex = 8;
            // 
            // capacity_TypeTextBox
            // 
            this.capacity_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Capacity_Type", true));
            this.capacity_TypeTextBox.Location = new System.Drawing.Point(326, 139);
            this.capacity_TypeTextBox.Name = "capacity_TypeTextBox";
            this.capacity_TypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacity_TypeTextBox.TabIndex = 10;
            // 
            // available_DateDateTimePicker
            // 
            this.available_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.driversBindingSource, "Available_Date", true));
            this.available_DateDateTimePicker.Location = new System.Drawing.Point(588, 80);
            this.available_DateDateTimePicker.Name = "available_DateDateTimePicker";
            this.available_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.available_DateDateTimePicker.TabIndex = 12;
            // 
            // equipmentTextBox
            // 
            this.equipmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Equipment", true));
            this.equipmentTextBox.Location = new System.Drawing.Point(537, 128);
            this.equipmentTextBox.Name = "equipmentTextBox";
            this.equipmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.equipmentTextBox.TabIndex = 14;
            // 
            // available_CityTextBox
            // 
            this.available_CityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Available_City", true));
            this.available_CityTextBox.Location = new System.Drawing.Point(537, 44);
            this.available_CityTextBox.Name = "available_CityTextBox";
            this.available_CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.available_CityTextBox.TabIndex = 16;
            // 
            // available_StateTextBox
            // 
            this.available_StateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Available_State", true));
            this.available_StateTextBox.Location = new System.Drawing.Point(732, 45);
            this.available_StateTextBox.Name = "available_StateTextBox";
            this.available_StateTextBox.Size = new System.Drawing.Size(100, 20);
            this.available_StateTextBox.TabIndex = 18;
            // 
            // fedex_DriverTextBox
            // 
            this.fedex_DriverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Fedex_Driver", true));
            this.fedex_DriverTextBox.Location = new System.Drawing.Point(749, 128);
            this.fedex_DriverTextBox.Name = "fedex_DriverTextBox";
            this.fedex_DriverTextBox.Size = new System.Drawing.Size(100, 20);
            this.fedex_DriverTextBox.TabIndex = 20;
            // 
            // desired_CityTextBox
            // 
            this.desired_CityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Desired_City", true));
            this.desired_CityTextBox.Location = new System.Drawing.Point(537, 170);
            this.desired_CityTextBox.Name = "desired_CityTextBox";
            this.desired_CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.desired_CityTextBox.TabIndex = 22;
            // 
            // desired_StateTextBox
            // 
            this.desired_StateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Desired_State", true));
            this.desired_StateTextBox.Location = new System.Drawing.Point(749, 173);
            this.desired_StateTextBox.Name = "desired_StateTextBox";
            this.desired_StateTextBox.Size = new System.Drawing.Size(100, 20);
            this.desired_StateTextBox.TabIndex = 24;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Comments", true));
            this.commentsTextBox.Location = new System.Drawing.Point(336, 218);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(468, 80);
            this.commentsTextBox.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(824, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(824, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Email";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.bindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1286, 25);
            this.bindingNavigator1.TabIndex = 29;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(920, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "clear all";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 642);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(desired_StateLabel);
            this.Controls.Add(this.desired_StateTextBox);
            this.Controls.Add(desired_CityLabel);
            this.Controls.Add(this.desired_CityTextBox);
            this.Controls.Add(fedex_DriverLabel);
            this.Controls.Add(this.fedex_DriverTextBox);
            this.Controls.Add(available_StateLabel);
            this.Controls.Add(this.available_StateTextBox);
            this.Controls.Add(available_CityLabel);
            this.Controls.Add(this.available_CityTextBox);
            this.Controls.Add(equipmentLabel);
            this.Controls.Add(this.equipmentTextBox);
            this.Controls.Add(available_DateLabel);
            this.Controls.Add(this.available_DateDateTimePicker);
            this.Controls.Add(capacity_TypeLabel);
            this.Controls.Add(this.capacity_TypeTextBox);
            this.Controls.Add(capacity_NumberLabel);
            this.Controls.Add(this.capacity_NumberTextBox);
            this.Controls.Add(driver_PhoneLabel);
            this.Controls.Add(this.driver_PhoneTextBox);
            this.Controls.Add(driver_NameLabel);
            this.Controls.Add(this.driver_NameTextBox);
            this.Controls.Add(this.driversDataGridView);
            this.Name = "Form1";
            this.Text = "Driver Availability";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dab1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dab1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dab1DataSetBindingSource;
        private Dab1DataSet dab1DataSet;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private Dab1DataSetTableAdapters.DriversTableAdapter driversTableAdapter;
        private Dab1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView driversDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.TextBox driver_NameTextBox;
        private System.Windows.Forms.TextBox driver_PhoneTextBox;
        private System.Windows.Forms.TextBox capacity_NumberTextBox;
        private System.Windows.Forms.TextBox capacity_TypeTextBox;
        private System.Windows.Forms.DateTimePicker available_DateDateTimePicker;
        private System.Windows.Forms.TextBox equipmentTextBox;
        private System.Windows.Forms.TextBox available_CityTextBox;
        private System.Windows.Forms.TextBox available_StateTextBox;
        private System.Windows.Forms.TextBox fedex_DriverTextBox;
        private System.Windows.Forms.TextBox desired_CityTextBox;
        private System.Windows.Forms.TextBox desired_StateTextBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
    }
}

