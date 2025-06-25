//HintName: G.Models.RealtimeServerEventResponseCreatedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `response.created`.
    /// </summary>
    public enum RealtimeServerEventResponseCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseCreatedType value)
        {
            return value switch
            {
                RealtimeServerEventResponseCreatedType.ResponseCreated => "response.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "response.created" => RealtimeServerEventResponseCreatedType.ResponseCreated,
                _ => null,
            };
        }
    }
}