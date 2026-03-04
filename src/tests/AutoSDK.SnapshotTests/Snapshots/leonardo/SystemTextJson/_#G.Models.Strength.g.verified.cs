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
        VeryLow,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
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
                Strength.VeryLow => "VERY_LOW",
                Strength.Low => "LOW",
                Strength.Medium => "MEDIUM",
                Strength.High => "HIGH",
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
                "VERY_LOW" => Strength.VeryLow,
                "LOW" => Strength.Low,
                "MEDIUM" => Strength.Medium,
                "HIGH" => Strength.High,
                _ => null,
            };
        }
    }
}