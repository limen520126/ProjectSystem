//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Account1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class R_Role_Menus
    {
        public int ID { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> MenuID { get; set; }
    
        public virtual Menus Menus { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
