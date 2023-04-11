using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP_Csharp
{
    public class ProductOnStock : ICloneable
    {
        protected string productName;
        protected string manufacturingDate;
        protected string qualityCertificate;
        protected double cost;

        public ProductOnStock(string name, string date, string certificate, double cost)
        {
            productName = name;
            manufacturingDate = date;
            qualityCertificate = certificate;
            this.cost = cost;
        }

        ~ProductOnStock() { 
            
        }

        public void SetProductName(string name) { productName = name; }
        public void SetManufacturingDate(string date) { manufacturingDate = date; }
        public void SetQualityCertificate(string certificate) { qualityCertificate = certificate; }
        public void SetCost(double cost) { this.cost = cost; }

        public string GetProductName() { return productName; }
        public string GetManufacturingDate() { return manufacturingDate; }
        public string GetQualityCertificate() { return qualityCertificate; }
        public double GetCost() { return cost; }

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

        public object Clone()
        {
            return new ProductOnStock(productName, manufacturingDate, qualityCertificate, cost);
        }
    }
}
