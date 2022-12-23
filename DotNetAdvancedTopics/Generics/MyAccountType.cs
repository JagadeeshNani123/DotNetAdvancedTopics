using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotNetAdvancedTopics.Generics
{
    public class MyAccountType<T> : IList<T>
    {
        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count()
        {
            return 1;
        }

        public bool IsReadOnly()
        {
            return false;
        }

        int ICollection<T>.Count =>  this.Count();

        bool ICollection<T>.IsReadOnly => this.IsReadOnly();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            if(this.Count()>0 && !this.IsReadOnly())
            {
                this.Clear();
            }
        }

        public bool Contains(T item)
        {
            return "Jagadeesh".Contains("J");
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            List<T> coll = new List<T>();
            return (IEnumerator<T>) coll;
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
