using System;

namespace TestAverage
{
    class Program
    {
        static int GetUserResponse(string question) //Custom Method to clean up code
        {
            int integerFromUser;
            bool success = false;

            do
            {
                Console.WriteLine(question);
                var userResponse = Console.ReadLine();
                success = int.TryParse(userResponse, out integerFromUser);

            } while (success == false);

            return integerFromUser;

        }
        static void Main(string[] args)
        {
            //Test Average App
            //Input from Console is of type string. So... we must convert it to an int

            var scoreOne = GetUserResponse("Enter your first score");

            var scoreTwo = GetUserResponse("Enter your second score");

            var scoreThree = GetUserResponse("Enter your third score");

            var scoresAdded = (scoreOne + scoreTwo + scoreThree);
            var scoreAverage = (scoresAdded / 3);

            Console.WriteLine("The average of your three scores is" + " " + scoreAverage);



            Console.WriteLine();

        }
    }
}
