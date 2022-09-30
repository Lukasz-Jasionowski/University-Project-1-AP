using AP1;
int choose;
Logon newRegistration = new Logon();
try
{
    do
    {
        Console.WriteLine("Welcome to our service.\nChoose what you want to do.\n1.Register\n2.Log in\n3.Exit");
        choose = Convert.ToInt32(Console.ReadLine());
        switch (choose)
        {
            case 1:
                newRegistration.RegisterNewUser();
                break;
            case 2:
                newRegistration.LoginUser();
                break;
            case 3:
                Console.WriteLine("Good bye!");
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect value");
                Console.ResetColor();
                break;
        }
    } while (choose != 3);
}
catch (Exception)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Incorrect value, next time follow the instructions.");
    Console.ResetColor();
}