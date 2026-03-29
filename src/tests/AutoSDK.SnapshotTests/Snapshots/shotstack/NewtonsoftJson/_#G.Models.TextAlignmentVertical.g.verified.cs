//HintName: G.Models.TextAlignmentVertical.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The vertical alignment of the text. Value must be one of: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`top`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`center`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`bottom`&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: center
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextAlignmentVertical
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bottom")]
        Bottom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="center")]
        Center,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="top")]
        Top,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextAlignmentVerticalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextAlignmentVertical value)
        {
            return value switch
            {
                TextAlignmentVertical.Bottom => "bottom",
                TextAlignmentVertical.Center => "center",
                TextAlignmentVertical.Top => "top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextAlignmentVertical? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => TextAlignmentVertical.Bottom,
                "center" => TextAlignmentVertical.Center,
                "top" => TextAlignmentVertical.Top,
                _ => null,
            };
        }
    }
}