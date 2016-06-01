using System;

namespace Kurs.Model
{
    public enum FamilyStatus
    {
        Unknown = 0,
        Married = 1,
        NotMarried = 2,
        Divorced = 3
    }

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
