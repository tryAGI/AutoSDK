//HintName: G.Models.SessionObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type.
    /// </summary>
    public enum SessionObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionObject value)
        {
            return value switch
            {
                SessionObject.RealtimeSession => "realtime.session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.session" => SessionObject.RealtimeSession,
                _ => null,
            };
        }
    }
}