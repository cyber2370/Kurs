using Kurs.Model;

namespace Kurs.Views
{
    static class FormHelper
    {
        public static FamilyStatus GetFamilyValueByIndex(int index)
        {
            string str;
            switch (index)
            {

                case 1:
                    str = "Married";
                    break;
                case 2:
                    str = "NotMarried";
                    break;
                case 3:
                    str = "Divorced";
                    break;
                default:
                    str = "Unknown";
                    break;
            }
            return PrisonerCollection.ConvertToEnum<FamilyStatus>(str);
        }

        public static int GetFamilyIndexByValue(string value)
        {
            switch (value)
            {
                case "Married":
                    return 1;
                case "NotMarried":
                    return 2;
                case "Divorced":
                    return 3;
                default:
                    return 0;
            }
        }

        public static Prisons GetPrisonValueByIndex(int index)
        {
            string str;
            switch (index)
            {
                case 1:
                    str = "Butyrskaya";
                    break;
                case 2:
                    str = "Crosses";
                    break;
                case 3:
                    str = "Lefortovo";
                    break;
                case 4:
                    str = "Sailor";
                    break;
                case 5:
                    str = "VladimirskyCentral";
                    break;
                case 6:
                    str = "WhiteSwan";
                    break;
                default:
                    str = "Unknown";
                    break;
            }
            return PrisonerCollection.ConvertToEnum<Prisons>(str);

        }

        public static int GetPrisonIndexByValue(string value)
        {
            switch (value)
            {
                case "Butyrskaya":
                    return 1;
                case "Crosses":
                    return 2;
                case "Lefortovo":
                    return 3;
                case "Sailor":
                    return 4;
                case "VladimirskyCentral":
                    return 5;
                case "WhiteSwan":
                    return 6;
                default:
                    return 0;
            }
        }
    }
}
