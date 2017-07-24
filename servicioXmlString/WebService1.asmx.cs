using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace servicioXmlString
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string xmlString()
        {
            return "<Persona rut = '1 - 9'>Jose<Direccion>mi casa</Direccion></Persona>";
        }

        [WebMethod]
        public XmlDocument xmlObjeto()
        {
            XmlDocument xml = new XmlDocument();
            XmlElement elemento = xml.CreateElement("Persona");
            elemento.SetAttribute("rut", "1-9");
            elemento.InnerText = "Jose";
            XmlNode nodo = xml.CreateElement("Direccion");
            nodo.InnerText = "mi casa";
            elemento.AppendChild(nodo);
            xml.AppendChild(elemento);
            return xml;           
        }
    }
}
