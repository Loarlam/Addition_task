using System;

namespace Addition_task
{
    class Dictionary
    {
        string[] _rus = new string[3];
        string[] _eng = new string[3];
        string[] _ua = new string[3];

        public Dictionary(params string[] arrayLine)
        {
            _rus = arrayLine[0..3];
            _eng = arrayLine[3..6];
            _ua = arrayLine[6..9];
        }

        public string this[string index]
        {
            get
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 0; i < 3; i++)
                {
                    if (_rus[i] == index)
                        return _rus[i] + " - " + _eng[i] + " - " + _ua[i];
                    else if (_eng[i] == index)
                        return _eng[i] + " - " + _rus[i] + " - " + _ua[i];
                    else if (_ua[i] == index)
                        return _ua[i] + " - " + _eng[i] + " - " + _rus[i];
                }
                Console.ResetColor();
                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < 3)
                    return _rus[index] + " - " + _eng[index] + " - " + _ua[index] + "\n" + _eng[index] + " - " + _rus[index] + " - " + _ua[index] + "\n" + _ua[index] + " - " + _eng[index] + " - " + _rus[index];
                else
                    return "Попытка обращения за пределы массива.";                
            }
        }
    }
}
