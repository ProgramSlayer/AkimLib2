namespace AkimLib2.Core.Entities.Intruder.Params;

// Параметры одного из видов технического оснащения нарушителя
public class IntruderEquipmentParams
{
    // Использование оснащения
    public bool IsUsed { get; set; }

    // TODO: придумать название получше.
    // Снижение времени преодоления препятствий в Х раз
    public double ObstacleOvercomeTimeReduceCoef { get; set; }

    // TODO: придумать название получше.
    // Снижение скорости движения в Х раз
    public double VelocityReduceCoef { get; set; }
}
