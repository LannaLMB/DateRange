using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateRange
{
    class Program
    {
        private static object allDates;

        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Please Enter a Date in the Following Format: mm dd yyyy");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Please Enter Another Date in the Following Format: mm dd yyyy");
            DateTime date2 = DateTime.Parse(Console.ReadLine());



            // Process
            System.TimeSpan diff = date2.Subtract(date1);

            int result = DateTime.Compare(date1, date2);
            int years = diff.Days / 365;
            int months = (diff.Days % 365) / 31;
            int days = (diff.Days % 365) % 31;




            // Output
            Console.WriteLine(" ");
            Console.WriteLine("The Duration Between Those Dates Is: "+ years + " Years, " + months + " Months, and " + days + " Days.");
        }
    }
}
