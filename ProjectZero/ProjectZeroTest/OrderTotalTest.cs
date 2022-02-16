using ProjectZeroModel;
using Xunit;

namespace ProjectZeroTest;

public class OrderTotalTest
{
    [Fact]
    public void OrderTotalShouldBeADecimal()
    {
        //Arrange
        Orders order = new Orders();
        decimal validTotal = 660.99m;

        //Act
        order.OrderTotal = validTotal;

        //Assert
        Assert.IsType<decimal>(order.OrderTotal);

    }
}