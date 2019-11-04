using System;
using System.IO;

public class CommandLine
{
   public static void Main(string[] args)
   {
       using (StreamWriter outputFile = new StreamWriter("PAJwynik.txt", append: true)) {
       outputFile.WriteLine("--------");
       outputFile.WriteLine("Uruchomiono: " + System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
       outputFile.WriteLine("Liczba argumentow = {0}", args.Length);
       for(int i = 0; i < args.Length; i++)
       {
           outputFile.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
       }
       outputFile.WriteLine();
   }
   }
}
