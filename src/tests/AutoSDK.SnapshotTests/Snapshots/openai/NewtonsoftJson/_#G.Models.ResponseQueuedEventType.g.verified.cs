//HintName: G.Models.ResponseQueuedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.queued'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseQueuedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.queued")]
        ResponseQueued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseQueuedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseQueuedEventType value)
        {
            return value switch
            {
                ResponseQueuedEventType.ResponseQueued => "response.queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseQueuedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.queued" => ResponseQueuedEventType.ResponseQueued,
                _ => null,
            };
        }
    }
}