using ProjectZeroModel;
using Xunit;

namespace ProjectZeroTest;

public class ItemCateTest
{
    [Fact]
    public void ItemCateShouldBeWithinValidLength()
    {
        //Arrange
        Item item = new Item();
        string validName = "Funko";

        //Act
        item.ItemCate = validName;

        //Assert
        Assert.True(item.ItemCate.Length <= 20);

    }
}