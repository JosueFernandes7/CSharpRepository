using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSetDictionarys.Entities
{
    class PrintService<K>
    {
        private K[] _values = new K[10];
        private int _count = 0;

        public PrintService() { }

        public void AddValue(K value)
        {
            if (_count >= 0 && _count < _values.Length)
            {
                _values[_count] = value;
                _count++;
            }
        }

        public K First() { return _values[0]; }
        public void Print()
        {
            foreach (K value in _values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
