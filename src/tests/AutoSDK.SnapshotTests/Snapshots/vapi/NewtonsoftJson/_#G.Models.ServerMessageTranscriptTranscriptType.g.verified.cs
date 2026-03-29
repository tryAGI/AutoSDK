//HintName: G.Models.ServerMessageTranscriptTranscriptType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the transcript.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageTranscriptTranscriptType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="final")]
        Final,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="partial")]
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