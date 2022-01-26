// See https://aka.ms/new-console-template for more information
using ProjectZeroUI;


bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    Console.Clear();
    
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "Exit":
            repeat = false;
            break;
        default:
            Console.WriteLine("Page Does Not Exist");
            break;
    }






}
