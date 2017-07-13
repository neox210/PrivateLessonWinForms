namespace PrivateLessonsEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hourdescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PrivateLessonHours", "HourDescription", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.PrivateLessonHours", "HourDescription");
        }
    }
}
