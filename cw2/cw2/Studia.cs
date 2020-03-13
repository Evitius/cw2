using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace cw2
{
    public class Studia
    {
        [XmlElement(elementName: "name")]
        public string Name { get; set; }

        [XmlElement(elementName: "mode")]
        public string Mode { get; set; }
    }
}
