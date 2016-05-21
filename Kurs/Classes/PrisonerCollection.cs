
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using Kurs.Classes.Model;

namespace Kurs.Classes
{
    /// <summary>
    /// Класс для работы со списком заключенными.
    /// </summary>
    public static class PrisonerCollection
    {
        public static BindingList<Prisoner> PrisonersList { get; private set; }


        /// <summary>
        /// Конструктор статического класса PrisonerCollection.
        /// </summary>
        static PrisonerCollection()
        {
            PrisonersList = new BindingList<Prisoner>();

                LoadCollection();
        }


        /// <summary>
        /// Метод поиска объекта Prisoner по полю Id.
        /// </summary>
        /// <param name="id">Идентификатор заключенного. Должен существовать заключенный с таким ID.</param>
        /// <returns></returns>
        public static Prisoner GetPrisonerById(int id)
        {
            var pris = PrisonersList.SingleOrDefault(x => x.Id == id);
            if(pris == null) 
                throw new NullReferenceException($"Неверный идентификатор {id}");
            return pris;
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
            prisoner.Id = newId != -1 ? newId + 1 : 1;
            PrisonersList.Add(prisoner);
        }


        /// <summary>
        /// Метод замены заключенного. 
        /// </summary>
        /// <param name="id">ID заменяемого заключенного.</param>
        /// <param name="prisoner">Заключенный для замены.</param>
        public static void ReplacePrisoner(int id, Prisoner prisoner)
        {
            var replaceThis = GetPrisonerById(id);
            PrisonersList[PrisonersList.IndexOf(replaceThis)] = prisoner;
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


        private static void FillXmlFile()
        {
            var list = new BindingList<Prisoner>();
            for (var i = 0; i < 100; i++)
            {
                var persInf = new PersonalInfo()
                {
                    FirstName = "Имя " + i,
                    SecondName = "Фамилия" + i,
                    MiddleName = "Отчество " + i,
                    Birthday = new DateTime(1978, 06, 13),
                    FamilyStatus = FamilyStatus.Married,
                    СityOfBirth = "Kiev"
                };
                var imprisonInf = new ImprisonmentInfo()
                {
                    Prison = Prisons.BlackDolphin,
                    PrisonCell = 511,
                    ImprisonmentCount = 123,
                    JailingYears = 13,
                    JailedDate = new DateTime(1994, 03, 13)
                };

                list.Add(new Prisoner()
                {
                    Id = i,
                    ImprisonmentInfo = imprisonInf,
                    PersonalInfo = persInf
                });
            }
            InOutXml.SaveToFile(list);
        }
    }
}
