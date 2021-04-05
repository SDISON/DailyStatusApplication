namespace DailyStatus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_login : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO LOGINS VALUES ('Sushen.Shrotriya@watchguard.com', '12345678')");
        }
        
        public override void Down()
        {
        }
    }
}
