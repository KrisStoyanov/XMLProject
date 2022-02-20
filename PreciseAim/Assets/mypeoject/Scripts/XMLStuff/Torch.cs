using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Xml.Parser.Models
{
    [Serializable]
    public class Torch
    {

        [XmlElement("Transform")]
        public Transform Transform { get; set; }
    }
}
