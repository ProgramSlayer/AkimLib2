using AkimLib2.Core.Entities.Intruder;
using AkimLib2.Core.Entities.Intruder.Params;
using AkimLib2.Core.Enums;
using System;

namespace WpfApp1.ViewModels;

public class IntruderViewModel : BaseViewModel
{
    private readonly Intruder _intruder = new();
    private static readonly VelocityMeasureUnits[] _velocityMeasureUnits = Enum.GetValues<VelocityMeasureUnits>();

    public IntruderViewModel() { }
    
    public IntruderViewModel(Intruder intruder)
    {
        _intruder = intruder;
    }

    private IntruderVelocityParams IntruderVelocityParams => _intruder.VelocityParams;

    private IntruderAccomplicesParams IntruderAccomplicesParams => _intruder.AccomplicesParams;
    
    private IntruderPsychophysicalParams IntruderPsychophysicalParams => _intruder.PsychophysicalParams;
    
    private IntruderEquipmentParams IntruderOsnL => _intruder.OsnL;
    
    private IntruderEquipmentParams IntruderOsnM => _intruder.OsnM;
    
    private IntruderEquipmentParams IntruderOsnH => _intruder.OsnH;
    
    private IntruderCarParams IntruderCarParams => _intruder.CarParams;
    
    private IntruderComplexionParams IntruderComplexionParams => _intruder.ComplexionParams;
    
    public static VelocityMeasureUnits[] VelocityMeasureUnits => _velocityMeasureUnits;

    public int Id => _intruder.Id;
    
    public string? Nm
    {
        get => _intruder.Nm;
        set
        {
            _intruder.Nm = value;
            OnPropertyChanged(nameof(Nm));
        }
    }

    public VelocityMeasureUnits VelocityMeasureUnit
    {
        get => IntruderVelocityParams.VelocityMeasureUnit;
        set
        {
            IntruderVelocityParams.VelocityMeasureUnit = value;
            OnPropertyChanged(nameof(VelocityMeasureUnit));
        }
    }

    public double VMin
    {
        get => IntruderVelocityParams.VMin;
        set
        {
            IntruderVelocityParams.VMin = value;
            OnPropertyChanged(nameof(VMin));
        }
    }

    public double VMax
    {
        get => IntruderVelocityParams.VMax;
        set
        {
            IntruderVelocityParams.VMax = value;
            OnPropertyChanged(nameof(VMax));
        }
    }

    public bool Soo
    {
        get => IntruderAccomplicesParams.Soo;
        set
        {
            IntruderAccomplicesParams.Soo = value;
            OnPropertyChanged(nameof(Soo));
        }
    }

    public double VZad
    {
        get => IntruderAccomplicesParams.VZad;
        set
        {
            IntruderAccomplicesParams.VZad = value;
            OnPropertyChanged(nameof(VZad));
        }
    }

    public double VVob
    {
        get => IntruderAccomplicesParams.VVob;
        set
        {
            IntruderAccomplicesParams.VVob = value;
            OnPropertyChanged(nameof(VVob));
        }
    }

    public double Tdvrs
    {
        get => IntruderAccomplicesParams.Tdvrs;
        set
        {
            IntruderAccomplicesParams.Tdvrs = value;
            OnPropertyChanged(nameof(Tdvrs));
        }
    }

    public double VHid
    {
        get => IntruderPsychophysicalParams.VHid;
        set
        {
            IntruderPsychophysicalParams.VHid = value;
            OnPropertyChanged(nameof(VHid));
        }
    }

    public double VOst
    {
        get => IntruderPsychophysicalParams.VOst;
        set
        {
            IntruderPsychophysicalParams.VOst = value;
            OnPropertyChanged(nameof(VOst));
        }
    }

    public double VOtk
    {
        get => IntruderPsychophysicalParams.VOtk;
        set
        {
            IntruderPsychophysicalParams.VOtk = value;
            OnPropertyChanged(nameof(VOtk));
        }
    }

