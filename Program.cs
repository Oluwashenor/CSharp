﻿using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello am Ava, whats your name ?");
            // var name = Console.ReadLine();
            // Console.WriteLine("Welcome {0}", name);
            // Console.WriteLine("Enter a Number");
            // var number = Console.ReadLine();
            // if(int.Parse(number)<=10){
            //     Console.WriteLine("Valid Number");
            // }
            // else{
            //     Console.WriteLine("Invalid");
            // }


            /*  2- Write a program which takes two numbers from the console and displays the maximum of the two.
            */
            // Console.WriteLine("");
            // Console.WriteLine("Code to check th highest between two numbers");
            // Console.WriteLine("Enter First number");
            // int a = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter Second number");
            // int b = Convert.ToInt32(Console.ReadLine());
            // var highest = (a > b) ? a : b;
            // Console.WriteLine("The highest value is {0}", highest);



            /* 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait. */
            //  Console.WriteLine("");
            //  Console.WriteLine("Landsape or portrait checker");
            //  Console.WriteLine("Enter your Height");
            //  var height = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine("Enter your Width");
            //  var width = Convert.ToInt32(Console.ReadLine());
            //  var response = (height > width) ? "Portrait":"Landscape";
            //  Console.WriteLine("This image is {0}",response);



            /* Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.
               */

            // Console.WriteLine("");
            // Console.WriteLine("Speed Checker");
            // Console.WriteLine("Enter your Speed Limit");
            // var speedLimit = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter the Speed of the vehicle");
            // var speedOfVehicle = Convert.ToInt32(Console.ReadLine());
            // if (speedOfVehicle < speedLimit)
            // {
            //     Console.WriteLine("Ok");
            // }
            // else
            // {
            //     Console.WriteLine("Above the speed limit");


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


                // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
                for (int i = 0; i <= 100; i++)
                {
                    if(i%3 == 0 ){
                         Console.WriteLine(i);
                    }
                } 


                // Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
                Console.WriteLine("Enter a number or enter ok to quit");
                int value = 0;
                while(true){
                   var userInput = Console.ReadLine();
                   if(userInput == "ok"){
                       break;
                   }
                   else{
                      value =  Convert.ToInt32(userInput) + Convert.ToInt32(userInput);
                   }
                }
                Console.WriteLine(value);

        }
    }
}