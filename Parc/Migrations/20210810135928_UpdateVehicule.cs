using Microsoft.EntityFrameworkCore.Migrations;

namespace Parc.Migrations
{
    public partial class UpdateVehicule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicule_Visite_VisiteId1",
                table: "Vehicule");

            migrationBuilder.DropIndex(
                name: "IX_Vehicule_VisiteId1",
                table: "Vehicule");

            migrationBuilder.DropColumn(
                name: "AssurenceId",
                table: "Vehicule");

            migrationBuilder.DropColumn(
                name: "ParcId",
                table: "Vehicule");

            migrationBuilder.DropColumn(
                name: "VisiteId",
                table: "Vehicule");

            migrationBuilder.DropColumn(
                name: "VisiteId1",
                table: "Vehicule");

            migrationBuilder.AlterColumn<string>(
                name: "VehiculeId",
                table: "Visite",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaintenanceId",
                table: "Vehicule",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ChauffeurId",
                table: "Vehicule",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AssurenceNumero",
                table: "Vehicule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParcNom",
                table: "Vehicule",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Visite_VehiculeId",
                table: "Visite",
                column: "VehiculeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicule_AssurenceNumero",
                table: "Vehicule",
                column: "AssurenceNumero");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicule_ChauffeurId",
                table: "Vehicule",
                column: "ChauffeurId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicule_MaintenanceId",
                table: "Vehicule",
                column: "MaintenanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicule_ParcNom",
                table: "Vehicule",
                column: "ParcNom");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicule_Assurence_AssurenceNumero",
                table: "Vehicule",
                column: "AssurenceNumero",
                principalTable: "Assurence",
                principalColumn: "Numero",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicule_Chauffeur_ChauffeurId",
                table: "Vehicule",
                column: "ChauffeurId",
                principalTable: "Chauffeur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicule_Maintenance_MaintenanceId",
                table: "Vehicule",
                column: "MaintenanceId",
                principalTable: "Maintenance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicule_Parcs_ParcNom",
                table: "Vehicule",
                column: "ParcNom",
                principalTable: "Parcs",
                principalColumn: "Nom",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visite_Vehicule_VehiculeId",
                table: "Visite",
                column: "VehiculeId",
                principalTable: "Vehicule",
                principalColumn: "Matricule",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicule_Assurence_AssurenceNumero",
                table: "Vehicule");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicule_Chauffeur_ChauffeurId",
                table: "Vehicule");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicule_Maintenance_MaintenanceId",
                table: "Vehicule");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicule_Parcs_ParcNom",
                table: "Vehicule");

            migrationBuilder.DropForeignKey(
                name: "FK_Visite_Vehicule_VehiculeId",
                table: "Visite");

            migrationBuilder.DropIndex(
                name: "IX_Visite_VehiculeId",
                table: "Visite");

            migrationBuilder.DropIndex(
                name: "IX_Vehicule_AssurenceNumero",
                table: "Vehicule");

            migrationBuilder.DropIndex(
                name: "IX_Vehicule_ChauffeurId",
                table: "Vehicule");

            migrationBuilder.DropIndex(
                name: "IX_Vehicule_MaintenanceId",
                table: "Vehicule");

            migrationBuilder.DropIndex(
                name: "IX_Vehicule_ParcNom",
                table: "Vehicule");

            migrationBuilder.DropColumn(
                name: "AssurenceNumero",
                table: "Vehicule");

            migrationBuilder.DropColumn(
                name: "ParcNom",
                table: "Vehicule");

            migrationBuilder.AlterColumn<string>(
                name: "VehiculeId",
                table: "Visite",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaintenanceId",
                table: "Vehicule",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChauffeurId",
                table: "Vehicule",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssurenceId",
                table: "Vehicule",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ParcId",
                table: "Vehicule",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisiteId",
                table: "Vehicule",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VisiteId1",
                table: "Vehicule",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicule_VisiteId1",
                table: "Vehicule",
                column: "VisiteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicule_Visite_VisiteId1",
                table: "Vehicule",
                column: "VisiteId1",
                principalTable: "Visite",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
