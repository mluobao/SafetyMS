using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZhuGuan.AnQuan.Model;

namespace ZhuGuan.AnQuan.BLL
{
    public partial class UserInfoService
    {
        public bool SetRole(int userId, List<string> roleNames)
        {
            var currentUser = DbSession.UserInfoDal.GetEntities(u => u.Id == userId).FirstOrDefault(); //在DbContext中缓存返回的实体--查询
            currentUser.RoleInfo.Clear();   //清除原有的权限

            var allSelectedRoles = DbSession.RoleInfoDal.GetEntities(r => roleNames.Contains(r.RoleName)).ToList(); //在DbContext中缓存返回的实体--查询

            foreach (var roleInfo in allSelectedRoles)
            {
                currentUser.RoleInfo.Add(roleInfo); //重新添加角色
            }
            DbSession.SaveChanges();
            return true;
        }
    }
}
