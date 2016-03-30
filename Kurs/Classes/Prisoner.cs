﻿using System;
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
    public class Prisoner
    {
        string _name, _surname, _prison, _relations, _article, _character;
        int _prisonCell;

        public Prisoner()
        {
            _name = _surname = _prison = _relations = _article = _character = "";
            _prisonCell = 0;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public string Prison { get { return _prison; } set { _prison = value; } }
        public string Relations { get { return _relations; } set { _relations = value; } }
        public string Article { get { return _article; } set { _article = value; } }
        public string Character { get { return _character; } set { _character = value; } }
        public int PrisonCell { get { return _prisonCell; } set { _prisonCell = value; } }
    }
}
