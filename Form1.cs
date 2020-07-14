using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 1;
            comboBox4.SelectedIndex = 1;
            comboBox5.SelectedIndex = 1;
            comboBox6.SelectedIndex = 1;
            comboBox7.SelectedIndex = 1;
            comboBox8.SelectedIndex = 1;
            comboBox9.SelectedIndex = 1;
            comboBox10.SelectedIndex = 1;
            comboBox12.SelectedIndex = 1;
            comboBox13.SelectedIndex = 1;
            comboBox14.SelectedIndex = 1;
            comboBox15.SelectedIndex = 1;
            comboBox16.SelectedIndex = 1;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bill = 0;
            if (checkBox1.Checked)
            {
                int a = Convert.ToInt32(comboBox1.Text);
                bill += (60 * a);
            }

            if (checkBox2.Checked)
            {
                int a = Convert.ToInt32(comboBox2.Text);
                bill += (90 * a);
            }

            if (checkBox3.Checked)
            {
                int a = Convert.ToInt32(comboBox3.Text);
                bill += (150 * a);
            }

            if (checkBox4.Checked)
            {
                int a = Convert.ToInt32(comboBox4.Text);
                bill += (150 * a);
            }

            if (checkBox5.Checked)
            {
                int a = Convert.ToInt32(comboBox5.Text);
                bill += (100 * a);
            }

            if (checkBox6.Checked)
            {
                int a = Convert.ToInt32(comboBox6.Text);
                bill += (120 * a);
            }

            if (checkBox7.Checked)
            {
                int a = Convert.ToInt32(comboBox7.Text);
                bill += (150 * a);
            }

            if (checkBox8.Checked)
            {
                int a = Convert.ToInt32(comboBox9.Text);
                bill += (460 * a);
            }

            if (checkBox9.Checked)
            {
                int a = Convert.ToInt32(comboBox8.Text);
                bill += (300 * a);
            }

            if (checkBox10.Checked)
            {
                int a = Convert.ToInt32(comboBox10.Text);
                bill += (250 * a);
            }

            if (checkBox12.Checked)
            {
                int a = Convert.ToInt32(comboBox12.Text);
                bill += (100 * a);
            }

            if (checkBox13.Checked)
            {
                int a = Convert.ToInt32(comboBox13.Text);
                bill += (20 * a);
            }

            if (checkBox14.Checked)
            {
                int a = Convert.ToInt32(comboBox14.Text);
                bill += (35 * a);
            }

            if (checkBox15.Checked)
            {
                int a = Convert.ToInt32(comboBox15.Text);
                bill += (25 * a);
            }

            if (checkBox16.Checked)
            {
                int a = Convert.ToInt32(comboBox16.Text);
                bill += (25 * a);
            }
            if (bill == 0)
            {
                MessageBox.Show(" Please choose at least one item !");
            }
            else
            {
                label21.Text = "Total bill = " + bill.ToString() + "TK";
                NextPage lk = new NextPage(label21.Text);
                lk.Show();
                Hide();
            }
        }  
    }
}
