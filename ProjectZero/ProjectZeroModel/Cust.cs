/*
    This Class is for customer model and what it should contain
*/

namespace ProjectZeroModel
{
    public class Cust 
    {
        public string? CustName { get; set;}
        public string? CustAddress {get; set;}
        public string? CustNum { get; set; }
        public List<Item> CustOrders { get; set; }


        public Cust()
        {
            CustName = " ";
            CustAddress = " ";
            CustNum = "0000000000";
        }

        public override string ToString()
        {
            return $"Name: {CustName}\nPhone Number: {CustNum}" +
              $"\nAddress: {CustAddress}\nOrders: {CustOrders}";
        }
    }

}