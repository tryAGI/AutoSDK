//HintName: G.Models.RichCaptionActiveFontTextDecoration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text decoration to apply to the active word.<br/>
    /// Default Value: none<br/>
    /// Example: underline
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RichCaptionActiveFontTextDecoration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="line-through")]
        LineThrough,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="underline")]
        Underline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichCaptionActiveFontTextDecorationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichCaptionActiveFontTextDecoration value)
        {
            return value switch
            {
                RichCaptionActiveFontTextDecoration.LineThrough => "line-through",
                RichCaptionActiveFontTextDecoration.None => "none",
                RichCaptionActiveFontTextDecoration.Underline => "underline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichCaptionActiveFontTextDecoration? ToEnum(string value)
        {
            return value switch
            {
                "line-through" => RichCaptionActiveFontTextDecoration.LineThrough,
                "none" => RichCaptionActiveFontTextDecoration.None,
                "underline" => RichCaptionActiveFontTextDecoration.Underline,
                _ => null,
            };
        }
    }
}