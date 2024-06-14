using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using GerenciamentoClubesEsportivos.Models.Entities;
using GerenciamentoClubesEsportivos.Utils.Interfaces;


namespace GerenciamentoClubesEsportivos.Models.Services
{
    public static class XmlService
    {
        public static void SerializeToFile<T>(List<T> objectToSerialize, string filePath, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

            if (!fileName.Contains(".xml")) fileName += ".xml";

            var path = Path.Combine(filePath, fileName);

            using (StreamWriter sw = new StreamWriter(path))
            {
                serializer.Serialize(sw, objectToSerialize);
            }
        }

        public static List<T> DeserializeFromFile<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File {filePath} not found.");
                return null;
            }

            try
            {
                using (var stream = new FileStream(filePath, FileMode.Open))
                {
                    var serializer = new XmlSerializer(typeof(List<T>));
                    return (List<T>)serializer.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing file {filePath}: {ex.Message}");
                return null;
            }
        }
    }
}