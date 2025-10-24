using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class intsdö : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absenses_groups_GroupId",
                table: "Absenses");

            migrationBuilder.DropForeignKey(
                name: "FK_ChildGroupHistory_groups_GroupId",
                table: "ChildGroupHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_children_groups_GroupId",
                table: "children");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_groups_GroupId",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_jobTitles_employees_EmployeeId",
                table: "jobTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_queue_children_ChildId",
                table: "queue");

            migrationBuilder.DropForeignKey(
                name: "FK_queue_groups_GroupId",
                table: "queue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_queue",
                table: "queue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_menu",
                table: "menu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_jobTitles",
                table: "jobTitles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_groups",
                table: "groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_children",
                table: "children");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChildGroupHistory",
                table: "ChildGroupHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Absenses",
                table: "Absenses");

            migrationBuilder.RenameTable(
                name: "queue",
                newName: "Queue");

            migrationBuilder.RenameTable(
                name: "menu",
                newName: "Menu");

            migrationBuilder.RenameTable(
                name: "jobTitles",
                newName: "JobTitles");

            migrationBuilder.RenameTable(
                name: "groups",
                newName: "Groups");

            migrationBuilder.RenameTable(
                name: "employees",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "children",
                newName: "Children");

            migrationBuilder.RenameTable(
                name: "ChildGroupHistory",
                newName: "ChildGroupsHistory");

            migrationBuilder.RenameTable(
                name: "Absenses",
                newName: "Absences");

            migrationBuilder.RenameIndex(
                name: "IX_queue_GroupId",
                table: "Queue",
                newName: "IX_Queue_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_queue_ChildId",
                table: "Queue",
                newName: "IX_Queue_ChildId");

            migrationBuilder.RenameIndex(
                name: "IX_jobTitles_EmployeeId",
                table: "JobTitles",
                newName: "IX_JobTitles_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_employees_GroupId",
                table: "Employees",
                newName: "IX_Employees_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_children_GroupId",
                table: "Children",
                newName: "IX_Children_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_ChildGroupHistory_GroupId",
                table: "ChildGroupsHistory",
                newName: "IX_ChildGroupsHistory_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Absenses_GroupId",
                table: "Absences",
                newName: "IX_Absences_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Queue",
                table: "Queue",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menu",
                table: "Menu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTitles",
                table: "JobTitles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Children",
                table: "Children",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChildGroupsHistory",
                table: "ChildGroupsHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Absences",
                table: "Absences",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Absences_Groups_GroupId",
                table: "Absences",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChildGroupsHistory_Groups_GroupId",
                table: "ChildGroupsHistory",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Groups_GroupId",
                table: "Children",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Groups_GroupId",
                table: "Employees",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitles_Employees_EmployeeId",
                table: "JobTitles",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Queue_Children_ChildId",
                table: "Queue",
                column: "ChildId",
                principalTable: "Children",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Queue_Groups_GroupId",
                table: "Queue",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absences_Groups_GroupId",
                table: "Absences");

            migrationBuilder.DropForeignKey(
                name: "FK_ChildGroupsHistory_Groups_GroupId",
                table: "ChildGroupsHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Children_Groups_GroupId",
                table: "Children");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Groups_GroupId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTitles_Employees_EmployeeId",
                table: "JobTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_Queue_Children_ChildId",
                table: "Queue");

            migrationBuilder.DropForeignKey(
                name: "FK_Queue_Groups_GroupId",
                table: "Queue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Queue",
                table: "Queue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menu",
                table: "Menu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTitles",
                table: "JobTitles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Children",
                table: "Children");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChildGroupsHistory",
                table: "ChildGroupsHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Absences",
                table: "Absences");

            migrationBuilder.RenameTable(
                name: "Queue",
                newName: "queue");

            migrationBuilder.RenameTable(
                name: "Menu",
                newName: "menu");

            migrationBuilder.RenameTable(
                name: "JobTitles",
                newName: "jobTitles");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "groups");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "employees");

            migrationBuilder.RenameTable(
                name: "Children",
                newName: "children");

            migrationBuilder.RenameTable(
                name: "ChildGroupsHistory",
                newName: "ChildGroupHistory");

            migrationBuilder.RenameTable(
                name: "Absences",
                newName: "Absenses");

            migrationBuilder.RenameIndex(
                name: "IX_Queue_GroupId",
                table: "queue",
                newName: "IX_queue_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Queue_ChildId",
                table: "queue",
                newName: "IX_queue_ChildId");

            migrationBuilder.RenameIndex(
                name: "IX_JobTitles_EmployeeId",
                table: "jobTitles",
                newName: "IX_jobTitles_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_GroupId",
                table: "employees",
                newName: "IX_employees_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Children_GroupId",
                table: "children",
                newName: "IX_children_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_ChildGroupsHistory_GroupId",
                table: "ChildGroupHistory",
                newName: "IX_ChildGroupHistory_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Absences_GroupId",
                table: "Absenses",
                newName: "IX_Absenses_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_queue",
                table: "queue",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_menu",
                table: "menu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jobTitles",
                table: "jobTitles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_groups",
                table: "groups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_children",
                table: "children",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChildGroupHistory",
                table: "ChildGroupHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Absenses",
                table: "Absenses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Absenses_groups_GroupId",
                table: "Absenses",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChildGroupHistory_groups_GroupId",
                table: "ChildGroupHistory",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_children_groups_GroupId",
                table: "children",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_groups_GroupId",
                table: "employees",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_jobTitles_employees_EmployeeId",
                table: "jobTitles",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_queue_children_ChildId",
                table: "queue",
                column: "ChildId",
                principalTable: "children",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_queue_groups_GroupId",
                table: "queue",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
