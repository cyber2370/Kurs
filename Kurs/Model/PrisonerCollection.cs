using System;
using System.ComponentModel;
using System.Linq;

namespace Kurs.Model
{
    /// <summary>
    /// Класс для работы со списком заключенными.
    /// </summary>
    public static class PrisonerCollection
    {

        public static bool IsChanged { get; private set; }
        public static BindingList<Prisoner> PrisonersList { get; private set; }


        /// <summary>
        /// Конструктор статического класса PrisonerCollection.
        /// </summary>
        static PrisonerCollection()
        {
            PrisonersList = new BindingList<Prisoner>();
            IsChanged = false;
            LoadCollection();
        }


        /// <summary>
        /// Метод поиска объекта Prisoner по полю Id.
        /// </summary>
        /// <param name="id">Идентификатор заключенного.
        /// Должен существовать заключенный с таким ID.</param>
        /// <returns></returns>
        public static Prisoner GetPrisonerById(int id)
        {
            var pris = PrisonersList.SingleOrDefault(x => x.Id == id);
            if (pris == null)
                throw new NullReferenceException("Неверный идентификатор {id}");
            return pris;
        }


        /// <summary>
        /// Метод удаления заключенного по полю id.
        /// </summary>
        /// <param name="id">Идентификатор заключенного</param>
        public static void RemovePrisoner(int id)
        {
            PrisonersList.Remove(GetPrisonerById(id));
            IsChanged = true;
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
            IsChanged = true;
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
            IsChanged = true;
        }


        /// <summary>
        /// Удаляет всех заключенных.
        /// </summary>
        public static void DeleteAllPrisoners()
        {
            PrisonersList = new BindingList<Prisoner>();
            IsChanged = true;
        }


        /// <summary>
        /// Метод получения наибольшего идентификатора заключенного.
        /// </summary>
        /// <returns>Возвращает идентификатор последнего заключенного 
        /// или -1 при отсутствии заключенных.</returns>
        private static int GetMaxPrisonerId()
        {
            return (PrisonersList.Count > 0)
                ? PrisonersList.Max(x => x.Id) : 0;
        }

        /// <summary>
        /// Метод поиска по разным критериям. 
        /// Фильтрует основную коллекцию по заполненным критериям в модели.
        /// 
        /// </summary>
        /// <param name="prisoner"></param>
        /// <returns></returns>
        public static BindingList<Prisoner> Find(Prisoner prisoner)
        {

            var prisPersInfo = prisoner.PersonalInfo;
            var prisImprInfo = prisoner.ImprisonmentInfo;

            var collection = PrisonersList.Where(x =>
                x.PersonalInfo.FirstName.Contains(prisPersInfo.FirstName)
                && x.PersonalInfo.SecondName.Contains(prisPersInfo.SecondName)
                && x.PersonalInfo.MiddleName.Contains(prisPersInfo.MiddleName)
                && x.PersonalInfo.СityOfBirth.Contains(prisPersInfo.СityOfBirth)

                && (prisPersInfo.Birthday == new DateTime(1800, 1, 1)
                    || x.PersonalInfo.Birthday.Equals(prisPersInfo.Birthday))

                && (prisPersInfo.FamilyStatus == FamilyStatus.Unknown
                    || x.PersonalInfo.FamilyStatus == prisPersInfo.FamilyStatus)

                && (prisImprInfo.JailedDate == new DateTime(1800, 1, 1)
                    || x.ImprisonmentInfo.JailedDate
                            .Equals(prisImprInfo.JailedDate))

                && (prisImprInfo.JailingMonths == 0
                    || x.ImprisonmentInfo.JailingMonths ==
                            prisImprInfo.JailingMonths)

                && (prisImprInfo.ImprisonmentCount == 0
                    || x.ImprisonmentInfo.ImprisonmentCount ==
                            prisImprInfo.ImprisonmentCount)

                && (prisImprInfo.Prison == Prisons.Unknown
                    || x.ImprisonmentInfo.Prison == prisImprInfo.Prison)

                && (prisImprInfo.PrisonCell == 0
                    || x.ImprisonmentInfo.PrisonCell
                                == prisImprInfo.PrisonCell));

            var list = new BindingList<Prisoner>();
            foreach (var z in collection)
                list.Add(z);
            return list;
        }


        /// <summary>
        /// Записывает изменения в файл. 
        /// </summary>
        public static void Save()
        {
            XmlSerializator.SaveToFile(PrisonersList);
            IsChanged = false;
        }


        /// <summary>
        /// Заполняет коллекцию из файла.
        /// </summary>
        public static void LoadCollection()
        {
            var col = XmlSerializator.GetCollectionFromFile();
            PrisonersList = col ?? new BindingList<Prisoner>();
            IsChanged = false;
        }


        /// <summary>
        /// Метод приводит строку к типу перечисления.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T ConvertToEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
