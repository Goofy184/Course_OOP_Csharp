using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP_Csharp
{
    public class ProductInStore : ProductOnStock
    {
        protected double markup;
        protected string expirationDate;

        public ProductInStore(string name, string date, string certificate, double cost, double markup, string expirationDate)
            : base(name, date, certificate, cost)
        {
            this.markup = markup;
            this.expirationDate = expirationDate;
        }

        ~ProductInStore() { 
            
        }

        public void SetMarkup(double markup) { this.markup = markup; }
        public void SetExpirationDate(string date) { expirationDate = date; }

        public double GetMarkup() { return markup; }
        public string GetExpirationDate() { return expirationDate; }

        public override double GetPrice()
        {
            return cost * (1 + markup);
        }
    }
}
