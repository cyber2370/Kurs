using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Kurs.Classes
{
    static class DataBase
    {
        private static XmlDocument xDoc;
        private static XmlElement xRoot;
        public static string xPath = "data/prisoners2.xml";
        public static Dictionary<string, string> dict;
        
        static DataBase()
        {
            dict = new Dictionary<string, string>();
            dict.Add("id", "ID");
            dict.Add("name", "Имя");
            dict.Add("surname", "Фамилия");
            dict.Add("place", "Место в иерархии");
            dict.Add("relations", "Семейные отношения");
            dict.Add("article", "Статья");
            dict.Add("character", "Особенности характера");
        }

        public static void deletePrisoner(int id)
        {
            xDoc = new XmlDocument();
            xDoc.Load(xPath);
            xRoot = xDoc.DocumentElement;

            XmlNode node = xRoot.SelectSingleNode("prisoner[@id='" + id.ToString() + "']");
            if (node != null)
                xRoot.RemoveChild(node);
            xDoc.Save(xPath);
        }

        public static void addPrisoner(Prisoner prisoner)
        {
            XDocument xDoc = XDocument.Load(xPath);
            XElement xtmp = new XElement("prisoner",
                new XAttribute("id", (Convert.ToInt32(xDoc.Root.Elements().Last().Attribute("id").Value) + 1).ToString()),
                new XElement("name", prisoner.Name),
                new XElement("surname", prisoner.Surname),
                new XElement("prison", prisoner.Place),
                new XElement("relations", prisoner.Relations),
                new XElement("article", prisoner.Article),
                new XElement("character", prisoner.Character));
            xDoc.Root.Add(xtmp);
            xDoc.Save(xPath);
        }

        public static void fillDGV(ref DataGridView DGV)
        {
            DGV.RowCount = 0;
            XDocument xdoc = XDocument.Load(xPath);
            foreach (XElement phoneElement in xdoc.Element("prisoners").Elements("prisoner"))
            {
                DGV.Rows.Add(phoneElement.Attribute("id").Value, phoneElement.Element("name").Value,
                    phoneElement.Element("surname").Value, phoneElement.Element("article").Value);
            }
        }

        public static void printXML(ref RichTextBox rtb)
        {
            XDocument xdoc = XDocument.Load(xPath);
            rtb.Text = "";
            foreach (XElement phoneElement in xdoc.Element("prisoners").Elements("prisoner"))
            {
                string str = "";
                str += dict[phoneElement.FirstAttribute.Name.ToString()] + ": " + phoneElement.FirstAttribute.Value + ";\n";
                foreach (XElement elements in phoneElement.Elements())
                    str += dict[elements.Name.ToString()] + ": " + elements.Value + ";\n";
                rtb.Text += str + "\n";
            }
        } 
    }
}





/*
public static void readXML(ref RichTextBox rtb)
{
   XDocument xdoc = XDocument.Load("data/prisoners2.xml");
    var items = from xe in xdoc.Element("prisoners").Elements("prisoner")
                where xe.Element("surname").Value == "Xela"
                select new Prisoner
                {
                    Name = xe.Attribute("name").Value,
                    Surname = xe.Element("surname").Value,
                    Place = xe.Attribute("place").Value,
                    Relations = xe.Element("relations").Value,
                    Article = xe.Attribute("article").Value,
                    Character = xe.Element("character").Value,
                    ID = Convert.ToInt32(xe.Attribute("name").Value)
                }

    foreach (var item in items)
        rtb.Text += item.Name + "-" + item.Surname;


    xDoc = new XmlDocument();
    xDoc.Load(xPath);
    MessageBox.Show(xPath);
    xRoot = xDoc.DocumentElement;

    foreach (XmlNode xnode in xRoot)
    {
        if (xnode.Attributes.Count > 0)
        {
            XmlNode attr = xnode.Attributes.GetNamedItem("id");
            if (attr != null)
                Console.WriteLine(attr.Value);
        }
        foreach (XmlNode childnode in xnode.ChildNodes)
        {
            switch (childnode.Name)
            {
                case ("name"):
                    {
                        rtb.Text += "Name: " + childnode.InnerText;
                        break;
                    }
                case ("surname"):
                    {
                        rtb.Text += "Surname: " + childnode.InnerText;
                        break;
                    }
                case ("place"):
                    {
                        rtb.Text += "Prison: " + childnode.InnerText;
                        break;
                    }
                case ("relations"):
                    {
                        rtb.Text += "Relations: " + childnode.InnerText;
                        break;
                    }
                case ("article"):
                    {
                        rtb.Text += "Article: " + childnode.InnerText;
                        break;
                    }
                case ("character"):
                    {
                        rtb.Text += "Character: " + childnode.InnerText;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            rtb.Text += "\n";
        }
        rtb.Text += "\n";
    }
}*/
