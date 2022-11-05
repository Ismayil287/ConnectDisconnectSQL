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

namespace ConnectDisconnectSQL
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(DataSource.DS);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnDissconn_Click(object sender, EventArgs e)
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
                btnConnDissconn.Text = "Disconnect";
                lblOpenClose.Text = "Open";
            }
            else
            {
                connection.Close();
                btnConnDissconn.Text = "Connection";
                lblOpenClose.Text = "Close";
            }
        }
    }
}
