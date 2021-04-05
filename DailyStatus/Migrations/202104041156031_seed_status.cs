namespace DailyStatus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_status : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '02-04-2021', 'taskdone1', 'tasktodo1', 'difiiculty1')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '02-04-2021', 'taskdone2', 'tasktodo2', 'difiiculty2')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '02-04-2021', 'taskdone3', 'tasktodo3', 'difiiculty3')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '02-04-2021', 'taskdone4', 'tasktodo4', 'difiiculty4')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '02-04-2021', 'taskdone5', 'tasktodo5', 'difiiculty5')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '02-04-2021', 'taskdone6', 'tasktodo6', 'difiiculty6')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '02-04-2021', 'taskdone7', 'tasktodo7', 'difiiculty7')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '02-04-2021', 'taskdone8', 'tasktodo8', 'difiiculty8')");
            Sql("INSERT INTO STATUS VALUES ('Sushen.Shrotriya@watchguard.com', '02-04-2021', 'taskdone9', 'tasktodo9', 'difiiculty9')");
        }
        
        public override void Down()
        {
        }
    }
}
