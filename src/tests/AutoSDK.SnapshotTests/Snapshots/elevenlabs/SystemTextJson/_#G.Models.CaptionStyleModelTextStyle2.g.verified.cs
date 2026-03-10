//HintName: G.Models.CaptionStyleModelTextStyle2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleModelTextStyle2
    {
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Italic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleModelTextStyle2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleModelTextStyle2 value)
        {
            return value switch
            {
                CaptionStyleModelTextStyle2.Normal => "normal",
                CaptionStyleModelTextStyle2.Italic => "italic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleModelTextStyle2? ToEnum(string value)
        {
            return value switch
            {
                "normal" => CaptionStyleModelTextStyle2.Normal,
                "italic" => CaptionStyleModelTextStyle2.Italic,
                _ => null,
            };
        }
    }
}