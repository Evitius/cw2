using System;
using System.Collections.Generic;
using System.IO;

namespace Cw2
{
    class Program
    {
        static void Main(string[] args)
        {

          
            var path = @"C:\Users\s18803\Desktop\dane.csv";
            var destinationPath = @"C:\Users\s18803\Desktop\wynik.xml";

            try
            {
        
            
             var liness = File.ReadLines(path);
             var hash = new HashSet<cw2.Student>(new cw2.OwnComparer());
             ICollection<string> list = new List<string>();
             StreamWriter logs = File.CreateText("log.txt")

             foreach (var line in liness)
             {
                 
               var splitLine = line.Split(",");
                
                if(splitLine.Length < 9)
                {
                   logs.WriteLine(line);
                   break;
                }
                  
                 cw2.Student student = new cw2.Student(splitLine);
                 Console.WriteLine(line);
                 hash.Add(student);

             }

               

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0}: ", e.GetType().Name, e.Message);
            }

           

         }
    }



}    //.Newtonsoft.JSON   JSonConvert.SerializableObject
