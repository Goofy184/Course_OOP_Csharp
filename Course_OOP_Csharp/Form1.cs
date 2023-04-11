﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_OOP_Csharp
{
    public partial class Form1 : Form
    {
        private Store store;
        public Form1()
        {

            InitializeComponent();
            store = new Store();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            string name = productNameTextBox.Text;
            string date = manufacturingDateTextBox.Text;
            string certificate = qualityCertificateTextBox.Text;
            double cost = double.Parse(costTextBox.Text);
            double markup = double.Parse(markupTextBox.Text);
            string expirationDate = expirationDateTextBox.Text;

            ProductInStore product = new ProductInStore(name, date, certificate, cost, markup, expirationDate);
            store.AddProduct(product);
            productsListBox.Items.Add(product.GetProductName()+"\t"+product.GetManufacturingDate() + "\t" + product.GetQualityCertificate() + "\t" + product.GetCost() + "\t" + product.GetMarkup() + "\t" + product.GetExpirationDate());
        }
        private void calculateProfitButton_Click(object sender, EventArgs e)
        {
            double profit = store.GetTotalProfit();
            profitLabel.Text = $"Total Profit: {profit}";
        }
    }
}
