using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhepTinhCoBan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double tong = so1 + so2;
            txtkq.Text = tong.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double tong = so1 - so2;

            txtkq.Text = tong.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double tong = so1 * so2;

            txtkq.Text = tong.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double tong = so1 / so2;

            if (so2 == 0)
            {
                MessageBox.Show("Yếu kém");
                txtso2.Text = "";
            }
            else
            {
                txtkq.Text = tong.ToString();
            }
        }

        private void tb1_Scroll(object sender, EventArgs e)
        {
            txtso1.Text = tb1.Value.ToString();
            txtso2.Text = tb2.Value.ToString();
            tinhTongNew();
            
           
        }
        double tinhTong(double so1, double so2)
        {
            return so1 + so2;
        }
        void tinhTongNew()
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            
            double kq = so1 + so2;
            txtkq.Text = kq.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

       
       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtso1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkq_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            {

                double so3 = Convert.ToDouble(txtso3.Text);
                int somu = Convert.ToInt32(txtsomu.Text);
                double ketqua = so3;

                for (int i = 1; i <= somu; i++)
                {
                    ketqua = so3 * so3;
                }
                txtketqua.Text = ketqua.ToString();
            }
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            {

                double so3 = Convert.ToDouble(txtso3.Text);
                int mu = Convert.ToInt32(textsomu.Text);
                double ketqua = so3;

                for (int i = 1; i < mu; i++)
                {
                    ketqua *= so3;
                }
                textketqua.Text = ketqua.ToString();
            }
        }
    }
}
