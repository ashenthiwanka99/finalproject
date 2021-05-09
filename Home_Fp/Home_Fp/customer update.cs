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
    public partial class customer_update : Form
    {
        public customer_update()
        {
            InitializeComponent();
        }
        string condition;
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string cid = Convert.ToString(cid_txt.Text);
            string cname = Convert.ToString(cname_txt.Text);
            string address = Convert.ToString(address_txt.Text);
            string nic = Convert.ToString(nic_txt.Text);
            string mobile = Convert.ToString(telephone_txt.Text);
            string mail = Convert.ToString(email_txt.Text);

            if (string.IsNullOrEmpty(cid))
            {
                errorProvider6.SetError(cname_txt, "Customer ID cannot be empty!");
            }
            if (string.IsNullOrEmpty(cname))
            {
                errorProvider1.SetError(cname_txt, "Customer cannot be empty!");
            }
            if (!Regex.Match(cname_txt.Text, "^[A-Z][a-zA-Z]*$").Success)
            {

                MessageBox.Show("Customer name not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cname_txt.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(address))
            { errorProvider2.SetError(address_txt, "Customer address cannot be empty!"); }
            else if (string.IsNullOrEmpty(nic))
            {
                errorProvider3.SetError(nic_txt, "Customer NIC cannot be empty!");
                if (nic_txt.Text.Length == 9)
                {

                }
                else
                {
                    MessageBox.Show("Customer NIC is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrEmpty(mobile))
            {
                errorProvider4.SetError(telephone_txt, "Customer Telephone Number cannot be empty!");

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
                errorProvider5.SetError(email_txt, "Customer Email cannot be empty!");
            }
            else
            {
                try
                {
                    
                    string MyConnection2 = "Data Source=DESKTOP-OJKM71A;Initial Catalog=KN Auto Trading PVT Ltd_db; Integrated Security=True";
                  
                    string Query = "update customer_tbl set name='" + this.cname_txt.Text + "',address='" + this.address_txt.Text + "',nic='" + this.nic_txt.Text + "',gender='" +condition+ "',telephone='" + this.telephone_txt.Text + "',email='" + this.email_txt.Text + "' where customer_id='" + this.cid_txt.Text + "';";
                   
                    SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Customer Update Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            condition = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            condition = "Female";
        }

        private void cname_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            { e.Handled = true; }
        }

        private void telephone_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            { e.Handled = true; }
        }

        private void nic_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            { e.Handled = true; }
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

        private void cid_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            { e.Handled = true; }
        }

        private void cid_txt_TextChanged(object sender, EventArgs e)
        {
            //conection
            string cs = @"Data Source=DESKTOP-OJKM71A;Initial Catalog=KN Auto Trading PVT Ltd_db; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //comand
            string sql = "select name, address, nic, telephone, email from customer_tbl where customer_id ='" + cid_txt.Text + "'";
            SqlCommand com = new SqlCommand(sql, con);

            //Access data
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                cname_txt.Text = dr.GetValue(0).ToString();
                address_txt.Text = dr.GetValue(1).ToString();
                nic_txt.Text = dr.GetValue(2).ToString();
                telephone_txt.Text = dr.GetValue(3).ToString();
                email_txt.Text = dr.GetValue(4).ToString();
            }
            con.Close();
        }
    }
}
