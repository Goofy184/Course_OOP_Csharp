using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Course_OOP_Csharp
{
    public class ProductOnStock
    {
        protected string productName; 
        protected string manufacturingDate; 
        protected string qualityCertificate; 
        protected double cost; 
        public ProductOnStock(string name, string date, string certificate, double cost)
        {
            ProductName = name; 
            ManufacturingDate = date; 
            QualityCertificate = certificate;
            Cost = cost; 
        }
        ~ProductOnStock()
        { }

        public string ProductName
        {
            set
            {
                productName = value;
            }
            get
            {
                return productName;

            }
        }
        public string ManufacturingDate
        {
            set
            {
                validateDate(value);
                manufacturingDate = value;
            }
            get
            {
                return manufacturingDate;

            }
        }

        public string QualityCertificate
        {
            set
            {
                qualityCertificate = value;
            }
            get
            {
                return qualityCertificate;

            }
        }
        public double Cost
        {
            set
            {
                cost = value;
            }
            get
            {
                return cost;

            }
        }
        public virtual double GetPrice() 
        {
            return cost; 
        }
        public static ProductOnStock operator +(ProductOnStock product, double value)
        {
            product.cost += value; 
            return product;
        }
        public static ProductOnStock operator -(ProductOnStock product, double value)
        {
            product.cost -= value; 
            return product;
        }

        protected void validateDate(string date)
        {
            DateTime.Parse(date);
        }
    }
}



