namespace AkimLib2.Core.Entities.Intruder.Params;

// Комплекция нарушителя
public class IntruderComplexionParams
{
    // Длина в полный рост (мм)
    public int LengthStandingMm { get; set; }
    
    // Длина в приседе (мм)
    public int LengthSquattingMm { get; set; }
    
    // Длина ползком (мм)
    public int LengthCrowlingMm { get; set; }

    // Высота в полный рост (мм)
    public int HeightStandingMm { get; set; }

    // Высота в приседе (мм)
    public int HeightSquattingMm { get; set; }

    // Высота ползком (мм)
    public int HeightCrowlingMm { get; set; }
    
    // Ширина в полный рост (мм)
    public int WidthStandingMm { get; set; }

    // Ширина в приседе (мм)
    public int WidthSquattingMm { get; set; }

    // Ширина ползком (мм)
    public int WidthCrowlingMm { get; set; }
}
