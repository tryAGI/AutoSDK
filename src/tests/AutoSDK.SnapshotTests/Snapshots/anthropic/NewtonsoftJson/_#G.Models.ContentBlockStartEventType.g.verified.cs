//HintName: G.Models.ContentBlockStartEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: content_block_start
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContentBlockStartEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_block_start")]
        ContentBlockStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentBlockStartEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentBlockStartEventType value)
        {
            return value switch
            {
                ContentBlockStartEventType.ContentBlockStart => "content_block_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentBlockStartEventType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_start" => ContentBlockStartEventType.ContentBlockStart,
                _ => null,
            };
        }
    }
}