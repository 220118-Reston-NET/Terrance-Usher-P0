using ProjectZeroModel;
using ProjectZeroBL;

namespace ProjectZeroUI
{
    public class AddCustMenu : IMenu
    {

        private static Cust _newCust = new Cust();
        
        //Dependency Injection
        private ICustomerBL _custBL;
        public AddCustMenu(ICustomerBL c_custBL) { _custBL = c_custBL; }

        public void Display()
        {
            Console.WriteLine("Enter Your Information");
            Console.WriteLine("[4] Address - " + _newCust.CustAddress);
            Console.WriteLine("[3] Phone Number - " + _newCust.CustNum);
            Console.WriteLine("[2] Name - " + _newCust.CustName);
            Console.WriteLine("[1] Save");
            Console.WriteLine("[0] Go Back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    _custBL.AddCust(_newCust);
                    return "MainMenu";
                case "2":
                    Console.WriteLine("Please enter a Name");
                    _newCust.CustName = Console.ReadLine();
                    return "AddCustomer";
                case "3":
                    Console.WriteLine("Please Enter a Phone Number");
                    try
                    {
                        _newCust.CustNum = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (System.Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    return "AddCustomer";
                case "4":
                    Console.WriteLine("Please enter an Address.");
                    _newCust.CustAddress = Console.ReadLine();
                    return "AddCustomer";
                default:
                    Console.WriteLine("Please input a vaild response");
                    Console.WriteLine("Please Press Enter to continue");
                    Console.ReadLine();
                    return "AddCustomer";
            }
        }
    }
}