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
    public partial class Renting : Form
    {
        public Renting()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-H2L26T6;Initial Catalog=car_rental_managementsystem;Integrated Security=True");
        private void Renting_Load(object sender, EventArgs e)
        {
            populate();
            show();

            //genarete ref number
            Random random = new Random();
            RefNo.Text = Convert.ToString(random.Next(11111, 99999));
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CustomerTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            custDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void show()
        {
            Con.Open();
            string query = "select * from CarTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            carDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void custDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CustNm.Text = custDGV.SelectedRows[0].Cells[1].Value.ToString();

            }
        }

        private void carDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                carReg.Text = carDGV.SelectedRows[0].Cells[0].Value.ToString();
                Brand.Text = carDGV.SelectedRows[0].Cells[1].Value.ToString();
                model.Text = carDGV.SelectedRows[0].Cells[2].Value.ToString();
                Price.Text = carDGV.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = Convert.ToInt32(Price.Text);
            if (Price.Text == "" || Price.Text == "0" || Price.Text == "''" || Lbtime.Text == "0" || Lbtime.Text == "" || Brand.Text==""||model.Text==""||carReg.Text==""||CustNm.Text=="")
            {
                MessageBox.Show("please fill the field with correct details", "CAR RENTAL SYSTEM");
            }

            else if (a < 0)
            {
                MessageBox.Show("cannot store a negative value!!", "CAR RENTAL SYSTEM");

            }
            else
            {
                Con.Open();
                String query = "insert into RENTINGTB values(" + RefNo.Text + " , '" + CustNm.Text + "' ,'" + Brand.Text + "', '" + model.Text + "', '" + carReg.Text + "','" + Price.Text + "','" + Lbtime.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfully rented out", "CAR RENTAL SYSTEM");
                Con.Close();
            }


                
        }

        private void RefNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CustNm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Brand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void model_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void carReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Lbtime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
