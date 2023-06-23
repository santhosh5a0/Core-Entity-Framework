using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System;

#nullable disable

namespace EFCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class _23062023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Create Table
            migrationBuilder.CreateTable(
               name: "Leagues",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Leagues", x => x.Id);
               });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeagueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //Create Index
            migrationBuilder.CreateIndex(
            name: "IX_Teams_LeagueId",
                table: "Teams",
                column: "LeagueId");

//            1 > give command package console manager "add-migration 22022023"




//2 > Create Table and create another table with Foreign key




//Up method: 

 

//migrationBuilder.CreateTable(

//                name: "Leagues",

//                columns: table => new

//                {

//                    Id = table.Column<int>(type: "int", nullable: false)

//                        .Annotation("SqlServer:Identity", "1, 1"),

//                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),

//                    Active = table.Column<string>(type: "bit", nullable: true)

//                },

//                constraints: table =>

//                {

//                    table.PrimaryKey("PK_Leagues", x => x.Id);

//                });



//            migrationBuilder.CreateTable(

//                name: "Teams",

//                columns: table => new

//                {

//                    Id = table.Column<int>(type: "int", nullable: false)

//                        .Annotation("SqlServer:Identity", "1, 1"),

//                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),

//                    LeagueId = table.Column<int>(type: "int", nullable: false)

//                },

//                constraints: table =>

//                {

//                    table.PrimaryKey("PK_Teams", x => x.Id);

//                    table.ForeignKey(

//                        name: "FK_Teams_Leagues_LeagueId",

//                        column: x => x.LeagueId,

//                        principalTable: "Leagues",

//                        principalColumn: "Id",

//                        onDelete: ReferentialAction.Cascade);

//                });





//            Down method: 

//  migrationBuilder.DropTable(

//                name: "Teams");



//            migrationBuilder.DropTable(

//                name: "Leagues");



//            3 > Create Index

//   migrationBuilder.CreateIndex(

//                name: "IX_Teams_LeagueId",

//                table: "Teams",

//                column: "LeagueId");





//            4 > Create Function or View




//  migrationBuilder.Sql(@"CREATE FUNCTION [dbo].[GetEarliestMatch] (@teamId int) 

//                                RETURNS datetime 

//                                BEGIN 

//                                DECLARE @result datetime 

//                                SELECT TOP 1 @result = date 

//                                FROM [dbo].[Matches] 

//                                order by Date 

//                                return @result 

//                                END");

//            migrationBuilder.Sql(@"CREATE VIEW [dbo].[TeamsCoachesLeagues] 

//AS 

//SELECT t.Name, c.Name AS CoachName, l.Name AS LeagueName 

//FROM  dbo.Teams AS t LEFT OUTER JOIN 

//dbo.Coaches AS c ON t.Id = c.TeamId INNER JOIN 

//dbo.Leagues AS l ON t.LeagueId = l.Id"
            



//            Down method
            

//            migrationBuilder.Sql(@"DROP VIEW [dbo].[TeamsCoachesLeagues]");

//            migrationBuilder.Sql(@"DROP Function [dbo].[GetEarliestMatch]");





//            5 > Create Stored Procedure




//migrationBuilder.Sql(@"CREATE PROCEDURE sp_GetTeamCoach 

//                                @teamId int  

//                                AS 

//                                BEGIN 

//                                SELECT * from Coaches where TeamId = @teamid 

//                                END");



//            migrationBuilder.Sql(@"DROP PROCEDURE [dbo].[sp_CoachName]");





//            6 > Insert Data Into tables




//migrationBuilder.InsertData(

//                table: "Leagues",

//                columns: new[] { "Id", "Name" },

//                values: new object[] { 20, "Sample League" });



//            Down method

//  migrationBuilder.DeleteData(

//                table: "Leagues",

//                keyColumn: "Id",

//                keyValue: 20);





//            7 > Add column to existing table




//   migrationBuilder.AddColumn<string>(

//                name: "CreatedBy",

//                table: "Teams",
//            type: "nvarchar(max)",

//                nullable: true);



//            Down

//migrationBuilder.DropColumn(

//                name: "CreatedBy",

//                table: "Teams");



//            8 > Alter Column in existing Column




//  migrationBuilder.AlterColumn<string>(

//                name: "Name",

//                table: "Teams",

//                type: "nvarchar(50)",

//                maxLength: 50,

//                nullable: true,

//                oldClrType: typeof(string),

//                oldType: "nvarchar(max)",

//                oldNullable: true);



//            Down method: 

 

//migrationBuilder.AlterColumn<string>(

//                name: "Name",

//                table: "Teams",

//                type: "nvarchar(max)",

//                nullable: true,

//                oldClrType: typeof(string),

//                oldType: "nvarchar(50)",

//                oldMaxLength: 50,

//                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Leagues");
        }
    }
}
