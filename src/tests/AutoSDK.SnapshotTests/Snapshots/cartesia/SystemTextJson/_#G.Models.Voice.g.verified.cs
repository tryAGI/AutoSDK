//HintName: G.Models.Voice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"id":"\u003Cstring\u003E","is_owner":true,"is_public":false,"name":"\u003Cstring\u003E","description":"\u003Cstring\u003E","language":"en","created_at":"2024-11-04T05:31:56Z"}
    /// </summary>
    public sealed partial class Voice
    {
        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether your organization owns the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOwner { get; set; }

        /// <summary>
        /// Whether the voice is publicly accessible.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPublic { get; set; }

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GenderPresentationJsonConverter))]
        public global::G.GenderPresentation? Gender { get; set; }

        /// <summary>
        /// The date and time the voice was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A URL to download a preview audio file for this voice. Useful to avoid consuming credits when looking for the right voice. The URL requires the same Authorization header. Voice previews may be changed, moved, or deleted so you should avoid storing the URL permanently. This property will be null if there's no preview available. Only included when `expand[]` includes `preview_file_url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_file_url")]
        public string? PreviewFileUrl { get; set; }

        /// <summary>
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SupportedLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SupportedLanguage Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the voice.
        /// </param>
        /// <param name="isOwner">
        /// Whether your organization owns the voice.
        /// </param>
        /// <param name="isPublic">
        /// Whether the voice is publicly accessible.
        /// </param>
        /// <param name="name">
        /// The name of the voice.
        /// </param>
        /// <param name="description">
        /// The description of the voice.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the voice was created.
        /// </param>
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </param>
        /// <param name="gender"></param>
        /// <param name="previewFileUrl">
        /// A URL to download a preview audio file for this voice. Useful to avoid consuming credits when looking for the right voice. The URL requires the same Authorization header. Voice previews may be changed, moved, or deleted so you should avoid storing the URL permanently. This property will be null if there's no preview available. Only included when `expand[]` includes `preview_file_url`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Voice(
            string id,
            bool isOwner,
            bool isPublic,
            string name,
            string description,
            global::System.DateTime createdAt,
            global::G.SupportedLanguage language,
            global::G.GenderPresentation? gender,
            string? previewFileUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsOwner = isOwner;
            this.IsPublic = isPublic;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Gender = gender;
            this.CreatedAt = createdAt;
            this.PreviewFileUrl = previewFileUrl;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        public Voice()
        {
        }
    }
}