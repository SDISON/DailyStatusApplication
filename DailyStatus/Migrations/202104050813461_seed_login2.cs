namespace DailyStatus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_login2 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM LOGINS WHERE Email = 'Sushen.Shrotriya@watchguard.com'");
            Sql("INSERT INTO LOGINS VALUES ('Intern1@watchguard.com', '12345678')");
            Sql("INSERT INTO LOGINS VALUES ('Intern2@watchguard.com', '12345678')");
            Sql("INSERT INTO LOGINS VALUES ('Intern3@watchguard.com', '12345678')");
            Sql("INSERT INTO LOGINS VALUES ('Intern4@watchguard.com', '12345678')");
            Sql("INSERT INTO LOGINS VALUES ('Intern5@watchguard.com', '12345678')");
            Sql("INSERT INTO LOGINS VALUES ('Intern6@watchguard.com', '12345678')");
            Sql("INSERT INTO LOGINS VALUES ('Intern7@watchguard.com', '12345678')");
        }
        
        public override void Down()
        {
        }
    }
}

