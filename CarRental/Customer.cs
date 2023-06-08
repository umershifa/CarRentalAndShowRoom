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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-H2L26T6;Initial Catalog=car_rental_managementsystem;Integrated Security=True")
        {

        };

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentaldbDataSet4.CustomerTb1' table. You can move, or remove it, as needed.
            //this.customerTb1TableAdapter.Fill(this.carRentaldbDataSet4.CustomerTb1);
            Random random = new Random();
            CustId.Text = Convert.ToString(random.Next(1,100));

            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CustId.Text == "" || CustName.Text == "" || CustAdd.Text == "" || phone.Text =="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "insert into CustomerTb1 values(" + CustId.Text + " , '" + CustName.Text + "' , '" + CustAdd.Text + "', '"+phone.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added");
                    Con.Close();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CustId.Text == "" || CustName.Text == "" || CustAdd.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "update CustomerTb1 set CustName='" + CustName.Text + "',CustAdd='" + CustAdd.Text + "',phone='" + phone.Text + "' where CustId=" + CustId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated");
                    Con.Close();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CustId.Text == "")
            {
                MessageBox.Show("Missing infomation!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CustomerTb1 where CustId=" + CustId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    Con.Close();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustId.Text = SellDVG.SelectedRows[0].Cells[0].Value.ToString();
            CustName.Text = SellDVG.SelectedRows[0].Cells[1].Value.ToString();
            CustAdd.Text = SellDVG.SelectedRows[0].Cells[2].Value.ToString();
            phone.Text = SellDVG.SelectedRows[0].Cells[3].Value.ToString();

        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CustomerTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            SellDVG.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void CustId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void CustName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void CustAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
