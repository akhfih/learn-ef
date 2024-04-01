using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnEF.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "m_customer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_name = table.Column<string>(type: "NVarchar(50)", nullable: false),
                    address = table.Column<string>(type: "NVarchar(250)", nullable: false),
                    mobile_phone = table.Column<string>(type: "NVarchar(14)", nullable: false),
                    email = table.Column<string>(type: "NVarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_customer", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "m_customer");
        }
    }
}
