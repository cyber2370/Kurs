
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Kurs.Classes
{
    /// <summary>
    /// Класс для работы с файлом XML.
    /// </summary>
    public static class InOutXml
    {
        private static string _filePath = @"prisoners_test2.xml";
        private static XDocument XDoc = !File.Exists(_filePath) ? XDocument.Load(File.Create(_filePath)) : XDocument.Load(_filePath);
        private static XElement Root;

        static InOutXml()
        {
            Root = XDoc.Element("prisoners");
        }


        /// <summary>
        /// Метод сохранения коллекции заключенных в файл.
        /// </summary>
        public static void SaveToFile(List<Prisoner> list)
        {
            foreach (var el in list)
            {
                Root.Add(GetXElementFromPrisoner(el));
            }
            XDoc.Save(_filePath);
        }


        /// <summary>
        ///  Метод создания коллекции заключенных из файла.
        /// </summary>
        /// <returns>Возвращает список заключенных.</returns>
        public static List<Prisoner> GetCollectionFromFile()
        {
            var list = new List<Prisoner>();

            foreach (var elem in Root.Elements())
                list.Add(GetPrisonerFromXElement(elem));

            return list;
        }

        private static XElement GetXElementFromPrisoner(Prisoner prisoner)
        {
            return new XElement("Prisoner",
                    new XAttribute("Id", prisoner.Id),
                    new XElement("FirstName", prisoner.FirstName),
                    new XElement("SecondName", prisoner.SecondName),
                    new XElement("MiddleName", prisoner.MiddleName),
                    new XElement("Family", prisoner.Family),
                    new XElement("Prison", prisoner.Prison),
                    new XElement("PrisonCell", prisoner.PrisonCell),
                    new XElement("Information", prisoner.AdditionalInfo),
                    new XElement("ImprisonmentCount", prisoner.ImprisonmentCount),
                    new XElement("BirthCity", prisoner.СityOfBirth));
        }

        private static Prisoner GetPrisonerFromXElement(XElement xPrisoner)
        {
            return new Prisoner()
                {
                    Id = Convert.ToInt32(xPrisoner.FirstAttribute.Value),
                    FirstName = xPrisoner.Element("FirstName")?.Value ?? "emptyFirstName",
                    SecondName = xPrisoner.Element("SecondName")?.Value ?? "emptySecondName",
                    MiddleName = xPrisoner.Element("MiddleName")?.Value ?? "emptyMiddleName",
                    Prison = (Prisons)Enum.Parse(typeof(Prisons), xPrisoner.Element("Prison")?.Value ?? "empty", true),
                    PrisonCell = Convert.ToInt32(xPrisoner.Element("Prisoncell")?.Value ?? "0"),
                    Family = Convert.ToBoolean(xPrisoner.Element("Family")?.Value ?? "false"),
                    AdditionalInfo = xPrisoner.Element("AdditionalInfo")?.Value ?? "emptyInfo",
                    ImprisonmentCount = Convert.ToInt32(xPrisoner.Element("ImprisonmentCount")?.Value ?? "0"),
                    СityOfBirth = xPrisoner.Element("BirthCity")?.Value ?? "emptyBirthCity"
            };
        }
    }
}
