namespace AkimLib2.Core.Entities.Intruder.Params;

// TODO: придумать названия свойств получше.
// Параметры автомобиля нарушителя
public class IntruderCarParams
{
    // Наличие автомобиля
    public bool HasCar { get; set; }

    // Вероятность бросить транспортное средство (0..1)
    public double VDrp { get; set; }

    // Увеличение скорости в Х раз
    public double VelocityIncreaseCoef { get; set; }
}
