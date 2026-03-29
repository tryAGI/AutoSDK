//HintName: G.Models.ServerMessageTranscriptType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "transcript" is sent as transcriber outputs partial or final transcript.
    /// </summary>
    public enum ServerMessageTranscriptType
    {
        /// <summary>
        /// 
        /// </summary>
        Transcript,
        /// <summary>
        /// 
        /// </summary>
        TranscriptFinal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageTranscriptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageTranscriptType value)
        {
            return value switch
            {
                ServerMessageTranscriptType.Transcript => "transcript",
                ServerMessageTranscriptType.TranscriptFinal => "transcript-final",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageTranscriptType? ToEnum(string value)
        {
            return value switch
            {
                "transcript" => ServerMessageTranscriptType.Transcript,
                "transcript-final" => ServerMessageTranscriptType.TranscriptFinal,
                _ => null,
            };
        }
    }
}