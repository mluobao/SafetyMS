using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZhuGuan.AnQuan.IBLL
{
    public partial interface IUserInfoService
    {
        bool SetRole(int userId, List<string> roleNames);
    }
}
