//HintName: G.Models.SessionTurnDetection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for turn detection.
    /// </summary>
    public sealed partial class SessionTurnDetection
    {
        /// <summary>
        /// The type of turn detection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SessionTurnDetectionTypeJsonConverter))]
        public global::G.SessionTurnDetectionType? Type { get; set; }

        /// <summary>
        /// Activation threshold for VAD (0.0 to 1.0).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Amount of audio to include before speech starts (in milliseconds).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix_padding_ms")]
        public int? PrefixPaddingMs { get; set; }

        /// <summary>
        /// Duration of silence to detect speech stop (in milliseconds).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("silence_duration_ms")]
        public int? SilenceDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTurnDetection" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of turn detection.
        /// </param>
        /// <param name="threshold">
        /// Activation threshold for VAD (0.0 to 1.0).
        /// </param>
        /// <param name="prefixPaddingMs">
        /// Amount of audio to include before speech starts (in milliseconds).
        /// </param>
        /// <param name="silenceDurationMs">
        /// Duration of silence to detect speech stop (in milliseconds).
        /// </param>
        public SessionTurnDetection(
            global::G.SessionTurnDetectionType? type,
            double? threshold,
            int? prefixPaddingMs,
            int? silenceDurationMs)
        {
            this.Type = type;
            this.Threshold = threshold;
            this.PrefixPaddingMs = prefixPaddingMs;
            this.SilenceDurationMs = silenceDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTurnDetection" /> class.
        /// </summary>
        public SessionTurnDetection()
        {
        }
    }
}