

namespace ProjectZeroModel
{
    public class Orders
    {
        public int OrderID { get; set; }
        public string StoreName { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerAddress { get; set; }

        public double OrderTotal { get; set; }




        public List<Item> ItemsPurchased { get; set; }

        public override string ToString()
        {
            return $"Order ID: {OrderID}\nCustomer ID: {CustomerID}\nName: {CustomerName}\nPhone Number: {CustomerNumber}" +
              $"\nAddress: {CustomerAddress}\n{ItemsPurchased}\nTotal: {OrderTotal}";
        }

    
        
    
    
    
    
    }

}