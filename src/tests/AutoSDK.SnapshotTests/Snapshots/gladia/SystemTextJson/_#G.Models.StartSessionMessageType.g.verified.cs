//HintName: G.Models.StartSessionMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: start_session<br/>
    /// Example: start_session
    /// </summary>
    public enum StartSessionMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        StartSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StartSessionMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartSessionMessageType value)
        {
            return value switch
            {
                StartSessionMessageType.StartSession => "start_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartSessionMessageType? ToEnum(string value)
        {
            return value switch
            {
                "start_session" => StartSessionMessageType.StartSession,
                _ => null,
            };
        }
    }
}