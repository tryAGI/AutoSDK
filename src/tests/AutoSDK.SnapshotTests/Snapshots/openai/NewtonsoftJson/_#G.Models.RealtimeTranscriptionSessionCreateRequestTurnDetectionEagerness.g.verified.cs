//HintName: G.Models.RealtimeTranscriptionSessionCreateRequestTurnDetectionEagerness.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Used only for `semantic_vad` mode. The eagerness of the model to respond. `low` will wait longer for the user to continue speaking, `high` will respond more quickly. `auto` is the default and is equivalent to `medium`.<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeTranscriptionSessionCreateRequestTurnDetectionEagerness
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateRequestTurnDetectionEagernessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateRequestTurnDetectionEagerness value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateRequestTurnDetectionEagerness.Low => "low",
                RealtimeTranscriptionSessionCreateRequestTurnDetectionEagerness.Medium => "medium",
                RealtimeTranscriptionSessionCreateRequestTurnDetectionEagerness.High => "high",
                RealtimeTranscriptionSessionCreateRequestTurnDetectionEagerness.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateRequestTurnDetectionEagerness? ToEnum(string value)
        {
            return value switch
            {
                "low" => RealtimeTranscriptionSessionCreateRequestTurnDetectionEagerness.Low,
                "medium" => RealtimeTranscriptionSessionCreateRequestTurnDetectionEagerness.Medium,
                "high" => RealtimeTranscriptionSessionCreateRequestTurnDetectionEagerness.High,
                "auto" => RealtimeTranscriptionSessionCreateRequestTurnDetectionEagerness.Auto,
                _ => null,
            };
        }
    }
}