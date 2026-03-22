//HintName: G.Models.RealtimeSessionTurnDetectionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of turn detection.<br/>
    /// Default Value: server_vad
    /// </summary>
    public enum RealtimeSessionTurnDetectionType
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
    public static class RealtimeSessionTurnDetectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionTurnDetectionType value)
        {
            return value switch
            {
                RealtimeSessionTurnDetectionType.SemanticVad => "semantic_vad",
                RealtimeSessionTurnDetectionType.ServerVad => "server_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionTurnDetectionType? ToEnum(string value)
        {
            return value switch
            {
                "semantic_vad" => RealtimeSessionTurnDetectionType.SemanticVad,
                "server_vad" => RealtimeSessionTurnDetectionType.ServerVad,
                _ => null,
            };
        }
    }
}