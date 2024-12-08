//HintName: G.Models.ContentBlockDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: content_block_delta
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContentBlockDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_block_delta")]
        ContentBlockDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentBlockDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentBlockDeltaEventType value)
        {
            return value switch
            {
                ContentBlockDeltaEventType.ContentBlockDelta => "content_block_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentBlockDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_delta" => ContentBlockDeltaEventType.ContentBlockDelta,
                _ => null,
            };
        }
    }
}