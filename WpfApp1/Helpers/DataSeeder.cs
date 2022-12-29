using AkimLib2.Core.Entities.Intruder;
using AkimLib2.Core.Enums;
using System;
using System.Collections.Generic;
using WpfApp1.Context;

namespace WpfApp1.Helpers;

public static class DataSeeder
{
    public static readonly Random rnd = new();
    public static async void Seed(AkimLib2DbContext context)
    {
        List<Intruder> intruders = new();
        int firstVmu = (int)VelocityMeasureUnits.KilometersPerHour;
        int lastVmu = (int)VelocityMeasureUnits.Undefined;
        Random rnd = new();
        for (int i = 1; i <= 10000; i++)
        {
            var vmu = (VelocityMeasureUnits)rnd.Next(firstVmu, lastVmu);

            var vMin = rnd.NextDouble() * 10d;
            var vMax = vMin + rnd.NextDouble() * 10d;

            var soo = rnd.Next(2) != 0;
            var vZad = rnd.NextDouble();
            var vVob = rnd.NextDouble();
            var tdvrs = rnd.NextDouble();

            var vHid = rnd.NextDouble();
            var vOst = rnd.NextDouble();
            var vOtk = rnd.NextDouble();
            var vSch = rnd.NextDouble();
            var vSup = rnd.NextDouble();
            var vNap = rnd.NextDouble();
            var runDistMin = rnd.NextDouble() * 10d;
            var runDistMax = runDistMin + rnd.NextDouble() * 100d;
            var terrKnowledge = rnd.Next(101);
            var vAir = rnd.NextDouble();

            var tls = rnd.Next(2) != 0;

            var osnlIsUsed = rnd.Next(2) != 0;
            var osnlObstacleOvercomeTimeReduceCoef = osnlIsUsed ? rnd.NextDouble() * 10d : 0d;
            var osnlVelocityReduceCoef = osnlIsUsed ? rnd.NextDouble() * 10d : 0d;

            var osnmIsUsed = rnd.Next(2) != 0;
            var osnmObstacleOvercomeTimeReduceCoef = osnmIsUsed ? rnd.NextDouble() * 10d : 0d;
            var osnmVelocityReduceCoef = osnmIsUsed ? rnd.NextDouble() * 10d : 0d;

            var osnhIsUsed = rnd.Next(2) != 0;
            var osnhObstacleOvercomeTimeReduceCoef = osnhIsUsed ? rnd.NextDouble() * 10d : 0d;
            var osnhVelocityReduceCoef = osnhIsUsed ? rnd.NextDouble() * 10d : 0d;

            var vDro = rnd.NextDouble();

            var hasCar = rnd.Next(2) != 0;
            var vDrp = hasCar ? rnd.NextDouble() : 0d;
            var velocityIncreaseCoef = hasCar ? rnd.NextDouble() * 10d : 0d;

            int lengthStandingMm = rnd.Next(0, 100000);
            int lengthSquattingMm = rnd.Next(0, 100000);
            int lengthCrowlingMm = rnd.Next(0, 100000);
            int heightStandingMm = rnd.Next(0, 100000);
            int heightSquattingMm = rnd.Next(0, 100000);
            int heightCrowlingMm = rnd.Next(0, 100000);
            int widthStandingMm = rnd.Next(0, 100000);
            int widthSquattingMm = rnd.Next(0, 100000);
            int widthCrowlingMm = rnd.Next(0, 100000);

            Intruder intruder = new()
            {
                Nm = $"Test Intruder {i}",
                VelocityParams = new()
                {
                    VelocityMeasureUnit = vmu,
                    VMin = vMin,
                    VMax = vMax,
                },
                AccomplicesParams = new()
                {
                    Soo = soo,
                    VZad = vZad,
                    VVob = vVob,
                    Tdvrs = tdvrs,
                },
                PsychophysicalParams = new()
                {
                    VHid = vHid,
                    VOst = vOst,
                    VOtk = vOtk,
                    VSch = vSch,
                    VSup = vSup,
                    VNap = vNap,
                    RunDistanceMin = runDistMin,
                    RunDistanceMax = runDistMax,
                    TerritoryKnowledge = terrKnowledge,
                    VAir = vAir,
                },
                Tls = tls,
                OsnL = new()
                {
                    IsUsed = osnlIsUsed,
                    ObstacleOvercomeTimeReduceCoef = osnlObstacleOvercomeTimeReduceCoef,
                    VelocityReduceCoef = osnlVelocityReduceCoef,
                },
                OsnM = new()
                {
                    IsUsed = osnmIsUsed,
                    ObstacleOvercomeTimeReduceCoef = osnmObstacleOvercomeTimeReduceCoef,
                    VelocityReduceCoef = osnmVelocityReduceCoef,
                },
                OsnH = new()
                {
                    IsUsed = osnhIsUsed,
                    ObstacleOvercomeTimeReduceCoef = osnhObstacleOvercomeTimeReduceCoef,
                    VelocityReduceCoef = osnhVelocityReduceCoef,
                },
                VDro = vDro,
                CarParams = new()
                {
                    HasCar = hasCar,
                    VDrp = vDrp,
                    VelocityIncreaseCoef = velocityIncreaseCoef,
                },
                ComplexionParams = new()
                {
                    LengthStandingMm = lengthStandingMm,
                    LengthSquattingMm = lengthSquattingMm,
                    LengthCrowlingMm = lengthCrowlingMm,
                    HeightStandingMm = heightStandingMm,
                    HeightSquattingMm = heightSquattingMm,
                    HeightCrowlingMm = heightCrowlingMm,
                    WidthStandingMm = widthStandingMm,
                    WidthSquattingMm = widthSquattingMm,
                    WidthCrowlingMm = widthCrowlingMm,
                },
            };

            intruders.Add(intruder);
        }

        await context.Intruders.AddRangeAsync(intruders);
        await context.SaveChangesAsync();
    }
}
