using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP_Csharp

{
    public class Store
    {
        private StoreIterator<ProductInStore> products;

        public Store()
        {
            products = new StoreIterator<ProductInStore>();
        }

        public void AddProduct(ProductInStore product)
        {
            products.Add(product);
        }

        public StoreIterator<ProductInStore> GetProducts()
        {
            return products;
        }

        public double GetTotalProfit()
        {
            double profit = 0;
            foreach (ProductInStore product in products)
            {
                profit += product.GetPrice();
            }
            return profit;
        }
    }
}