    public double VSch
    {
        get => IntruderPsychophysicalParams.VSch;
        set
        {
            IntruderPsychophysicalParams.VSch = value;
            OnPropertyChanged(nameof(VSch));
        }
    }

    public double VSup
    {
        get => IntruderPsychophysicalParams.VSup; 
        set
        {
            IntruderPsychophysicalParams.VSup = value;
            OnPropertyChanged(nameof(VSup));
        }
    }

    public double VNap
    {
        get => IntruderPsychophysicalParams.VNap; 
        set
        {
            IntruderPsychophysicalParams.VNap = value;
            OnPropertyChanged(nameof(VNap));
        }
    }

    public double RunDistanceMin
    {
        get => IntruderPsychophysicalParams.RunDistanceMin; 
        set
        {
            IntruderPsychophysicalParams.RunDistanceMin = value;
            OnPropertyChanged(nameof(RunDistanceMin));
        }
    }

    public double RunDistanceMax
    {
        get => IntruderPsychophysicalParams.RunDistanceMax; 
        set
        {
            IntruderPsychophysicalParams.RunDistanceMax = value;
            OnPropertyChanged(nameof(RunDistanceMax));
        }
    }

    public int TerritoryKnowledge
    {
        get => IntruderPsychophysicalParams.TerritoryKnowledge; 
        set
        {
            IntruderPsychophysicalParams.TerritoryKnowledge = value;
            OnPropertyChanged(nameof(TerritoryKnowledge));
        }
    }

    public double VAir
    {
        get => IntruderPsychophysicalParams.VAir; 
        set
        {
            IntruderPsychophysicalParams.VAir = value;
            OnPropertyChanged(nameof(VAir));
        }
    }

    public bool Tls
    {
        get => _intruder.Tls;
        set
        {
            _intruder.Tls = value;
            OnPropertyChanged(nameof(Tls));
        }
    }

    public bool OsnLIsUsed
    {
        get => IntruderOsnL.IsUsed;
        set
        {
            IntruderOsnL.IsUsed = value;
            OnPropertyChanged(nameof(OsnLIsUsed));
        }
    }

    public double OsnLObstacleOvercomeTimeReduceCoef
    {
        get => IntruderOsnL.ObstacleOvercomeTimeReduceCoef; 
        set
        {
            IntruderOsnL.ObstacleOvercomeTimeReduceCoef = value;
            OnPropertyChanged(nameof(OsnLObstacleOvercomeTimeReduceCoef));
        }
    }

    public double OsnLVelocityReduceCoef
    {
        get => IntruderOsnL.VelocityReduceCoef; 
        set
        {
            IntruderOsnL.VelocityReduceCoef = value;
            OnPropertyChanged(nameof(OsnLVelocityReduceCoef));
        }
    }

    public bool OsnMIsUsed
    {
        get => IntruderOsnM.IsUsed;
        set
        {
            IntruderOsnM.IsUsed = value;
            OnPropertyChanged(nameof(OsnMIsUsed));
        }
    }
    public double OsnMObstacleOvercomeTimeReduceCoef
    {
        get => IntruderOsnM.ObstacleOvercomeTimeReduceCoef; 
        set
        {
            IntruderOsnM.ObstacleOvercomeTimeReduceCoef = value;
            OnPropertyChanged(nameof(OsnMObstacleOvercomeTimeReduceCoef));
        }
    }

    public double OsnMVelocityReduceCoef
    {
        get => IntruderOsnM.VelocityReduceCoef; 
        set
        {
            IntruderOsnM.VelocityReduceCoef = value;
            OnPropertyChanged(nameof(OsnMVelocityReduceCoef));
        }
    }

