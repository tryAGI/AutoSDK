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
        EMBER,
        /// <summary>
        /// 
        /// </summary>
        FRESH,
        /// <summary>
        /// 
        /// </summary>
        JUNGLE,
        /// <summary>
        /// 
        /// </summary>
        MAGIC,
        /// <summary>
        /// 
        /// </summary>
        MELON,
        /// <summary>
        /// 
        /// </summary>
        MOSAIC,
        /// <summary>
        /// 
        /// </summary>
        PASTEL,
        /// <summary>
        /// 
        /// </summary>
        ULTRAMARINE,
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
                ColorPalettePresetName.EMBER => "EMBER",
                ColorPalettePresetName.FRESH => "FRESH",
                ColorPalettePresetName.JUNGLE => "JUNGLE",
                ColorPalettePresetName.MAGIC => "MAGIC",
                ColorPalettePresetName.MELON => "MELON",
                ColorPalettePresetName.MOSAIC => "MOSAIC",
                ColorPalettePresetName.PASTEL => "PASTEL",
                ColorPalettePresetName.ULTRAMARINE => "ULTRAMARINE",
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
                "EMBER" => ColorPalettePresetName.EMBER,
                "FRESH" => ColorPalettePresetName.FRESH,
                "JUNGLE" => ColorPalettePresetName.JUNGLE,
                "MAGIC" => ColorPalettePresetName.MAGIC,
                "MELON" => ColorPalettePresetName.MELON,
                "MOSAIC" => ColorPalettePresetName.MOSAIC,
                "PASTEL" => ColorPalettePresetName.PASTEL,
                "ULTRAMARINE" => ColorPalettePresetName.ULTRAMARINE,
                _ => null,
            };
        }
    }
}