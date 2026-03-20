//HintName: G.Models.TurnDetection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Server VAD turn detection configuration. Null for manual mode.
    /// </summary>
    public sealed partial class TurnDetection
    {
        /// <summary>
        /// Turn detection type: server_vad or null for manual.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// VAD sensitivity threshold (0.1 - 0.9).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Milliseconds of silence before ending a turn (0 - 10000).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_duration_ms")]
        public int? SilenceDurationMs { get; set; }

        /// <summary>
        /// Milliseconds of audio to include before speech start (0 - 10000).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_padding_ms")]
        public int? PrefixPaddingMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnDetection" /> class.
        /// </summary>
        /// <param name="type">
        /// Turn detection type: server_vad or null for manual.
        /// </param>
        /// <param name="threshold">
        /// VAD sensitivity threshold (0.1 - 0.9).
        /// </param>
        /// <param name="silenceDurationMs">
        /// Milliseconds of silence before ending a turn (0 - 10000).
        /// </param>
        /// <param name="prefixPaddingMs">
        /// Milliseconds of audio to include before speech start (0 - 10000).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurnDetection(
            string? type,
            double? threshold,
            int? silenceDurationMs,
            int? prefixPaddingMs)
        {
            this.Type = type;
            this.Threshold = threshold;
            this.SilenceDurationMs = silenceDurationMs;
            this.PrefixPaddingMs = prefixPaddingMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnDetection" /> class.
        /// </summary>
        public TurnDetection()
        {
        }
    }
}