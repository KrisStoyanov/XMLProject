using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Xml.Parser.Models
{
    [Serializable]
    public class Balloon
    {

        [XmlElement("Transform")]
        public Transform Transform { get; set; }

        [XmlElement("speed")]
        public float Speed { get; set; }

        [XmlElement("cargo")]
        public string Cargo { get; set; }

        
    }
}
