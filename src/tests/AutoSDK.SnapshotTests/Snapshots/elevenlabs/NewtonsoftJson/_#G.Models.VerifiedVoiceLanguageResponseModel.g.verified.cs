//HintName: G.Models.VerifiedVoiceLanguageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VerifiedVoiceLanguageResponseModel
    {
        /// <summary>
        /// The language of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// The voice's model ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// The voice's accent, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// The voice's preview URL, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="previewUrl">
        /// The voice's preview URL, if applicable.
        /// </param>
        public VerifiedVoiceLanguageResponseModel(
            string language,
            string modelId,
            string? accent,
            string? previewUrl)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Accent = accent;
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