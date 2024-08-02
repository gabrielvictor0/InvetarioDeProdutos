using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invetory
{
    public class ProductRepository
    {
        public static string AddProduct(Product product)
        {
			try
			{

				var search = ListProduct.Product!.Find(x => x.Name == product.Name);
                if (search != null)
                {
                    search.Quantity = product.Quantity;
                    search.Name = search.Name;
                    ListProduct.Product.Add(search);
                    return "product update";
                }

                ListProduct.Product.Add(product);
                return "product registered";

			}
			catch (Exception)
			{

				throw;
			}
        }

        public static int? SearchQuantityProduct(string name)
        {
            try
            {
                Product newProduct = new Product();
                newProduct.Name = name;
                newProduct.Quantity = 5;
                ListProduct.Product!.Add(newProduct);

                var product = ListProduct.Product!.FirstOrDefault(x => x.Name == name);
                
                return product!.Quantity;
            }
            catch (Exception)
            {   

                throw;
            }
        }
    }
}
