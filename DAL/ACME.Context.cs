﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    //using System.Data.Objects;
    //using System.Data.Objects.DataClasses;
    using System.Linq;

    public partial class FL_ACMEEntities : DbContext
    {
        public FL_ACMEEntities()
            : base("name=FL_ACMEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<FL_AZKAR> FL_AZKAR { get; set; }
        public DbSet<FL_MASJID> FL_MASJID { get; set; }
        public DbSet<User> Users { get; set; }
    
        public virtual ObjectResult<sp_GetAllUsers_Result> sp_GetAllUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAllUsers_Result>("sp_GetAllUsers");
        }
    
        public virtual ObjectResult<sp_GetUserByIDPAss_Result> sp_GetUserByIDPAss(string userid, string password)
        {
            var useridParameter = userid != null ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetUserByIDPAss_Result>("sp_GetUserByIDPAss", useridParameter, passwordParameter);
        }
    
        public virtual ObjectResult<sp_Masjid_GetALL_Result> sp_Masjid_GetALL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Masjid_GetALL_Result>("sp_Masjid_GetALL");
        }
    }
}
