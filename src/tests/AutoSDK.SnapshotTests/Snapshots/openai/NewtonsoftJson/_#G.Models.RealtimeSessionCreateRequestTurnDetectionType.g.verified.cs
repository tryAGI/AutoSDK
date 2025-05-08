//HintName: G.Models.RealtimeSessionCreateRequestTurnDetectionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of turn detection.<br/>
    /// Default Value: server_vad
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeSessionCreateRequestTurnDetectionType
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
    public static class RealtimeSessionCreateRequestTurnDetectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestTurnDetectionType value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestTurnDetectionType.ServerVad => "server_vad",
                RealtimeSessionCreateRequestTurnDetectionType.SemanticVad => "semantic_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestTurnDetectionType? ToEnum(string value)
        {
            return value switch
            {
                "server_vad" => RealtimeSessionCreateRequestTurnDetectionType.ServerVad,
                "semantic_vad" => RealtimeSessionCreateRequestTurnDetectionType.SemanticVad,
                _ => null,
            };
        }
    }
}