using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using xmlConsumerString.AiepEjemploXml;

namespace xmlConsumerString
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService1 ws = new WebService1();
            string result = ws.xmlString();

            XmlNode xml = ws.xmlObjeto();

            var xmlResult = xml.OuterXml.ToString();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlResult);
            XmlNodeList persona = xmlDoc.GetElementsByTagName("Persona");

            foreach(XmlElement x in persona)
            {
                XmlNode valor = x;
            }

            Console.ReadLine();
        }
    }
}
