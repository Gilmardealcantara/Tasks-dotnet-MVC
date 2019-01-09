using Microsoft.EntityFrameworkCore.Migrations;

namespace Tasks.Migrations
{
    public partial class PopulateTasksDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Tasks(ConclusionDate, IsComplete, Name) VALUES('2017-10-10 08:00:00', 1, 'Task 1')");
            migrationBuilder.Sql("INSERT INTO Tasks(ConclusionDate, IsComplete, Name) VALUES('2018-12-21 08:00:00', 0, 'Task 2')");
            migrationBuilder.Sql("INSERT INTO Tasks(ConclusionDate, IsComplete, Name) VALUES('2019-07-22 08:00:00', 0, 'Task 3')");
            migrationBuilder.Sql("INSERT INTO Tasks(ConclusionDate, IsComplete, Name) VALUES('2018-11-09 08:00:00', 1, 'Task 4')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM TASKS");
        }
    }
}
