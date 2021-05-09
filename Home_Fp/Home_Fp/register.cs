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
using System.Text.RegularExpressions;

namespace KN_Auto_Trading_Car_Sale
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        SqlConnection con;
        
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_Load(object sender, EventArgs e)
        {
            //conection
            con = new SqlConnection("Data Source=DESKTOP-OJKM71A;Initial Catalog=KN Auto Trading PVT Ltd_db; Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull (max(cast(uid as int)),0)+1 From user_tbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            uid_txt.Text = dt.Rows[0][0].ToString();
            con.Close();

        }

        private void sndbtn_Click(object sender, EventArgs e)
        {
           
            string nuname = Convert.ToString(uname_txt.Text);
            string npwrd = Convert.ToString(pwrdtxt.Text);
            string ncpwrd = Convert.ToString(cpwrdtxt.Text);
            string mail = Convert.ToString(umail_txt.Text);
            if (string.IsNullOrEmpty(nuname))
            {
                errorProvider3.SetError(pwrdtxt, "New Username cannot be empty!"); 
             }
            else if (!Regex.Match(uname_txt.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // first name was incorrect  
                MessageBox.Show("Customer name not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uname_txt.Focus();
                return;
            }
            else if (npwrd.Length == 0)
            { MessageBox.Show(" New user Password cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              if (!Regex.IsMatch(pwrdtxt.Text, @"[A-Za-z][A-Za-z0-9]{2,7}"))
                {
                    errorProvider1.SetError(pwrdtxt, "Password invalid!");
                }
            }
            else if (ncpwrd.Length == 0)
            { MessageBox.Show(" New user Confirm Password cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!Regex.IsMatch(cpwrdtxt.Text, @"[A-Za-z][A-Za-z0-9]{2,7}"))
                {
                    errorProvider2.SetError(cpwrdtxt, "Password invalid!");
                }
            }
            else if (npwrd != ncpwrd)
            { MessageBox.Show("Confirm password must same as the password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (string.IsNullOrEmpty(mail))
            {
                errorProvider2.SetError(cpwrdtxt, "New User Email cannot be empty!"); 
             }
            else
            {

                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "Data Source=DESKTOP-OJKM71A;Initial Catalog=KN Auto Trading PVT Ltd_db; Integrated Security=True";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into user_tbl(uid,uname,pword,email) values('" + this.uid_txt.Text + "','" + this.uname_txt.Text + "','" + this.pwrdtxt.Text + "','" + this.umail_txt.Text + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("New User Added successfully!");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            
        }

        private void umail_txt_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (umail_txt.Text.Length > 0 && umail_txt.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(umail_txt.Text.Trim()))
                {
                    MessageBox.Show("Wrong Email Address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);             
                    umail_txt.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void uname_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            { e.Handled = true; }
        }
    }
}
