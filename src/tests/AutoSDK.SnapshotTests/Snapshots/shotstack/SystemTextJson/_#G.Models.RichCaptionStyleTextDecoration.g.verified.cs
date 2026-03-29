//HintName: G.Models.RichCaptionStyleTextDecoration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text decoration to apply.<br/>
    /// Default Value: none<br/>
    /// Example: underline
    /// </summary>
    public enum RichCaptionStyleTextDecoration
    {
        /// <summary>
        /// 
        /// </summary>
        LineThrough,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Underline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichCaptionStyleTextDecorationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichCaptionStyleTextDecoration value)
        {
            return value switch
            {
                RichCaptionStyleTextDecoration.LineThrough => "line-through",
                RichCaptionStyleTextDecoration.None => "none",
                RichCaptionStyleTextDecoration.Underline => "underline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichCaptionStyleTextDecoration? ToEnum(string value)
        {
            return value switch
            {
                "line-through" => RichCaptionStyleTextDecoration.LineThrough,
                "none" => RichCaptionStyleTextDecoration.None,
                "underline" => RichCaptionStyleTextDecoration.Underline,
                _ => null,
            };
        }
    }
}