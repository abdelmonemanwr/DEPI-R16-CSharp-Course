using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericRepository<T> : IGenericRepository<T>
    {
        int top;
        private T[] data;
        public GenericRepository(int size=10)
        {
            top = 0;
            data = new T[size];
        }

        public void Add(T item)
        {
            data[top++] = item;
        }

        public T[] GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, T item)
        {
            throw new NotImplementedException();
        }
    }
}
