using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkWeek3Problem3_IsTriangle
{
    class Program
    {   //Evan Caraway, Srinivas Reddy Doma, Kipack Jeong
        static void Main(string[] args)
        {
            Console.Write("Enter side X length: ");         //request user enter length.
            int.TryParse(Console.ReadLine(), out int x);    //parse user input to integer and save to variable.

            Console.Write("Enter side Y length: ");
            int.TryParse(Console.ReadLine(), out int y);

            Console.Write("Enter side Z length: ");
            int.TryParse(Console.ReadLine(), out int z);

            if (IsTriangle(x, y, z))                        //check user inputs with IsTriangle() method and display results.
            {
                Console.WriteLine($"Congratulations, {x}, {y}, and {z} will form a triangle!");
            }
            else
            {
                Console.WriteLine($"Sorry, {x}, {y}, and {z} will not form a triangle.");
            }
        }

        /// <summary>
        /// Checks to see if 3 given integer lengths can form a triangle.
        /// </summary>
        /// <param name="x">length of side "x"</param>
        /// <param name="y">length of side "y"</param>
        /// <param name="z">length of side "z:</param>
        /// <returns>returns bool value of "true" or "false".</returns>
        static bool IsTriangle(int x, int y, int z)
        {
            if ((x + y) < z || (x + z) < y || (y + z) < x)
            {
                return false;
            }
            else
            {
                return true;
            }
                    
        }

    }
}
