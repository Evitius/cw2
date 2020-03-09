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

                foreach (var line in liness)
            {
                    cw2.Student student = new cw2.Student();
                    Console.WriteLine(line);

                }

               

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0}: ", e.GetType().Name, e.Message);
            }

           

            var today = DateTime.UtcNow;


          

          //  public int getHashCode(Student Obj)
          // {
          //      return StringComparer
          // }

            //hash.Add();

            //if(!hash.Add(Student))


        }
    }



}    //.Newtonsoft.JSON   JSonConvert.SerializableObject