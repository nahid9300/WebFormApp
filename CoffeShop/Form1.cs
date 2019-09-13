using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var name = contactBox.Text;
            int number = Convert.ToInt32(contactBox.Text);
            var address = addressBox.Text;
            var order = orderBox.Text;
            int qnt = Convert.ToInt32(quantityBox.Text);
            int Amount;
            if(order=="Black")
            {
                Amount = 120;
            }
            else if(order=="Cold")
            {
                Amount = 100;
            }
            else if (order == "Hot")
            {
                Amount = 90;
            }
            else
            {
                Amount = 80;
            }
            MessageBox.Show("Data Saved");
            showLabel13.Text = name;
            showLabel14.Text = number.ToString();
            showLabel15.Text = address;
            showLabel16.Text = order;
            showLabel17.Text = qnt.ToString();
            string result= Convert.ToString(qnt * Amount);
            showLabel18.Text = result;
        }
    }
}
