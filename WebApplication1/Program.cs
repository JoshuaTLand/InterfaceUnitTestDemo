using WebApplication1;

// Actual program code
IDbConnector dbConnector = new DbConnector();
CodeToTest codeToTest = new CodeToTest(dbConnector);
var returnedId = codeToTest.RunCode();

// now go do something with that id


//Unit test code
IDbConnector dbConnectorTEst = new DbConnectorTest();
CodeToTest CodeToTestTest = new CodeToTest(dbConnectorTEst);
var returnedIdTest = CodeToTestTest.RunCode();

//Assert.IsEqual(returnedIdTest, 1);



public class CodeToTest
{

    IDbConnector interfaceConnector;

    public CodeToTest(IDbConnector connector)
    {
        interfaceConnector = connector;
    }

    public int RunCode() 
    { 
        Product product = interfaceConnector.GetProduct();
        interfaceConnector.DeleteProduct(product.Id);

        ShoppingCart cart = new ShoppingCart();
        cart.AddProduct(product);

        return product.Id;
    }
}



