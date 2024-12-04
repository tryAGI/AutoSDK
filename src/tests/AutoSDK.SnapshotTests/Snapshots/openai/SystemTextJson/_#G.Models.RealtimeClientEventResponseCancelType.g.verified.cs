//HintName: G.Models.RealtimeClientEventResponseCancelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `response.cancel`.
    /// </summary>
    public enum RealtimeClientEventResponseCancelType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCancel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeClientEventResponseCancelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventResponseCancelType value)
        {
            return value switch
            {
                RealtimeClientEventResponseCancelType.ResponseCancel => "response.cancel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventResponseCancelType? ToEnum(string value)
        {
            return value switch
            {
                "response.cancel" => RealtimeClientEventResponseCancelType.ResponseCancel,
                _ => null,
            };
        }
    }
}