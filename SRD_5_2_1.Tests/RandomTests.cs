using Random = SRD_5_2_1.Domain.Random;
namespace SRD_5_2_1.Tests;

public class RandomTests
{
    [Theory]
    [InlineData(-1, 8)]
    [InlineData(int.MinValue, int.MaxValue)]
    [InlineData(1,1)]
    public void Random_Returns_Number_In_Range(int min, int max)
    {
        int result = Random.Range(min, max);
        Assert.InRange(result, min, max);
    }

    [Theory]
    [InlineData(10, -9)]
    [InlineData(-2, -9)]
    [InlineData(int.MaxValue, int.MinValue)]
    public void Should_Not_Allow_Min_Value_Be_Higher_Than_Max(int min, int max)
    {
        Assert.Throws<ArgumentException>(() =>
        {
            int result = Random.Range(min, max);
        });
    }
}