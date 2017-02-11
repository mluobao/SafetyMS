using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ZhuGuan.AnQuan.IBLL
{
    public interface IBaseService<T> where T : class,new()
    {

        //不在DbContext中缓存返回的实体--查询
        IQueryable<T> AsNoTrackingGetEntities(Expression<Func<T, bool>> whereLambdaExpression);

        //在DbContext中缓存返回的实体--查询
        IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLambdaExpression);

        //添加
        T Add(T entity);

        //批量添加
        List<T> AddEntities(List<T> entities);

        //修改
        bool Update(T entity);

        //批量修改
        bool UpdateEntities(List<T> entities);

        //删除
        bool Delete(int id);

        //批量删除
        bool DeleteEntities(List<int> ids);
    }
}
