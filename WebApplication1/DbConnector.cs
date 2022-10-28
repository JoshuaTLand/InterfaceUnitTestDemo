using System.Data.SqlClient;

namespace WebApplication1
{

    public interface IDbConnector
    {
        Product GetProduct();
        void DeleteProduct(int id);
    }

    public class DbConnector : IDbConnector
    {
        public Product GetProduct()
        {
            // get product from database
            var databaseProduct = new Product();
            return databaseProduct;
        }

        public void DeleteProduct(int id)
        {
            // actually go and delete
        }
    }

    public class DbConnectorTest : IDbConnector
    {
        public Product GetProduct()
        {
            return new Product()
            {
                Id = 1,
                Name = "testName",
                Price = 1.00m,
            };
        }

        public void DeleteProduct(int id)
        {

        }
    }
}
