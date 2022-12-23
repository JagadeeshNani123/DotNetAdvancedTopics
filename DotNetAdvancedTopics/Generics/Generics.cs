using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetAdvancedTopics.Generics
{
    class Generics<T>
    {
        public T Value;
        public List<T> collection = new List<T>();
        public T MyGenericMethod<T>(T t)
        {
            return t;
        }

        public void AddItemToCollection(T item)
        {
            collection.Add(item);
        }
    }
}
