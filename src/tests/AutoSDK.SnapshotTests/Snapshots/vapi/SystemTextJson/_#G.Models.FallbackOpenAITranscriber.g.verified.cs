//HintName: G.Models.FallbackOpenAITranscriber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackOpenAITranscriber
    {
        /// <summary>
        /// This is the transcription provider that will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackOpenAITranscriberProviderJsonConverter))]
        public global::G.FallbackOpenAITranscriberProvider Provider { get; set; }

        /// <summary>
        /// This is the model that will be used for the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackOpenAITranscriberModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FallbackOpenAITranscriberModel Model { get; set; }

        /// <summary>
        /// This is the language that will be set for the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackOpenAITranscriberLanguageJsonConverter))]
        public global::G.FallbackOpenAITranscriberLanguage? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackOpenAITranscriber" /> class.
        /// </summary>
        /// <param name="model">
        /// This is the model that will be used for the transcription.
        /// </param>
        /// <param name="provider">
        /// This is the transcription provider that will be used.
        /// </param>
        /// <param name="language">
        /// This is the language that will be set for the transcription.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackOpenAITranscriber(
            global::G.FallbackOpenAITranscriberModel model,
            global::G.FallbackOpenAITranscriberProvider provider,
            global::G.FallbackOpenAITranscriberLanguage? language)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackOpenAITranscriber" /> class.
        /// </summary>
        public FallbackOpenAITranscriber()
        {
        }
    }
}