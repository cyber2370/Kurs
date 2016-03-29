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
    class Prisoner
    {
        string _name, _surname, _place, _relations, _article, _character;
        DateTime _imprisonment, _term;
        int _prisonCell, _ID;

        public Prisoner()
        {
            _name = _surname = _place = _relations = _article = _character = "";
            _prisonCell = _ID = 0;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public string Place { get { return _place; } set { _place = value; } }
        public string Relations { get { return _relations; } set { _relations = value; } }
        public string Article { get { return _article; } set { _article = value; } }
        public string Character { get { return _character; } set { _character = value; } }
        public int PrisonCell { get { return _prisonCell; } set { _prisonCell = value; } }
        public int ID { get { return _ID; } set { _ID = value; } }
    }
}
