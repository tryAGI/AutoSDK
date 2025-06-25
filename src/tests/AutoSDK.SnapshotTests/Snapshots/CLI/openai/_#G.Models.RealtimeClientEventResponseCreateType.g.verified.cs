//HintName: G.Models.RealtimeClientEventResponseCreateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `response.create`.
    /// </summary>
    public enum RealtimeClientEventResponseCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeClientEventResponseCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventResponseCreateType value)
        {
            return value switch
            {
                RealtimeClientEventResponseCreateType.ResponseCreate => "response.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventResponseCreateType? ToEnum(string value)
        {
            return value switch
            {
                "response.create" => RealtimeClientEventResponseCreateType.ResponseCreate,
                _ => null,
            };
        }
    }
}