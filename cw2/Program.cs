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

            foreach (var line in liness)
            {


                Console.WriteLine(line);
            }

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0}: ", e.GetType().Name, e.Message);
            }

            //ICollection<string> list = new List<string>;

            var today = DateTime.UtcNow;


            var hash = new HashSet<cw2.Student>(new cw2.OwnComparer());

          //  public int getHashCode(Student Obj)
          // {
          //      return StringComparer
          // }

            //hash.Add();

            //if(!hash.Add(Student))


        }
    }



}


//.Newtonsoft.JSON   JSonConvert.SerializableObject