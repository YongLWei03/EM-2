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
    
    public partial class EM_System_Program
    {
        public EM_System_Program()
        {
            this.EM_User_Right = new HashSet<EM_User_Right>();
        }
    
        public int Id { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string ActionDescription { get; set; }
        public string ControllerDescription { get; set; }
        public int RightType { get; set; }
        public int SystemType { get; set; }
        public int ParentId { get; set; }
        public string ModifeTime { get; set; }
        public string CreateTime { get; set; }
    
        public virtual ICollection<EM_User_Right> EM_User_Right { get; set; }
    }
}
