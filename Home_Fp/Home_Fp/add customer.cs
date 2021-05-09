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
    public partial class add_customer : Form
    {
        public add_customer()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        string condition;

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_customer_Load(object sender, EventArgs e)
        {
            
            //conection
            con = new SqlConnection("Data Source=DESKTOP-OJKM71A;Initial Catalog=KN Auto Trading PVT Ltd_db; Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull (max(cast(customer_id as int)),0)+1 From customer_tbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cid_txt.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void sndbtn_Click(object sender, EventArgs e)
        {
            
            string cid = Convert.ToString(cid_txt.Text);
            string cname = Convert.ToString(cname_txt.Text);
            string address = Convert.ToString(address_txt.Text);
            string nic = Convert.ToString(nic_txt.Text);
            string mobile = Convert.ToString(telephone_txt.Text);
            string mail = Convert.ToString(email_txt.Text);
            if (string.IsNullOrEmpty(cname))
            { 
                errorProvider1.SetError(cname_txt, "New Customer cannot be empty!");
            }
            if (!Regex.Match(cname_txt.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
               
                MessageBox.Show("Customer name not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cname_txt.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(address))
            { errorProvider2.SetError(address_txt, "New Customer address cannot be empty!"); }
            else if (string.IsNullOrEmpty(nic))
            {
                errorProvider3.SetError(nic_txt, "New Customer NIC cannot be empty!");
                if (nic_txt.Text.Length == 9)
                {

                }
                else
                {
                    MessageBox.Show(" New Customer NIC is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrEmpty(mobile))
            {
                errorProvider4.SetError(telephone_txt, " New Customer Telephone Number cannot be empty!");
               
                Regex phonenumber = new Regex("\\d{10}");
                if (phonenumber.IsMatch(telephone_txt.Text))
                {

                }
                else
                {
                    MessageBox.Show("Customer Telephone number is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrEmpty(mail))
            {
                errorProvider5.SetError(email_txt, "New Customer Email cannot be empty!"); 
             }
            else
            {

                try
                {
                    con = new SqlConnection("Data Source=DESKTOP-OJKM71A;Initial Catalog=KN Auto Trading PVT Ltd_db; Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("Insert into customer_tbl values (@a, @b, @c, @d, @e, @f, @g)", con);
                    cmd.Parameters.AddWithValue("a", cid);
                    cmd.Parameters.AddWithValue("b", cname);
                    cmd.Parameters.AddWithValue("c", address);
                    cmd.Parameters.AddWithValue("d", nic);
                    cmd.Parameters.AddWithValue("e", condition);
                    cmd.Parameters.AddWithValue("f", mobile);
                    cmd.Parameters.AddWithValue("g", mail);

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Customer save Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data Not saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmd.Dispose();
                        

                    }
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void email_txt_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (email_txt.Text.Length > 0 && email_txt.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(email_txt.Text.Trim()))
                {
                    MessageBox.Show("Wrong Email Address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    email_txt.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            condition = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            condition = "Female";
        }

        private void nic_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            { e.Handled = true; }
        }

        private void telephone_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            { e.Handled = true; }
        }

        private void cname_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            { e.Handled = true; }
        }
    }
}
