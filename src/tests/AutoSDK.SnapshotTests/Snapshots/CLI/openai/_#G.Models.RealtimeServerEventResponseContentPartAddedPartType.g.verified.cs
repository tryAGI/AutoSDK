//HintName: G.Models.RealtimeServerEventResponseContentPartAddedPartType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The content type ("text", "audio").
    /// </summary>
    public enum RealtimeServerEventResponseContentPartAddedPartType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseContentPartAddedPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseContentPartAddedPartType value)
        {
            return value switch
            {
                RealtimeServerEventResponseContentPartAddedPartType.Audio => "audio",
                RealtimeServerEventResponseContentPartAddedPartType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseContentPartAddedPartType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => RealtimeServerEventResponseContentPartAddedPartType.Audio,
                "text" => RealtimeServerEventResponseContentPartAddedPartType.Text,
                _ => null,
            };
        }
    }
}