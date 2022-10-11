using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PointofSale_ITE_314
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            int Search;
            Search = int.Parse(item_num.Text);

            if (Search == 1)
            {
                description.Text = ("RTX 3080");
                no_stocks.Text = (20).ToString();
                item_price.Text = (40000).ToString();
                vat.Text = (13.25).ToString();
            }
            if (Search == 2)
            {
                description.Text = ("RTX 4090");
                no_stocks.Text = (21).ToString();
                item_price.Text = (3999).ToString();
                vat.Text = (13.25).ToString();
            }
            if (Search == 3)
            {
                description.Text = ("RTX 3050 TI");
                no_stocks.Text = (9).ToString();
                item_price.Text = (1000).ToString();
                vat.Text = (13.25).ToString();
            }
            if (Search == 4)
            {
                description.Text = ("GTX 1660 Super");
                no_stocks.Text = (2).ToString();
                item_price.Text = (49999).ToString();
                vat.Text = (13.25).ToString();
            }
            if (Search == 5)
            {
                description.Text = ("RTX 5090 Ti");
                no_stocks.Text = (7).ToString();
                item_price.Text = (70000).ToString();
                vat.Text = (13.25).ToString();
            }
            else
            {
                item_num.Text = ("Nothing to Show");
            }
        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private void item_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void no_order_TextChanged(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            try
            {
                double addvat = Convert.ToDouble(vat.Text);
                double price = Convert.ToDouble(item_price.Text);
                double order = Convert.ToDouble(no_order.Text);
                total.Text = (price * order + addvat ).ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void vat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void compute_Click(object sender, EventArgs e)
        {
            try
            {
                double cash1 = double.Parse(cash.Text);
                double tot = double.Parse(total.Text);
                total_change.Text = (cash1 - tot).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid");
            }
        }
    }
}
