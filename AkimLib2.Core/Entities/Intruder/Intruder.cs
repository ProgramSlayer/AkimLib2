using AkimLib2.Core.Base;
using AkimLib2.Core.Entities.Intruder.Params;

namespace AkimLib2.Core.Entities.Intruder;

public class Intruder : BaseEntity
{
    // Наименование
    public string? Nm { get; set; }

    //// Сигнатура элемента типа Нарушитель
    //public static ElemTypes ElemType => ElemTypes.Intruder;

    // Параметры скорости передвижения
    public IntruderVelocityParams VelocityParams { get; set; } = new();

    // Параметры сообщников
    public IntruderAccomplicesParams AccomplicesParams { get; set; } = new();

    // Психофизические параметры
    public IntruderPsychophysicalParams PsychophysicalParams { get; set; } = new();

    // Использование подручных средств
    public bool Tls { get; set; }

    // Легкое техническое оснащение
    public IntruderEquipmentParams OsnL { get; set; } = new();

    // Среднее техническое оснащение
    public IntruderEquipmentParams OsnM { get; set; } = new();

    // Тяжелое техническое оснащение
    public IntruderEquipmentParams OsnH { get; set; } = new();

    // Вероятность бросить часть технического оснащения (0..1)
    public double VDro { get; set; }

    // Параметры автомобиля
    public IntruderCarParams CarParams { get; set; } = new();

    // Параметры комлекции нарушителя
    public IntruderComplexionParams ComplexionParams { get; set; } = new();
}
