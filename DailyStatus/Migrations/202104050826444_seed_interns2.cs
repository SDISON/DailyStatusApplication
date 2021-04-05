namespace DailyStatus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_interns2 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Interns WHERE 1 = 1");
            Sql("INSERT INTO INTERNS VALUES ('Intern1@watchguard.com', 'Intern1', 'Mentor1', '02-01-2021', 'IT-DEV')");
            Sql("INSERT INTO INTERNS VALUES ('Intern2@watchguard.com', 'Intern2', 'Mentor2', '02-02-2021', 'IT-DEV')");
            Sql("INSERT INTO INTERNS VALUES ('Intern3@watchguard.com', 'Intern3', 'Mentor3', '02-03-2021', 'RnD')");
            Sql("INSERT INTO INTERNS VALUES ('Intern4@watchguard.com', 'Intern4', 'Mentor4', '02-04-2021', 'IT-DEV')");
            Sql("INSERT INTO INTERNS VALUES ('Intern5@watchguard.com', 'Intern5', 'Mentor3', '01-04-2021', 'RnD')");
            Sql("INSERT INTO INTERNS VALUES ('Intern6@watchguard.com', 'Intern6', 'Mentor2', '01-02-2021', 'RnD')");
            Sql("INSERT INTO INTERNS VALUES ('Intern7@watchguard.com', 'Intern7', 'Mentor1', '01-03-2021', 'IT-DEV')");
        }
        
        public override void Down()
        {
        }
    }
}
