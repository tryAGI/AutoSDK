//HintName: G.Models.ServerMessageTranscriptTranscriptType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the transcript.
    /// </summary>
    public enum ServerMessageTranscriptTranscriptType
    {
        /// <summary>
        /// 
        /// </summary>
        Final,
        /// <summary>
        /// 
        /// </summary>
        Partial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageTranscriptTranscriptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageTranscriptTranscriptType value)
        {
            return value switch
            {
                ServerMessageTranscriptTranscriptType.Final => "final",
                ServerMessageTranscriptTranscriptType.Partial => "partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageTranscriptTranscriptType? ToEnum(string value)
        {
            return value switch
            {
                "final" => ServerMessageTranscriptTranscriptType.Final,
                "partial" => ServerMessageTranscriptTranscriptType.Partial,
                _ => null,
            };
        }
    }
}