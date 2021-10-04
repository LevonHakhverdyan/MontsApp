using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontsApp
{
    public class _MontsOfYearEnumerator :IEnumerator
    {
        private readonly string[] _source;
        private readonly int _size;
        private int _counter = 0;
        public _MontsOfYearEnumerator(string[] source, int size)
        {
            _source = source;
            _size = size;
        }
        public object Current => _source[_counter++];

        public bool MoveNext()
        {
            return _counter < _size;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

}
