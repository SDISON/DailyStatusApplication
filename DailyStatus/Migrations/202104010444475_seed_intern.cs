namespace DailyStatus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_intern : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Interns VALUES ('Sushen.Shrotriya@watchguard.com', 'Sushen Shrotriya', 'Abhilash', '02-02-2021', 'IT-DEV')");
        }
        
        public override void Down()
        {
        }
    }
}
