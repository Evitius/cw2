using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace cw2
{
	[Serializable]
	public class Uczelnia
	{
		[XmlAttribute]
		public DateTime CreatedAt { get; set;}

		[XmlAttribute] 
		public string Author { get; set; }
		
		public HashSet<Student> Studenci { get; set;}

		public AktywneStudia ActiveStudies { get; set; }
	}
}
