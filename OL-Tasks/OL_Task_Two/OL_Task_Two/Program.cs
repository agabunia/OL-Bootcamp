using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL_Task_Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int user_input, i;
            int[] container = new int[20];
            string user_output = "";

            //the number is entered by the user and converted to integer
            Console.WriteLine("Enter the number: ");
            user_input = Convert.ToInt32(Console.ReadLine());

            //the loop is used to take user input's division reminder by 2 and collects them in container array
            for (i = 0; user_input > 0; i++)
            {
                container[i] = user_input % 2;
                user_input = user_input / 2;
            }

            //this loop takes conatainer array and reversed it to calculate binary code
            for (i = i - 1; i >= 0; i--)
            {
                user_output = user_output + container[i];
            }

            Console.WriteLine("The number in binary is: ");
            Console.WriteLine(user_output);
        }
    }
}
