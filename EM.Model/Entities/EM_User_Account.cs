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
    
    public partial class EM_User_Account
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string LoginEmail { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public int Status { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime ModifyTime { get; set; }
        public Nullable<int> RoleId { get; set; }
    }
}
