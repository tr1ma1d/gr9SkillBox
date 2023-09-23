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

namespace GibddGroupNine
{
    public partial class Information : Form
    {
        public event Action OnTransition;
  
        public Information()
        {
            InitializeComponent();

            ClosePastMethod();
        }

        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
        private void ClosePastMethod()
        {
            Form1 form1 = new Form1();
            form1.Close();
        }
    }
}
