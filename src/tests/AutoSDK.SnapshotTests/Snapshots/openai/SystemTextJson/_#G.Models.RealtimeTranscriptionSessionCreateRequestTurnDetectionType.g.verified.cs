//HintName: G.Models.RealtimeTranscriptionSessionCreateRequestTurnDetectionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of turn detection.<br/>
    /// Default Value: server_vad
    /// </summary>
    public enum RealtimeTranscriptionSessionCreateRequestTurnDetectionType
    {
        /// <summary>
        /// 
        /// </summary>
        SemanticVad,
        /// <summary>
        /// 
        /// </summary>
        ServerVad,
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
                RealtimeTranscriptionSessionCreateRequestTurnDetectionType.SemanticVad => "semantic_vad",
                RealtimeTranscriptionSessionCreateRequestTurnDetectionType.ServerVad => "server_vad",
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
                "semantic_vad" => RealtimeTranscriptionSessionCreateRequestTurnDetectionType.SemanticVad,
                "server_vad" => RealtimeTranscriptionSessionCreateRequestTurnDetectionType.ServerVad,
                _ => null,
            };
        }
    }
}