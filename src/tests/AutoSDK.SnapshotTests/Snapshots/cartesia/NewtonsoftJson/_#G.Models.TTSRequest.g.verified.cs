//HintName: G.Models.TTSRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSRequest
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
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public global::G.SupportedLanguage? Language { get; set; }

        /// <summary>
        /// Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.<br/>
        /// See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_config")]
        public global::G.GenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OutputFormat OutputFormat { get; set; } = default!;

        /// <summary>
        /// Whether to save the generated audio file. When true, the response will include a `Cartesia-File-ID` header.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("save")]
        public bool? Save { get; set; }

        /// <summary>
        /// The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciation_dict_id")]
        public string? PronunciationDictId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSRequest" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model to use for the generation. See [Models](/build-with-cartesia/tts-models) for available models.
        /// </param>
        /// <param name="transcript"></param>
        /// <param name="voice"></param>
        /// <param name="outputFormat"></param>
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </param>
        /// <param name="generationConfig">
        /// Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.<br/>
        /// See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.
        /// </param>
        /// <param name="save">
        /// Whether to save the generated audio file. When true, the response will include a `Cartesia-File-ID` header.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pronunciationDictId">
        /// The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.
        /// </param>
        public TTSRequest(
            string modelId,
            string transcript,
            global::G.TTSRequestVoiceSpecifier voice,
            global::G.OutputFormat outputFormat,
            global::G.SupportedLanguage? language,
            global::G.GenerationConfig? generationConfig,
            bool? save,
            string? pronunciationDictId)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Language = language;
            this.GenerationConfig = generationConfig;
            this.OutputFormat = outputFormat;
            this.Save = save;
            this.PronunciationDictId = pronunciationDictId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSRequest" /> class.
        /// </summary>
        public TTSRequest()
        {
        }
    }
}