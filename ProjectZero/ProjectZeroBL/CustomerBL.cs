using ProjectZeroDL;
using ProjectZeroModel;

namespace ProjectZeroBL
{

    public class CustomerBL : ICustomerBL
    {

        //Dependency Injection Pattern
        private IRepository _repo;
        public CustomerBL(IRepository c_repo) { _repo = c_repo; }


        public Cust AddCust(Cust c_cust)
        {
            // Console.WriteLine("Please Input Your Name.");
            // c_cust.CustName = Console.ReadLine();
            // Console.WriteLine("Please Input Your Phone Number.");
            // c_cust.CustNum = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Please Input Your Address.");
            // c_cust.CustAddress = Console.ReadLine();
            // Console.WriteLine("Thank You");
            
            return _repo.AddCust(c_cust);
        }

        public List<Store> GetAllStores()
        {
            return _repo.GetAllStores();
        }

        public int GetLastCust()
        {
            return _repo.GetLastCust();
        }

        public List<Inv> GetStoreInv(int StoreID)
        {
            return _repo.GetStoreInv(StoreID);
        }

        public List<Cust> SearchCustomer(string c_cate, string c_name)
        {
            List<Cust> listofCustomer = _repo.GetAllCust();

            switch (c_cate)
            {
                case "Name":
                    return listofCustomer.Where(cust => cust.CustName.Contains(c_name)).ToList();
                case "Address":
                    return listofCustomer.Where(cust => cust.CustAddress.Contains(c_name)).ToList();
                case "PhoneNumber":
                    return listofCustomer.Where(cust => cust.CustNum.Contains(c_name)).ToList();
                default:
                    Console.WriteLine("You can't spell.");
                    Console.ReadLine();
                    return listofCustomer;
            }

        }
    }


}