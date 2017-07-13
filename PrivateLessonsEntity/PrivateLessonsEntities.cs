namespace PrivateLessonsEntity
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PrivateLessonsEntities : DbContext
    {
        // Your context has been configured to use a 'PrivateLessonsEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PrivateLessonsEntity.PrivateLessonsEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PrivateLessonsEntities' 
        // connection string in the application configuration file.
        public PrivateLessonsEntities()
            : base("name=PrivateLessonsEntities")
        {
            

        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Students>().HasMany(c => c.PrivateLessons);
        //}


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //}

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }


        public virtual DbSet<AdminLogin> AdminLogin { get; set; }
        public virtual DbSet<PrivateLessonHour> PrivateLessonHour { get; set; }
        public virtual DbSet<Students> Students { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}