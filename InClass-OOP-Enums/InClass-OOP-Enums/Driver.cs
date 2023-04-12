using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_OOP_Enums
{
    public class Driver
    {
        public static void Main()
        {
            //Console.WriteLine(Divide(10, 3));
            //Console.WriteLine(Divide(10.0, 3.0));

            string name = "bob";

            DaysOfTheWeek monday = DaysOfTheWeek.Sunday;
            string mondayStr = monday.ToString(); //convert from enum -> string

            Console.WriteLine(monday);
            Console.WriteLine(mondayStr);

            Console.WriteLine("Please enter a day of the week:");
            string userInput = Console.ReadLine();
            DaysOfTheWeek userDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput); //convert from string->enum

            switch(userDay)
            {
                case DaysOfTheWeek.Sunday:
                case DaysOfTheWeek.Saturday:
                    Console.WriteLine("It's the weekend");
                    break;
                case DaysOfTheWeek.Monday:
                case DaysOfTheWeek.Tuesday:
                case DaysOfTheWeek.Wednesday:
                case DaysOfTheWeek.Thursday:
                    Console.WriteLine("It's the middle of the week");
                    break;
                case DaysOfTheWeek.Friday:
                    Console.WriteLine("It's almost the weekend");
                    break;
                default:
                    break;
            }

            int myNum = (int)DaysOfTheWeek.Wednesday;
            Console.WriteLine(myNum);
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        /*
        public static int Divide(int b, int a)
        {
            return a / b;
        }
        */

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        /*
        public static int Divide(double a, double b)
        {
            return (int)(a / b);
        }
        */
    }
}
