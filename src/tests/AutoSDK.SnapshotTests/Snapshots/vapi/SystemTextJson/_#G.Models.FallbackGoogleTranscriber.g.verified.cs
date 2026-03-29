//HintName: G.Models.FallbackGoogleTranscriber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackGoogleTranscriber
    {
        /// <summary>
        /// This is the transcription provider that will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackGoogleTranscriberProviderJsonConverter))]
        public global::G.FallbackGoogleTranscriberProvider Provider { get; set; }

        /// <summary>
        /// This is the model that will be used for the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackGoogleTranscriberModelJsonConverter))]
        public global::G.FallbackGoogleTranscriberModel? Model { get; set; }

        /// <summary>
        /// This is the language that will be set for the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackGoogleTranscriberLanguageJsonConverter))]
        public global::G.FallbackGoogleTranscriberLanguage? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackGoogleTranscriber" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the transcription provider that will be used.
        /// </param>
        /// <param name="model">
        /// This is the model that will be used for the transcription.
        /// </param>
        /// <param name="language">
        /// This is the language that will be set for the transcription.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackGoogleTranscriber(
            global::G.FallbackGoogleTranscriberProvider provider,
            global::G.FallbackGoogleTranscriberModel? model,
            global::G.FallbackGoogleTranscriberLanguage? language)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackGoogleTranscriber" /> class.
        /// </summary>
        public FallbackGoogleTranscriber()
        {
        }
    }
}