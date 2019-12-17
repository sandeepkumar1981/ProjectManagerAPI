using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityProjectManager;
using System.Data.Entity;

namespace DataLayerProjectManager
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=SBAProjectManager")
        {
            Database.SetInitializer(new CustomInitializer());
        }

        public DbSet<EntityParentTask> ParentTasks { get; set; }
        public DbSet<EntityTask> Tasks { get; set; }
        public DbSet<EntityProject> Projects { get; set; }
        public DbSet<EntityUser> Users { get; set; }

    }

    public class CustomInitializer : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {

        }
    }
}
