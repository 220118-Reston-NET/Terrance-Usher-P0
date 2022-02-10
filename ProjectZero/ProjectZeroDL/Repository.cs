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

        public List<Cust> GetAllCust()
        {
            _jsonString = File.ReadAllText(_filepath + "Customers.json"); 

            return JsonSerializer.Deserialize<List<Cust>>(_jsonString);

        }

        public List<Store> GetAllStores()
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