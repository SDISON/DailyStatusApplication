namespace DailyStatus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_intern2 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Interns WHERE Mentor = 'Abhilash'");
            Sql("INSERT INTO INTERNS VALUES ('Intern1@watchguard.com', 'Intern1', 'Mentor1', '02-01-2021', 'IT-DEV')");
            Sql("INSERT INTO INTERNS VALUES ('Intern2@watchguard.com', 'Intern2', 'Mentor2', '02-02-2021', 'IT-DEV')");
            Sql("INSERT INTO INTERNS VALUES ('Intern3@watchguard.com', 'Intern3', 'Mentor3', '02-03-2021', 'RnD')");
            Sql("INSERT INTO INTERNS VALUES ('Intern4@watchguard.com', 'Intern4', 'Mentor4', '02-04-2021', 'IT-DEV')");
            Sql("INSERT INTO INTERNS VALUES ('Intern5@watchguard.com', 'Intern5', 'Mentor5', '01-04-2021', 'RnD')");
            Sql("INSERT INTO INTERNS VALUES ('Intern6@watchguard.com', 'Intern6', 'Mentor6', '01-02-2021', 'RnD')");
            Sql("INSERT INTO INTERNS VALUES ('Intern7@watchguard.com', 'Intern7', 'Mentor7', '01-03-2021', 'IT-DEV')");
        }
        
        public override void Down()
        {
        }
    }
}
