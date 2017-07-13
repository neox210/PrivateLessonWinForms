namespace PrivateLessonsEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HourDescriptionSchedule : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PrivateLessonHours", "HourDescriptionSchedule", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PrivateLessonHours", "HourDescriptionSchedule");
        }
    }
}
