using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using ZhuGuan.AnQuan.IBLL;

namespace ZhuGuan.AnQuan.BLLFactory
{
    public class ServiceSessionFactory
    {
        //一次请求共用一个ServiceSession实例
        public static IServiceSession GetCurrentServiceSession()
        {
            IServiceSession service = CallContext.GetData("ServiceSession") as IServiceSession;
            if (service == null)
            {
                service = new ServiceSession();
                CallContext.SetData("ServiceSession", service);
            }
            return service;
        }
    }
}
