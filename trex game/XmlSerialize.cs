using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace trex_game
{
    public static class XmlSerialize
    {
        public static void SaveObjects<T>(List<T> list, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                serializer.Serialize(writer, list);
            }
        }

        public static List<T> ConvertXmlToObjects<T>(string fileName)
        {
            if (!File.Exists(fileName))
                return new List<T>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                return (List<T>)serializer.Deserialize(reader);
            }
        }
    }
}
