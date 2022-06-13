namespace SimpleApi.Test;
using SimpleApi.Controllers;

public class UnitTest1
{
    ValuesController controller = new ValuesController();

    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("Tosa Ojiru", returnValue.Value);
    }

    [Fact]
    public void Test1()
    {

    }
}