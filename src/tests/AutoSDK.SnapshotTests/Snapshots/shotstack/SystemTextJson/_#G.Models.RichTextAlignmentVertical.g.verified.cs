//HintName: G.Models.RichTextAlignmentVertical.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The vertical alignment of the text within the bounding box.<br/>
    /// Default Value: middle<br/>
    /// Example: middle
    /// </summary>
    public enum RichTextAlignmentVertical
    {
        /// <summary>
        /// 
        /// </summary>
        Bottom,
        /// <summary>
        /// 
        /// </summary>
        Middle,
        /// <summary>
        /// 
        /// </summary>
        Top,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichTextAlignmentVerticalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichTextAlignmentVertical value)
        {
            return value switch
            {
                RichTextAlignmentVertical.Bottom => "bottom",
                RichTextAlignmentVertical.Middle => "middle",
                RichTextAlignmentVertical.Top => "top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichTextAlignmentVertical? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => RichTextAlignmentVertical.Bottom,
                "middle" => RichTextAlignmentVertical.Middle,
                "top" => RichTextAlignmentVertical.Top,
                _ => null,
            };
        }
    }
}