//HintName: G.Models.ClientMessageTranscriptType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "transcript" is sent as transcriber outputs partial or final transcript.
    /// </summary>
    public enum ClientMessageTranscriptType
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
    public static class ClientMessageTranscriptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageTranscriptType value)
        {
            return value switch
            {
                ClientMessageTranscriptType.Transcript => "transcript",
                ClientMessageTranscriptType.TranscriptFinal => "transcript-final",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageTranscriptType? ToEnum(string value)
        {
            return value switch
            {
                "transcript" => ClientMessageTranscriptType.Transcript,
                "transcript-final" => ClientMessageTranscriptType.TranscriptFinal,
                _ => null,
            };
        }
    }
}