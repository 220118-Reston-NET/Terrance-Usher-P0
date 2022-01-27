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

        public List<Cust> SearchCustomer(string c_name)
        {
            throw new NotImplementedException();
        }
    }


}