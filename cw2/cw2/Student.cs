using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace cw2
{
    public class Student
    {

        [XmlAttribute(attributeName: "indexNumber")]
        public string Id { get; set; }

        [XmlElement(elementName: "fname")]
        public string Name { get; set; }
        
        [XmlElement(elementName: "lname")]
        public string Surname { get; set; } 

        [XmlElement(elementName: "birthdate")]
        public string Date { get; set; }

        [XmlElement(elementName: "email")]
        public string Email { get; set; }

        [XmlElement(elementName: "mothersName")]
        public string Mother { get; set; }

        [XmlElement(elementName: "fathersName")]
        public string Father { get; set; }

        [XmlElement(elementName: "studies")]
        public Studia Studies { get; set; }


    }
}