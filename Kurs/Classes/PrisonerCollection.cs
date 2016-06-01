
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Kurs.Model;

namespace Kurs.Classes
{
    /// <summary>
    /// Класс для работы со списком заключенными.
    /// </summary>
    public static class PrisonerCollection
    {

        public static bool IsChanged { get; set; }
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
            var newId = GetMaxPrisonerId();
            prisoner.Id = (newId != -1) ? (newId + 1) : 1;
            PrisonersList.Add(prisoner);
        }


        /// <summary>
        /// Метод замены заключенного. 
        /// </summary>
        /// <param name="id">ID заменяемого заключенного.</param>
        /// <param name="prisoner">Заключенный для замены.</param>
        public static void ReplacePrisoner(Prisoner prisoner)
        {
            var replaceThis = GetPrisonerById(prisoner.Id);
            PrisonersList[PrisonersList.IndexOf(replaceThis)] = prisoner;
        }


        /// <summary>
        /// Метод получения наибольшего идентификатора заключенного.
        /// </summary>
        /// <returns>Возвращает идентификатор последнего заключенного или -1 при отсутствии заключенных.</returns>
        private static int GetMaxPrisonerId()
        {
            return (PrisonersList.Count > 0) ? PrisonersList.Max(x => x.Id) : 0;
        }

        public static BindingList<Prisoner> Find(Prisoner prisoner)
        {
            var collection = new List<Prisoner>();
            foreach (var z in PrisonersList)
                collection.Add(z);

            var prisPersInfo = prisoner.PersonalInfo;
            var prisImprInfo = prisoner.ImprisonmentInfo;

            collection.RemoveAll(x =>
                !(x.PersonalInfo.FirstName.Contains(prisPersInfo.FirstName)
                && x.PersonalInfo.SecondName.Contains(prisPersInfo.SecondName)
                && x.PersonalInfo.MiddleName.Contains(prisPersInfo.MiddleName)
                && x.PersonalInfo.СityOfBirth.Contains(prisPersInfo.СityOfBirth)
              //&& (x.PersonalInfo.Birthday.Equals(prisPersInfo.Birthday))
                && (prisPersInfo.FamilyStatus.ToString() == "Неизвестно" 
                    || x.PersonalInfo.FamilyStatus.ToString().Contains(
                    prisPersInfo.FamilyStatus.ToString()))
              //&& x.ImprisonmentInfo.JailedDate.Equals(prisImprInfo.JailedDate)
                && (prisImprInfo.JailingMonths == 0 
                    || x.ImprisonmentInfo.JailingMonths.Equals(prisImprInfo.JailingMonths) 
                && (prisImprInfo.ImprisonmentCount == 0
                    || x.ImprisonmentInfo.ImprisonmentCount.Equals(prisImprInfo.ImprisonmentCount))
                && (prisImprInfo.Prison.ToString() == "Неизвестно"
                    || x.ImprisonmentInfo.Prison.ToString().Equals(prisImprInfo.Prison.ToString()))
                && (prisImprInfo.Prison.ToString() == "Неизвестно"
                    || x.ImprisonmentInfo.PrisonCell.Equals(prisImprInfo.ImprisonmentCount)))));

            var res = new BindingList<Prisoner>();
            foreach (var z in collection)
                res.Add(z);
            return res;
        }

        /// <summary>
        /// Записывает изменения в файл. 
        /// </summary>
        public static void Save()
        {
            XmlSerializator.SaveToFile(PrisonersList);
        }


        /// <summary>
        /// Заполняет коллекцию из файла.
        /// </summary>
        public static void LoadCollection()
        {
            var col = XmlSerializator.GetCollectionFromFile();
            PrisonersList = col ?? new BindingList<Prisoner>();
        }
    }
}
