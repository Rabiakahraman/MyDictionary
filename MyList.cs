using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<T,K>
    {
      
        T[] _key;
        K[] _value;
        T[] _tempKey;
        K[] _tempValue;

        public MyList()
        {
            _key = new T[0];
            _value = new K[0];
        }


        public void Add(T key, K value)
        {
            _tempKey = _key;
            _key = new T[_key.Length + 1];
            for (int i = 0; i <_tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];

            }

            _key[_key.Length - 1] = key;

            _tempValue = _value;
            _value = new K[_value.Length + 1];
            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }
            _value[_value.Length - 1] = value;
        }    
    }
}
