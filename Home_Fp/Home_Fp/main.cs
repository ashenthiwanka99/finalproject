using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Fp
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sidePanel.Width == 50)
            {
                sidePanel.Visible = false;
                sidePanel.Width = 237;
                Panelanimator.ShowSync(sidePanel);
                Logoanimator.ShowSync(logo);
            }

            else
            {
                Logoanimator.Hide(logo);
                sidePanel.Visible = false;
                sidePanel.Width = 50;
                Panelanimator.ShowSync(sidePanel);
            }
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            if (panel_cus.Height == 48)
            {
                panel_cus.Visible = false;
                panel_cus.Height = 173;
                cust_animi.ShowSync(panel_cus);

            }
            else
            {

                panel_cus.Visible = false;
                panel_cus.Height = 48;
                cust_animi.ShowSync(panel_cus);
            }
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            if (panel_pay.Height == 48)
            {
                panel_pay.Visible = false;
                panel_pay.Height = 137;
                pay_animi.ShowSync(panel_pay);

            }
            else
            {

                panel_pay.Visible = false;
                panel_pay.Height = 48;
                pay_animi.ShowSync(panel_pay);
            }
        }

        private void btn_vehicle_Click(object sender, EventArgs e)
        {
            if (panel_vehi.Height == 48)
            {
                panel_vehi.Visible = false;
                panel_vehi.Height = 137;
                vihi_animi.ShowSync(panel_vehi);

            }
            else
            {

                panel_vehi.Visible = false;
                panel_vehi.Height = 48;
                vihi_animi.ShowSync(panel_vehi);
            }

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            if (panel_rep.Height == 48)
            {
                panel_rep.Visible = false;
                panel_rep.Height = 240;
                report_animi.ShowSync(panel_rep);

            }
            else
            {

                panel_rep.Visible = false;
                panel_rep.Height = 48;
                report_animi.ShowSync(panel_rep);
            }

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
