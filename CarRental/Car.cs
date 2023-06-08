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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\CarRental\CarRental\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Car_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentaldbDataSet1.carTb1' table. You can move, or remove it, as needed.
            //this.carTb1TableAdapter.Fill(this.carRentaldbDataSet1.carTb1);
            populate();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from carTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            carDGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = Convert.ToInt32(PriceTb.Text);
            if (RegnoTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || PriceTb.Text==""||a<0)
            {
                MessageBox.Show("Missing Information or adding with a negative value");
            }
            else if(PriceTb.Text == "0")
            {
                MessageBox.Show("cost field should contain a valid value","CAR RENTAL SYSTEM");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "insert into CarTb1 values('" +RegnoTb.Text + "' , '" + BrandTb.Text + "' , '" + ModelTb.Text + "', '"+PriceTb.Text+"', '"+AvailableCb.SelectedItem.ToString()+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Added");
                    Con.Close();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegnoTb.Text = "";
            BrandTb.Text = "";
            ModelTb.Text = "";
            PriceTb.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (RegnoTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || PriceTb.Text == "" || AvailableCb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "update carTb1 set Brand='" + BrandTb.Text + "', Model='" + ModelTb.Text + "',Price='" + PriceTb.Text + "',Available='" + AvailableCb.Text + "' where RegNo='" + RegnoTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Updated","CAR RENTAL SYSTEM");
                    Con.Close();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RegnoTb.Text = carDGV.SelectedRows[0].Cells[0].Value.ToString();
                BrandTb.Text = carDGV.SelectedRows[0].Cells[1].Value.ToString();
                ModelTb.Text = carDGV.SelectedRows[0].Cells[2].Value.ToString();
                PriceTb.Text = carDGV.SelectedRows[0].Cells[3].Value.ToString();
                AvailableCb.Text = carDGV.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RegnoTb.Text == "")
            {
                MessageBox.Show("Missing infomation!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from carTb1 where RegNO='" + RegnoTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted Successfully");
                    Con.Close();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegnoTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (!char.IsControl(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar))))
            {
                e.Handled = true;
            }
        }

        private void AvailableCb_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled =true;
        }

        private void PriceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&(!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void BrandTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void ModelTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void AvailableCb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ModelTb_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
