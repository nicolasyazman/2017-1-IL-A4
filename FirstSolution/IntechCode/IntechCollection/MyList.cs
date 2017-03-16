using System;

namespace IntechCode.IntechCollection
{
    public class MyList<T> : IMyList<T>
    {
<<<<<<< HEAD
        private T[] _data;
        private int _count;

        public MyList()
        {
            _data = new T[10];
            _count = 0;
=======
        T[] _items;
        int _count;

        public MyList()
        {
            _items = new T[16];
>>>>>>> eada2770bfde49af7f82797b3a61f6b4d7bf6a9a
        }

        public T this[int index] 
        {
<<<<<<< HEAD
           
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
=======
            get
            {
                if (index >= _count) throw new IndexOutOfRangeException();
                return _items[index];
            }
            set
            {
                if (index >= _count) throw new IndexOutOfRangeException();
                _items[index] = value;
>>>>>>> eada2770bfde49af7f82797b3a61f6b4d7bf6a9a
            }
        }

        public int Count => _count;
<<<<<<< HEAD
=======

        public void Add(T item) => Insert(_count, item);

        public void Insert(int index, T item)
        {
            if (index < 0 || index > _count) throw new IndexOutOfRangeException();
            if (_count == _items.Length)
            {
                // Realloc needed.
                T[] newItems = new T[ _items.Length * 2];
                Array.Copy(_items, 0, newItems, 0, _count);
                _items = newItems;
            }
            if (index == _count) _items[_count] = item;
            else
            {
                Array.Copy(_items, index, _items, index + 1, _count - index);
                _items[index] = item;
            }
            ++_count;
        }
>>>>>>> eada2770bfde49af7f82797b3a61f6b4d7bf6a9a

        public void RemoveAt(int index)
        {
<<<<<<< HEAD
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
=======
            if (index < 0 || index >= _count) throw new IndexOutOfRangeException();
            Array.Copy(_items, index+1, _items, index, _count - index -1);
            _items[--_count] = default(T);
>>>>>>> eada2770bfde49af7f82797b3a61f6b4d7bf6a9a
        }

        public int IndexOf(T item)
        {
<<<<<<< HEAD
            for (int i = 0; i < Count; i++)
            { 
                if (_data[i].Equals(item))
                    return i;
=======
            for( int i = 0; i < _count; ++i)
            {
                if (System.Collections.Generic.EqualityComparer<T>.Default.Equals(item, _items[i]))
                {
                    return i;
                }
>>>>>>> eada2770bfde49af7f82797b3a61f6b4d7bf6a9a
            }
            return -1;
        }

        class E : IMyEnumerator<T>
        {
<<<<<<< HEAD
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
=======
            readonly MyList<T> _list;
            int _currentIndex;

            public E( MyList<T> theList )
            {
                _list = theList;
                _currentIndex = -1;
            }

            public T Current => _list._items[_currentIndex];

            public bool MoveNext()
            {
                return ++_currentIndex < _list._count;
            }
>>>>>>> eada2770bfde49af7f82797b3a61f6b4d7bf6a9a
        }

        public IMyEnumerator<T> GetEnumerator()
        {
<<<<<<< HEAD
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
=======
            return new E( this );
>>>>>>> eada2770bfde49af7f82797b3a61f6b4d7bf6a9a
        }

    }
}
