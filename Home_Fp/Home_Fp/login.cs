using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KN_Auto_Trading_Car_Sale
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        { 

            panel1.BackColor = Color.FromArgb(100,0,0,0);
            panel1.Location = new Point(
             this.ClientSize.Width / 2 - panel1.Size.Width / 2,
              this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            textBox1.Select();

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uname_txt_TextChanged(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void uname_txt_Click(object sender, EventArgs e)
        {
            uname_txt.Text = "";
        }

        private void pword_txt_Click(object sender, EventArgs e)
        {
            pword_txt.PasswordChar = '*';
            pword_txt.Text = "";
        }

        private void pwremind_lbl_Click(object sender, EventArgs e)
        {
            pwrecovery pw = new pwrecovery();
            pw.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(uname_txt.Text))
            {
                MessageBox.Show("Please Enter Username!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(pword_txt.Text))
            {
                MessageBox.Show("Please Enter Password!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //conection
                string cs = @"Data Source=DESKTOP-OJKM71A;Initial Catalog=KN Auto Trading PVT Ltd_db; Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                //comand
                string sql = "select * from user_tbl where uname ='" + uname_txt.Text + "' and pword ='" + pword_txt.Text + "' ";
                SqlCommand com = new SqlCommand(sql, con);

                //Access data
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                     first = new register();
                    first.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User Name Or Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            
      
    }
}
