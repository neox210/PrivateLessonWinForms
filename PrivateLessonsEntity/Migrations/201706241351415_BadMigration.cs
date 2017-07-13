namespace PrivateLessonsEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BadMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PrivateLessonHours",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    StudentId = c.Int(nullable: false),
                    StartDate = c.DateTime(nullable: false),
                    EndDate = c.DateTime(nullable: false),
                    IsHome = c.Boolean(nullable: false),
                    Subject = c.String(),
                    Topic = c.String(),
                    Comment = c.String(),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.PrivateLessonHours");
        }
    }
}
