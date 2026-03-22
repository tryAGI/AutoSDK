//HintName: G.Models.SessionTurnDetectionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of turn detection.
    /// </summary>
    public enum SessionTurnDetectionType
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        ServerVad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionTurnDetectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionTurnDetectionType value)
        {
            return value switch
            {
                SessionTurnDetectionType.None => "none",
                SessionTurnDetectionType.ServerVad => "server_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionTurnDetectionType? ToEnum(string value)
        {
            return value switch
            {
                "none" => SessionTurnDetectionType.None,
                "server_vad" => SessionTurnDetectionType.ServerVad,
                _ => null,
            };
        }
    }
}