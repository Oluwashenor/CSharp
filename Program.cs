using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        static void ValidNumber()
        {
            // Wrtie a program and ask the user to enter a number. the number should be be between 1 and 10 if the user enters a valid number the program should display valid and if not shows "Invalid" 
            Console.WriteLine("Hello am Ava, whats your name ?");
            var name = Console.ReadLine();
            Console.WriteLine("Welcome {0}", name);
            Console.WriteLine("Enter a Number");
            var number = Console.ReadLine();
            if (int.Parse(number) <= 10)
            {
                Console.WriteLine("Valid Number");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }


        static void MaxAmongTwoNumbers()
        {
            /*  2- Write a program which takes two numbers from the console and displays the maximum of the two.
           */
            Console.WriteLine("");
            Console.WriteLine("Code to check th highest between two numbers");
            Console.WriteLine("Enter First number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int b = Convert.ToInt32(Console.ReadLine());
            var highest = (a > b) ? a : b;
            Console.WriteLine("The highest value is {0}", highest);
        }


        static void ImageOrientation()
        {
            /* 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait. */
            Console.WriteLine("");
            Console.WriteLine("Landsape or portrait checker");
            Console.WriteLine("Enter your Height");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Width");
            var width = Convert.ToInt32(Console.ReadLine());
            var response = (height > width) ? "Portrait" : "Landscape";
            Console.WriteLine("This image is {0}", response);

        }


        void speedChecker()
        {

            /* Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.
               */

            Console.WriteLine("");
            Console.WriteLine("Speed Checker");
            Console.WriteLine("Enter your Speed Limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Speed of the vehicle");
            var speedOfVehicle = Convert.ToInt32(Console.ReadLine());
            if (speedOfVehicle < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Above the speed limit");


                var diff = speedOfVehicle - speedLimit;
                var demeritPoint = diff / 5;
                Console.WriteLine("Your Demerit Point is {0}", demeritPoint);
                if (demeritPoint > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("License not Suspended");
                }

            }

        }


        static void DivisibleBy3()
        {
            //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static void inquisitive()
        {
            // Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

            Console.WriteLine("Enter a number or enter ok to quit");
            int value = 0;
            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput == "ok")
                {
                    break;
                }
                else
                {
                    value = Convert.ToInt32(userInput) + Convert.ToInt32(userInput);
                }
            }
            Console.WriteLine(value);

        }


        static void Factorial()
        {
            // 3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.


            Console.WriteLine("Enter the number you need to solve");
            int factorial = Convert.ToInt32(Console.ReadLine());
            int value = 1;
            for (int i = factorial; i > 0; i--)
            {
                Console.WriteLine(i);
                value *= i;
            }
            Console.WriteLine(value);


        }



        static void GuesserGame()
        {
            /* 4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)*/

            Random random = new Random();
            int guessed = random.Next(0, 10);
            Console.WriteLine("What do you think the guessed number will be ?");
            int userGuessed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(guessed);
            if (userGuessed == guessed)
            {
                Console.WriteLine("You Won");
            }
            else
            {
                Console.WriteLine("You Lost");
            }

        }


        static void MaxInArrayOfString()
        {
            // Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Enter your Numbers seperated by Commas ?");
            var userInput2 = Console.ReadLine();
            var seperated = userInput2.Split(',');
            var max = 0;
            foreach (var s in seperated)
            {
                var current = Convert.ToInt32(s);
                if (current > max)
                {
                    max = current;
                }
            }
            Console.WriteLine("The Max number {0}", max);

        }



        static void DateFunction(){
            // Immutable - Once created cant be changed
            
            var dateTime = new DateTime(2015, 1,1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            

            Console.WriteLine("Hour : " + now.Hour);
            Console.WriteLine("Minute : " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yy-MM-dd"));
        }


        static void TimeSpanLearning(){

            // Creation
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration : {0}", duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Minutes: " + timeSpan.TotalMinutes);

            // Add 
            Console.WriteLine("Add Example", timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Add Example", timeSpan.Subtract(TimeSpan.FromMinutes(2)));


            // Conversion to string 
            Console.WriteLine("ToString" + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse : " + TimeSpan.Parse("01:02:03"));            
        }


     
        static void Main(string[] args)
        {
            Strings.ExerciseOne();
        }
    }
}