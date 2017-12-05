using System;
using System.Collections.Generic;


namespace ToDoList_SponServe_DAL.Repository
{
    /// <summary>
    /// Implements repository pattern
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public interface IRepo<T1,T2> : IDisposable where T1: class
    {

        void Insert(T1 obj);
        void Save();
    }
}
