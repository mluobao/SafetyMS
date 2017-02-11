using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using ZhuGuan.AnQuan.IDAL;

namespace ZhuGuan.AnQuan.DALFactory
{
    public class DbSessionFactory
    {
        //一次请求共用一个DbSession实例
        public static IDbSession GetCurrentDbSession()
        {
            IDbSession db = CallContext.GetData("DbSession") as IDbSession;
            if (db == null)
            {
                db = new DbSession();
                CallContext.SetData("DbSession", db);
            }
            return db;
        }
    }
}
