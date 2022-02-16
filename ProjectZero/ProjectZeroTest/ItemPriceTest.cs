using ProjectZeroModel;
using Xunit;

namespace ProjectZeroTest;

public class ItemPriceTest
{
    [Fact]
    public void ItemPriceShouldBeADecimal()
    {
        //Arrange
        Item item = new Item();
        decimal validPrice = 25.99m;

        //Act
        item.ItemPrice = validPrice;

        //Assert
        Assert.IsType<decimal>(item.ItemPrice);

    }
}