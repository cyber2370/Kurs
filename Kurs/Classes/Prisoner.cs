using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Classes
{
    /*    Класс Заключенный
     *    Содержит:
     *    Анкетные данные заключенных, статья, срок, дата заключения под стражу,
     *    место в тюремной иерархии, камера, сведения о родственниках, особенности характера. 
     **/


    /// <summary>
    /// Действующие тюрьмы.
    /// </summary>
    public enum Prisons
    {
        БутырскаяТюрьма,
        Кресты,
        ЛефортовскаяТюрьма,
        МатросскаяТюрьма,
        BlackDolphin,
        ВладимирскийЦентрал,
        БелыйЛебедь
    }

    /// <summary>
    /// Модель заключенного.
    /// </summary>
    public class Prisoner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }
        public string СityOfBirth { get; set; }
        public Prisons Prison { get; set; }
        public int PrisonCell { get; set; }
        public bool Family { get; set; }
        public string AdditionalInfo { get; set; }
        public int ImprisonmentCount { get; set; }
    }
}