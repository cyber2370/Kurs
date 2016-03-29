using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Kurs.Classes
{
    class DataBase
    {
        private static XmlDocument xDoc;
        private static XmlElement xRoot;
        private static string xPath;
        static DataBase()
        {
            xPath = "data/prisoners1.xml";
            xDoc = new XmlDocument();
            xDoc.Load(xPath);
            xRoot = xDoc.DocumentElement;

        }

        public static void deletePrisoner(int id)
        {
            XmlNode node = xRoot.SelectSingleNode("prisoner[@id='" + id.ToString() + "']");
            if (node != null)
                xRoot.RemoveChild(node);
            xDoc.Save(xPath);
        }


        public static void addPrisoner()
        {

            XmlElement prisonerElem = xDoc.CreateElement("prisoner");

            prisonerElem.Attributes.Append(xDoc.CreateAttribute("id")).AppendChild(xDoc.CreateTextNode("1"));
            xDoc.CreateElement("name").AppendChild(xDoc.CreateTextNode("name1"));
            xDoc.CreateElement("surname").AppendChild(xDoc.CreateTextNode("surname1"));
            xDoc.CreateElement("place").AppendChild(xDoc.CreateTextNode("prison1"));
            xDoc.CreateElement("relations").AppendChild(xDoc.CreateTextNode("Mom, Dad, Brother"));
            xDoc.CreateElement("article").AppendChild(xDoc.CreateTextNode("Criminal article1"));
            xDoc.CreateElement("character").AppendChild(xDoc.CreateTextNode("cute1"));

            xRoot.AppendChild(prisonerElem);
            xDoc.Save(xPath);
        }

        public static void readXML()
        {
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("id");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }
                // обходим все дочерние узлы элемента user
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // если узел - company
                    if (childnode.Name == "company")
                    {
                        Console.WriteLine("loh: {0}", childnode.InnerText);
                    }
                    // если узел age
                    if (childnode.Name == "age")
                    {
                        Console.WriteLine("pidr: {0}", childnode.InnerText);
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
