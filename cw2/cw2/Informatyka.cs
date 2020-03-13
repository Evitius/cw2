using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace cw2
{
    public class Informatyka
    {
        [XmlAttribute]
        public string Name = "Computer Science";
       
        [XmlAttribute]
        public int NumberOfStudents { get; set; }
    }
}
