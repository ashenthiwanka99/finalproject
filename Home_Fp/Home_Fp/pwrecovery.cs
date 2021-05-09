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
using System.Net.Mail;
using System.Net;

namespace KN_Auto_Trading_Car_Sale
{
    public partial class pwrecovery : Form
    {
        public pwrecovery()
        {
            InitializeComponent();
        }

        private void sndbtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(uname_txt.Text))
            {
                MessageBox.Show("Please Enter Username!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SmtpClient clientdetails = new SmtpClient();
                    clientdetails.Port = Convert.ToInt32(porttxt.Text.Trim());
                    clientdetails.Host = smtpsvrtxt.Text.Trim();
                    clientdetails.EnableSsl = checkBox1.Checked;
                    clientdetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                    clientdetails.UseDefaultCredentials = false;
                    clientdetails.Credentials = new NetworkCredential(Sendermailtxt.Text.Trim(), SenderPWtxt.Text.Trim());

                    MailMessage maildetails = new MailMessage();
                    maildetails.From = new MailAddress(Sendermailtxt.Text.Trim());
                    maildetails.To.Add(umail_txt.Text.Trim());
                    maildetails.Subject = subtxt.Text.Trim();
                    maildetails.Body = bodytxt.Text.Trim();
                    clientdetails.Send(maildetails);

                    MessageBox.Show("Your Mail has been Sent!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pwrecovery_Load(object sender, EventArgs e)
        {
           groupBox1.Hide();
            groupBox3.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uname_txt_TextChanged(object sender, EventArgs e)
        {
            

                //conection
                string cs = @"Data Source=DESKTOP-OJKM71A;Initial Catalog=KN Auto Trading PVT Ltd_db; Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                //comand
                string sql = "select pword, email from user_tbl where uname ='" + uname_txt.Text + "'";
                SqlCommand com = new SqlCommand(sql, con);

                //Access data
                SqlDataReader dr = com.ExecuteReader();
                while(dr.Read())
                {
                    bodytxt.Text = dr.GetValue(0).ToString();
                    umail_txt.Text = dr.GetValue(1).ToString();
                    
                }
                con.Close();             
                
            }
        }
    }
