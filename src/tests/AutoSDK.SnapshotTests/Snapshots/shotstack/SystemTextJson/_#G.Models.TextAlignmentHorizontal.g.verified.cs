//HintName: G.Models.TextAlignmentHorizontal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The horizontal alignment of the text. Value must be one of: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`left`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`center`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`right`&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: center
    /// </summary>
    public enum TextAlignmentHorizontal
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
    public static class TextAlignmentHorizontalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextAlignmentHorizontal value)
        {
            return value switch
            {
                TextAlignmentHorizontal.Center => "center",
                TextAlignmentHorizontal.Left => "left",
                TextAlignmentHorizontal.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextAlignmentHorizontal? ToEnum(string value)
        {
            return value switch
            {
                "center" => TextAlignmentHorizontal.Center,
                "left" => TextAlignmentHorizontal.Left,
                "right" => TextAlignmentHorizontal.Right,
                _ => null,
            };
        }
    }
}