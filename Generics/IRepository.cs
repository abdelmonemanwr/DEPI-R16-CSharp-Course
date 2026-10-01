using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    interface IGenericRepository<T>
    {
        void Add(T item);
        void Update(int id, T item);
        T GetById(int id);
        T[] GetAll();
    }

    //interface IStudentRepository
    //{
    //    void Add(Student item);
    //    void Update(int id, Student item);
    //    Student GetById(int id);
    //    Student[] GetAll();
    //}

    //interface IEmployeeRepository
    //{
    //    void Add(Employee item);
    //    void Update(int id, Employee item);
    //    Employee GetById(int id);
    //    Employee[] GetAll();
    //}
}
