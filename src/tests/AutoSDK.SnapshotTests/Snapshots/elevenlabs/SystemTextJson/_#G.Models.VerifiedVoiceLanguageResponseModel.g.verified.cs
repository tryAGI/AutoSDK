//HintName: G.Models.VerifiedVoiceLanguageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"accent":"American","language":"en","model_id":"eleven_turbo_v2_5"}
    /// </summary>
    public sealed partial class VerifiedVoiceLanguageResponseModel
    {
        /// <summary>
        /// The language of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// The voice's model ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// The voice's accent, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// The voice's locale, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// The voice's preview URL, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifiedVoiceLanguageResponseModel" /> class.
        /// </summary>
        /// <param name="language">
        /// The language of the voice.
        /// </param>
        /// <param name="modelId">
        /// The voice's model ID.
        /// </param>
        /// <param name="accent">
        /// The voice's accent, if applicable.
        /// </param>
        /// <param name="locale">
        /// The voice's locale, if applicable.
        /// </param>
        /// <param name="previewUrl">
        /// The voice's preview URL, if applicable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifiedVoiceLanguageResponseModel(
            string language,
            string modelId,
            string? accent,
            string? locale,
            string? previewUrl)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Accent = accent;
            this.Locale = locale;
            this.PreviewUrl = previewUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifiedVoiceLanguageResponseModel" /> class.
        /// </summary>
        public VerifiedVoiceLanguageResponseModel()
        {
        }
    }
}