using AkimLib2.Core.Entities.Intruder;
using WpfApp1.ViewModels;

namespace WpfApp1.Helpers;

public static class ViewModelToModelMapper
{
    public static Intruder Map(IntruderViewModel vm) => new()
    {
        Id = vm.Id,
        Nm = vm.Nm,
        Tls = vm.Tls,
        VDro = vm.VDro,
        AccomplicesParams = new()
        {
            Soo = vm.Soo,
            Tdvrs = vm.Tdvrs,
            VVob = vm.VVob,
            VZad = vm.VZad,
        },
        CarParams = new()
        {
            HasCar = vm.HasCar,
            VDrp = vm.VDrp,
            VelocityIncreaseCoef = vm.VelocityIncreaseCoef,
        },
        ComplexionParams = new()
        {
            HeightCrowlingMm = vm.HeightCrowlingMm,
            HeightSquattingMm = vm.HeightSquattingMm,
            HeightStandingMm = vm.HeightStandingMm,
            LengthCrowlingMm = vm.LengthCrowlingMm,
            LengthSquattingMm = vm.LengthSquattingMm,
            LengthStandingMm = vm.LengthStandingMm,
            WidthCrowlingMm = vm.WidthCrowlingMm,
            WidthSquattingMm = vm.WidthSquattingMm,
            WidthStandingMm = vm.WidthStandingMm,
        },
        OsnH = new()
        {
            IsUsed = vm.OsnHIsUsed,
            ObstacleOvercomeTimeReduceCoef = vm.OsnHObstacleOvercomeTimeReduceCoef,
            VelocityReduceCoef = vm.OsnHVelocityReduceCoef,
        },
        OsnL = new()
        {
            IsUsed = vm.OsnLIsUsed,
            ObstacleOvercomeTimeReduceCoef = vm.OsnLObstacleOvercomeTimeReduceCoef,
            VelocityReduceCoef = vm.OsnLVelocityReduceCoef,
        },
        OsnM = new()
        {
            IsUsed = vm.OsnMIsUsed,
            ObstacleOvercomeTimeReduceCoef = vm.OsnMObstacleOvercomeTimeReduceCoef,
            VelocityReduceCoef = vm.OsnMVelocityReduceCoef,
        },
        PsychophysicalParams = new()
        {
            RunDistanceMax = vm.RunDistanceMax,
            RunDistanceMin = vm.RunDistanceMin,
            TerritoryKnowledge = vm.TerritoryKnowledge,
            VAir = vm.VAir,
            VHid = vm.VHid,
            VNap = vm.VNap,
            VOst = vm.VOst,
            VOtk = vm.VOtk,
            VSch = vm.VSch,
            VSup = vm.VSup
        },
        VelocityParams = new()
        {
            VelocityMeasureUnit = vm.VelocityMeasureUnit,
            VMax = vm.VMax,
            VMin = vm.VMin,
        },
    };
}
