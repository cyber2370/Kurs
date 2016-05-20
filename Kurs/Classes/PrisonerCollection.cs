
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Kurs.Classes
{
    /// <summary>
    /// Класс для работы со списком заключенными.
    /// </summary>
    public static class PrisonerCollection
    {
        public static List<Prisoner> PrisonersList { get; private set; }


        /// <summary>
        /// Конструктор статического класса PrisonerCollection.
        /// </summary>
        static PrisonerCollection()
        {
            PrisonersList = new List<Prisoner>();

            //заполнение списка заключенных
            LoadCollection();
        }


        /// <summary>
        /// Метод поиска объекта Prisoner по полю Id.
        /// </summary>
        /// <param name="id">Идентификатор заключенного. Должен существовать заключенный с таким Id.</param>
        /// <returns></returns>
        public static Prisoner GetPrisonerById(int id)
        {
            var pris = PrisonersList.SingleOrDefault(x => x.Id == id);
            if(pris == null) 
                throw new NullReferenceException($"Неверный идентификатор {id}");
            return pris;
        }


        /// <summary>
        /// Метод получения наибольшего идентификатора заключенного.
        /// </summary>
        /// <returns>Возвращает идентификатор последнего заключенного или -1 при отсутствии заключенных.</returns>
        private static int GetLastPrisonerId()
        {
            //return id of last prisoner or -1, if PrisonerList is empty
            return PrisonersList.LastOrDefault()?.Id ?? -1;
        }


        /// <summary>
        /// Метод удаления заключенного по полю id.
        /// </summary>
        /// <param name="id">Идентификатор заключенного</param>
        public static void RemovePrisoner(int id)
        {
            PrisonersList.Remove(GetPrisonerById(id));
        }

        /// <summary>
        /// Метод добавления нового заключенного в коллекцию.
        /// </summary>
        /// <param name="prisoner"></param>
        public static void AddPrisoner(Prisoner prisoner)
        {
            var newId = GetLastPrisonerId();
            prisoner.Id = newId != -1 ? newId : 1;
            PrisonersList.Add(prisoner);
        }


        /// <summary>
        /// Метод замены заключенного. 
        /// Заменяет заключенного с идентификатором, совпадающим с идентификатором принимаемого заключенного.
        /// </summary>
        /// <param name="prisoner">Id должно содержать существующее значение!</param>
        public static void ReplacePrisoner(Prisoner prisoner)
        {
            var replaceThis = GetPrisonerById(prisoner.Id);
            PrisonersList.Insert(PrisonersList.IndexOf(replaceThis), prisoner);
            PrisonersList.Remove(replaceThis);
        }


        /// <summary>
        /// Записывает изменения в файл. 
        /// </summary>
        public static void Save()
        {
            InOutXml.SaveToFile(PrisonersList);
        }


        /// <summary>
        /// Заполняет коллекцию из файла.
        /// </summary>
        public static void LoadCollection()
        {
            PrisonersList = InOutXml.GetCollectionFromFile();
        }

        private static Prisoner GetPrisonerTest()
        {
            return new Prisoner()
            {
                Id = 1,
                FirstName = "Kolya",
                SecondName = "Tevoxin",
                MiddleName = "Nikolaevich",
                Prison = Prisons.BlackDolphin,
                ImprisonmentCount = 4,
                PrisonCell = 453,
                Family = false,
                СityOfBirth = "Kharkov",
                AdditionalInfo = "Smth additional info"  
            };
        }

    }
}
