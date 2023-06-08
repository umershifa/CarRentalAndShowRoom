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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-H2L26T6;Initial Catalog=car_rental_managementsystem;Integrated Security=True");


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Rental_Load(object sender, EventArgs e)
        {
            //this.rentalTb1TableAdapter.Fill(this.carRentaldbDataSet5.RentalTb1);
            populate();
            returnreport();
            sumreturn();



        }
       
        public void sumreturn()
        {
            double sum = 0;
            for (int i = 0; i <= dgv.Rows.Count; i++)
            {
                try
                {
                    sum += double.Parse(dgv.Rows[i].Cells[6].Value.ToString());

                }
                catch (Exception)
                {

                }
                textBox1.Text = sum.ToString();
            }

        }
        private void populate()
        {
            Con.Open();
            string query = "select * from ReturnTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void returnreport()
        {
            Con.Open();
            string query = "select * from RENTINGTB";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Uid_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarReg_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void RentDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report rt = new Report();
            rt.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void custnm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
