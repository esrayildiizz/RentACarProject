using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //Bu yapı c# a özel bir yapı:
            //RentACarContext bellekte işi bitince atılsın.
            using (TContext context = new TContext())
            {
                //git veri kaynağından benim gönderdiğim product dan bir tane nesneye eşleştir.
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            //Bu yapı c# a özel bir yapı:
            //RentACarContext bellekte işi bitince atılsın.
            using (TContext context = new TContext())
            {
                //git veri kaynağından benim gönderdiğim product dan bir tane nesneye eşleştir.
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter); //filter a göre bir tane değer döndür.
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {

                return filter == null //filtre = null mı
                    ? context.Set<TEntity>().ToList()  //değil ise Product a yerleş
                    : context.Set<TEntity>().Where(filter).ToList(); //null ise
            }
        }

        public void Update(TEntity entity)
        {
            //Bu yapı c# a özel bir yapı:
            //RentACarContext bellekte işi bitince atılsın.
            using (TContext context = new TContext())
            {
                //git veri kaynağından benim gönderdiğim product dan bir tane nesneye eşleştir.
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
