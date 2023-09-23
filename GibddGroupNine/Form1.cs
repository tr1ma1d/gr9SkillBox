using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GibddGroupNine
{
    public partial class Form1 : Form
    {
        static int counter = 0;
        DateTime lockOut = DateTime.MinValue;
        private System.Windows.Forms.Timer timer;
        public static string stringConnect = "server=localhost;userid=root;database=gybdd;password=123456;sslmode=none";

        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
          

          
        }
        //relized a button Login
        
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
            
                this.Hide();
                inf.Show();
      
               
            }
            else if(dt.Rows.Count == 0)
            {
                counter++;
                lbWarning.Text = $"У вас осталось попыток: {3 - counter}";
                if(counter >= 3)
                {
                    LockButton();
                }
            }



            conn.Close();
        }
        private void LockButton()
        {
            lockOut = DateTime.Now.AddMinutes(1);
            logButton.Enabled = false;
            counter = 0;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(lockOut > DateTime.Now)
            {
                TimeSpan remain = lockOut - DateTime.Now;
              
                lbTimer.Text = $"Осталось: {remain.Seconds}";
            
            }
            else
            {
                logButton.Enabled = false;
            }
        }
    }
}
