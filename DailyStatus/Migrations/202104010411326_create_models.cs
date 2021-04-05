namespace DailyStatus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Interns",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Mentor = c.String(),
                        JoiningDate = c.String(),
                        Group = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        InternEmail = c.String(),
                        Date = c.String(),
                        TaskDone = c.String(nullable: false),
                        TaskForTomorrow = c.String(nullable: false),
                        DifficultyFaced = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Status");
            DropTable("dbo.Logins");
            DropTable("dbo.Interns");
        }
    }
}
