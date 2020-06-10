using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DataAccessLayer.Entities
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ShopDepartment> Departments { get; set; }
        public DbSet<Spoil_Item> SpoilItems { get; set; }

        public DatabaseContext(string connectionString) : base(connectionString) { }
    }
}
