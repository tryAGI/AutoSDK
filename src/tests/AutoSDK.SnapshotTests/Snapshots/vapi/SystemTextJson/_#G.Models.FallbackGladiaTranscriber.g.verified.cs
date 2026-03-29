//HintName: G.Models.FallbackGladiaTranscriber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackGladiaTranscriber
    {
        /// <summary>
        /// This is the transcription provider that will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackGladiaTranscriberProviderJsonConverter))]
        public global::G.FallbackGladiaTranscriberProvider Provider { get; set; }

        /// <summary>
        /// This is the Gladia model that will be used. Default is 'fast'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackGladiaTranscriberModelJsonConverter))]
        public global::G.FallbackGladiaTranscriberModel? Model { get; set; }

        /// <summary>
        /// Defines how the transcription model detects the audio language. Default value is 'automatic single language'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageBehaviour")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackGladiaTranscriberLanguageBehaviourJsonConverter))]
        public global::G.FallbackGladiaTranscriberLanguageBehaviour? LanguageBehaviour { get; set; }

        /// <summary>
        /// Defines the language to use for the transcription. Required when languageBehaviour is 'manual'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackGladiaTranscriberLanguageJsonConverter))]
        public global::G.FallbackGladiaTranscriberLanguage? Language { get; set; }

        /// <summary>
        /// Defines the languages to use for the transcription. Required when languageBehaviour is 'manual'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackGladiaTranscriberLanguagesJsonConverter))]
        public global::G.FallbackGladiaTranscriberLanguages? Languages { get; set; }

        /// <summary>
        /// Provides a custom vocabulary to the model to improve accuracy of transcribing context specific words, technical terms, names, etc. If empty, this argument is ignored.<br/>
        /// ⚠️ Warning ⚠️: Please be aware that the transcription_hint field has a character limit of 600. If you provide a transcription_hint longer than 600 characters, it will be automatically truncated to meet this limit.<br/>
        /// Example: custom vocabulary
        /// </summary>
        /// <example>custom vocabulary</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptionHint")]
        public string? TranscriptionHint { get; set; }

        /// <summary>
        /// If prosody is true, you will get a transcription that can contain prosodies i.e. (laugh) (giggles) (malefic laugh) (toss) (music)… Default value is false.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prosody")]
        public bool? Prosody { get; set; }

        /// <summary>
        /// If true, audio will be pre-processed to improve accuracy but latency will increase. Default value is false.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioEnhancer")]
        public bool? AudioEnhancer { get; set; }

        /// <summary>
        /// Transcripts below this confidence threshold will be discarded.<br/>
        /// @default 0.4<br/>
        /// Example: 0.4F
        /// </summary>
        /// <example>0.4F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidenceThreshold")]
        public double? ConfidenceThreshold { get; set; }

        /// <summary>
        /// Endpointing time in seconds - time to wait before considering speech ended<br/>
        /// Example: 0.05F
        /// </summary>
        /// <example>0.05F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointing")]
        public double? Endpointing { get; set; }

        /// <summary>
        /// Speech threshold - sensitivity configuration for speech detection (0.0 to 1.0)<br/>
        /// Example: 0.6F
        /// </summary>
        /// <example>0.6F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speechThreshold")]
        public double? SpeechThreshold { get; set; }

        /// <summary>
        /// Enable custom vocabulary for improved accuracy<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("customVocabularyEnabled")]
        public bool? CustomVocabularyEnabled { get; set; }

        /// <summary>
        /// Custom vocabulary configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customVocabularyConfig")]
        public global::G.GladiaCustomVocabularyConfigDTO? CustomVocabularyConfig { get; set; }

        /// <summary>
        /// Region for processing audio (us-west or eu-west)<br/>
        /// Example: us-west
        /// </summary>
        /// <example>us-west</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackGladiaTranscriberRegionJsonConverter))]
        public global::G.FallbackGladiaTranscriberRegion? Region { get; set; }

        /// <summary>
        /// Enable partial transcripts for low-latency streaming transcription<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("receivePartialTranscripts")]
        public bool? ReceivePartialTranscripts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackGladiaTranscriber" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the transcription provider that will be used.
        /// </param>
        /// <param name="model">
        /// This is the Gladia model that will be used. Default is 'fast'
        /// </param>
        /// <param name="languageBehaviour">
        /// Defines how the transcription model detects the audio language. Default value is 'automatic single language'.
        /// </param>
        /// <param name="language">
        /// Defines the language to use for the transcription. Required when languageBehaviour is 'manual'.
        /// </param>
        /// <param name="languages">
        /// Defines the languages to use for the transcription. Required when languageBehaviour is 'manual'.
        /// </param>
        /// <param name="transcriptionHint">
        /// Provides a custom vocabulary to the model to improve accuracy of transcribing context specific words, technical terms, names, etc. If empty, this argument is ignored.<br/>
        /// ⚠️ Warning ⚠️: Please be aware that the transcription_hint field has a character limit of 600. If you provide a transcription_hint longer than 600 characters, it will be automatically truncated to meet this limit.<br/>
        /// Example: custom vocabulary
        /// </param>
        /// <param name="prosody">
        /// If prosody is true, you will get a transcription that can contain prosodies i.e. (laugh) (giggles) (malefic laugh) (toss) (music)… Default value is false.<br/>
        /// Example: false
        /// </param>
        /// <param name="audioEnhancer">
        /// If true, audio will be pre-processed to improve accuracy but latency will increase. Default value is false.<br/>
        /// Example: false
        /// </param>
        /// <param name="confidenceThreshold">
        /// Transcripts below this confidence threshold will be discarded.<br/>
        /// @default 0.4<br/>
        /// Example: 0.4F
        /// </param>
        /// <param name="endpointing">
        /// Endpointing time in seconds - time to wait before considering speech ended<br/>
        /// Example: 0.05F
        /// </param>
        /// <param name="speechThreshold">
        /// Speech threshold - sensitivity configuration for speech detection (0.0 to 1.0)<br/>
        /// Example: 0.6F
        /// </param>
        /// <param name="customVocabularyEnabled">
        /// Enable custom vocabulary for improved accuracy<br/>
        /// Example: false
        /// </param>
        /// <param name="customVocabularyConfig">
        /// Custom vocabulary configuration
        /// </param>
        /// <param name="region">
        /// Region for processing audio (us-west or eu-west)<br/>
        /// Example: us-west
        /// </param>
        /// <param name="receivePartialTranscripts">
        /// Enable partial transcripts for low-latency streaming transcription<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackGladiaTranscriber(
            global::G.FallbackGladiaTranscriberProvider provider,
            global::G.FallbackGladiaTranscriberModel? model,
            global::G.FallbackGladiaTranscriberLanguageBehaviour? languageBehaviour,
            global::G.FallbackGladiaTranscriberLanguage? language,
            global::G.FallbackGladiaTranscriberLanguages? languages,
            string? transcriptionHint,
            bool? prosody,
            bool? audioEnhancer,
            double? confidenceThreshold,
            double? endpointing,
            double? speechThreshold,
            bool? customVocabularyEnabled,
            global::G.GladiaCustomVocabularyConfigDTO? customVocabularyConfig,
            global::G.FallbackGladiaTranscriberRegion? region,
            bool? receivePartialTranscripts)
        {
            this.Provider = provider;
            this.Model = model;
            this.LanguageBehaviour = languageBehaviour;
            this.Language = language;
            this.Languages = languages;
            this.TranscriptionHint = transcriptionHint;
            this.Prosody = prosody;
            this.AudioEnhancer = audioEnhancer;
            this.ConfidenceThreshold = confidenceThreshold;
            this.Endpointing = endpointing;
            this.SpeechThreshold = speechThreshold;
            this.CustomVocabularyEnabled = customVocabularyEnabled;
            this.CustomVocabularyConfig = customVocabularyConfig;
            this.Region = region;
            this.ReceivePartialTranscripts = receivePartialTranscripts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackGladiaTranscriber" /> class.
        /// </summary>
        public FallbackGladiaTranscriber()
        {
        }
    }
}