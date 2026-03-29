//HintName: G.Models.GenerationRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationRequest
    {
        /// <summary>
        /// The ID of the model to use for the generation. See [Models](/build-with-cartesia/tts-models) for available models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// The transcript to generate speech for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TTSRequestVoiceSpecifier Voice { get; set; }

        /// <summary>
        /// Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.<br/>
        /// See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_config")]
        public global::G.GenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SupportedLanguageJsonConverter))]
        public global::G.SupportedLanguage? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebSocketRawOutputFormat OutputFormat { get; set; }

        /// <summary>
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// Some customers use unique identifiers from their own systems (such as conversation IDs) as context IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        public string? ContextId { get; set; }

        /// <summary>
        /// Whether this input may be followed by more inputs.<br/>
        /// If not specified, this defaults to `false`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue")]
        public bool? Continue { get; set; }

        /// <summary>
        /// The maximum time in milliseconds to buffer text before starting generation. Values between [0, 5000]ms are supported. Defaults to 3000ms.<br/>
        /// When set, the model will buffer incoming text chunks until it's confident it has enough context to generate high-quality speech, or the buffer delay elapses, whichever comes first. Without this option set, the model will kick off generations immediately, ceding control of buffering to the user.<br/>
        /// Use this to balance responsiveness with higher quality speech generation, which often benefits from having more context.<br/>
        /// Default Value: 3000
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
        /// Whether to flush the context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flush")]
        public bool? Flush { get; set; }

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
        /// Whether to use normalized timestamps (True) or original timestamps (False).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_normalized_timestamps")]
        public bool? UseNormalizedTimestamps { get; set; }

        /// <summary>
        /// The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dict_id")]
        public string? PronunciationDictId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequest" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model to use for the generation. See [Models](/build-with-cartesia/tts-models) for available models.
        /// </param>
        /// <param name="transcript">
        /// The transcript to generate speech for.
        /// </param>
        /// <param name="voice"></param>
        /// <param name="outputFormat"></param>
        /// <param name="generationConfig">
        /// Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.<br/>
        /// See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.
        /// </param>
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </param>
        /// <param name="contextId">
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// Some customers use unique identifiers from their own systems (such as conversation IDs) as context IDs.
        /// </param>
        /// <param name="continue">
        /// Whether this input may be followed by more inputs.<br/>
        /// If not specified, this defaults to `false`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxBufferDelayMs">
        /// The maximum time in milliseconds to buffer text before starting generation. Values between [0, 5000]ms are supported. Defaults to 3000ms.<br/>
        /// When set, the model will buffer incoming text chunks until it's confident it has enough context to generate high-quality speech, or the buffer delay elapses, whichever comes first. Without this option set, the model will kick off generations immediately, ceding control of buffering to the user.<br/>
        /// Use this to balance responsiveness with higher quality speech generation, which often benefits from having more context.<br/>
        /// Default Value: 3000
        /// </param>
        /// <param name="flush">
        /// Whether to flush the context.
        /// </param>
        /// <param name="addTimestamps">
        /// Whether to return word-level timestamps. If `false` (default), no word timestamps will be produced at all. If `true`, the server will return timestamp events containing word-level timing information.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="addPhonemeTimestamps">
        /// Whether to return phoneme-level timestamps. If `false` (default), no phoneme timestamps will be produced. If `true`, the server will return timestamp events containing phoneme-level timing information.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useNormalizedTimestamps">
        /// Whether to use normalized timestamps (True) or original timestamps (False).
        /// </param>
        /// <param name="pronunciationDictId">
        /// The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationRequest(
            string modelId,
            string transcript,
            global::G.TTSRequestVoiceSpecifier voice,
            global::G.WebSocketRawOutputFormat outputFormat,
            global::G.GenerationConfig? generationConfig,
            global::G.SupportedLanguage? language,
            string? contextId,
            bool? @continue,
            int? maxBufferDelayMs,
            bool? flush,
            bool? addTimestamps,
            bool? addPhonemeTimestamps,
            bool? useNormalizedTimestamps,
            string? pronunciationDictId)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.GenerationConfig = generationConfig;
            this.Language = language;
            this.OutputFormat = outputFormat ?? throw new global::System.ArgumentNullException(nameof(outputFormat));
            this.ContextId = contextId;
            this.Continue = @continue;
            this.MaxBufferDelayMs = maxBufferDelayMs;
            this.Flush = flush;
            this.AddTimestamps = addTimestamps;
            this.AddPhonemeTimestamps = addPhonemeTimestamps;
            this.UseNormalizedTimestamps = useNormalizedTimestamps;
            this.PronunciationDictId = pronunciationDictId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequest" /> class.
        /// </summary>
        public GenerationRequest()
        {
        }
    }
}