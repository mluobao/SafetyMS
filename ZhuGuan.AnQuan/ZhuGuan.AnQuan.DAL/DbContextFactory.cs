using System.Data.Entity;
using System.Runtime.Remoting.Messaging;
using ZhuGuan.AnQuan.Model;

namespace ZhuGuan.AnQuan.DAL
{
    public class DbContextFactory
    {
        public static DbContext GetCurrentContext()
        {
            #region 一次请求共用一个dbContext实例
            DbContext dbContext = CallContext.GetData("DbContext") as DbContext;
            if (dbContext == null)
            {
                dbContext = new DataModelContainer();
                CallContext.SetData("DbContext", dbContext);
            }
            return dbContext; 
            #endregion
        }


    }
}
