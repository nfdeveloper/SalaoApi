using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Atendimento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer_service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    amount_paid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    amount_to_be_paid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    scheduling_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    service_id = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    ClienteEntityId = table.Column<int>(type: "int", nullable: true),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    FuncionarioEntityId = table.Column<int>(type: "int", nullable: true),
                    payment_type_id = table.Column<int>(type: "int", nullable: false),
                    TipoPagamentoEntityId = table.Column<int>(type: "int", nullable: true),
                    service_status_id = table.Column<int>(type: "int", nullable: false),
                    StatusAtendimentoEntityId = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    user_create = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_update = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_customer_service_client_ClienteEntityId",
                        column: x => x.ClienteEntityId,
                        principalTable: "client",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_customer_service_employee_FuncionarioEntityId",
                        column: x => x.FuncionarioEntityId,
                        principalTable: "employee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_customer_service_payment_type_TipoPagamentoEntityId",
                        column: x => x.TipoPagamentoEntityId,
                        principalTable: "payment_type",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_customer_service_service_service_id",
                        column: x => x.service_id,
                        principalTable: "service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_customer_service_service_status_StatusAtendimentoEntityId",
                        column: x => x.StatusAtendimentoEntityId,
                        principalTable: "service_status",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_customer_service_ClienteEntityId",
                table: "customer_service",
                column: "ClienteEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_customer_service_FuncionarioEntityId",
                table: "customer_service",
                column: "FuncionarioEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_customer_service_service_id",
                table: "customer_service",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_service_StatusAtendimentoEntityId",
                table: "customer_service",
                column: "StatusAtendimentoEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_customer_service_TipoPagamentoEntityId",
                table: "customer_service",
                column: "TipoPagamentoEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer_service");
        }
    }
}
