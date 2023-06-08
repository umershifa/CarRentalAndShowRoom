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

namespace CarRental
{
    public partial class DASH_BOARD : Form
    {
        public DASH_BOARD()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-H2L26T6;Initial Catalog=car_rental_managementsystem;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            printDialog1.ShowDialog();
        }

        private void DASH_BOARD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentaldbDataSet13.carTb1' table. You can move, or remove it, as needed.
            //this.carTb1TableAdapter.Fill(this.carRentaldbDataSet13.carTb1);
            // TODO: This line of code loads data into the 'carRentaldbDataSet12.CustomerTb1' table. You can move, or remove it, as needed.
            //this.customerTb1TableAdapter.Fill(this.carRentaldbDataSet12.CustomerTb1);
            populate();
            

            //number of cars
            string querycar = "Select count(*)from CarTb1";
            SqlDataAdapter sda = new SqlDataAdapter(querycar, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label24.Text = dt.Rows[0][0].ToString();

            //number of customers
            string querycust = "Select count(*)from CustomerTb1";
            SqlDataAdapter sda1 = new SqlDataAdapter(querycust, Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            label26.Text = dt1.Rows[0][0].ToString();

            //number of users
            string queryuser = "Select count(*)from UserTb1";
            SqlDataAdapter sda2 = new SqlDataAdapter(queryuser, Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            label28.Text = dt2.Rows[0][0].ToString();

            

            //SHOWS RECEIPT
            rtfRECEIPT.Clear();

            rtfRECEIPT.AppendText(Environment.NewLine);
            rtfRECEIPT.AppendText("==========================================" + Environment.NewLine);
            rtfRECEIPT.AppendText("\t\t" + "SAMU CAR RENTAL PALACE" + Environment.NewLine);
            rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
            rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
            rtfRECEIPT.AppendText("\tRefrence NO:\t\t" + RefNo.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tCustomer Name\t\t" + CustNm.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tBrand:\t\t\t" + Brand.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tCar_Model NO:\t\t" + model.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tCarReg:\t\t\t" + carReg.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tCharge/Hour:\t\t" + Price.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tHours on Rent\t\t" + Lbtime.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
            rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
            
            rtfRECEIPT.AppendText("\tTOTAL CHARGES\t" + Totaltxt.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
            rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
            rtfRECEIPT.AppendText("\t" + time.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\t" + date.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
            rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine);
            rtfRECEIPT.AppendText("\t" + "YOU ARE ALWAYS WELCOMED AGAIN" + Environment.NewLine);

            //show time and date
            date.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            // search data
           
            
        }

       
        private void populate()
        {
            Con.Open();
            string query = "select * from RENTINGTB";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            custDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        
        private void totalbtn_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = Convert.ToInt32(Lbtime.Text);
            if (Price.Text==""|| Price.Text=="0" || Price.Text == "''" || Lbtime.Text == "0" || Totaltxt.Text == "" )
            {
                MessageBox.Show("cannot compute with empty or with zero value!!");
            }

            else if (a<0)
            {
                MessageBox.Show("cannot compute negative value!!");

            }
            else
            {
                try
                {
                    Totaltxt.Text = (Double.Parse(Price.Text) * Double.Parse(Lbtime.Text)).ToString();
                    // store to report module
                    Con.Open();
                    String query = "insert into ReturnTb1 values(" + RefNo.Text + " , '" + CustNm.Text + "' ,'" + Brand.Text + "', '" + model.Text + "', '" + carReg.Text + "','" + Price.Text + "','" + Totaltxt.Text + "','" + date.Text + "','" + time.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Return successful", "CAR RENTAL SYSTEM");
                    Con.Close();

                    //show receipt
                    rtfRECEIPT.Clear();

                    rtfRECEIPT.AppendText(Environment.NewLine);
                    rtfRECEIPT.AppendText("==========================================" + Environment.NewLine);
                    rtfRECEIPT.AppendText("\t\t" + "SAMU CAR RENTAL PALACE" + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
                    rtfRECEIPT.AppendText("\tRefrence NO:\t\t" + RefNo.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("\tCustomer Name\t\t" + CustNm.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("\tBrand:\t\t\t" + Brand.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("\tCar_Model NO:\t\t" + model.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("\tCarReg:\t\t\t" + carReg.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("\tCharge/Hour:\t\t" + Price.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("\tHours on Rent\t\t" + Lbtime.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);

                    rtfRECEIPT.AppendText("\tTOTAL CHARGES\t" + Totaltxt.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
                    rtfRECEIPT.AppendText("\t" + time.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("\t" + date.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine);
                    rtfRECEIPT.AppendText("\t" + "YOU ARE ALWAYS WELCOMED AGAIN" + Environment.NewLine);
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
           
        }


        private void backbtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfRECEIPT.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 5));
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RefNo.Text = custDGV.SelectedRows[0].Cells[0].Value.ToString();
                CustNm.Text = custDGV.SelectedRows[0].Cells[1].Value.ToString();
                Brand.Text = custDGV.SelectedRows[0].Cells[2].Value.ToString();
                model.Text = custDGV.SelectedRows[0].Cells[3].Value.ToString();
                carReg.Text = custDGV.SelectedRows[0].Cells[4].Value.ToString();
                Price.Text = custDGV.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Totaltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            
            CustNm.Text = "";
            model.Text="--";
            carReg.Text = "";
            Price.Text = "0";
            Lbtime.Text = "0";
            
            Totaltxt.Text = "";

            //reset receipt
            rtfRECEIPT.Clear();

            rtfRECEIPT.AppendText(Environment.NewLine);
            rtfRECEIPT.AppendText("==========================================" + Environment.NewLine);
            rtfRECEIPT.AppendText("\t\t" + "SAMU CAR RENTAL PALACE" + Environment.NewLine);
            rtfRECEIPT.AppendText("------------------------------------------------------------------------" + Environment.NewLine);
            rtfRECEIPT.AppendText("------------------------------------------------------------------------" + Environment.NewLine);
            rtfRECEIPT.AppendText("\tRefrence NO:\t\t" + RefNo.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tCustomer Name\t\t" + CustNm.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tBrand:\t\t\t" + Brand.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tCar_Model:\t\t" + model.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tCarReg:\t\t\t" + carReg.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tCharge/Hour:\t\t" + Price.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tHours on Rent\t\t" + Lbtime.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("------------------------------------------------------------------------" + Environment.NewLine);
            rtfRECEIPT.AppendText("------------------------------------------------------------------------" + Environment.NewLine);
            
            rtfRECEIPT.AppendText("\tTOTAL CHARGES\t" + Totaltxt.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("------------------------------------------------------------------------" + Environment.NewLine);
            rtfRECEIPT.AppendText("------------------------------------------------------------------------" + Environment.NewLine);
            rtfRECEIPT.AppendText("\t" + time.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\t" + date.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("------------------------------------------------------------------------" + Environment.NewLine);
            rtfRECEIPT.AppendText("------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine);
            rtfRECEIPT.AppendText("\t" + "YOU ARE ALWAYS WELCOMED AGAIN" + Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CustNm.Text == "--" || model.Text == "--" || carReg.Text == "--" || Price.Text == "0" || Lbtime.Text == "0" || Totaltxt.Text == "0")
            {
                MessageBox.Show("PLEASE RECHECK THE FIELDS!!");
            }
            else
            {
                try
                {
                    rtfRECEIPT.Clear();

                    rtfRECEIPT.AppendText(Environment.NewLine);
                    rtfRECEIPT.AppendText("==========================================" + Environment.NewLine);
                    rtfRECEIPT.AppendText("\t\t" + "SAMU CAR RENTAL PALACE" + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
                    rtfRECEIPT.AppendText("\tRefrence NO:\t\t" + RefNo.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("\tCustomer Name\t\t" + CustNm.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("\tBrand:\t\t" + Brand.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("\tCar_Model:\t\t" + model.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("\tCarReg:\t\t\t" + carReg.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("\tCharge/Hour:\t\t" + Price.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("\tHours on Rent\t\t" + Lbtime.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
                    
                    rtfRECEIPT.AppendText("\tTOTAL CHARGES\t" + Totaltxt.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
                    rtfRECEIPT.AppendText("\t" + time.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("\t" + date.Text + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine);
                    rtfRECEIPT.AppendText("---------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine);
                    rtfRECEIPT.AppendText("\t" + "YOU ARE ALWAYS WELCOMED AGAIN" + Environment.NewLine);
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void RefNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void model_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Lbtime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Totaltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void fine_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void searchCAR_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }

        private void custDGV_Click(object sender, EventArgs e)
        {

        }

        private void custDGV_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void CustNm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void rtfRECEIPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void custDGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void carReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
