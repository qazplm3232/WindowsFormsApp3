using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp3;


namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Data Source=INBOOK_Y2_PLUS;Initial Catalog=StockPurhase1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (AuthenticateUser(login, password))
            {
                MessageBox.Show("Успешный вход!");
                Home home = new Home();
                home.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неправильно введён пароль или логин. ПОвторите попытку!");
            }
        }
        public static bool AuthenticateUser(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Clients WHERE Email = @Email AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", login);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();
                    return true;
                }
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}