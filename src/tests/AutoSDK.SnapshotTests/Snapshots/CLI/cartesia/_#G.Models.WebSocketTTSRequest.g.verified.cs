//HintName: G.Models.WebSocketTTSRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSocketTTSRequest
    {
        /// <summary>
        /// The ID of the model to use for the generation. See [Models](/build-with-cartesia/tts-models) for available models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputFormatJsonConverter))]
        public global::G.OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TTSRequestVoiceSpecifier Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.<br/>
        /// See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_config")]
        public global::G.GenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        /// Whether to return word-level timestamps. If `false` (default), no word timestamps will be produced at all. If `true`, the server will return timestamp events containing word-level timing information.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_timestamps")]
        public bool? AddTimestamps { get; set; }

        /// <summary>
        /// Whether to return phoneme-level timestamps. If `false` (default), no phoneme timestamps will be produced. If `true`, the server will return timestamp events containing phoneme-level timing information.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_phoneme_timestamps")]
        public bool? AddPhonemeTimestamps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_normalized_timestamps")]
        public bool? UseNormalizedTimestamps { get; set; }

        /// <summary>
        /// The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dict_id")]
        public string? PronunciationDictId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue")]
        public bool? Continue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        public string? ContextId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_buffer_delay_ms")]
        public int? MaxBufferDelayMs { get; set; }

        /// <summary>
        /// Use `generation_config.speed` for sonic-3.<br/>
        /// Speed setting for the model. Defaults to `normal`.<br/>
        /// This feature is experimental and may not work for all voices.<br/>
        /// Influences the speed of the generated speech. Faster speeds may reduce hallucination rate.<br/>
        /// Default Value: normal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelSpeedJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ModelSpeed? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSocketTTSRequest" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model to use for the generation. See [Models](/build-with-cartesia/tts-models) for available models.
        /// </param>
        /// <param name="voice"></param>
        /// <param name="outputFormat"></param>
        /// <param name="transcript"></param>
        /// <param name="language"></param>
        /// <param name="generationConfig">
        /// Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.<br/>
        /// See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.
        /// </param>
        /// <param name="addTimestamps">
        /// Whether to return word-level timestamps. If `false` (default), no word timestamps will be produced at all. If `true`, the server will return timestamp events containing word-level timing information.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="addPhonemeTimestamps">
        /// Whether to return phoneme-level timestamps. If `false` (default), no phoneme timestamps will be produced. If `true`, the server will return timestamp events containing phoneme-level timing information.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useNormalizedTimestamps"></param>
        /// <param name="pronunciationDictId">
        /// The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.
        /// </param>
        /// <param name="continue">
        /// Default Value: false
        /// </param>
        /// <param name="contextId"></param>
        /// <param name="maxBufferDelayMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSocketTTSRequest(
            string modelId,
            global::G.TTSRequestVoiceSpecifier voice,
            global::G.OutputFormat? outputFormat,
            string? transcript,
            string? language,
            global::G.GenerationConfig? generationConfig,
            bool? addTimestamps,
            bool? addPhonemeTimestamps,
            bool? useNormalizedTimestamps,
            string? pronunciationDictId,
            bool? @continue,
            string? contextId,
            int? maxBufferDelayMs)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.OutputFormat = outputFormat;
            this.Transcript = transcript;
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Language = language;
            this.GenerationConfig = generationConfig;
            this.AddTimestamps = addTimestamps;
            this.AddPhonemeTimestamps = addPhonemeTimestamps;
            this.UseNormalizedTimestamps = useNormalizedTimestamps;
            this.PronunciationDictId = pronunciationDictId;
            this.Continue = @continue;
            this.ContextId = contextId;
            this.MaxBufferDelayMs = maxBufferDelayMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSocketTTSRequest" /> class.
        /// </summary>
        public WebSocketTTSRequest()
        {
        }
    }
}