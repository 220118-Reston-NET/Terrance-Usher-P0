using ProjectZeroModel;
using System.Text.Json;

namespace ProjectZeroDL
{

    public class Repository : IRepository
    {
        
        private string _filepath = "../ProjectZeroDL/Database/";
        private string _jsonString;

        public Cust AddCust(Cust c_cust)
        {
            string path = _filepath + "Customers.json";
            
            List<Cust> listofCust = GetAllCust();
            listofCust.Add(c_cust);
            
            _jsonString = JsonSerializer.Serialize(listofCust, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path, _jsonString);
            
            return c_cust;
        }

        public List<Inv> AddToOrder(Orders CurrentOrder, int StoreItemID)
        {
            throw new NotImplementedException();
        }

        public void AddToOrder(Orders CurrentOrder, Inv StoreItem)
        {
            throw new NotImplementedException();
        }

        public void ChangeInvQuantity(int value, int StoreItemID)
        {
            throw new NotImplementedException();
        }

        public Orders CreateOrder(int CustID, int StoreID)
        {
            throw new NotImplementedException();
        }

        public List<Cust> GetAllCust()
        {
            _jsonString = File.ReadAllText(_filepath + "Customers.json"); 

            return JsonSerializer.Deserialize<List<Cust>>(_jsonString);

        }

        public List<Inv> GetAllOrderItems(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetAllOrders(int ID, string filter)
        {
            throw new NotImplementedException();
        }

        public List<Store> GetAllStores()
        {
            throw new NotImplementedException();
        }

        public Cust GetCustByID(int CustID)
        {
            throw new NotImplementedException();
        }

        public int GetLastCust()
        {
            throw new NotImplementedException();
        }

        public List<Inv> GetStoreInv(int StoreID)
        {
            throw new NotImplementedException();
        }
    }

}