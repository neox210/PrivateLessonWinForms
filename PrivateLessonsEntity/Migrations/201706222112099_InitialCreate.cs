namespace PrivateLessonsEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.PrivateLessonHours",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            StudentId = c.Int(nullable: false),
            //            StartDate = c.DateTime(nullable: false),
            //            EndDate = c.DateTime(nullable: false),
            //            IsHome = c.Boolean(nullable: false),
            //            Subject = c.String(),
            //            Topic = c.String(),
            //            Comment = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        City = c.String(),
                        Street = c.String(),
                        Level = c.String(),
                        SchoolClass = c.Int(nullable: false),
                        Comment = c.String(),
                        StudentDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
           // DropTable("dbo.PrivateLessonHours");
            DropTable("dbo.AdminLogins");
        }
    }
}
