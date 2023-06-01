using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP_Csharp
{
    public class Store:IEnumerable<ProductInStore>
    {
        private List<ProductInStore> products; 
        public Store()
        {
            products = new List<ProductInStore>(); 
        }
        public void AddProduct(ProductInStore product)
        {
            products.Add(product); 
        }

        public IEnumerator<ProductInStore> GetEnumerator()
        {
            return new StoreIterator(products.ToArray());
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new StoreIterator(products.ToArray());
        }
    }
}

