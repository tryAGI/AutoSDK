//HintName: G.Models.LivekitStackType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LivekitStackType
    {
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LivekitStackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LivekitStackType value)
        {
            return value switch
            {
                LivekitStackType.Standard => "standard",
                LivekitStackType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LivekitStackType? ToEnum(string value)
        {
            return value switch
            {
                "standard" => LivekitStackType.Standard,
                "static" => LivekitStackType.Static,
                _ => null,
            };
        }
    }
}