using Add.Core.Service;

namespace AddTest;

[TestClass]
public class AddPositiveNumers
{
    private readonly IService addService;
    public AddPositiveNumers()
    {
        addService = new Service();
    }

    [TestMethod]
    public void AddTwoIntegers()
    {
        var result = addService.Add(0, 1);
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void AddTwoDecimals()
    {
        decimal firstAddend  = 0.33m;
        decimal secondAddend = 0.22m;
        decimal result = addService.Add(firstAddend, secondAddend);
        Assert.AreEqual(0.55m, result);
    }

    [TestMethod]
    public void AddTwoDoubles()
    {
        double firstAddend  = 2.2222222;
        double secondAddend = 2.2222222;
        double result = addService.Add(firstAddend, secondAddend);
        Assert.AreEqual(4.4444444, result);
    }
}