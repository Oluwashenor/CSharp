using System.IO;

namespace ConsoleApplication{

    public class MyFiles{
        public static void Filer(){

            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg");
            File.Delete(path);
            if(File.Exists(path)){
                //
            }
            var connect = File.ReadAllText(path);
            var fileInfo = new FileInfo(path);
            fileInfo.Delete();
            if(fileInfo.Exists){
                //
            }

        }

        public static void Directoryy(){
            Directory.CreateDirectory(@"c:\temp\folder");
            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.sln*", SearchOption.AllDirectories);
            foreach (var file in files){
                Console.WriteLine(file);
            }
            var directories = Directory.GetDirectories(@"c:\");
        }
    }

}