using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CRUD_System.Entities
{
    public partial class MyModel : DbContext
    {
        public MyModel()
            : base("name=MyDBConnectionString")
        {
        }

        public virtual DbSet<Detail> Details { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
