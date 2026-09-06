//HintName: G.Models.CaptionStyleModelTextWeight.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleModelTextWeight
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
    public static class CaptionStyleModelTextWeightExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleModelTextWeight value)
        {
            return value switch
            {
                CaptionStyleModelTextWeight.Bold => "bold",
                CaptionStyleModelTextWeight.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleModelTextWeight? ToEnum(string value)
        {
            return value switch
            {
                "bold" => CaptionStyleModelTextWeight.Bold,
                "normal" => CaptionStyleModelTextWeight.Normal,
                _ => null,
            };
        }
    }
}