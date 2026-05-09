//HintName: G.Models.WebSocketResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebSocketResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chunk")]
        Chunk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flush_done")]
        FlushDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phoneme_timestamps")]
        PhonemeTimestamps,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timestamps")]
        Timestamps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSocketResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSocketResponseDiscriminatorType value)
        {
            return value switch
            {
                WebSocketResponseDiscriminatorType.Chunk => "chunk",
                WebSocketResponseDiscriminatorType.Done => "done",
                WebSocketResponseDiscriminatorType.Error => "error",
                WebSocketResponseDiscriminatorType.FlushDone => "flush_done",
                WebSocketResponseDiscriminatorType.PhonemeTimestamps => "phoneme_timestamps",
                WebSocketResponseDiscriminatorType.Timestamps => "timestamps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSocketResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chunk" => WebSocketResponseDiscriminatorType.Chunk,
                "done" => WebSocketResponseDiscriminatorType.Done,
                "error" => WebSocketResponseDiscriminatorType.Error,
                "flush_done" => WebSocketResponseDiscriminatorType.FlushDone,
                "phoneme_timestamps" => WebSocketResponseDiscriminatorType.PhonemeTimestamps,
                "timestamps" => WebSocketResponseDiscriminatorType.Timestamps,
                _ => null,
            };
        }
    }
}