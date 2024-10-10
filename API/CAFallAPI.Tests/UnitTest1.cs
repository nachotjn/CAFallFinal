using Xunit;
using Assert = Xunit.Assert;

public class SampleTests
{
    [Fact] 
    public void Test_Addition_ReturnsCorrectSum()
    {
        
        int a = 5;
        int b = 3;

        int result = a + b;

        Assert.Equal(8, result);
    }
}