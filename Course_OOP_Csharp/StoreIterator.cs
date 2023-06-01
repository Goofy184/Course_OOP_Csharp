using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP_Csharp
{
    public class StoreIterator : IEnumerator<ProductInStore>
    {
        private ProductInStore[] products;

        private int iteratorPosition = -1;

        public StoreIterator(ProductInStore[] products)
        {
            this.products = products;
        }

        public ProductInStore Current
        {
            get
            {
                return products[iteratorPosition];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            iteratorPosition++;
            return iteratorPosition < products.Length;
        }

        public void Reset()
        {
            iteratorPosition = 0;
        }
    }
}

