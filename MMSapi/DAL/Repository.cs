using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MMSapi.Models;
using System.Data.Entity;
using MMSapi.DAL;
namespace MMSapi.DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        dbcoontext mdb;
        private DbSet<T> sdmdb;
        public Repository()
        {
            mdb = new dbcoontext();
            sdmdb = mdb.Set<T>();
        }

        public IEnumerable<T> getall()
        {
            return sdmdb.ToList();
        }
        public void insertdata(T obj)
        {
            sdmdb.Add(obj);
            mdb.SaveChanges();
        }
        public void updatedata(T obj)
        {
           sdmdb.Attach(obj);
         //   mdb.Entry(obj).State = System.Data.EntityState.Modified;
            //mdb.SaveChanges();
            mdb.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            mdb.SaveChanges();
        }

        public void removeEmployees(int d)
        {
            //var td = (from s in mdb.Employees where s.emp_ID == d select s).SingleOrDefault();
            //mdb.Employees.Remove(td);
        }
        public void remove(T obj)
        {
            sdmdb.Remove(obj);
            mdb.SaveChanges();
        }
        public void removeRatings(int d)
        {
            //var td = (from s in mdb.Ratings where s.ref_id == d select s).SingleOrDefault();
            //mdb.Ratings.Remove(td);
        }

       
    }
   
       

    
}