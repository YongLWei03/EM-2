//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EM.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class EM_Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public Nullable<decimal> KPIPercent { get; set; }
        public Nullable<decimal> KPIValue { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public string Creater { get; set; }
        public string Modifier { get; set; }
    }
}