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
    
    public partial class AccidentInfo
    {
        public AccidentInfo()
        {
            this.DelFlag = 1;
        }
    
        public int AId { get; set; }
        public System.DateTime HappenDate { get; set; }
        public string Unit { get; set; }
        public string AcciType { get; set; }
        public string AcciDesp { get; set; }
        public string AcciAnalysis { get; set; }
        public string Class2 { get; set; }
        public string Remark { get; set; }
        public short DelFlag { get; set; }
    }
}
