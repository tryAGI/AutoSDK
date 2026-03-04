//HintName: G.Models.ColorPalettePresetName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A color palette preset value<br/>
    /// Example: PASTEL
    /// </summary>
    public enum ColorPalettePresetName
    {
        /// <summary>
        /// 
        /// </summary>
        Ember,
        /// <summary>
        /// 
        /// </summary>
        Fresh,
        /// <summary>
        /// 
        /// </summary>
        Jungle,
        /// <summary>
        /// 
        /// </summary>
        Magic,
        /// <summary>
        /// 
        /// </summary>
        Melon,
        /// <summary>
        /// 
        /// </summary>
        Mosaic,
        /// <summary>
        /// 
        /// </summary>
        Pastel,
        /// <summary>
        /// 
        /// </summary>
        Ultramarine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ColorPalettePresetNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColorPalettePresetName value)
        {
            return value switch
            {
                ColorPalettePresetName.Ember => "EMBER",
                ColorPalettePresetName.Fresh => "FRESH",
                ColorPalettePresetName.Jungle => "JUNGLE",
                ColorPalettePresetName.Magic => "MAGIC",
                ColorPalettePresetName.Melon => "MELON",
                ColorPalettePresetName.Mosaic => "MOSAIC",
                ColorPalettePresetName.Pastel => "PASTEL",
                ColorPalettePresetName.Ultramarine => "ULTRAMARINE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColorPalettePresetName? ToEnum(string value)
        {
            return value switch
            {
                "EMBER" => ColorPalettePresetName.Ember,
                "FRESH" => ColorPalettePresetName.Fresh,
                "JUNGLE" => ColorPalettePresetName.Jungle,
                "MAGIC" => ColorPalettePresetName.Magic,
                "MELON" => ColorPalettePresetName.Melon,
                "MOSAIC" => ColorPalettePresetName.Mosaic,
                "PASTEL" => ColorPalettePresetName.Pastel,
                "ULTRAMARINE" => ColorPalettePresetName.Ultramarine,
                _ => null,
            };
        }
    }
}