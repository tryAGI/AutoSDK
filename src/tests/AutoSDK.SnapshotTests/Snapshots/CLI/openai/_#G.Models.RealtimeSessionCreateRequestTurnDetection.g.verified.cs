//HintName: G.Models.RealtimeSessionCreateRequestTurnDetection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for turn detection, ether Server VAD or Semantic VAD. This can be set to `null` to turn off, in which case the client must manually trigger model response.<br/>
    /// Server VAD means that the model will detect the start and end of speech based on audio volume and respond at the end of user speech.<br/>
    /// Semantic VAD is more advanced and uses a turn detection model (in conjuction with VAD) to semantically estimate whether the user has finished speaking, then dynamically sets a timeout based on this probability. For example, if user audio trails off with "uhhm", the model will score a low probability of turn end and wait longer for the user to continue speaking. This can be useful for more natural conversations, but may have a higher latency.
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequestTurnDetection
    {
        /// <summary>
        /// Type of turn detection.<br/>
        /// Default Value: server_vad
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeSessionCreateRequestTurnDetectionTypeJsonConverter))]
        public global::G.RealtimeSessionCreateRequestTurnDetectionType? Type { get; set; }

        /// <summary>
        /// Used only for `semantic_vad` mode. The eagerness of the model to respond. `low` will wait longer for the user to continue speaking, `high` will respond more quickly. `auto` is the default and is equivalent to `medium`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eagerness")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeSessionCreateRequestTurnDetectionEagernessJsonConverter))]
        public global::G.RealtimeSessionCreateRequestTurnDetectionEagerness? Eagerness { get; set; }

        /// <summary>
        /// Used only for `server_vad` mode. Activation threshold for VAD (0.0 to 1.0), this defaults to 0.5. A<br/>
        /// higher threshold will require louder audio to activate the model, and<br/>
        /// thus might perform better in noisy environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Used only for `server_vad` mode. Amount of audio to include before the VAD detected speech (in<br/>
        /// milliseconds). Defaults to 300ms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_padding_ms")]
        public int? PrefixPaddingMs { get; set; }

        /// <summary>
        /// Used only for `server_vad` mode. Duration of silence to detect speech stop (in milliseconds). Defaults<br/>
        /// to 500ms. With shorter values the model will respond more quickly,<br/>
        /// but may jump in on short pauses from the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_duration_ms")]
        public int? SilenceDurationMs { get; set; }

        /// <summary>
        /// Whether or not to automatically generate a response when a VAD stop event occurs.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_response")]
        public bool? CreateResponse { get; set; }

        /// <summary>
        /// Whether or not to automatically interrupt any ongoing response with output to the default<br/>
        /// conversation (i.e. `conversation` of `auto`) when a VAD start event occurs.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupt_response")]
        public bool? InterruptResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestTurnDetection" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of turn detection.<br/>
        /// Default Value: server_vad
        /// </param>
        /// <param name="eagerness">
        /// Used only for `semantic_vad` mode. The eagerness of the model to respond. `low` will wait longer for the user to continue speaking, `high` will respond more quickly. `auto` is the default and is equivalent to `medium`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="threshold">
        /// Used only for `server_vad` mode. Activation threshold for VAD (0.0 to 1.0), this defaults to 0.5. A<br/>
        /// higher threshold will require louder audio to activate the model, and<br/>
        /// thus might perform better in noisy environments.
        /// </param>
        /// <param name="prefixPaddingMs">
        /// Used only for `server_vad` mode. Amount of audio to include before the VAD detected speech (in<br/>
        /// milliseconds). Defaults to 300ms.
        /// </param>
        /// <param name="silenceDurationMs">
        /// Used only for `server_vad` mode. Duration of silence to detect speech stop (in milliseconds). Defaults<br/>
        /// to 500ms. With shorter values the model will respond more quickly,<br/>
        /// but may jump in on short pauses from the user.
        /// </param>
        /// <param name="createResponse">
        /// Whether or not to automatically generate a response when a VAD stop event occurs.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="interruptResponse">
        /// Whether or not to automatically interrupt any ongoing response with output to the default<br/>
        /// conversation (i.e. `conversation` of `auto`) when a VAD start event occurs.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateRequestTurnDetection(
            global::G.RealtimeSessionCreateRequestTurnDetectionType? type,
            global::G.RealtimeSessionCreateRequestTurnDetectionEagerness? eagerness,
            double? threshold,
            int? prefixPaddingMs,
            int? silenceDurationMs,
            bool? createResponse,
            bool? interruptResponse)
        {
            this.Type = type;
            this.Eagerness = eagerness;
            this.Threshold = threshold;
            this.PrefixPaddingMs = prefixPaddingMs;
            this.SilenceDurationMs = silenceDurationMs;
            this.CreateResponse = createResponse;
            this.InterruptResponse = interruptResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestTurnDetection" /> class.
        /// </summary>
        public RealtimeSessionCreateRequestTurnDetection()
        {
        }
    }
}