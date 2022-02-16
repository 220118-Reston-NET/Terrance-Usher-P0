using ProjectZeroModel;
using Xunit;

namespace ProjectZeroTest;

public class StoreAddressTest
{
    [Fact]
    public void StoreAddressShouldBeWithinValidLength()
    {
        //Arrange
        Store item = new Store();
        string validName = "Terrance's Apartment";

        //Act
        item.StoreAddress = validName;

        //Assert
        Assert.True(item.StoreAddress.Length <= 75);

    }
}