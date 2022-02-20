using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Xml.Parser.Models
{
    [XmlRoot("GameElements")]
    public class GameElements
    {
        [XmlArray("Torches")]
        public Torch[] Torches;

        [XmlArray("Balloons")]
        public Balloon[] Balloons;

        [XmlArray("Arrows")]
        public Arrow[] Arrows;

        [XmlArray("HealthPotions")]
        public HealthPotion[] HealthPotions;

        [XmlAttribute("ArrowsCount")]
        public uint ArrowsCount;
    }
}
