//HintName: G.Models.TTSRequestLatency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Latency-quality trade-off. normal: best quality, balanced: reduced latency, low: lowest latency.<br/>
    /// Default Value: normal
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TTSRequestLatency
    {
        /// <summary>
        /// best quality, balanced: reduced latency, low: lowest latency.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="balanced")]
        Balanced,
        /// <summary>
        /// best quality, balanced: reduced latency, low: lowest latency.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// best quality, balanced: reduced latency, low: lowest latency.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="normal")]
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSRequestLatencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSRequestLatency value)
        {
            return value switch
            {
                TTSRequestLatency.Balanced => "balanced",
                TTSRequestLatency.Low => "low",
                TTSRequestLatency.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSRequestLatency? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => TTSRequestLatency.Balanced,
                "low" => TTSRequestLatency.Low,
                "normal" => TTSRequestLatency.Normal,
                _ => null,
            };
        }
    }
}