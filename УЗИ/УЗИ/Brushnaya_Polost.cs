using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УЗИ
{
    public partial class Brushnaya_Polost : Form
    {
        public Brushnaya_Polost()
        {
            InitializeComponent();
        }
        // readonly string connectionString = @"Data Source=LAVR-PC\SQLEXPRESS;Initial Catalog=db_yzi;Integrated Security=True";
        readonly string DefaultConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
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
