using System.Text;

namespace ConsoleApplication {
   public class Strings{
          public static void WorkingWithText(){
            // Strings are immutable
            // Formatting Strings
            var name = "Baba Koodu";
            Console.WriteLine("Lower case : {0}", name.ToLower());
            Console.WriteLine("Upper case : {0}", name.ToUpper());
            Console.WriteLine("Trim : {0}", name.Trim());
            

            var index =name.IndexOf(" ");
            var firstName = name.Substring(0, index);
            var lastName = name.Substring(index + 1);
            Console.WriteLine("First name : {0}", firstName);
            Console.WriteLine("Last name : {0}", lastName);

            var names = name.Split(' ');
            Console.WriteLine("First name : {0}", names[0]);
            Console.WriteLine("Last name : {0}", names[1]);

            Console.WriteLine(name.Replace("Baba", "Father"));


            if (String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");
            if (String.IsNullOrWhiteSpace(null))
                Console.WriteLine("Invalid");
            

            // Conversion
            var str = "25";
            var age = Convert.ToByte(str);

            float price = 29.5f;
            Console.WriteLine(price.ToString("C0"));

            // Text Summary 
            var sentence = "This is a really really really really really really really really really long text";
            const int maxLemgth = 20;

            if(sentence.Length < maxLemgth)
                Console.WriteLine(sentence);
            else{
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<String>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if(totalCharacters > maxLemgth)
                        break;
                }
                var summary = String.Join(" ", summaryWords) + ".....";
                Console.WriteLine(summary); 
            }



        }


       public static void StringBuilder(){
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            
            builder.Replace('-', '+');
            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            
            Console.WriteLine(builder);
            
        }



        public static void ExerciseOne(){
            /*
1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
 For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
            */
        }


        public static void ExerciseTwo(){
            /*
2- Write a program and ask the user to enter a few numbers separated by a hyphen.
 If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
            */
        }

        public static void ExerciseThree(){
            /*
3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
            */
        }

        public static void ExerciseFour(){
            /*
4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
            */
        }

        public static void ExerciseFive(){
            /*
            5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.
            */
        }

    }
}