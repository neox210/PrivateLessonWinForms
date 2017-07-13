namespace PrivateLessonsEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentsCreatedDateaddToDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "CreatedDate");
        }
    }
}
