//HintName: G.Models.SessionCreatedPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum SessionCreatedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionCreatedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionCreatedPayloadType value)
        {
            return value switch
            {
                SessionCreatedPayloadType.SessionCreated => "session.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionCreatedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "session.created" => SessionCreatedPayloadType.SessionCreated,
                _ => null,
            };
        }
    }
}