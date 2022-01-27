// See https://aka.ms/new-console-template for more information
using ProjectZeroUI;
using ProjectZeroDL;
using ProjectZeroBL;


bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    Console.Clear();
    
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "AddCustomer":
            menu = new AddCustMenu(new CustomerBL(new Repository()));
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
