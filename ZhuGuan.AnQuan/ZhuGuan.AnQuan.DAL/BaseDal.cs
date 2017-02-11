using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using ZhuGuan.AnQuan.Model.Enum;

namespace ZhuGuan.AnQuan.DAL
{
    public class BaseDal<T> where T : class,new()
    {
        //依赖抽象的编程，可以在应对变化的时候，改变最小。
        public DbContext Db
        {
            get { return DbContextFactory.GetCurrentContext(); }
        }

        #region 不在DbContext中缓存返回的实体--查询
        public IQueryable<T> AsNoTrackingGetEntities(Expression<Func<T, bool>> whereLambdaExpression)
        {
            return Db.Set<T>().AsNoTracking().Where(whereLambdaExpression).AsQueryable();   //不在DbContext中缓存返回的实体
        }

        #endregion

        #region 在DbContext中缓存返回的实体--查询
        public IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLambdaExpression)
        {
            return Db.Set<T>().Where(whereLambdaExpression).AsQueryable();   //在DbContext中缓存返回的实体，处理实体间多对多的关系
        }

        #endregion

        #region 添加

        public T Add(T entity)
        {
            Db.Set<T>().Add(entity);
            //Db.SaveChanges(); //把SaveChanges方法提高到bll层
            return entity;
        }

        //批量添加
        public List<T> AddEntities(List<T> entities)
        {
            //Db.Set<T>().AddRange(entities);   //EF6里面的功能
            foreach (var entity in entities)
            {
                Db.Set<T>().Add(entity);
            }

            return entities;
        }

        #endregion

        #region 修改

        public void Update(T entity)
        {
            Db.Entry(entity).State = EntityState.Modified;

            //return true; //Db.SaveChanges() > 0;
        }

        //批量修改
        public void UpdateEntities(List<T> entities)
        {
            foreach (var entity in entities)
            {
                Db.Entry(entity).State = EntityState.Modified;
                //if (Db.Entry(entity).CurrentValues != null)
                //{
                //    Db.Entry(entity).State = EntityState.Modified;
                //}
            }
            //return true;
        }

        #endregion

        #region 删除

        //实际删除
        //public bool Delete(T entity)
        //{
        //    //在生产环境中，所有的删除都要做成软删除


        //    Db.Entry(entity).State= EntityState.Deleted;
        //    return Db.SaveChanges() > 0;
        //}

        /// <summary>
        /// 逻辑删除
        /// </summary>
        /// <param name="id">主键的值</param>
        /// <returns></returns>
        public void Delete(int id)
        {
            var entity = Db.Set<T>().Find(id);
            Db.Entry(entity).Property("DelFlag").CurrentValue = (short)DelFlagEnum.Deleted;
            Db.Entry(entity).Property("DelFlag").IsModified = true;
            //return true; //Db.SaveChanges() > 0;
        }

        //批量删除
        public void DeleteEntities(List<int> ids)
        {
            foreach (var id in ids)
            {
                var entity = Db.Set<T>().Find(id);
                Db.Entry(entity).Property("DelFlag").CurrentValue = (short)DelFlagEnum.Deleted;
                Db.Entry(entity).Property("DelFlag").IsModified = true;
            }
            //return true;
        }

        #endregion
    }
}
