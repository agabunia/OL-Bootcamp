using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL_TaskThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area, volume;

            //new object is creadted from class Overloading
            OverloadingMethod newMethod = new OverloadingMethod();
            area = newMethod.Calculator(15, 20);
            volume = newMethod.Calculator(10, 20, 30);

            Console.WriteLine(area);
            Console.WriteLine(volume);
        }

        //created class where overloading method Calculator is declared 
        class OverloadingMethod
        {
            public int Calculator(int length, int width)
            {
                return length * width;
            }

            public int Calculator(int length, int width, int height)
            {
                return length * width * height;
            }
        }  
    }
}
