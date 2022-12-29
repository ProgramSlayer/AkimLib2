﻿namespace AkimLib2.Core.Entities.Intruder.Params;

// TODO: придумать названия свойств получше.
// Параметры сообщников нарушителя
public class IntruderAccomplicesParams
{
    // Наличие сообщников
    public bool Soo { get; set; }

    // Вероятность снижения задержки на элементах СЗП в 2 раза (0..1)
    // Вероятность снижения задержки на элементах ИСО в 2 раза (0..1)
    public double VZad { get; set; }

    // Вероятность снижения вероятности обнаружения извещателями ТСО в 2 раза (0..1)
    // Вероятность снижения обнаруживающей способности извещателей в 2 раза (0..1)
    public double VVob { get; set; }

    // Среднее время до выдачи умышленной ложной тревоги (ч)
    public double Tdvrs { get; set; }
}