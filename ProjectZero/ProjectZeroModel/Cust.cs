/*
    This Class is for customer model and what it should contain
*/

namespace ProjectZeroModel
{
    public class Cust 
    {
        public string? CustName { get; set;}
        public string? CustAddress {get; set;}
        public int CustNum { get; set; }
        public List<Item> CustOrders { get; set; }


        public Cust()
        {
            CustName = " ";
            CustAddress = " ";
            CustNum = 0000000000;
        }
    }

}