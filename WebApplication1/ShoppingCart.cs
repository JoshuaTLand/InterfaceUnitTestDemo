using System.Data.SqlClient;

namespace WebApplication1
{
    public class ShoppingCart
    {
        List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            // get db info from string
            // us _connection to get db info
            _products.Add(product);
        }
    }
}
