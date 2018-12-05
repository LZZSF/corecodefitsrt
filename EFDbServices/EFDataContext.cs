using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDbServices
{
    public class EFDataContext : DbContext
    {
        public EFDataContext(DbContextOptions<EFDataContext> options) : base(options) { }
        public DbSet<UserManagement> UserManagements { get; set; }
        public DbSet<RoleManagement> RoleManagements { get; set; }
    }
}
