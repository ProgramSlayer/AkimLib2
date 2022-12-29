namespace AkimLib2.Core.Entities.Intruder.Params;

// TODO: придумать названия свойств получше.
// Психофизические параметры нарушителя
public class IntruderPsychophysicalParams
{
    // Вероятность незаметного проникновения (профессионализм, осторожность) (0..1)
    public double VHid { get; set; }

    // Вероятность снижения осторожности (0..1)
    public double VOst { get; set; }

    // Вероятность отказа от проникновения (0..1)
    public double VOtk { get; set; }

    // Вероятность изменения скорости движения (0..1)
    public double VSch { get; set; }

    // Вероятность повышения скорости движения в случае решения изменить скорость (0..1)
    public double VSup { get; set; }

    // Вероятность смены направления движения при явной реакции СЗП (0..1)
    // Вероятность смены направления движения, если замечены сотрудники службы безопасности (0..1)
    public double VNap { get; set; }

    // Мин. дальность отбегания при смене направления движения
    public double RunDistanceMin { get; set; }

    // Макс. дальность отбегания при смене направления движения
    public double RunDistanceMax { get; set; }

    // Знание территории объекта, % (0..100)
    public int TerritoryKnowledge { get; set; }

    // Вероятность проникновения по воздушным конструкциям (0..1)
    public double VAir { get; set; }
}