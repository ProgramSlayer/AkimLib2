using AkimLib2.Core.Entities.Intruder.Params;
using AkimLib2.Core.Enums;

namespace WpfApp1.ViewModels;

public class IntruderVelocityParamsViewModel : BaseViewModel
{
    private readonly IntruderVelocityParams _intruderVelocityParams = new();

    public IntruderVelocityParamsViewModel(IntruderVelocityParams? intruderVelocityParams = null) 
    {
        if (intruderVelocityParams != null)
        {
            _intruderVelocityParams = intruderVelocityParams;
        }
    }

    public VelocityMeasureUnits VelocityMeasureUnit
    {
        get => _intruderVelocityParams.VelocityMeasureUnit;
        set
        {
            _intruderVelocityParams.VelocityMeasureUnit = value;
            OnPropertyChanged(nameof(VelocityMeasureUnit));
        }
    }

    public double VMin
    {
        get => _intruderVelocityParams.VMin;
        set
        {
            _intruderVelocityParams.VMin = value;
            OnPropertyChanged(nameof(VMin));
        }
    }

    public double VMax
    {
        get => _intruderVelocityParams.VMax;
        set
        {
            _intruderVelocityParams.VMax = value;
            OnPropertyChanged(nameof(VMax));
        }
    }
}