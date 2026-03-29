//HintName: G.Models.RichTextStyleTextDecoration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text decoration to apply.<br/>
    /// Default Value: none<br/>
    /// Example: underline
    /// </summary>
    public enum RichTextStyleTextDecoration
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
    public static class RichTextStyleTextDecorationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichTextStyleTextDecoration value)
        {
            return value switch
            {
                RichTextStyleTextDecoration.LineThrough => "line-through",
                RichTextStyleTextDecoration.None => "none",
                RichTextStyleTextDecoration.Underline => "underline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichTextStyleTextDecoration? ToEnum(string value)
        {
            return value switch
            {
                "line-through" => RichTextStyleTextDecoration.LineThrough,
                "none" => RichTextStyleTextDecoration.None,
                "underline" => RichTextStyleTextDecoration.Underline,
                _ => null,
            };
        }
    }
}