using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace DrivingMissDaisy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dab1DataSet.Drivers' table. You can move, or remove it, as needed.

            this.driversTableAdapter.Fill(this.dab1DataSet.Drivers);

            try
            {
                String str = "Data Source=ALICE-PC\\ALICE;Initial Catalog=Dab1;Integrated Security=True";
                String query = "select * from Drivers ORDER BY [Available_Date] DESC";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("Connected to Drivers!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                String str = "Data Source=ALICE-PC\\ALICE;Initial Catalog=Dab1;Integrated Security=True";
             //   String query = "select * from Drivers";
                SqlConnection con = new SqlConnection(str);
               // SqlCommand cmd = new SqlCommand(query, con);
                con.Close();
                MessageBox.Show("Disconnected from database!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
            driver_NameTextBox.Text = null;
            driver_PhoneTextBox.Text = null;
            capacity_NumberTextBox.Text = null;
            capacity_TypeTextBox.Text = null;
            available_DateDateTimePicker.Text = null;
            equipmentTextBox.Text = null;
            available_CityTextBox.Text = null;
            available_StateTextBox.Text = null;
            fedex_DriverTextBox.Text = null;
            desired_CityTextBox.Text = null;
            desired_StateTextBox.Text = null;
            commentsTextBox.Text = null;
            */
            // this line gives an error: this.bindingNavigator1.BindingSource.AddNew();
           //this doesnt work either: bindingNavigator1.BindingSource.AddNew();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           // this.bindingNavigator1.BindingSource.AddNew();
            //this.bindingNavigator1.BindingSource.MoveLast();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            /*  try
            {
                this.Validate();
                this.driversBindingSource.EndEdit();
                this.driversTableAdapter.Update(this.dab1DataSet.Drivers);
                MessageBox.Show("Update Successful!");
                this.driversTableAdapter.Fill(this.dab1DataSet.Drivers);

            }
            catch (Exception ex)
            {
                MessageBox.Show("update failed!!! :(");
            }
            */

            String connectionString = "Data Source=ALICE-PC\\ALICE;Initial Catalog=Dab1;Integrated Security=True";
            string sql = null;

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                sql = "insert into Drivers (Driver_Name, Driver_Phone,Capacity_Number,Capacity_Type,Available_Date,Equipment,Available_City,Available_State,Fedex_Driver,Desired_City,Desired_State,Comments) values (@drivername, @driverphone, @capacitynumber, @capacitytype, @availabledate, @equipment, @availablecity, @availablestate, @fedexdriver, @desiredcity, @desiredstate, @comments)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@drivername", driver_NameTextBox.Text);
                    cmd.Parameters.AddWithValue("@driverphone", driver_PhoneTextBox.Text);
                    cmd.Parameters.AddWithValue("@capacitynumber", capacity_NumberTextBox.Text);
                    cmd.Parameters.AddWithValue("@capacitytype", capacity_TypeTextBox.Text);
                    cmd.Parameters.Add("@availabledate", SqlDbType.Date).Value = available_DateDateTimePicker.Text;
                    cmd.Parameters.AddWithValue("@equipment", equipmentTextBox.Text);
                    cmd.Parameters.AddWithValue("@availablecity", available_CityTextBox.Text);
                    cmd.Parameters.AddWithValue("@availablestate", available_StateTextBox.Text);
                    cmd.Parameters.AddWithValue("@fedexdriver", fedex_DriverTextBox.Text);
                    cmd.Parameters.AddWithValue("@desiredcity", desired_CityTextBox.Text);
                    cmd.Parameters.AddWithValue("@desiredstate", desired_StateTextBox.Text);
                    cmd.Parameters.AddWithValue("@comments", commentsTextBox.Text);

                    //cmd.ExecuteNonQuery();
                    int affectedRows = cmd.ExecuteNonQuery();

                    MessageBox.Show("Row inserted!");


                    this.driversTableAdapter.Fill(this.dab1DataSet.Drivers);

                    //the line below does not work, but i would like for it to sort the available date column in descending order, eventually!
                    //     this.driversDataGridView.Sort(this.driversDataGridView.Columns["Available_Date"], ListSortDirection.Descending);


                }
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {


            DataTable driversTable = new DataTable("Drivers");
            driversTable.Columns.Add("DriverAA_ID");
            driversTable.Columns.Add("Driver_Name");
            driversTable.Columns.Add("Driver_Phone");
            driversTable.Columns.Add("Capacity_Number");
            driversTable.Columns.Add("Capacity_Type");
            driversTable.Columns.Add("Available_Date");
            driversTable.Columns.Add("Equipment");
            driversTable.Columns.Add("Available_City");
            driversTable.Columns.Add("Available_State");
            driversTable.Columns.Add("Fedex_Driver");
            driversTable.Columns.Add("Desired_City");
            driversTable.Columns.Add("Desired_State");
            driversTable.Columns.Add("Comments");

            

            DataSet ds = new DataSet("Drivers");
            ds.Tables.Add(driversTable);


            //create an Excel application instance
            Excel.Application excelApp = new Excel.Application();

            //create an excel workbook instance and open it from the predefined location
            Excel.Workbook excelWorkBook = excelApp.Workbooks.Open(@"C:\CrossonTools\Tools\DriverAvailability2.xlsx");



            foreach (DataTable table in ds.Tables)
            {
             
                //add a new worksheet to workbook with the Datatable name
                Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
              //  excelWorkSheet.Name = table.TableName;
               // string sqlqry = "SELECT * FROM Drivers";


                for (int i = 1; i < table.Columns.Count + 1; i++)
                {
                    excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                }

                for (int j = 0; j < table.Rows.Count; j++)
                {
                    for (int k = 0; k < table.Columns.Count; k++)
                    {
                        excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                    }
                }
                excelWorkBook.Save();
                excelWorkBook.SendMail("alice.brock@crossonagency.com", "CROSSON DRIVER AVAILABILITY!!");
                
                //xcelApp.Quit();
            }


        }


    }

       

      
    }

