using ApoCan.BLL.Patterns.Repository.IRep;
using ApoCan.BLL.Patterns.Singleton;
using ApoCan.DAL.Context;
using ApoCan.MODEL.Entities;
using ApoCan.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApoCan.BLL.Patterns.Repository.BaseRep
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {

        protected ApocanContext db;

        public BaseRepository()
        {
            db = DBTool.DBInstance;
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();

        }

        public void Add(T item)
        {
            db.Set<T>().Add(item);
            Save();
        }

        protected void Save()
        {
            db.SaveChanges();
        }

        public void SoftDelete(T item)
        {

            item.DeletedDate = DateTime.Now;
            item.Status = DataStatus.Deleted;
            Save();
        }

        public void Destroy(T item)
        {
            db.Set<T>().Remove(item);
            Save();
        }


        public virtual void Update(T item)
        {
            T toBeUpdated = db.Set<T>().Find(item.ID);
            item.ModifiedDate = DateTime.Now;
            item.Status = DataStatus.Updated;
            db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();

        }


        public List<T> Where(Expression<Func<T, bool>> exp)
        {

            return db.Set<T>().Where(exp).ToList();
        }

        public T Default(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().FirstOrDefault(exp);
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return db.Set<T>().Select(exp).ToList();
        }

        public T Find(int id)
        {
            return db.Set<T>().Find(id);
        }


    }
}
