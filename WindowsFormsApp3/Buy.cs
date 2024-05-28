using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace WindowsFormsApp6
{
    public partial class Buy : Form
    {
        string connectionString = "Data Source=INBOOK_Y2_PLUS;Initial Catalog=StockPurhase1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Buy()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int clientId = int.Parse(txtClientId.Text);
            string stockName = txtStockName.Text;
            int quantity = int.Parse(txtQuantity.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            DateTime date = DateTime.Parse(txtDate.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Purchases (ClientId, StockName, Quantity, Price, Date) VALUES (@ClientId, @StockName, @Quantity, @Price, @Date)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientId", clientId);
                command.Parameters.AddWithValue("@StockName", stockName);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Date", date);

                command.ExecuteNonQuery();

                MessageBox.Show("Покупка акции успешно записана в базу данных.");
            }
        }

        private void Buy_Load(object sender, EventArgs e)
        {

        }
    }
}