    public bool OsnHIsUsed
    {
        get => IntruderOsnH.IsUsed;
        set
        {
            IntruderOsnH.IsUsed = value;
            OnPropertyChanged(nameof(OsnHIsUsed));
        }
    }
    public double OsnHObstacleOvercomeTimeReduceCoef
    {
        get => IntruderOsnH.ObstacleOvercomeTimeReduceCoef; 
        set
        {
            IntruderOsnH.ObstacleOvercomeTimeReduceCoef = value;
            OnPropertyChanged(nameof(OsnHObstacleOvercomeTimeReduceCoef));
        }
    }

    public double OsnHVelocityReduceCoef
    {
        get => IntruderOsnH.VelocityReduceCoef; 
        set
        {
            IntruderOsnH.VelocityReduceCoef = value;
            OnPropertyChanged(nameof(OsnHVelocityReduceCoef));
        }
    }

    public bool HasCar
    {
        get => IntruderCarParams.HasCar;
        set
        {
            IntruderCarParams.HasCar = value;
            OnPropertyChanged(nameof(HasCar));
        }
    }

    public double VDrp
    {
        get => IntruderCarParams.VDrp;
        set
        {
            IntruderCarParams.VDrp = value;
            OnPropertyChanged(nameof(VDrp));
        }
    }

    public double VelocityIncreaseCoef
    {
        get => IntruderCarParams.VelocityIncreaseCoef;
        set
        {
            IntruderCarParams.VelocityIncreaseCoef = value;
            OnPropertyChanged(nameof(VelocityIncreaseCoef));
        }
    }

    public int LengthStandingMm
    {
        get => IntruderComplexionParams.LengthStandingMm;
        set
        {
            IntruderComplexionParams.LengthStandingMm = value;
            OnPropertyChanged(nameof(LengthStandingMm));
        }
    }

    public int LengthSquattingMm
    {
        get => IntruderComplexionParams.LengthSquattingMm;
        set
        {
            IntruderComplexionParams.LengthSquattingMm = value;
            OnPropertyChanged(nameof(LengthSquattingMm));
        }
    }

    public int LengthCrowlingMm
    {
        get => IntruderComplexionParams.LengthCrowlingMm;
        set
        {
            IntruderComplexionParams.LengthCrowlingMm = value;
            OnPropertyChanged(nameof(LengthCrowlingMm));
        }
    }

    public int HeightStandingMm
    {
        get => IntruderComplexionParams.HeightStandingMm;
        set
        {
            IntruderComplexionParams.HeightStandingMm = value;
            OnPropertyChanged(nameof(HeightStandingMm));
        }
    }

    public int HeightSquattingMm
    {
        get => IntruderComplexionParams.HeightSquattingMm;
        set
        {
            IntruderComplexionParams.HeightSquattingMm = value;
            OnPropertyChanged(nameof(HeightSquattingMm));
        }
    }

    public int HeightCrowlingMm
    {
        get => IntruderComplexionParams.HeightCrowlingMm;
        set
        {
            IntruderComplexionParams.HeightCrowlingMm = value;
            OnPropertyChanged(nameof(HeightCrowlingMm));
        }
    }

    public int WidthStandingMm
    {
        get => IntruderComplexionParams.WidthStandingMm;
        set
        {
            IntruderComplexionParams.WidthStandingMm = value;
            OnPropertyChanged(nameof(WidthStandingMm));
        }
    }

    public int WidthSquattingMm
    {
        get => IntruderComplexionParams.WidthSquattingMm;
        set
        {
            IntruderComplexionParams.WidthSquattingMm = value;
            OnPropertyChanged(nameof(WidthSquattingMm));
        }
    }

    public int WidthCrowlingMm
    {
        get => IntruderComplexionParams.WidthCrowlingMm;
        set
        {
            IntruderComplexionParams.WidthCrowlingMm = value;
            OnPropertyChanged(nameof(WidthCrowlingMm));
        }
    }

    public double VDro
    {
        get => _intruder.VDro;
        set
        {
            _intruder.VDro = value;
            OnPropertyChanged(nameof(VDro));
        }
    }

}
