//HintName: G.Models.TTSSSERequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSSSERequest
    {
        /// <summary>
        /// The ID of the model to use for the generation. See [Models](/build-with-cartesia/tts-models) for available models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript", Required = global::Newtonsoft.Json.Required.Always)]
        public string Transcript { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TTSRequestVoiceSpecifier Voice { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SSEOutputFormat OutputFormat { get; set; } = default!;

        /// <summary>
        /// Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.<br/>
        /// See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_config")]
        public global::G.GenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public global::G.SupportedLanguage? Language { get; set; }

        /// <summary>
        /// Use `generation_config.speed` for sonic-3.<br/>
        /// Speed setting for the model. Defaults to `normal`.<br/>
        /// This feature is experimental and may not work for all voices.<br/>
        /// Influences the speed of the generated speech. Faster speeds may reduce hallucination rate.<br/>
        /// Default Value: normal
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ModelSpeed? Speed { get; set; }

        /// <summary>
        /// Whether to return word-level timestamps. If `false` (default), no word timestamps will be produced at all. If `true`, the server will return timestamp events containing word-level timing information.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add_timestamps")]
        public bool? AddTimestamps { get; set; }

        /// <summary>
        /// Whether to return phoneme-level timestamps. If `false` (default), no phoneme timestamps will be produced. If `true`, the server will return timestamp events containing phoneme-level timing information.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add_phoneme_timestamps")]
        public bool? AddPhonemeTimestamps { get; set; }

        /// <summary>
        /// Whether to use normalized timestamps (True) or original timestamps (False).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_normalized_timestamps")]
        public bool? UseNormalizedTimestamps { get; set; }

        /// <summary>
        /// The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciation_dict_id")]
        public string? PronunciationDictId { get; set; }

        /// <summary>
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// Some customers use unique identifiers from their own systems (such as conversation IDs) as context IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_id")]
        public string? ContextId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSSSERequest" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model to use for the generation. See [Models](/build-with-cartesia/tts-models) for available models.
        /// </param>
        /// <param name="transcript"></param>
        /// <param name="voice"></param>
        /// <param name="outputFormat"></param>
        /// <param name="generationConfig">
        /// Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.<br/>
        /// See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.
        /// </param>
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
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
        /// <param name="contextId">
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// Some customers use unique identifiers from their own systems (such as conversation IDs) as context IDs.
        /// </param>
        public TTSSSERequest(
            string modelId,
            string transcript,
            global::G.TTSRequestVoiceSpecifier voice,
            global::G.SSEOutputFormat outputFormat,
            global::G.GenerationConfig? generationConfig,
            global::G.SupportedLanguage? language,
            bool? addTimestamps,
            bool? addPhonemeTimestamps,
            bool? useNormalizedTimestamps,
            string? pronunciationDictId,
            string? contextId)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.OutputFormat = outputFormat ?? throw new global::System.ArgumentNullException(nameof(outputFormat));
            this.GenerationConfig = generationConfig;
            this.Language = language;
            this.AddTimestamps = addTimestamps;
            this.AddPhonemeTimestamps = addPhonemeTimestamps;
            this.UseNormalizedTimestamps = useNormalizedTimestamps;
            this.PronunciationDictId = pronunciationDictId;
            this.ContextId = contextId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSSSERequest" /> class.
        /// </summary>
        public TTSSSERequest()
        {
        }
    }
}