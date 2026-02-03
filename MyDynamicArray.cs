using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithArrays
{
    public class MyDynamicArray
    {
        private int _length;
        private int[] _numbers;
        private int _count = 0;
        public MyDynamicArray(int lenght)
        {
            _length = lenght;
            _numbers = new int[lenght];
        }

        public void Insert(int item)
        {
            if (_count >= _length)
            {
                int newLenght = _length * 2;
                int[] newArray = new int[newLenght];

                _numbers.CopyTo(newArray, 0);

                _numbers = newArray;
                _length = newLenght;
            }

            _numbers[_count++] = item;

        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _count)
                throw new ArgumentOutOfRangeException("index");

            for (int i = index; i < _count; i++)
                _numbers[i] = _numbers[i + 1];

            _count--;
        }

        public int IndexOf(int item)
        {
            foreach (int i in _numbers)
            {
                if (item == _numbers[i])
                {
                    return i;
                }
            }

            return -1;
        }

        public string Print()
        {
            return string.Join(", ", _numbers.Take(_count));
        }
    }
}
