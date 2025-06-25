//HintName: G.Models.RealtimeServerEventSessionUpdatedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `session.updated`.
    /// </summary>
    public enum RealtimeServerEventSessionUpdatedType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventSessionUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventSessionUpdatedType value)
        {
            return value switch
            {
                RealtimeServerEventSessionUpdatedType.SessionUpdated => "session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventSessionUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.updated" => RealtimeServerEventSessionUpdatedType.SessionUpdated,
                _ => null,
            };
        }
    }
}