
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using Kurs.Classes.Model;

namespace Kurs.Classes
{
    /// <summary>
    /// Класс для работы с файлом XML.
    /// </summary>
    public static class InOutXml
    {
        private static string _filePath = @"prisoners_test3.xml";
        static readonly XmlSerializer Formatter = new XmlSerializer(typeof(BindingList<Prisoner>));

        /// <summary>
        /// Метод сохранения коллекции заключенных в файл.
        /// </summary>
        public static void SaveToFile(BindingList<Prisoner> list)
        {
            using (var fs = new FileStream(_filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                Formatter.Serialize(fs, list);
            }
        }

        /// <summary>
        ///  Метод создания коллекции заключенных из файла.
        /// </summary>
        /// <returns>Возвращает список заключенных.</returns>
        public static BindingList<Prisoner> GetCollectionFromFile()
        {
            using (var fs = new FileStream(_filePath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                var list = (BindingList<Prisoner>) Formatter.Deserialize(fs);
                return list;
            }
        }
    }
}
