//HintName: G.Models.ColorPalettePresetName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A color palette preset value<br/>
    /// Example: PASTEL
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ColorPalettePresetName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EMBER")]
        Ember,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FRESH")]
        Fresh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="JUNGLE")]
        Jungle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MAGIC")]
        Magic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MELON")]
        Melon,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MOSAIC")]
        Mosaic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PASTEL")]
        Pastel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ULTRAMARINE")]
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