using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace cw2
{
    public class SztukaNowychMediow
    {
        [XmlAttribute]
        public string Name = "New Art Media";
        [XmlAttribute] 
        public int NumberOfStudents { get; set; }
    }
}
