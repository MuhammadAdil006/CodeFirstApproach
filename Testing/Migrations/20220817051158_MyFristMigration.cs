using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Testing.Migrations
{
    public partial class MyFristMigration : Migration
    {
        //Iske khayal me db ni bna huva

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Product",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
            //        Details = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Product", x => x.Id);
            //    });
        }


        //down wala galti se bhi delete ni krna chahty ha
        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropTable(
        //        name: "Product");
        //}
    }
}
