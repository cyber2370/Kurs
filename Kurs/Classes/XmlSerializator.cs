
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using Kurs.Model;

namespace Kurs.Classes
{
    /// <summary>
    /// Класс для работы с файлом XML.
    /// </summary>
    public static class XmlSerializator
    {
        //Путь к Xml-документу.
        private static string _filePath = @"database.xml";

        //Объявление Xml-документа.
        private static XDocument _doc;

        //Корневой элемент Xml-документа.
        private static XElement _root;


        /// <summary>
        /// Статический конструктор без параметров.
        /// Создание или подключение документа.
        /// </summary>
        static XmlSerializator()
        {
            if (File.Exists(_filePath))
            {
                _doc = XDocument.Load(_filePath);
                if (!_doc.Elements().Any())
                {
                    _doc = new XDocument(new XElement("Prisoners"));
                    _doc.Save(_filePath);
                }
            }
            else
            {
                _doc = new XDocument(new XElement("Prisoners"));
            }
            _root = _doc.Element("Prisoners");
        }

        /// <summary>
        /// Метод сохранения коллекции заключенных в файл.
        /// </summary>
        /// 
        public static void SaveToFile(BindingList<Prisoner> list)
        {
            _root.RemoveAll();
            foreach (var elem in list)
                _root.Add(SerializePrisoner(elem));
            _doc.Save(_filePath);
        }

        /// <summary>
        ///  Метод создания коллекции заключенных
        ///  с помощью чтения из файла.
        /// </summary>
        /// <returns>Возвращает список компаний.</returns>
        public static BindingList<Prisoner> GetCollectionFromFile()
        {
            var list = new BindingList<Prisoner>();
            foreach (var xElem in _root.Elements())
            {
                var elem = DeserializePrisoner(xElem);
                if (elem != null)
                    list.Add(elem);
            }
            return list;
        }


        /// <summary>
        /// Метод создает объект заключенного (Prisoner) из представления XML-объекта.
        /// </summary>
        /// <param name="pris"></param>
        /// <returns></returns>
        private static XElement SerializePrisoner(Prisoner pris)
        {
            var persInfo = new XElement("PersonalInfo",
                                new XElement("FirstName", pris.PersonalInfo.FirstName),
                                new XElement("SecondName", pris.PersonalInfo.SecondName),
                                new XElement("MiddleName", pris.PersonalInfo.MiddleName),
                                new XElement("Birthday", pris.PersonalInfo.Birthday),
                                new XElement("СityOfBirth", pris.PersonalInfo.СityOfBirth),
                                new XElement("FamilyStatus", pris.PersonalInfo.FamilyStatus));

            var imprInfo = new XElement("ImprisonmentInfo",
                new XElement("JailedDate", pris.ImprisonmentInfo.JailedDate),
                new XElement("ImprisonmentCount", pris.ImprisonmentInfo.ImprisonmentCount),
                new XElement("JailingMonths", pris.ImprisonmentInfo.JailingMonths),
                new XElement("Prison", pris.ImprisonmentInfo.Prison),
                new XElement("PrisonCell", pris.ImprisonmentInfo.PrisonCell));

            return new XElement("Prisoner", 
                                new XAttribute("Id", pris.Id), 
                                persInfo, 
                                imprInfo);
        }


        /// <summary>
        /// Метод создает объект XML заключенного (XML) из Prisoner.
        /// </summary>
        /// <param name="pris"></param>
        /// <returns></returns>
        private static Prisoner DeserializePrisoner(XElement xPris)
        {
            var xPersInfo = xPris.Element("PersonalInfo");
            var persInfo = new PersonalInfo()
            {
                FirstName = xPersInfo.Element("FirstName").Value,
                SecondName = xPersInfo.Element("SecondName").Value,
                MiddleName = xPersInfo.Element("MiddleName").Value,
                FamilyStatus = ConvertToEnum<FamilyStatus>(xPersInfo.Element("FamilyStatus").Value),
                Birthday = Convert.ToDateTime(xPersInfo.Element("Birthday").Value),
                СityOfBirth = xPersInfo.Element("СityOfBirth").Value
            };


            var xImprInfo = xPris.Element("ImprisonmentInfo");
            var imprInfo = new ImprisonmentInfo()
            {
                JailedDate = Convert.ToDateTime(xImprInfo.Element("JailedDate").Value),
                JailingMonths = Convert.ToInt32(xImprInfo.Element("JailingMonths").Value),
                PrisonCell = Convert.ToInt32(xImprInfo.Element("PrisonCell").Value),
                ImprisonmentCount = Convert.ToInt32(xImprInfo.Element("ImprisonmentCount").Value),
                Prison = ConvertToEnum<Prisons>(xImprInfo.Element("Prison").Value)
            };

            return new Prisoner()
            {
                Id = Convert.ToInt32(xPris.FirstAttribute.Value),
                ImprisonmentInfo = imprInfo,
                PersonalInfo = persInfo
            };
        }


        /// <summary>
        /// Метод приводит строку к типу перечисления.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        private static T ConvertToEnum<T>(string value)
        {
            return (T) Enum.Parse(typeof(T), value, true);
        }

}
}
