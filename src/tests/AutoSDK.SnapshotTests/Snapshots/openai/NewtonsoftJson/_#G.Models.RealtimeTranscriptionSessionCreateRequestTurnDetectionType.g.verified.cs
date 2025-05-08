//HintName: G.Models.RealtimeTranscriptionSessionCreateRequestTurnDetectionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of turn detection.<br/>
    /// Default Value: server_vad
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeTranscriptionSessionCreateRequestTurnDetectionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="server_vad")]
        ServerVad,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="semantic_vad")]
        SemanticVad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateRequestTurnDetectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateRequestTurnDetectionType value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateRequestTurnDetectionType.ServerVad => "server_vad",
                RealtimeTranscriptionSessionCreateRequestTurnDetectionType.SemanticVad => "semantic_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateRequestTurnDetectionType? ToEnum(string value)
        {
            return value switch
            {
                "server_vad" => RealtimeTranscriptionSessionCreateRequestTurnDetectionType.ServerVad,
                "semantic_vad" => RealtimeTranscriptionSessionCreateRequestTurnDetectionType.SemanticVad,
                _ => null,
            };
        }
    }
}