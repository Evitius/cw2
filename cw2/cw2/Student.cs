using System;
using System.Collections.Generic;
using System.Text;

namespace cw2
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Studies { get; set; }
        public string Course { get; set; }
        public string Id { get; set; }
        public string Date { get; set; }
        public string Email { get; set; }
        public string Mother { get; set; }
        public string Father { get; set; }


        public Student(string[] line)
        {
            Name = line[0].ToString();
            Surname = line[1].ToString();
            Studies = line[2].ToString();
            Course = line[3].ToString();
            Id = line[4].ToString();
            Date = line[5].ToString();
            Email = line[6].ToString();
            Mother = line[7].ToString();
            Father = line[8].ToString();
        }
    }
}