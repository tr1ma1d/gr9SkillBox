using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GibddGroupNine
{
    public partial class Form1 : Form
    {
        
        public static string stringConnect = "server=localhost;userid=root;database=gybdd;password=123456;sslmode=none";
       
        public Form1()
        {
            InitializeComponent();
         
        }
        private void LogIn()
        {

            MySqlConnection conn = new MySqlConnection(stringConnect);
            conn.Open();
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            string sqlQuery = $"SELECT `login`, `password` FROM `identification` WHERE `login` = @uL AND `password` = @uP";

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(sqlQuery,conn);
            MySqlCommand msCommand = new MySqlCommand(sqlQuery,conn);
            
            DataTable dt = new DataTable();
            msCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            msCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

            sqlAdapter.SelectCommand = msCommand;
            sqlAdapter.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("You`re successfull login");

                Information inf = new Information();
                inf.OnTransition += CloseCurrentForm;
                inf.Show();
               
            }
            else
            {
                MessageBox.Show("No");
            }



            conn.Close();
        }
        private void SignIn()
        {
            MySqlConnection conn = new MySqlConnection(stringConnect);
            conn.Open();
            string login = tbLogin.Text;
            string password = tbPassword.Text;

            string sqlQuery = $"INSERT INTO identification(login, password) VALUES ('{login}','{password}')";

            MySqlDataAdapter myAdapter = new MySqlDataAdapter(sqlQuery, conn);
            MySqlCommand mySqlCommand = new MySqlCommand(sqlQuery, conn);
            DataTable dt = new DataTable();
            myAdapter.Fill(dt);

            conn.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            LogIn();
        }
        //close form1
        private void CloseCurrentForm()
        {
            this.Close();
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            SignIn();
        }
       
    }
}
