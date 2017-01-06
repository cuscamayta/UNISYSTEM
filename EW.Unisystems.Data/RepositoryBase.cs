using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace EW.Unisystems.Data
{
    public abstract class RepositoryBase<T> where T : class
    {
        /// <summary>The data context.</summary>
        protected DBUnisystemEntities dataContext;

        /// <summary>The db set.</summary>
        protected readonly IDbSet<T> DbSet;

        /// <summary>The _data context.</summary>
        //private DBUnisystemEntities _dataContext;

        /// <summary>Gets the database factory.</summary>
       // protected IDatabaseFactory DatabaseFactory { get; private set; }

        /// <summary>Gets the d context.</summary>
        public DBUnisystemEntities DataContext
        {
            get { return dataContext ?? (dataContext = new DBUnisystemEntities()); }
        }



        /// <summary>Initializes a new instance of the <see cref="RepositoryBase{T}"/> class.</summary>
        protected RepositoryBase()
        {
            DbSet = DataContext.Set<T>();
            DataContext.Configuration.AutoDetectChangesEnabled = false;
        }

        /// <summary>The add.</summary>
        /// <param name="entity">The entity.</param>
        public virtual void Add(T entity)
        {
            DbSet.Add(entity);
        }



        /// <summary>
        /// <summary>The update.</summary>
        /// <param name="entity">The entity.</param>
        public virtual void Update(T entity)
        {
            DbSet.Attach(entity);

            DataContext.Entry(entity).State = System.Data.EntityState.Modified;
        }

        /// <summary>The delete.</summary>
        /// <param name="where">The where.</param>
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IQueryable<T> objects = DbSet.Where(where).AsQueryable();
            foreach (T obj in objects)
                Remove(obj);
        }

        /// <summary>The remove.</summary>
        /// <param name="entity">The entity.</param>
        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

        /// <summary>The get by id.</summary>
        /// <param name="id">The id.</param>
        /// <returns>The <see cref="T"/>.</returns>
        public virtual T GetById(long id)
        {
            return DbSet.Find(id);
        }

        /// <summary>The get by id.</summary>
        /// <param name="id">The id.</param>
        /// <param name="navigationProperties">The navigation properties.</param>
        /// <returns>The <see cref="T"/>.</returns>
        public virtual T GetById(string id, List<string> navigationProperties)
        {
            LoadNavigationProperties(navigationProperties);
            return DbSet.Find(id);
        }

        /// <summary>The get first.</summary>
        /// <param name="where">The where.</param>
        /// <returns>The <see cref="T"/>.</returns>
        public virtual T GetFirst(Expression<Func<T, bool>> where)
        {
            return DbSet.First(where);
        }

        /// <summary>The get first or default.</summary>
        /// <param name="where">The where.</param>
        /// <returns>The <see cref="T"/>.</returns>
        public virtual T GetFirstOrDefault(Expression<Func<T, bool>> where)
        {
            return DbSet.FirstOrDefault(where);
        }

        /// <summary>The get many.</summary>
        /// <param name="where">The where.</param>
        /// <returns>The <see cref="IQueryable"/>.</returns>
        public virtual IQueryable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return DbSet.Where(where);
        }

        /// <summary>The get many.</summary>
        /// <param name="where">The where.</param>
        /// <param name="navigationProperties">The navigation properties.</param>
        /// <returns>The <see cref="IQueryable"/>.</returns>
        public virtual IQueryable<T> GetMany(Expression<Func<T, bool>> where, List<string> navigationProperties)
        {
            LoadNavigationProperties(navigationProperties);
            return DbSet.AsQueryable();
        }

        /// <summary>The get all.</summary>
        /// <returns>The <see cref="IEnumerable"/>.</returns>
        public virtual IEnumerable<T> GetAll()
        {
            return DbSet.ToList();
        }

        /// <summary>The get all as q.</summary>
        /// <returns>The <see cref="IEnumerable"/>.</returns>
        public virtual IEnumerable<T> GetAllAsQ()
        {
            return DbSet;
        }

        public virtual IQueryable<T> BuildQuery()
        {
            return this.DataContext.Set<T>().AsQueryable<T>();
        }

        /// <summary>The get all.</summary>
        /// <param name="navigationProperties">The navigation properties.</param>
        /// <returns>The <see cref="IEnumerable"/>.</returns>
        public virtual IEnumerable<T> GetAll(List<string> navigationProperties)
        {
            LoadNavigationProperties(navigationProperties);
            return DbSet.ToList();
        }

        public int SaveChanges()
        {
            return DataContext.SaveChanges();
        }

        /// <summary>The load navigation properties.</summary>
        /// <param name="navigationProperties">The navigation properties.</param>
        protected void LoadNavigationProperties(List<string> navigationProperties)
        {
            foreach (var navigationProperty in navigationProperties)
            {
                DbSet.Include(navigationProperty);
            }
        }
    }
}