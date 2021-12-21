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
            
        }


        public static void ExerciseTwo(){

        }

    }
}