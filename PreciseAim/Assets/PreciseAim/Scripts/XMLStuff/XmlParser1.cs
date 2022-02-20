
using System.IO;
using System.Xml.Serialization;
using Xml.Parser.Models;
namespace Xml.Parser
{
    public class XmlParser
    {
        /// <summary>
        /// Deserializes the whole xml file to object
        /// </summary>
        /// <param name="filePath">xml file path</param>
        /// <returns></returns>
        public static GameElements Deserialize(string filePath)
        {
            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = Constants.Root;
            root.IsNullable = true;

            var serializer = new XmlSerializer(typeof(GameElements), root);

            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            var gameElements = (GameElements)serializer.Deserialize(fileStream);
            return gameElements;
        }
        
    }
}
