using Subtract.Core.Service;
namespace Subtract.Test;

[TestClass]
public class SubtractPositiveNumbers
{

    private readonly IService subtractService;
    public SubtractPositiveNumbers()
    {
        subtractService = new Service();
    }


    [TestMethod]
    public void SubtractTwoIntegers()
    {
    }

     [TestMethod]
    public void SubtractTwoDecimals()
    {
    }

     [TestMethod]
    public void SubtractTwoDoubles()
    {
    }
}