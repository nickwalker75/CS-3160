using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walker_Assignmnet2
{
    public partial class Form1 : Form
    {

        private int formItem, formSize;
        private decimal totalCharge;

        public Form1()
        {
            InitializeComponent();
        }

        private void grpItem_Enter(object sender, EventArgs e)
        {

        }

        private void grpSize_Enter(object sender, EventArgs e)
        {

        }

        private void radBurger_CheckedChanged(object sender, EventArgs e)
        {
            enableSizes();
            formItem = 0;
        }

        private void radFries_CheckedChanged(object sender, EventArgs e)
        {
            enableSizes();
            formItem = 1;
        }

        private void radSoftDrink_CheckedChanged(object sender, EventArgs e)
        {
            enableSizes();
            formItem = 2;
        }

        private void radWater_CheckedChanged(object sender, EventArgs e)
        {
            radSmall.Enabled = true;
            radMedium.Enabled = false;
            radLarge.Enabled = false;
            this.cboQuantity.SelectedIndex = 0;
            formItem = 3;
        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            cboQuantity.Enabled = true;
            btnAddtoOrd.Enabled = true;
            formSize = 0;
        }

        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            cboQuantity.Enabled = true;
            btnAddtoOrd.Enabled = true;
            formSize = 1;
        }

        private void radLarge1_CheckedChanged(object sender, EventArgs e)
        {
            cboQuantity.Enabled = true;
            btnAddtoOrd.Enabled = true;
            formSize = 2;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Rad Buttons
            radBurger.Checked = false;
            radFries.Checked = false;
            radSoftDrink.Checked = false;
            radWater.Checked = false;

            // Combo box
            cboQuantity.SelectedIndex = 0;

            // Item List
            lstOrderSummary.Text = string.Empty;

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstOrderSummary.SelectedIndex != -1)
            {
                PurchasedItem temp = lstOrderSummary.SelectedItem as PurchasedItem;
                lstOrderSummary.Items.Remove(lstOrderSummary.SelectedItem);

                // Update total charge
                totalCharge -= temp.cost();
                lblTotal.Text = totalCharge.ToString("C");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Hit OK to Place Order", "Place Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddtoOrd_Click(object sender, EventArgs e)
        {
            btnPlaceOrder.Enabled = true;
            btnDelete.Enabled = true;

            // Create new item
            PurchasedItem temp = new PurchasedItem(formItem, formSize, cboQuantity.SelectedIndex);

            // Add item to list
            lstOrderSummary.Items.Add(temp);

            // Change total cost
            totalCharge += temp.cost();
            lblTotal.Text = totalCharge.ToString("C");

        }

        private void enableSizes()
        {
            radSmall.Enabled = true;
            radMedium.Enabled = true;
            radLarge.Enabled = true;
        }

    }// Form class

    class PurchasedItem
    {
        private int item, size, quantity;
        private static decimal[,] itemCost;
        private static string format;
        private string[] sizeIcon = { "S", "M", "L" };
        private string[] itemName = { "Burger", "Fries", "Soft Drink", "Water" };

        public PurchasedItem(int formItem, int formSize, int quantity)
        {
            this.item = formItem;
            this.size = formSize;
            this.quantity = quantity + 1;
        }

        public decimal cost()
        {
            decimal temp = itemCost[item, size];
            temp = temp * quantity;
            return temp;
        }

        static PurchasedItem()
        {
            format = "{0, 2} {1, 1} {2, -15} {3, 10:C}";
            itemCost = new decimal[4, 3]
            {
                {2.50M, 3.00M, 3.50M},
                {0.99M, 1.29M, 1.49M},
                {1.29M, 1.40M, 1.60M},
                {0.00M, 0.00M, 0.00M}
            };
        }

        public override string ToString()
        {
            string temp = sizeIcon[size];
            string temp1 = itemName[item];

            return String.Format(format, quantity, temp, temp1, cost());
        }

    }// PurchasedItem class

}// namespace
