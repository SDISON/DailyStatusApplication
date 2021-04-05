namespace DailyStatus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_interns : DbMigration
    {
        public override void Up()
        {            
            Sql("INSERT INTO INTERNS VALUES ('Intern2@watchguard.com', 'Intern2', 'Abhilash', '02-02-2021', 'IT-DEV')");
            Sql("INSERT INTO INTERNS VALUES ('Intern3@watchguard.com', 'Intern3', 'Abhilash', '02-01-2021', 'RnD')");
            Sql("INSERT INTO INTERNS VALUES ('Intern4@watchguard.com', 'Intern4', 'Abhilash', '01-01-2021', 'IT-DEV')");
            Sql("INSERT INTO INTERNS VALUES ('Intern5@watchguard.com', 'Intern5', 'Abhilash', '04-04-2021', 'RnD')");
            Sql("INSERT INTO INTERNS VALUES ('Intern6@watchguard.com', 'Intern6', 'Abhilash', '03-02-2021', 'RnD')");
            Sql("INSERT INTO INTERNS VALUES ('Intern7@watchguard.com', 'Intern7', 'Abhilash', '02-03-2021', 'IT-DEV')");

        }
        
        public override void Down()
        {
        }
    }
}
