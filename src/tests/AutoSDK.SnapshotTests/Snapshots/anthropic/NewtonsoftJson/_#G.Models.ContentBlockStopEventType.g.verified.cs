//HintName: G.Models.ContentBlockStopEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: content_block_stop
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContentBlockStopEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_block_stop")]
        ContentBlockStop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentBlockStopEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentBlockStopEventType value)
        {
            return value switch
            {
                ContentBlockStopEventType.ContentBlockStop => "content_block_stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentBlockStopEventType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_stop" => ContentBlockStopEventType.ContentBlockStop,
                _ => null,
            };
        }
    }
}