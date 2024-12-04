//HintName: G.Models.RealtimeClientEventSessionUpdateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `session.update`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeClientEventSessionUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session.update")]
        SessionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeClientEventSessionUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventSessionUpdateType value)
        {
            return value switch
            {
                RealtimeClientEventSessionUpdateType.SessionUpdate => "session.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventSessionUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "session.update" => RealtimeClientEventSessionUpdateType.SessionUpdate,
                _ => null,
            };
        }
    }
}