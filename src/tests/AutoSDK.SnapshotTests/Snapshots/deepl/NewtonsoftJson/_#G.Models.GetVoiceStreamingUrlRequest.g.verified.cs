//HintName: G.Models.GetVoiceStreamingUrlRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVoiceStreamingUrlRequest
    {
        /// <summary>
        /// The audio format for streaming. Specifies container, codec, and encoding parameters.<br/>
        /// Supported formats include PCM (recommended), OPUS (recommended for low bandwidth), FLAC, MP3, and AAC.<br/>
        /// PCM formats require explicit sample rate. Mono audio only.<br/>
        /// Example: audio/ogg; codecs=opus
        /// </summary>
        /// <example>audio/ogg; codecs=opus</example>
        [global::Newtonsoft.Json.JsonProperty("source_media_content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VoiceMediaContentType SourceMediaContentType { get; set; } = default!;

        /// <summary>
        /// Source language of the audio stream. Must be one of the supported Voice API source languages.<br/>
        /// Language identifier must comply with IETF BCP 47 language tags.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("source_language")]
        public global::G.VoiceSourceLanguage? SourceLanguage { get; set; }

        /// <summary>
        /// Controls how the source_language value is used.<br/>
        /// - `auto`: Treats source language as a hint; server can override<br/>
        /// - `fixed`: Treats source language as mandatory; server must use this language<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::Newtonsoft.Json.JsonProperty("source_language_mode")]
        public global::G.VoiceSourceLanguageMode? SourceLanguageMode { get; set; }

        /// <summary>
        /// List of target languages for translation. The stream will emit translations for each language.<br/>
        /// Maximum 5 target languages per stream. Language identifiers must comply with IETF BCP 47.<br/>
        /// Example: [de, fr, es]
        /// </summary>
        /// <example>[de, fr, es]</example>
        [global::Newtonsoft.Json.JsonProperty("target_languages")]
        public global::System.Collections.Generic.IList<string>? TargetLanguages { get; set; }

        /// <summary>
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </summary>
        /// <example>def3a26b-3e84-45b3-84ae-0c0aaf3525f7</example>
        [global::Newtonsoft.Json.JsonProperty("glossary_id")]
        public string? GlossaryId { get; set; }

        /// <summary>
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// Possible options are:<br/>
        ///   * `default` - use the default formality for the target language<br/>
        ///   * `formal`/`more` - for a more formal language<br/>
        ///   * `informal`/`less` - for a more informal language<br/>
        /// Default Value: default<br/>
        /// Example: formal
        /// </summary>
        /// <example>formal</example>
        [global::Newtonsoft.Json.JsonProperty("formality")]
        public global::G.VoiceFormality? Formality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoiceStreamingUrlRequest" /> class.
        /// </summary>
        /// <param name="sourceMediaContentType">
        /// The audio format for streaming. Specifies container, codec, and encoding parameters.<br/>
        /// Supported formats include PCM (recommended), OPUS (recommended for low bandwidth), FLAC, MP3, and AAC.<br/>
        /// PCM formats require explicit sample rate. Mono audio only.<br/>
        /// Example: audio/ogg; codecs=opus
        /// </param>
        /// <param name="sourceLanguage">
        /// Source language of the audio stream. Must be one of the supported Voice API source languages.<br/>
        /// Language identifier must comply with IETF BCP 47 language tags.<br/>
        /// Example: en
        /// </param>
        /// <param name="sourceLanguageMode">
        /// Controls how the source_language value is used.<br/>
        /// - `auto`: Treats source language as a hint; server can override<br/>
        /// - `fixed`: Treats source language as mandatory; server must use this language<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </param>
        /// <param name="targetLanguages">
        /// List of target languages for translation. The stream will emit translations for each language.<br/>
        /// Maximum 5 target languages per stream. Language identifiers must comply with IETF BCP 47.<br/>
        /// Example: [de, fr, es]
        /// </param>
        /// <param name="glossaryId">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="formality">
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// Possible options are:<br/>
        ///   * `default` - use the default formality for the target language<br/>
        ///   * `formal`/`more` - for a more formal language<br/>
        ///   * `informal`/`less` - for a more informal language<br/>
        /// Default Value: default<br/>
        /// Example: formal
        /// </param>
        public GetVoiceStreamingUrlRequest(
            global::G.VoiceMediaContentType sourceMediaContentType,
            global::G.VoiceSourceLanguage? sourceLanguage,
            global::G.VoiceSourceLanguageMode? sourceLanguageMode,
            global::System.Collections.Generic.IList<string>? targetLanguages,
            string? glossaryId,
            global::G.VoiceFormality? formality)
        {
            this.SourceMediaContentType = sourceMediaContentType;
            this.SourceLanguage = sourceLanguage;
            this.SourceLanguageMode = sourceLanguageMode;
            this.TargetLanguages = targetLanguages;
            this.GlossaryId = glossaryId;
            this.Formality = formality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoiceStreamingUrlRequest" /> class.
        /// </summary>
        public GetVoiceStreamingUrlRequest()
        {
        }
    }
}