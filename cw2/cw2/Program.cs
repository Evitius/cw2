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
                    string[] splitLine = line.Split(",");

                    if (splitLine.Length < 9)
                    {
                        logs.WriteLine(line);
                        break;
                    }

                    cw2.Student student = new cw2.Student
                    {
                        Name = splitLine[0],
                        Surname = splitLine[1],
                        Id = "s" + splitLine[4],
                        Date = splitLine[5],
                        Email = splitLine[6],
                        Mother = splitLine[7],
                        Father = splitLine[8],
                        Studies = new Studia
                        {
                            Name = splitLine[3],
                            Mode = splitLine[4]
                        }
                    };
                    hash.Add(student);
                }



               
                XmlSerializer xmls = new XmlSerializer(typeof(HashSet<cw2.Student>));
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