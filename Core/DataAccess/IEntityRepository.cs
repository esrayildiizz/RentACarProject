
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //T tipi için kısıtlama getirdik yani herkes istediğini yazamasın.
    //generic constaint :kısıtlama
    // T nin tipi bir class olmalı ve class ta IEntity nin içinde olmalı.
    //IEntity de new lenebiliyor olmalıdır.
    public interface IEntityRepository<T> where T:class ,IEntity, new()
    {
        //Bütün ürünleri çek getir.
        //Şartlı listeleme
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);  //tek bir data getirmek için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
