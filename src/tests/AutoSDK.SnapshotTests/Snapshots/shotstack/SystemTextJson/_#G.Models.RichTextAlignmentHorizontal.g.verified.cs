//HintName: G.Models.RichTextAlignmentHorizontal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The horizontal alignment of the text.<br/>
    /// Default Value: center<br/>
    /// Example: center
    /// </summary>
    public enum RichTextAlignmentHorizontal
    {
        /// <summary>
        /// 
        /// </summary>
        Center,
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichTextAlignmentHorizontalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichTextAlignmentHorizontal value)
        {
            return value switch
            {
                RichTextAlignmentHorizontal.Center => "center",
                RichTextAlignmentHorizontal.Left => "left",
                RichTextAlignmentHorizontal.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichTextAlignmentHorizontal? ToEnum(string value)
        {
            return value switch
            {
                "center" => RichTextAlignmentHorizontal.Center,
                "left" => RichTextAlignmentHorizontal.Left,
                "right" => RichTextAlignmentHorizontal.Right,
                _ => null,
            };
        }
    }
}