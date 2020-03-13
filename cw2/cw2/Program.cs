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
            string path = args[0];
            string destinationPath = args[1];


            try
            {
                StreamWriter logs = File.CreateText("log.txt");

                var liness = File.ReadLines(path);
                var hash = new HashSet<cw2.Student>(new cw2.OwnComparer());
                int computerScienceStudents=0;
                int mediaArtStudents=0;

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
                            Name = splitLine[2],
                            Mode = splitLine[3]
                        }
                    };
                    hash.Add(student);
                }


                foreach (var student in hash)
                {
                    if (student.Studies.Name == "Sztuka Nowych Mediów dzienne" ) mediaArtStudents++;
                    else computerScienceStudents++;
                }


                Uczelnia uczelnia = new Uczelnia
                {
                    CreatedAt = DateTime.Today,
                    Author = "Michał Żabicki",
                    Studenci = hash,
                    ActiveStudies = new AktywneStudia
                    {
                        ComputerScience = new Informatyka
                        {
                            Name = "Informatyka dzienne",
                            NumberOfStudents = computerScienceStudents
                        },

                       NewArtMedia= new SztukaNowychMediow
                       {
                           Name = "Sztuka Nowych Mediów dzienne",
                           NumberOfStudents = mediaArtStudents
                        }
                    }
                };


               
                XmlSerializer xmls = new XmlSerializer(typeof(Uczelnia));
                FileStream fsWrite = new FileStream(destinationPath, FileMode.Create);
                xmls.Serialize(fsWrite,uczelnia);
                

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0}: ", e.GetType().Name, e.Message);
            }

        }
    }
}
   //.Newtonsoft.JSON   JSonConvert.SerializableObject