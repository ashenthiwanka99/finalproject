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

namespace KN_Auto_Trading_Car_Sale
{
    public partial class customer_viwe_delete : Form
    {
        public customer_viwe_delete()
        {
            InitializeComponent();
        }
        string cs = "Data Source=DESKTOP-OJKM71A;Initial Catalog=KN Auto Trading PVT Ltd_db; Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void customer_viwe_delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kN_Auto_Trading_PVT_Ltd_dbDataSet1.customer_tbl' table. You can move, or remove it, as needed.
            this.customer_tblTableAdapter1.Fill(this.kN_Auto_Trading_PVT_Ltd_dbDataSet1.customer_tbl);
            // TODO: This line of code loads data into the 'kN_Auto_Trading_PVT_Ltd_dbDataSet.customer_tbl' table. You can move, or remove it, as needed.
            this.customer_tblTableAdapter.Fill(this.kN_Auto_Trading_PVT_Ltd_dbDataSet.customer_tbl);
            try
            {
                string MyConnection2 = "Data Source=DESKTOP-OJKM71A;Initial Catalog=KN Auto Trading PVT Ltd_db; Integrated Security=True";
                
                string Query = "select * from customer_tbl;";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                  
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            string cid = Convert.ToString(cid_cmb.Text);
            if (string.IsNullOrEmpty(cid))
            {
                errorProvider1.SetError(cid_cmb, "Customer ID cannot be empty!");
            }
            else
            {
                try
                {
                    string MyConnection2 = "Data Source=DESKTOP-OJKM71A;Initial Catalog=KN Auto Trading PVT Ltd_db; Integrated Security=True";
                    string Query = "delete from customer_tbl where customer_id='" + this.cid_cmb.Text + "';";
                    SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Customer delete Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cid_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            { e.Handled = true; }
        }

        private void srch_btn_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from customer_tbl where customer_id = '" + cid_cmb.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
