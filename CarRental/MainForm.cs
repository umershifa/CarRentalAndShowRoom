using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class MainForm : Form
    {
        private object queryaddress;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            rep.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DASH_BOARD dashboard = new DASH_BOARD();
            dashboard.Show();
            
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void search_data_Click(object sender, EventArgs e)
        {
            String streetlb= Street_txt.Text;

            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://map.google.com/maps?q=");

                if(streetlb!=String.Empty)
                {
                    queryaddress.Append(streetlb + "," + "+");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error")
;           }
            webBrowser1.Navigate(queryaddress.ToString());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LB_DATE.Text = DateTime.Now.ToLongDateString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Renting renting = new Renting();
            renting.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
