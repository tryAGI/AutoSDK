//HintName: G.Models.EndSessionMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: end_session<br/>
    /// Example: end_session
    /// </summary>
    public enum EndSessionMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        EndSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndSessionMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndSessionMessageType value)
        {
            return value switch
            {
                EndSessionMessageType.EndSession => "end_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndSessionMessageType? ToEnum(string value)
        {
            return value switch
            {
                "end_session" => EndSessionMessageType.EndSession,
                _ => null,
            };
        }
    }
}