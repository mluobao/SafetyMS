//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZhuGuan.AnQuan.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UnitInfo
    {
        public UnitInfo()
        {
            this.IsInspUnit = 0;
            this.IsZrdw = 0;
            this.DelFlag = 1;
            this.UserInfo = new HashSet<UserInfo>();
            this.TeamInfo = new HashSet<TeamInfo>();
        }
    
        public int Id { get; set; }
        public string UnitName { get; set; }
        public short IsInspUnit { get; set; }
        public short IsZrdw { get; set; }
        public short DelFlag { get; set; }
        public string UnitProperty { get; set; }
        public string Remark { get; set; }
    
        public virtual ICollection<UserInfo> UserInfo { get; set; }
        public virtual ICollection<TeamInfo> TeamInfo { get; set; }
    }
}