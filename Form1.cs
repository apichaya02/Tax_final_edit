using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5555555555555
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salary = int.Parse(salarymonth.Text);
            int tax=0;
            int net;
            
            int alltax=0;
            salary = salary * 12;
            alltax = 60000;
            if (wife.Checked)
            {
                if (int.Parse(wifesalary.Text) == 0)
                {
                    alltax = alltax + 60000;
                }
            }
            if (int.Parse(son.Text)!=0)
            {
                alltax = alltax + int.Parse(son.Text) * 60000 - 30000;
            }
            if (pregnant.Checked)
            {
                alltax = alltax + int.Parse(pregnantcost.Text);
            }
            if (dad.Checked)
            {
                if (int.Parse(ageDad.Text) > 60)
                {
                    alltax = alltax + 30000;
                }
            }
            if (mom.Checked)
            {
                if (int.Parse(ageMom.Text) > 60)
                {
                    alltax = alltax + 30000;
                }
            }
            if (disabled.Checked)
            {
                alltax = alltax + int.Parse(disable.Text) * 60000;
            }
            ///กลุ่ม2///
            if (ninekup.Checked)
            {
                alltax = alltax + 9000;
            }
            if (no9k.Checked)
            {
                if (int.Parse(social_secur.Text) != 0)
                {
                    alltax = alltax + int.Parse(social_secur.Text);
                }
            }
            
            if (up100k.Checked)
            {
                alltax = alltax + 100000;
            }
            if (no100k.Checked)
            {
                if (int.Parse(life_insurance.Text) != 0)
                {
                    alltax = alltax + int.Parse(life_insurance.Text);
                }
            }
            
            if (no_money_couple.Checked)
            {
                alltax = alltax + 10000;
            }

            if (int.Parse(health_insurance.Text) != 0)
            {
                alltax = alltax + int.Parse(life_insurance.Text);
            }

            if (up15k.Checked)
            {
                alltax = alltax + 15000;
            }
            if (no15k.Checked)
            {
                if (int.Parse(parent_insurance.Text) != 0)
                {
                    alltax = alltax + int.Parse(parent_insurance.Text);
                }
            }
            
            if (int.Parse(provident_fund.Text) <= 10000)
            {
                alltax = alltax + int.Parse(provident_fund.Text);
            }
            else
            {
                alltax = alltax + 10000;
            }

            if (int.Parse(reserve.Text) <= 15/100*salary)
            {
                alltax = alltax + int.Parse(reserve.Text);
            }
            else if (int.Parse(reserve.Text) <= 500000)
            {
                alltax = alltax + int.Parse(reserve.Text);
            }

            if (int.Parse(reserve2.Text) <= 13200)
            {
                alltax = alltax + int.Parse(reserve2.Text);
            }
            else
            {
                alltax = alltax + 13200;
            }

            if (int.Parse(pension.Text) != 0)
            {
                alltax = alltax + int.Parse(pension.Text);
            }
            if (int.Parse(LTF.Text) != 0)
            {
                alltax = alltax + int.Parse(LTF.Text);
            }
            if (int.Parse(RMF.Text) != 0)
            {
                alltax = alltax + int.Parse(RMF.Text);
            }

            ///กลุ่ม3///
            if (int.Parse(house_interest.Text) <= 100000)
            {
                alltax = alltax + int.Parse(house_interest.Text);
            }
            else
            {
                alltax = alltax + 100000;
            }
            if (upno3m.Checked)
            {
                alltax = alltax + int.Parse(home58.Text) * 4 / 100;
            }
            if (upno5m.Checked)
            {
                alltax = alltax + int.Parse(home62.Text);
            }

            
            ///กลุ่ม5///
            if (int.Parse(edu_buy.Text) != 0) 
            {
                alltax = alltax + int.Parse(edu_buy.Text);
            }
            if (int.Parse(otop_buy.Text) != 0) 
            {
                alltax = alltax + int.Parse(otop_buy.Text);
            }
            if (int.Parse(maincity.Text) != 0) 
            {
                alltax = alltax + int.Parse(maincity.Text);
            }
            if (int.Parse(minorcity.Text) != 0) 
            {
                alltax = alltax + int.Parse(minorcity.Text);
            }

            if (int.Parse(car_storm.Text) != 0)
            {
                alltax = alltax + int.Parse(car_storm.Text);
            }

            if (int.Parse(home_storm.Text) != 0)
            {
                alltax = alltax + int.Parse(home_storm.Text);
            }



            net = salary - alltax;
            ///กลุ่ม4///
            if (int.Parse(edu_donate.Text) <= 0.1 * net)
            {
                alltax = alltax + int.Parse(edu_donate.Text);
            }

            if (int.Parse(storm_donate.Text) != 0)
            {
                alltax = alltax + int.Parse(storm_donate.Text);
            }
            if (int.Parse(donate.Text) <= 0.1 * net)
            {
                alltax = alltax + int.Parse(donate.Text);
            }
            if (int.Parse(political_donate.Text) <= 10000)
            {
                alltax = alltax + int.Parse(political_donate.Text);
            }

           

            if (net <= 0)
            {
                net = 0;
            }
            if (net > 5000000)
            {
                tax = net * 35 / 100;
            }
            if (net > 2000000)
            {
                tax = net * 30 / 100;
            }
            if (net > 1000000)
            {
                tax = net * 25 / 100;
            }
            if (net > 750000)
            {
                tax = net * 20 / 100;
            }
            if (net > 500000)
            {
                tax = net * 15 / 100;
            }
            if (net > 300000)
            {
                tax = net * 10 / 100;
            }
            if (net > 150000)
            {
                tax = net * 5 / 100;
            }
            if (net <= 150000)
            {
                tax = 0;
            }
            
            salary = salary - tax;
            paytax.Text = tax.ToString();
            textBox8.Text = salary.ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void paytax_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {


        }

        private void groupBox17_Enter(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void minorcity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
           

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
    }
}
