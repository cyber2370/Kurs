using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Classes.Model
{
    [Serializable]
    public enum FamilyStatus
    {
        Married,
        NotMarried,
        Divorced
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
