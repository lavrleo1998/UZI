using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace УЗИ.Properties
{
    public partial class ConnectDB : Form
    {
        public ConnectDB()
        {
            InitializeComponent();
        }

       // readonly string connectionString = @"Data Source=LAVR-PC\SQLEXPRESS;Initial Catalog=db_yzi;Integrated Security=True";
        readonly string DefaultConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private void ConnectDB_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection DefaultConnection = new SqlConnection(DefaultConnectionString);
            DefaultConnection.Open();

            SqlCommand command = new SqlCommand();
            
            command.Connection = DefaultConnection;
            command.CommandText = string.Format("SELECT * FROM [пациент]");
            SqlDataReader reader = command.ExecuteReader();           
                while (reader.Read())
                {
                    richTextBox1.Text = string.Format("Фамилия: {0}\n Имя: {1}\n Отчество: {2}\n", reader[1], reader[2], reader[3]);
                }
                reader.Close();
            DefaultConnection.Close();
        }
    }
}
