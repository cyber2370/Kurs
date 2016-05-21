using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Classes.Model
{


    /// <summary>
    /// Действующие тюрьмы.
    /// </summary>
    [Serializable]
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

    [Serializable]
    public class ImprisonmentInfo
    {
        public Prisons Prison { get; set; }
        public int PrisonCell { get; set; }
        public DateTime JailedDate { get; set; }
       // public DateTime FreedomDate { get; private set; }
        public double JailingYears { get; set; }
        public int ImprisonmentCount { get; set; }
        /*
        int years = Convert.ToInt32(value);
        int months = Convert.ToInt32((value - years)*12);
        int days = Convert.ToInt32(((value - years)*12 - months)*30);

        FreedomDate = JailedDate;
        FreedomDate = FreedomDate.AddYears(years);
        FreedomDate = FreedomDate.AddMonths(months);
        FreedomDate = FreedomDate.AddDays(days);
        */

    }
}
