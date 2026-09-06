//HintName: G.Models.CaptionStyleModelTextStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleModelTextStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Italic,
        /// <summary>
        /// 
        /// </summary>
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleModelTextStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleModelTextStyle value)
        {
            return value switch
            {
                CaptionStyleModelTextStyle.Italic => "italic",
                CaptionStyleModelTextStyle.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleModelTextStyle? ToEnum(string value)
        {
            return value switch
            {
                "italic" => CaptionStyleModelTextStyle.Italic,
                "normal" => CaptionStyleModelTextStyle.Normal,
                _ => null,
            };
        }
    }
}