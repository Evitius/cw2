using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace cw2
{
	[Serializable]
	public class Uczelnia
	{
		[XmlAttribute(AttributeName = "studenci")]
		public HashSet<Student> studenci { get; set; }
		}
}
