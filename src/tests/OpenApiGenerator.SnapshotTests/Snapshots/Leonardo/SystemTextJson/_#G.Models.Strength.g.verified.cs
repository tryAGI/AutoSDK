//HintName: G.Models.Strength.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When training using the PIXEL_ART model type, this influences the training strength.<br/>
    /// Default Value: MEDIUM
    /// </summary>
    public enum Strength
    {
        /// <summary>
        /// 
        /// </summary>
        VERYLOW,
        /// <summary>
        /// 
        /// </summary>
        LOW,
        /// <summary>
        /// 
        /// </summary>
        MEDIUM,
        /// <summary>
        /// 
        /// </summary>
        HIGH,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Strength value)
        {
            return value switch
            {
                Strength.VERYLOW => "VERY_LOW",
                Strength.LOW => "LOW",
                Strength.MEDIUM => "MEDIUM",
                Strength.HIGH => "HIGH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Strength? ToEnum(string value)
        {
            return value switch
            {
                "VERY_LOW" => Strength.VERYLOW,
                "LOW" => Strength.LOW,
                "MEDIUM" => Strength.MEDIUM,
                "HIGH" => Strength.HIGH,
                _ => null,
            };
        }
    }
}