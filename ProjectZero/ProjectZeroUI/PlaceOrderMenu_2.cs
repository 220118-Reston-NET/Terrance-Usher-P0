using ProjectZeroBL;
using ProjectZeroModel;

namespace ProjectZeroUI
{
    public class PlaceOrderMenu_2 : IMenu
    {
        public int CustID = 0;
        public int StoreID = 0;
        public void Display()
        {
            Console.WriteLine("Please Enter your Customer ID.");
            CustID = Convert.ToInt32(Console.ReadLine());
            
        }

        public string UserChoice()
        {
            throw new NotImplementedException();
        }
    }
}