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
using System.Configuration;

namespace EmployeeManagement
{
    public partial class EmployeeForm : Form
    {



        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void FindEmployeeButton_Click(object sender, EventArgs e)
        {

        }

        private void AddNewEmployee_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("",conn);
        }

       

    }
}
