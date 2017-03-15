using System;

namespace IntechCode.IntechCollection
{
    public class MyList<T> : IMyList<T>
    {
        private T[] _data;
        private int _count;

        public MyList()
        {
            _data = new T[10];
            _count = 0;
        }

        public T this[int index] 
        {
           
            get
            {
                if (index >= Count)
                {
                    throw new IndexOutOfRangeException("Index " + index + " is not within acceptable range : [" + 0 + ", " + Count + "[");
                }
                return  _data[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new IndexOutOfRangeException("Index " + index + " is not within acceptable range : [" + 0 + ", " + Count + "[");
                }
                _data[index] = value;
            }
        }

        public int Count => _count;

        public void Add(T item)
        {
            if (Count == _data.Length) // Array full, must instantiate new, bigger array (size *2)
            {
                T[] newData = new T[_data.Length * 2];
                for (int i = 0; i < _data.Length; i++)
                    newData[i] = _data[i];
                newData[_data.Length] = item;
                _data = newData;
            }
            else
            {
                _data[Count] = item;
            }
            _count++;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            { 
                if (_data[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (Count == 0)
            {
                throw new Exception("No item in the array, so cannot remove");
            }
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException("Index " + index + " is not within acceptable range : [" + 0 + ", " + Count + "[");
            }

            if (Count == _data.Length) // Array full, must instantiate new, bigger array (size *2)
            {
                T[] newData = new T[_data.Length * 2];
                for (int i = 0; i < _data.Length; i++)
                    newData[i] = _data[i];
                newData[_data.Length] = item;
                _data = newData;
            }
            for (int i = index + 1; i <= Count; i++)
            {
                _data[i] = _data[i - 1];
            }
            _data[index] = item;
            _count++;
        }

        public void RemoveAt(int index)
        {
            if (Count == 0)
            {
                throw new Exception("No item in the array, so cannot remove");
            }
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException("Index " + index + " is not within acceptable range : [" + 0 + ", " + Count + "[");
            }
            for (int i = index; i < Count - 1; i++)
            {
                _data[i] = _data[i + 1];
            }
            _count--;
        }
    }
}
