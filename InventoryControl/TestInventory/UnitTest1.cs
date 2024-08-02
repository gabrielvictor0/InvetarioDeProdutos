using Invetory;

namespace TestInventory
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Mouse", 8)]
        [InlineData("Mouse", 10)]
        [InlineData("Teclado", 200)]
        public void InsertProduct(string name, int quantity)
        {
            Product productExpect = new Product();
            productExpect.Name = name;
            productExpect.Quantity = quantity;

            var resultAddProduct = ProductRepository.AddProduct(productExpect);

            var productResult = ListProduct.Product!.Find(x => x.Name == name);
            
            if (resultAddProduct == "product update") 
            {
                Assert.Equal(productResult!.Quantity, productExpect.Quantity);
            }
            else
            {
                Assert.Equal(productResult, productExpect);
            }

        }

        [Theory]
        [InlineData("Mouse")]
        [InlineData("Teclado")]
        public void QuantityProduct(string name)
        {
            var result = ProductRepository.SearchQuantityProduct(name);
             
            var quantityExpected = ListProduct.Product!.FirstOrDefault(x => x.Name == name);

            Assert.Equal(result, quantityExpected!.Quantity);
        }
    }
}