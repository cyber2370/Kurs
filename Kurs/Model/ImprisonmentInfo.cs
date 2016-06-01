using System;

namespace Kurs.Model
{

    /// <summary>
    /// Действующие тюрьмы.
    /// </summary>
    public enum Prisons
    {
        Unknown = 0,
        Butyrskaya = 1,
        Crosses = 2,
        Lefortovo = 3,
        Sailor = 4,
        VladimirskyCentral = 5,
        WhiteSwan = 6
    }

    public class ImprisonmentInfo
    {
        public Prisons Prison { get; set; }
        public int PrisonCell { get; set; }
        public DateTime JailedDate { get; set; }
        public int JailingMonths { get; set; }
        public int ImprisonmentCount { get; set; }
    }
}
