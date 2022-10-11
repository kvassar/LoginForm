using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=HBS-KVASSAR;Initial Catalog=userLogin;Integrated Security=True");
            string query = "select * from logins where username ='" + usernameTextBox.Text.Trim() + "'and password='" + passswordTextBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                loggedIn objfrmLoggedIn = new loggedIn();
                this.Hide();
                objfrmLoggedIn.Show();
                

            }
            else
            {
                MessageBox.Show("please check your username and password");
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
