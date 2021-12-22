using System.Text;

namespace ConsoleApplication
{
    public class Strings
    {
        public static void WorkingWithText()
        {
            // Strings are immutable
            // Formatting Strings
            var name = "Baba Koodu";
            Console.WriteLine("Lower case : {0}", name.ToLower());
            Console.WriteLine("Upper case : {0}", name.ToUpper());
            Console.WriteLine("Trim : {0}", name.Trim());


            var index = name.IndexOf(" ");
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

            if (sentence.Length < maxLemgth)
                Console.WriteLine(sentence);
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<String>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLemgth)
                        break;
                }
                var summary = String.Join(" ", summaryWords) + ".....";
                Console.WriteLine(summary);
            }



        }


        public static void StringBuilder()
        {
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



        public static void ExerciseOne()
        {
            /*
            1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
            For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
            */
            Console.WriteLine("Enter a series of number seperated by hypen");
            var userInput = Console.ReadLine();

           var trimmed = userInput.Split("-");
           Console.WriteLine(trimmed.Length);

            // Increment
         if(Convert.ToInt32(trimmed[0]) > Convert.ToInt32(trimmed[1])){
             Console.WriteLine("Descending");
              // Decrement
            for (int i = 0; i < trimmed.Length ; i++)
            {
               Console.WriteLine(trimmed[i]);
               if(i != 0 ){
                    if((Convert.ToInt32(trimmed[i]) - Convert.ToInt32(trimmed[i+1]) != 1)){
                   Console.WriteLine("Not Consercutive");
                   break;
               }
                Console.WriteLine("Not Consercutive"); 
               }
            }
        }
        else{
            Console.WriteLine("Ascending");
           // Increment 
          for (int i = 0; i < trimmed.Length; i++)
           {
               Console.WriteLine(trimmed[i]);
               if(i != 0){
                    if((Convert.ToInt32(trimmed[i]) - Convert.ToInt32(trimmed[i-1]) != 1)){
                   Console.WriteLine("Not Consercutive");
                   break;
               }
               }
               Console.WriteLine("Consercutive");
           }

        }

        }

        public static void ExerciseTwo()
        {
            /*
            2- Write a program and ask the user to enter a few numbers separated by a hyphen.
            If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
            */

            Console.WriteLine("Enter your number seperated by a hypen");
            var userInput = Console.ReadLine();
            var duplicates = 0;
            if(String.IsNullOrWhiteSpace(userInput)){
                Console.WriteLine("GoodBye"); 
            }
            
            else{
              var trimmed = userInput.Split("-");
                for (int i = 0; i < trimmed.Length; i++)
                {
                    for (int j = 0; j < trimmed.Length; j++)
                    {
                        if (!(i==j)){
                            if(trimmed[i] == trimmed[j]){
                                duplicates++;
                            }
                        }
                    }
                }
            }
            if(duplicates > 0)
                Console.WriteLine("Duplicates {0}", duplicates);
        }

        public static void ExerciseThree()
        {
            /*
            3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
            A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
            */

            Console.WriteLine("Enter A valid time");
            var userTime = Console.ReadLine();
            Console.WriteLine(userTime);
            var hour = userTime.Split(":")[0];
            var minute = userTime.Split(":")[1];
            var response = "Invalid Time";
            if((Convert.ToInt32(hour) <= 23) && (Convert.ToInt32(minute) <= 59))
                response = "Ok";
            
            Console.WriteLine("The user\'s time {0} is {1}",userTime, response);
                

        }

        public static void ExerciseFour()
        {
            /*
            4- Write a program and ask the user to enter a few words separated by a space. 
            Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". 
            Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
            */
            Console.WriteLine("Enter couple of words seperated by spaces");
            var userInput = Console.ReadLine();
            var trimmedUserInput = userInput.Split(" ");
            StringBuilder words = new StringBuilder();
            foreach (var word in trimmedUserInput)
            {
                var sentence = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                words.Append(sentence);
            }
            Console.WriteLine(words);
        }

        public static void ExerciseFive()
        {
            /*
            5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word.
            So, if the user enters "inadequate", the program should display 6 on the console.
            */

            var vowels = new[] {'a','e','i','o','u'};
            Console.WriteLine("Please inut any english word");
            var userInput = Console.ReadLine();
            Console.WriteLine(userInput.Length);
            var numberVowels = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if(vowels.Contains(userInput[i]))
                    numberVowels++;
            }
            
            Console.WriteLine("We have {0} vowels in {1}", numberVowels, userInput);

        }

    }
}