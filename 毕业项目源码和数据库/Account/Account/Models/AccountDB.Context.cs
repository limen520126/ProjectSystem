﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Account.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AccountDBEntities : DbContext
    {
        public AccountDBEntities()
            : base("name=AccountDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Detail> Detail { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<Paper> Paper { get; set; }
        public virtual DbSet<R_Role_Menus> R_Role_Menus { get; set; }
        public virtual DbSet<R_User_Roles> R_User_Roles { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }
        public virtual DbSet<UserInfos> UserInfos { get; set; }
        public virtual DbSet<v_user_menus> v_user_menus { get; set; }
        public virtual DbSet<v_User_Role_Menu> v_User_Role_Menu { get; set; }
    }
}
