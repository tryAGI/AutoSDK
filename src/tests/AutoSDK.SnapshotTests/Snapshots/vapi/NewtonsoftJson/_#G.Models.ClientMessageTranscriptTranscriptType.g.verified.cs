//HintName: G.Models.ClientMessageTranscriptTranscriptType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the transcript.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientMessageTranscriptTranscriptType
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
    public static class ClientMessageTranscriptTranscriptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageTranscriptTranscriptType value)
        {
            return value switch
            {
                ClientMessageTranscriptTranscriptType.Final => "final",
                ClientMessageTranscriptTranscriptType.Partial => "partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageTranscriptTranscriptType? ToEnum(string value)
        {
            return value switch
            {
                "final" => ClientMessageTranscriptTranscriptType.Final,
                "partial" => ClientMessageTranscriptTranscriptType.Partial,
                _ => null,
            };
        }
    }
}