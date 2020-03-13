using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace cw2
{
	[Serializable]
	public class Uczelnia
	{
		[XmlAttribute(AttributeName = "createdAt")]
		public DateTime CreatedAt { get; set;}

		[XmlAttribute(AttributeName = "author")]
		public string Author { get; set; }

		[XmlElement(elementName: "studenci")]
		public HashSet<Student> Studenci { get; set;}
		}
}
