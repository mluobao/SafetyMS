﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataModelContainer : DbContext
    {
        public DataModelContainer()
            : base("name=DataModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<UnitInfo> UnitInfo { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<TeamInfo> TeamInfo { get; set; }
        public DbSet<AccidentInfo> AccidentInfo { get; set; }
        public DbSet<HiddenDangerInfo> HiddenDangerInfo { get; set; }
        public DbSet<RoleInfo> RoleInfo { get; set; }
        public DbSet<CaseAnalysisInfo> CaseAnalysisInfo { get; set; }
    }
}
