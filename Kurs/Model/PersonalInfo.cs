using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Model
{
    [Serializable]
    public enum FamilyStatus
    {
        Неизвестно = 0,
        Женат = 1,
        НеЖенат = 2,
        Разведен = 3
    }

    [Serializable]
    public class PersonalInfo
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }
        public string СityOfBirth { get; set; }
        public FamilyStatus FamilyStatus { get; set; }
    }
}
