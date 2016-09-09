
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_three
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont;

            displayTitle();

            do
            {
                int userNum = enterInt();

                displayTable(userNum);

                Console.Write("\n\nContinue?(y/n):\t");
                cont = Console.ReadLine();
            } while (cont.ToLower() == "y");
        }

        static void displayTitle()
        {
            Console.Write("Learn your squares and cubes!");
        }

        static int enterInt()
        {
            int userNum;

            do
            {
                Console.Write("\n\nEnter an integer:\t");
                bool result = Int32.TryParse(Console.ReadLine(), out userNum);

                if (userNum == 0)
                {
                    Console.WriteLine("\n\n<---Error--->Invalid Data Entered, Please Try Again...");
                }
            } while (userNum == 0);

            return userNum;
        }

        static void displayTable(int userNum)
        {
            Console.Write("\n\nNumber\t\tSquared\t\tCubed");
            Console.Write("\n======\t\t=======\t\t======");

            for (int i = 1; i <= userNum; i++)
            {
                Console.Write("\n" + i + "\t\t" + Math.Pow(i, 2) + "\t\t" + Math.Pow(i, 3));
            }
        }
    }
}

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Square_and_Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
 
            string cont;
            do
                
            {
                int userNum=0;

                try
                {
                    Console.WriteLine("\nEnter an integer:");

                    userNum = int.Parse(Console.ReadLine());
               
                }
                catch
                {
                    Console.Write("Invalid Input. Please try again!");
                }

                for (int n = 1; n <= userNum; n++)
    
                Console.Write("\n" + n + "\t\t" + Math.Pow(n, 2) + "\t\t" + Math.Pow(n, 3));
                
                Console.WriteLine("\n");
              
                Console.WriteLine("Do you want to continue? (y/n)");
                cont = Console.ReadLine();
                              
            }

            while (cont.ToLower() == "y" || cont.ToLower() == "yes");

        }
        
    }
}



/*
create 2 methods, one square, one cube*, work with integers, create two loops, special formattting.
 int x;

    for (x = 1;x <= 5; x++)
{
	Console.Write(“\nThe value of x is " + x);
}

    Console.WriteLine("Cubes: " + c*c*c);

     */
