using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1
{
    internal class Logon
    {

        private string userEmail;
        private string Text { get; set; }
        public List<Users> UsersList = new List<Users>();
        public Users newUser = new Users();
        string path = @"C:\Users\Luki\Desktop\data.txt";
        public void RegisterNewUser()
        {
            Console.Write("Enter username: ");
            newUser.UserName = Console.ReadLine();
            Console.Write("Enter email: ");
            newUser.UserEmail = Console.ReadLine();
            Console.Write("Enter password: ");
            newUser.UserPassword = Console.ReadLine();
            UsersList.Add(newUser);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The login details were saved in a data.txt file on the desktop.");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Your password has been encrypted.\n");
            Console.ResetColor();
            Text = $"Username: {newUser.UserName}\nEmail: {newUser.UserEmail}\nPassword: ********";
            File.WriteAllText(path, Text);
        }
        public void LoginUser()
        {
            Console.Write("\nEnter email to log in: ");
            userEmail = Console.ReadLine();
            if (userEmail == newUser.UserEmail)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in, your password has been decrypted!");
                Console.ResetColor();
                Text = $"Username: {newUser.UserName}\nEmail: {newUser.UserEmail}\nPassword: {newUser.UserPassword}";
                File.WriteAllText(path, Text);
            }
        }
    }
}