using System;

namespace TestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Average App

            Console.WriteLine("What is your first test score?");
            //Input from Console is of type string. So we must convert it to an int
            var responseFromUser = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your second test score?");
            var responseFromUser2 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your third and final test score?");
            var responseFromUser3 = int.Parse(Console.ReadLine());

            var responsesAdded = (responseFromUser + responseFromUser2 + responseFromUser3);
            var testAverage = (responsesAdded / 3);

            Console.WriteLine("The average of your three test scores is..." + testAverage);
         


            Console.ReadLine();

        }
    }
}
