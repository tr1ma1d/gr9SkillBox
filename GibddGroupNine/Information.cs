using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIN_LIB;
using MySql.Data.MySqlClient;




namespace GibddGroupNine
{
    public partial class Information : Form
    {
        static string stringConnection = "server=localhost;userid=root;database=gybdd;password=123456;sslmode=none";
       
        public Information()
        {
            InitializeComponent();
            DisplayGrid();
            Menu();

        }
        //output information to dataGrid(its window with table)
        private void DisplayGrid()
        {
            MySqlConnection conn = new MySqlConnection(stringConnection);
            conn.Open();
            string sqlQuery = "SELECT `name`, `passport serial`, `passport number`, `address`, `licence date`, `licence number`,`categories` FROM `drivelic`";
            MySqlDataAdapter Adapter = new MySqlDataAdapter(sqlQuery, conn);
            DataTable dataTable = new DataTable();  
            MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, conn);
            Adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        //for comboboxes
        private void Menu()
        {
            cbCategory.Items.AddRange(new string[] { "A", "B", "C", "D"});
        }
        
        private void Picture()
        {
            Bitmap image;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpg;*.png)|*.jpg; *.png|All files(*.*)|*.*";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(openFile.FileName);
                    this.pbPhoto.Size = new Size(128, 128);
                    pbPhoto.Image = image;
                    pbPhoto.Invalidate();
                }
                catch
                {
                    DialogResult result = MessageBox.Show("404");
                }
            }
           
        }
        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbFullName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbAddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbSerial.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbNum.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbCategory.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbLicence.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();    
            tbLicNum.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }
    }
}
