using System;

namespace Addition_task
{
    class Dictionary
    {
        string[] _rus = new string[5];
        string[] _eng = new string[5];
        string[] _ua = new string[5];

        public Dictionary()
        {
            _rus[0] = "книга"; 
            _rus[1] = "ручка"; 
            _rus[2] = "солнце"; 
            _rus[3] = "яблоко"; 
            _rus[4] = "стол";
            _eng[0] = "book";
            _eng[1] = "pen";
            _eng[2] = "sun";
            _eng[3] = "apple";
            _eng[4] = "table";
            _ua[0] = _rus[0];
            _ua[1] = _rus[1];
            _ua[2] = "сонце";
            _ua[3] = "яблуко";
            _ua[4] = "стiл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < _rus.Length; i++)
                    if (_rus[i] == index)
                        return _rus[i] + " - " + _eng[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _rus.Length)
                    return _rus[index] + " - " + _eng[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
