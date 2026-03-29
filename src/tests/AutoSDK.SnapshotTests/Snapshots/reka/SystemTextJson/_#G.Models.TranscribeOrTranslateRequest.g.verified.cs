//HintName: G.Models.TranscribeOrTranslateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscribeOrTranslateRequest
    {
        /// <summary>
        /// URL to a WAV audio file (http/https) or a base64-encoded data URI (data:audio/wav;base64,...).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUrl { get; set; }

        /// <summary>
        /// Audio sampling rate in Hz. Recommended value is 16000.<br/>
        /// Default Value: 16000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SamplingRate { get; set; }

        /// <summary>
        /// Target language for translation. When omitted, only transcription is performed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscribeOrTranslateRequestTargetLanguageJsonConverter))]
        public global::G.TranscribeOrTranslateRequestTargetLanguage? TargetLanguage { get; set; }

        /// <summary>
        /// Set to true to indicate this is a translation request. Must be true when target_language is specified.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_translate")]
        public bool? IsTranslate { get; set; }

        /// <summary>
        /// Set to true to receive base64-encoded WAV audio of the translated speech. Requires is_translate and target_language.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_translation_audio")]
        public bool? ReturnTranslationAudio { get; set; }

        /// <summary>
        /// Controls randomness in generation. Use 0.0 for deterministic output.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeOrTranslateRequest" /> class.
        /// </summary>
        /// <param name="audioUrl">
        /// URL to a WAV audio file (http/https) or a base64-encoded data URI (data:audio/wav;base64,...).
        /// </param>
        /// <param name="samplingRate">
        /// Audio sampling rate in Hz. Recommended value is 16000.<br/>
        /// Default Value: 16000
        /// </param>
        /// <param name="targetLanguage">
        /// Target language for translation. When omitted, only transcription is performed.
        /// </param>
        /// <param name="isTranslate">
        /// Set to true to indicate this is a translation request. Must be true when target_language is specified.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnTranslationAudio">
        /// Set to true to receive base64-encoded WAV audio of the translated speech. Requires is_translate and target_language.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="temperature">
        /// Controls randomness in generation. Use 0.0 for deterministic output.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 1024
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscribeOrTranslateRequest(
            string audioUrl,
            int samplingRate,
            global::G.TranscribeOrTranslateRequestTargetLanguage? targetLanguage,
            bool? isTranslate,
            bool? returnTranslationAudio,
            double? temperature,
            int? maxTokens)
        {
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
            this.SamplingRate = samplingRate;
            this.TargetLanguage = targetLanguage;
            this.IsTranslate = isTranslate;
            this.ReturnTranslationAudio = returnTranslationAudio;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeOrTranslateRequest" /> class.
        /// </summary>
        public TranscribeOrTranslateRequest()
        {
        }
    }
}