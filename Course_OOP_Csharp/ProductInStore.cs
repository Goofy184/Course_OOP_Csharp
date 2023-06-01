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

            if (DateTime.Parse(expirationDate)< DateTime.Parse(date))
            {
                throw new Exception("Expiration Date can not be before manufacturing date");
            }
            Markup = markup; 
            ExpirationDate = expirationDate;
        }
        ~ProductInStore() 
        {

        }
        public double Markup
        {
            set
            {
                markup = value;
            }
            get
            {
                return markup;

            }
        }
        public string ExpirationDate
        {
            set
            {
                validateDate(value);
                expirationDate = value;
            }
            get
            {
                return expirationDate;

            }
        }
        public override double GetPrice()
        {
            return cost * (1 + markup); 
        }
    }
}
