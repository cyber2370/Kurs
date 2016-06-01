using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Kurs.Model;

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
    [Serializable]
    public class Prisoner
    {
        [XmlAttribute]
        public int Id { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        public ImprisonmentInfo ImprisonmentInfo { get; set; }


        public string FirstName => PersonalInfo?.FirstName;
        public string SecondName => PersonalInfo?.SecondName;
        public string Prison => ImprisonmentInfo?.Prison.ToString();
    }
}