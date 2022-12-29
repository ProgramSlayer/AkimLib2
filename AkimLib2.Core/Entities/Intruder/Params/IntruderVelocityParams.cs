using AkimLib2.Core.Enums;

namespace AkimLib2.Core.Entities.Intruder.Params;

// TODO: придумать названия свойст получше.
// Параметры скорости передвижения нарушителя
public class IntruderVelocityParams
{
    // Единица измерения
    public VelocityMeasureUnits VelocityMeasureUnit { get; set; }

    // Минимальная скорость передвижения (км/ч)
    public double VMin { get; set; }

    // Максимальная скорость передвижения (км/ч)
    public double VMax { get; set; }
}
