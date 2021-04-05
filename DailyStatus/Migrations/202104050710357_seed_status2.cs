namespace DailyStatus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_status2 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM STATUS WHERE InternEmail = 'Sushen.Shrotriya@watchguard.com'");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '02-03-2021', 'taskdone1', 'tasktodo1', 'difiiculty1')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '03-03-2021', 'taskdone2', 'tasktodo2', 'difiiculty2')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '04-03-2021', 'taskdone3', 'tasktodo3', 'difiiculty3')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '05-03-2021', 'taskdone4', 'tasktodo4', 'difiiculty4')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '06-03-2021', 'taskdone5', 'tasktodo5', 'difiiculty5')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '07-03-2021', 'taskdone6', 'tasktodo6', 'difiiculty6')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '08-03-2021', 'taskdone7', 'tasktodo7', 'difiiculty7')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '09-03-2021', 'taskdone8', 'tasktodo8', 'difiiculty8')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '10-03-2021', 'taskdone9', 'tasktodo9', 'difiiculty9')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '11-03-2021', 'taskdone10', 'tasktodo10', 'difiiculty10')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '12-03-2021', 'taskdone11', 'tasktodo11', 'difiiculty11')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '13-03-2021', 'taskdone12', 'tasktodo12', 'difiiculty12')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '14-03-2021', 'taskdone13', 'tasktodo13', 'difiiculty13')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '15-03-2021', 'taskdone14', 'tasktodo14', 'difiiculty14')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '16-03-2021', 'taskdone15', 'tasktodo15', 'difiiculty15')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '17-03-2021', 'taskdone16', 'tasktodo16', 'difiiculty16')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '18-03-2021', 'taskdone17', 'tasktodo17', 'difiiculty17')");
        }
        
        public override void Down()
        {
        }
    }
}
