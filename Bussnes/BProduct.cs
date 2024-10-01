using Data;
using Entity;

namespace Bussnes
{  
    public class BProduct 
    {
        // creamos un objeto global de DProduct
        DProduct productData = new DProduct();

        public List<Product> listProducts()
        {
            return productData.listProduct();
        }
    }
}
