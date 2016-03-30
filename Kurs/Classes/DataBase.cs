using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kurs.Classes
{
    static class DataBase
    {
        public static string xPath = "data/prisoners2.xml";
        public static XDocument xDoc;

        static DataBase()
        {
            xDoc = XDocument.Load(xPath);
        }

        public static void deletePrisoner(string id)
        {
            xDoc.Element("prisoners").Elements("prisoner").Single(i => i.Attribute("id").Value == id).Remove();
            xDoc.Save(xPath);
        }

        public static Prisoner getPrisoner(string id)
        {
            Prisoner pris = new Prisoner();
            XElement elem = xDoc.Element("prisoners").Elements("prisoner").Single(i => i.FirstAttribute.Value == id);
            pris.Name = elem.Element("name").Value;
            pris.Surname = elem.Element("surname").Value;
            pris.Prison = elem.Element("prison").Value;
            pris.PrisonCell = Convert.ToInt32(elem.Element("prisoncell").Value);
            pris.Relations = elem.Element("relations").Value;
            pris.Article = elem.Element("article").Value;
            pris.Character = elem.Element("character").Value;
            return pris;
        }

        public static void addPrisoner(Prisoner prisoner)
        {
            XElement xtmp = new XElement("prisoner",
                new XAttribute("id", (Convert.ToInt32(xDoc.Root.Elements().Last().Attribute("id").Value) + 1).ToString()),
                new XElement("name", prisoner.Name),
                new XElement("surname", prisoner.Surname),
                new XElement("prison", prisoner.Prison),
                new XElement("relations", prisoner.Relations),
                new XElement("article", prisoner.Article),
                new XElement("character", prisoner.Character));
            xDoc.Root.Add(xtmp);
            xDoc.Save(xPath);
        }

        public static void fillDGV(ref DataGridView DGV)
        {
            DGV.RowCount = 0;
            foreach (XElement phoneElement in xDoc.Element("prisoners").Elements("prisoner"))
                DGV.Rows.Add(phoneElement.Attribute("id").Value, 
                    phoneElement.Element("name").Value,
                    phoneElement.Element("surname").Value, 
                    phoneElement.Element("article").Value);
        }
        
    }
}


//public static Dictionary<string, string> dict;
//dict = new Dictionary<string, string>();
//dict.Add("id", "ID");
//dict.Add("name", "Имя");
//dict.Add("surname", "Фамилия");
//dict.Add("place", "Место в иерархии");
//dict.Add("relations", "Семейные отношения");
//dict.Add("article", "Статья");
//dict.Add("character", "Особенности характера");