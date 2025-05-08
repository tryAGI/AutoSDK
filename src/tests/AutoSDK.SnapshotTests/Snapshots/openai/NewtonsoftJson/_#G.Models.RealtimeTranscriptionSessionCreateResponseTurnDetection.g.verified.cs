//HintName: G.Models.RealtimeTranscriptionSessionCreateResponseTurnDetection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for turn detection. Can be set to `null` to turn off. Server <br/>
    /// VAD means that the model will detect the start and end of speech based on <br/>
    /// audio volume and respond at the end of user speech.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponseTurnDetection
    {
        /// <summary>
        /// Type of turn detection, only `server_vad` is currently supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Activation threshold for VAD (0.0 to 1.0), this defaults to 0.5. A <br/>
        /// higher threshold will require louder audio to activate the model, and <br/>
        /// thus might perform better in noisy environments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Amount of audio to include before the VAD detected speech (in <br/>
        /// milliseconds). Defaults to 300ms.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix_padding_ms")]
        public int? PrefixPaddingMs { get; set; }

        /// <summary>
        /// Duration of silence to detect speech stop (in milliseconds). Defaults <br/>
        /// to 500ms. With shorter values the model will respond more quickly, <br/>
        /// but may jump in on short pauses from the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("silence_duration_ms")]
        public int? SilenceDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseTurnDetection" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of turn detection, only `server_vad` is currently supported.
        /// </param>
        /// <param name="threshold">
        /// Activation threshold for VAD (0.0 to 1.0), this defaults to 0.5. A <br/>
        /// higher threshold will require louder audio to activate the model, and <br/>
        /// thus might perform better in noisy environments.
        /// </param>
        /// <param name="prefixPaddingMs">
        /// Amount of audio to include before the VAD detected speech (in <br/>
        /// milliseconds). Defaults to 300ms.
        /// </param>
        /// <param name="silenceDurationMs">
        /// Duration of silence to detect speech stop (in milliseconds). Defaults <br/>
        /// to 500ms. With shorter values the model will respond more quickly, <br/>
        /// but may jump in on short pauses from the user.
        /// </param>
        public RealtimeTranscriptionSessionCreateResponseTurnDetection(
            string? type,
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
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseTurnDetection" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateResponseTurnDetection()
        {
        }
    }
}