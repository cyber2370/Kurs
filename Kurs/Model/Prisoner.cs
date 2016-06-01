namespace Kurs.Model
{
    /*    Класс Заключенный
        *    Содержит:
        *    Анкетные данные заключенных, статья, срок, дата заключения под стражу,
        *    место в тюремной иерархии, камера, сведения о родственниках, особенности характера. 
        **/


    /// <summary>
    /// Модель заключенного.
    /// </summary>
    public class Prisoner
    {
        public int Id { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        public ImprisonmentInfo ImprisonmentInfo { get; set; }


        public string FirstName => PersonalInfo.FirstName;
        public string SecondName => PersonalInfo.SecondName;
        public string MiddleName => PersonalInfo.MiddleName;
        public string Prison => ImprisonmentInfo.Prison.ToString();
    }
}