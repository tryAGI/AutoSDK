//HintName: G.Models.CaptionStyleModelTextWeight2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleModelTextWeight2
    {
        /// <summary>
        /// 
        /// </summary>
        Bold,
        /// <summary>
        /// 
        /// </summary>
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleModelTextWeight2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleModelTextWeight2 value)
        {
            return value switch
            {
                CaptionStyleModelTextWeight2.Bold => "bold",
                CaptionStyleModelTextWeight2.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleModelTextWeight2? ToEnum(string value)
        {
            return value switch
            {
                "bold" => CaptionStyleModelTextWeight2.Bold,
                "normal" => CaptionStyleModelTextWeight2.Normal,
                _ => null,
            };
        }
    }
}