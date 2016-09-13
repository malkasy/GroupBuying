using GroupBuying.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBuying.DAL
{
    public class GroupBuyingContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Category> Categories { get; set; }

        public GroupBuyingContext()
            : base("name=GroupBuying")
        {
            //write Sql Scripts in Debug
            Database.Log = s => Debug.WriteLine(s);
            // Database.Log = s => Errors.SaveLastSQLScript(s);
            //Configuration.ProxyCreationEnabled = false;

            this.Configuration.LazyLoadingEnabled = false;
            //not dropcreate use the current Data whithout Change it
            Database.SetInitializer<GroupBuyingContext>(null);
            //for derbug-dropCreateDB
            // Database.SetInitializer<GRTContext>(new GroupBuyingInitializer());
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }


    /// <summary>
    /// overload Config of initialize of Context, Only For debug!
    /// </summary>
    public class GroupBuyingInitializer : DropCreateDatabaseIfModelChanges<GroupBuyingContext>
    {
        protected override void Seed(GroupBuyingContext context)
        {
            base.Seed(context);
        }
    }
    //public class MigrationsContextFactory : IDbContextFactory<GroupBuyingContext>
    //{
    //    public GroupBuyingContext Create()
    //    {
    //        return new GroupBuyingContext("GroupBuying");
    //    }
    //}

}
