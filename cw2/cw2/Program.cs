using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace cw2
{
    class Program
    {
        static void Main(string[] args)
        {


            var path = @"C:\Users\Michał\Desktop\dane.csv";
            var destinationPath = @"C:\Users\Michał\Desktop\wynik.xml";

            try
            {
                StreamWriter logs = File.CreateText("log.txt");

                var liness = File.ReadLines(path);
                var hash = new HashSet<cw2.Student>(new cw2.OwnComparer());
                //ICollection<string> list = new List<string>();


                foreach (var line in liness)
                {
                    var splitLine = line.Split(",");

                    if (splitLine.Length < 9)
                    {
                        logs.WriteLine(line);
                        break;
                    }

                    cw2.Student student = new cw2.Student
                    {
                        Name = line[0].ToString(),
                        Surname = line[1].ToString(),
                        Studies = line[2].ToString(),
                        Course = line[3].ToString(),
                        Id = line[4].ToString(),
                        Date = line[5].ToString(),
                        Email = line[6].ToString(),
                        Mother = line[7].ToString(),
                        Father = line[8].ToString(),
                    };
                    hash.Add(student);
                }



                XmlRootAttribute xmlRA = new XmlRootAttribute(@"Created at " + DateTime.Now + new XmlRootAttribute("Author: Michał Żabicki"));
                XmlSerializer xmls = new XmlSerializer(typeof(HashSet<cw2.Student>), xmlRA);
                FileStream fsWrite = new FileStream(destinationPath, FileMode.Create);
                xmls.Serialize(fsWrite, hash);


            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0}: ", e.GetType().Name, e.Message);
            }

        }
    }
}
   //.Newtonsoft.JSON   JSonConvert.SerializableObject