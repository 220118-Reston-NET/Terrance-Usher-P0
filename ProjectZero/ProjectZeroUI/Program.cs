// See https://aka.ms/new-console-template for more information
using ProjectZeroUI;
using ProjectZeroDL;
using ProjectZeroBL;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string _connectionString = configuration.GetConnectionString("FirstConnectString");


bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    Console.Clear();
    
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "PlaceOrder_1":
            menu = new PlaceOrderMenu_1();
            break;
        case "ViewStoreInventory":
            menu = new ViewStoreInvMenu(new CustomerBL(new SQLRepository(_connectionString)));
            break;
        case "SearchCustomer":
            menu = new SearchCustMenu(new CustomerBL(new SQLRepository(_connectionString)));
            break;
        case "AddCustomer":
            menu = new AddCustMenu(new CustomerBL(new SQLRepository(_connectionString)));
            break;
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "Exit":
            repeat = false;
            break;
        default:
            Console.WriteLine("Page Does Not Exist");
            Console.WriteLine("Please press Enter to continue");
            Console.ReadLine();
            break;
    }






}
