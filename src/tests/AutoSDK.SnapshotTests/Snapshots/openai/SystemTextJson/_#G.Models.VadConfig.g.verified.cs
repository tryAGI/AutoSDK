//HintName: G.Models.VadConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VadConfig
    {
        /// <summary>
        /// Must be set to `server_vad` to enable manual chunking using server side VAD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VadConfigTypeJsonConverter))]
        public global::G.VadConfigType Type { get; set; }

        /// <summary>
        /// Amount of audio to include before the VAD detected speech (in <br/>
        /// milliseconds).<br/>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_padding_ms")]
        public int? PrefixPaddingMs { get; set; }

        /// <summary>
        /// Duration of silence to detect speech stop (in milliseconds).<br/>
        /// With shorter values the model will respond more quickly, <br/>
        /// but may jump in on short pauses from the user.<br/>
        /// Default Value: 200
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_duration_ms")]
        public int? SilenceDurationMs { get; set; }

        /// <summary>
        /// Sensitivity threshold (0.0 to 1.0) for voice activity detection. A <br/>
        /// higher threshold will require louder audio to activate the model, and <br/>
        /// thus might perform better in noisy environments.<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VadConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be set to `server_vad` to enable manual chunking using server side VAD.
        /// </param>
        /// <param name="prefixPaddingMs">
        /// Amount of audio to include before the VAD detected speech (in <br/>
        /// milliseconds).<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="silenceDurationMs">
        /// Duration of silence to detect speech stop (in milliseconds).<br/>
        /// With shorter values the model will respond more quickly, <br/>
        /// but may jump in on short pauses from the user.<br/>
        /// Default Value: 200
        /// </param>
        /// <param name="threshold">
        /// Sensitivity threshold (0.0 to 1.0) for voice activity detection. A <br/>
        /// higher threshold will require louder audio to activate the model, and <br/>
        /// thus might perform better in noisy environments.<br/>
        /// Default Value: 0.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VadConfig(
            global::G.VadConfigType type,
            int? prefixPaddingMs,
            int? silenceDurationMs,
            double? threshold)
        {
            this.Type = type;
            this.PrefixPaddingMs = prefixPaddingMs;
            this.SilenceDurationMs = silenceDurationMs;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VadConfig" /> class.
        /// </summary>
        public VadConfig()
        {
        }
    }
}