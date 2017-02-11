using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ZhuGuan.AnQuan.DALFactory;
using ZhuGuan.AnQuan.IDAL;

namespace ZhuGuan.AnQuan.BLL
{
    public abstract class BaseService<T> where T : class,new()
    {
        public IBaseDal<T> CurrentDal { get; set; }

        public BaseService()
        {
            SetCurrentDal();    //抽象方法，要求子类必须实现
        }

        public abstract void SetCurrentDal();

        public IDbSession DbSession
        {
            get { return DbSessionFactory.GetCurrentDbSession(); }
        }

        #region 查询

        //不在DbContext中缓存返回的实体
        public IQueryable<T> AsNoTrackingGetEntities(Expression<Func<T, bool>> whereLambdaExpression)
        {
            return CurrentDal.AsNoTrackingGetEntities(whereLambdaExpression);

        }

        //在DbContext中缓存返回的实体
        public IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLambdaExpression)
        {
            return CurrentDal.GetEntities(whereLambdaExpression);

        }

        

        #endregion

        #region 添加

        public T Add(T entity)
        {
            CurrentDal.Add(entity);
            DbSession.SaveChanges();
            return entity;
        }

        //批量添加
        public List<T> AddEntities(List<T> entities)
        {
            CurrentDal.AddEntities(entities);
            DbSession.SaveChanges();
            return entities;
        }
        #endregion

        #region 修改

        public bool Update(T entity)
        {
            CurrentDal.Update(entity);
            return DbSession.SaveChanges() > 0;
        }

        //批量修改
        public bool UpdateEntities(List<T> entities)
        {
            CurrentDal.UpdateEntities(entities);
            return DbSession.SaveChanges() > 0;
        }

        #endregion

        #region 删除

        public bool Delete(int id)  //在生产环境中，所有的删除都是软删除
        {
            CurrentDal.Delete(id);
            return DbSession.SaveChanges() > 0;
        }

        //批量删除
        public bool DeleteEntities(List<int> ids)
        {
            CurrentDal.DeleteEntities(ids);
            return DbSession.SaveChanges() > 0;
        }

        #endregion
    }
}
