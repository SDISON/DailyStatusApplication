namespace DailyStatus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_status4 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM STATUS WHERE 1= 1");
            for (int i = 2; i <= 31; i++)
            {
                string TempDate = "";
                if (i < 10)
                    TempDate = "'0" + i + "-01-2021'";
                else
                    TempDate = "'" + i + "-01-2021'";
                string statement = "INSERT INTO STATUS VALUES ('Intern1@watchguard.com'," + TempDate + ", 'taskdone1', 'tasktodo1', 'difiiculty1')";
                Sql(statement);
            }
            for (int i = 1; i <= 28; i++)
            {
                string TempDate = "";
                if (i < 10)
                    TempDate = "'0" + i + "-02-2021'";
                else
                    TempDate = "'" + i + "-02-2021'";
                string statement = "INSERT INTO STATUS VALUES ('Intern1@watchguard.com'," + TempDate + ", 'taskdone1', 'tasktodo1', 'difiiculty1')";
                Sql(statement);
            }
            for (int i = 1; i <= 31; i++)
            {
                string TempDate = "";
                if (i < 10)
                    TempDate = "'0" + i + "-03-2021'";
                else
                    TempDate = "'" + i + "-03-2021'";
                string statement = "INSERT INTO STATUS VALUES ('Intern1@watchguard.com'," + TempDate + ", 'taskdone1', 'tasktodo1', 'difiiculty1')";
                Sql(statement);
            }
            for (int i = 2; i <= 28; i++)
            {
                string TempDate = "";
                if (i < 10)
                    TempDate = "'0" + i + "-02-2021'";
                else
                    TempDate = "'" + i + "-02-2021'";
                string statement = "INSERT INTO STATUS VALUES ('Intern2@watchguard.com'," + TempDate + ", 'taskdone1', 'tasktodo1', 'difiiculty1')";
                Sql(statement);
            }
            for (int i = 1; i <= 31; i++)
            {
                string TempDate = "";
                if (i < 10)
                    TempDate = "'0" + i + "-03-2021'";
                else
                    TempDate = "'" + i + "-03-2021'";
                string statement = "INSERT INTO STATUS VALUES ('Intern2@watchguard.com'," + TempDate + ", 'taskdone1', 'tasktodo1', 'difiiculty1')";
                Sql(statement);
            }
            for (int i = 2; i <= 31; i++)
            {
                string TempDate = "";
                if (i < 10)
                    TempDate = "'0" + i + "-03-2021'";
                else
                    TempDate = "'" + i + "-03-2021'";
                string statement = "INSERT INTO STATUS VALUES ('Intern3@watchguard.com'," + TempDate + ", 'taskdone1', 'tasktodo1', 'difiiculty1')";
                Sql(statement);
            }
        }
        
        public override void Down()
        {
        }
    }
}
