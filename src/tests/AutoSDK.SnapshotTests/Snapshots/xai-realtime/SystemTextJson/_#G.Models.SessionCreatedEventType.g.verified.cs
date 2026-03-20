//HintName: G.Models.SessionCreatedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SessionCreatedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionCreatedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionCreatedEventType value)
        {
            return value switch
            {
                SessionCreatedEventType.SessionCreated => "session.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionCreatedEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.created" => SessionCreatedEventType.SessionCreated,
                _ => null,
            };
        }
    }
}