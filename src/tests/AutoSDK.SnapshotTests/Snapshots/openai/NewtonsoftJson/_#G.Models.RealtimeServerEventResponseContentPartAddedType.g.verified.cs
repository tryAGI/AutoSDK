//HintName: G.Models.RealtimeServerEventResponseContentPartAddedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `response.content_part.added`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventResponseContentPartAddedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.content_part.added")]
        ResponseContentPartAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseContentPartAddedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseContentPartAddedType value)
        {
            return value switch
            {
                RealtimeServerEventResponseContentPartAddedType.ResponseContentPartAdded => "response.content_part.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseContentPartAddedType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.added" => RealtimeServerEventResponseContentPartAddedType.ResponseContentPartAdded,
                _ => null,
            };
        }
    }
}