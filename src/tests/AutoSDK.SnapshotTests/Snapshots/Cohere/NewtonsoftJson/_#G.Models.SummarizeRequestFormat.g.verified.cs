//HintName: G.Models.SummarizeRequestFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `paragraph`, `bullets`, or `auto`, defaults to `auto`. Indicates the style in which the summary will be delivered - in a free form paragraph or in bullet points. If `auto` is selected, the best option will be picked based on the input text.<br/>
    /// Default Value: paragraph<br/>
    /// Included only in requests
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SummarizeRequestFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="paragraph")]
        Paragraph,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bullets")]
        Bullets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummarizeRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarizeRequestFormat value)
        {
            return value switch
            {
                SummarizeRequestFormat.Paragraph => "paragraph",
                SummarizeRequestFormat.Bullets => "bullets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarizeRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "paragraph" => SummarizeRequestFormat.Paragraph,
                "bullets" => SummarizeRequestFormat.Bullets,
                _ => null,
            };
        }
    }
}