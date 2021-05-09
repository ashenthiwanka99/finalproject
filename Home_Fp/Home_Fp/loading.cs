using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KN_Auto_Trading_Car_Sale
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Width += 10;

                if (pictureBox2.Width >=340)
                {
                    timer1.Stop();

                    login frm = new login();
                    frm.Show();
                    this.Hide();



                }
            }
            catch (Exception)
            { return; }
        }
    }
    }

