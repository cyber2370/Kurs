using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Model
{


    /// <summary>
    /// Действующие тюрьмы.
    /// </summary>
    [Serializable]
    public enum Prisons
    {
        Неизвестно = 0,
        БутырскаяТюрьма = 1,
        Кресты = 2,
        ЛефортовскаяТюрьма = 3,
        МатросскаяТюрьма = 4,
        ВладимирскийЦентрал = 5,
        БелыйЛебедь = 6
    }

    [Serializable]
    public class ImprisonmentInfo
    {
        public Prisons Prison { get; set; }
        public int PrisonCell { get; set; }
        public DateTime JailedDate { get; set; }
        public int JailingMonths { get; set; }
        public int ImprisonmentCount { get; set; }
    }
}
