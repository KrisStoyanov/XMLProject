using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Xml.Parser.Models
{
    [Serializable]
    [XmlRoot("Transform")]
    public class Transform
    {
        [XmlElement("position")]
        public string Position { get; set; }

        [XmlElement("rotation")]
        public string Rotation { get; set; }

        [XmlElement("scale")]
        public string Scale { get; set; }

        public float getPositionCoordinate(string coordinate)
        {
            float attributeResult = 0;

            if (coordinate.Equals(Constants.X))
            {
                attributeResult = (float)Convert.ToDecimal(Position.Trim().Split(' ')[0]);
            } else if (coordinate.Equals(Constants.Y))
            {
                attributeResult = (float)Convert.ToDecimal(Position.Trim().Split(' ')[1]);
            }
            else if (coordinate.Equals(Constants.Z))
            {
                attributeResult = (float)Convert.ToDecimal(Position.Trim().Split(' ')[2]);
            }

            return attributeResult;
        }

        public float getRotationCoordinate(string coordinate)
        {
            float attributeResult = 0;

            if (coordinate.Equals(Constants.X))
            {
                attributeResult = (float)Convert.ToDecimal(Rotation.Trim().Split(' ')[0]);
            }
            else if (coordinate.Equals(Constants.Y))
            {
                attributeResult = (float)Convert.ToDecimal(Rotation.Trim().Split(' ')[1]);
            }
            else if (coordinate.Equals(Constants.Z))
            {
                attributeResult = (float)Convert.ToDecimal(Rotation.Trim().Split(' ')[2]);
            }

            return attributeResult;
        }

        public float getScaleCoordinate(string coordinate)
        {
            float attributeResult = 0;
            if (coordinate.Equals(Constants.X))
            {
                attributeResult = (float)Convert.ToDecimal(Scale.Trim().Split(' ')[0]);

            }
            else if (coordinate.Equals(Constants.Y))
            {
                attributeResult = (float)Convert.ToDecimal(Scale.Trim().Split(' ')[1]);
            }
            else if (coordinate.Equals(Constants.Z))
            {
                attributeResult = (float)Convert.ToDecimal(Scale.Trim().Split(' ')[2]);
            }

            return attributeResult;
        }
    }
}
