//HintName: G.Models.SessionUpdatedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SessionUpdatedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionUpdatedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionUpdatedEventType value)
        {
            return value switch
            {
                SessionUpdatedEventType.SessionUpdated => "session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionUpdatedEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.updated" => SessionUpdatedEventType.SessionUpdated,
                _ => null,
            };
        }
    }
}