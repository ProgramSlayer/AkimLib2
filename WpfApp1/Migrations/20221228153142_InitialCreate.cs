using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfApp1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Intruder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nm = table.Column<string>(type: "TEXT", nullable: true),
                    VelocityParamsVelocityMeasureUnit = table.Column<int>(name: "VelocityParams_VelocityMeasureUnit", type: "INTEGER", nullable: false),
                    VelocityParamsVMin = table.Column<double>(name: "VelocityParams_VMin", type: "REAL", nullable: false),
                    VelocityParamsVMax = table.Column<double>(name: "VelocityParams_VMax", type: "REAL", nullable: false),
                    AccomplicesParamsSoo = table.Column<bool>(name: "AccomplicesParams_Soo", type: "INTEGER", nullable: false),
                    AccomplicesParamsVZad = table.Column<double>(name: "AccomplicesParams_VZad", type: "REAL", nullable: false),
                    AccomplicesParamsVVob = table.Column<double>(name: "AccomplicesParams_VVob", type: "REAL", nullable: false),
                    AccomplicesParamsTdvrs = table.Column<double>(name: "AccomplicesParams_Tdvrs", type: "REAL", nullable: false),
                    PsychophysicalParamsVHid = table.Column<double>(name: "PsychophysicalParams_VHid", type: "REAL", nullable: false),
                    PsychophysicalParamsVOst = table.Column<double>(name: "PsychophysicalParams_VOst", type: "REAL", nullable: false),
                    PsychophysicalParamsVOtk = table.Column<double>(name: "PsychophysicalParams_VOtk", type: "REAL", nullable: false),
                    PsychophysicalParamsVSch = table.Column<double>(name: "PsychophysicalParams_VSch", type: "REAL", nullable: false),
                    PsychophysicalParamsVSup = table.Column<double>(name: "PsychophysicalParams_VSup", type: "REAL", nullable: false),
                    PsychophysicalParamsVNap = table.Column<double>(name: "PsychophysicalParams_VNap", type: "REAL", nullable: false),
                    PsychophysicalParamsRunDistanceMin = table.Column<double>(name: "PsychophysicalParams_RunDistanceMin", type: "REAL", nullable: false),
                    PsychophysicalParamsRunDistanceMax = table.Column<double>(name: "PsychophysicalParams_RunDistanceMax", type: "REAL", nullable: false),
                    PsychophysicalParamsTerritoryKnowledge = table.Column<int>(name: "PsychophysicalParams_TerritoryKnowledge", type: "INTEGER", nullable: false),
                    PsychophysicalParamsVAir = table.Column<double>(name: "PsychophysicalParams_VAir", type: "REAL", nullable: false),
                    Tls = table.Column<bool>(type: "INTEGER", nullable: false),
                    OsnLIsUsed = table.Column<bool>(name: "OsnL_IsUsed", type: "INTEGER", nullable: false),
                    OsnLObstacleOvercomeTimeReduceCoef = table.Column<double>(name: "OsnL_ObstacleOvercomeTimeReduceCoef", type: "REAL", nullable: false),
                    OsnLVelocityReduceCoef = table.Column<double>(name: "OsnL_VelocityReduceCoef", type: "REAL", nullable: false),
                    OsnMIsUsed = table.Column<bool>(name: "OsnM_IsUsed", type: "INTEGER", nullable: false),
                    OsnMObstacleOvercomeTimeReduceCoef = table.Column<double>(name: "OsnM_ObstacleOvercomeTimeReduceCoef", type: "REAL", nullable: false),
                    OsnMVelocityReduceCoef = table.Column<double>(name: "OsnM_VelocityReduceCoef", type: "REAL", nullable: false),
                    OsnHIsUsed = table.Column<bool>(name: "OsnH_IsUsed", type: "INTEGER", nullable: false),
                    OsnHObstacleOvercomeTimeReduceCoef = table.Column<double>(name: "OsnH_ObstacleOvercomeTimeReduceCoef", type: "REAL", nullable: false),
                    OsnHVelocityReduceCoef = table.Column<double>(name: "OsnH_VelocityReduceCoef", type: "REAL", nullable: false),
                    VDro = table.Column<double>(type: "REAL", nullable: false),
                    CarParamsHasCar = table.Column<bool>(name: "CarParams_HasCar", type: "INTEGER", nullable: false),
                    CarParamsVDrp = table.Column<double>(name: "CarParams_VDrp", type: "REAL", nullable: false),
                    CarParamsVelocityIncreaseCoef = table.Column<double>(name: "CarParams_VelocityIncreaseCoef", type: "REAL", nullable: false),
                    ComplexionParamsLengthStandingMm = table.Column<int>(name: "ComplexionParams_LengthStandingMm", type: "INTEGER", nullable: false),
                    ComplexionParamsLengthSquattingMm = table.Column<int>(name: "ComplexionParams_LengthSquattingMm", type: "INTEGER", nullable: false),
                    ComplexionParamsLengthCrowlingMm = table.Column<int>(name: "ComplexionParams_LengthCrowlingMm", type: "INTEGER", nullable: false),
                    ComplexionParamsHeightStandingMm = table.Column<int>(name: "ComplexionParams_HeightStandingMm", type: "INTEGER", nullable: false),
                    ComplexionParamsHeightSquattingMm = table.Column<int>(name: "ComplexionParams_HeightSquattingMm", type: "INTEGER", nullable: false),
                    ComplexionParamsHeightCrowlingMm = table.Column<int>(name: "ComplexionParams_HeightCrowlingMm", type: "INTEGER", nullable: false),
                    ComplexionParamsWidthStandingMm = table.Column<int>(name: "ComplexionParams_WidthStandingMm", type: "INTEGER", nullable: false),
                    ComplexionParamsWidthSquattingMm = table.Column<int>(name: "ComplexionParams_WidthSquattingMm", type: "INTEGER", nullable: false),
                    ComplexionParamsWidthCrowlingMm = table.Column<int>(name: "ComplexionParams_WidthCrowlingMm", type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intruder", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Intruder");
        }
    }
}
