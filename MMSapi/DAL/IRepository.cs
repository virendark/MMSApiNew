using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMSapi.DAL
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> getall();
        void insertdata(T dt);
        void removeEmployees(int id);

        void updatedata(T dt);

        void remove(T id);
        void removeRatings(int id);

    }
}