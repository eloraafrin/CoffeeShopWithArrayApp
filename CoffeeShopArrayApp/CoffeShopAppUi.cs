using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopArrayApp
{
    public partial class CoffeShopAppUi : Form
    {
        public CoffeShopAppUi()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string[] customerName = new string[50];
        int[] contactNo = new int[11];
        string[] address = new string[50];
        string[] order = new string[50];
        int[] quantity = new int[10];
        int[] totalPrice = new int[10];
        string[] paymentStatus = new string[50];
        int i = 1;
        private void saveButton_Click(object sender, EventArgs e)
        {

            try
            {
                displayRichTextBox.Clear();
                if (orderComboBox.Text == "")
                {
                    MessageBox.Show("Please Select an Item");
                    return;
                }

                else
                {
                    customerName[i] = customerNameTextBox.Text;
                    contactNo[i] = Convert.ToInt32(contactNoTextBox.Text);
                    address[i] = addressTextBox.Text;
                    order[i] = orderComboBox.Text;
                    quantity[i] = Convert.ToInt32(quantityTextBox.Text);
                    
                    if (order[i] == "Black")
                    {
                        totalPrice[i] = quantity[i] * 120;

                    }

                    else if (order[i] == "Cold")
                    {
                        totalPrice[i] = quantity[i] * 100;
                    }

                    else if (order[i] == "Hot")
                    {
                        totalPrice[i] = quantity[i] * 90;
                    }

                    else if (order[i] == "Regular")
                    {
                        totalPrice[i] = quantity[i] * 80;
                    }

                }


                paymentStatus[i] = displayRichTextBox.Text= ("\n         Payment Status\n\n                "+i+"\nCustomer Name: " + customerName[i] + "\nContact No.: " + contactNo[i] + "\nAddress: " + address[i] +
                   "\nOrder: " + order[i] + "\nQuantity: " + quantity[i] + "\nTotal Price: " + totalPrice[i]);



                i++;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            try
            {
                displayRichTextBox.Clear();
                for(int j=0; j<i; j++)
                {
                    displayRichTextBox.Text += paymentStatus[j];
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
