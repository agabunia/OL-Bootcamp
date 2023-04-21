using System;

namespace OL_TaskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username_database = "TestTest", password_database = "Password123"; //username and password which is already entered
            string username_input, password_input;
            int count = 0;

            //this is loop which gives 5 tries to enter username and password
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the username: ");
                username_input = Console.ReadLine();

                Console.WriteLine("Enter the password: ");
                password_input = Console.ReadLine();

                if (username_input == username_database && password_input == password_database)
                {
                    Console.WriteLine("Congratulations! You have entered in the system");
                    break;
                }
                else
                {
                    count++;
                    if(count < 5)
                    {
                        Console.WriteLine("Try again!");
                    }
                    else
                    {
                        //if username or password is entered incorrectly 5 times this message will be outputed and loop will end
                        Console.WriteLine("You have entered information incorrectly too many time!");
                        break;
                    }  
                }
            }
        }
    }
}
