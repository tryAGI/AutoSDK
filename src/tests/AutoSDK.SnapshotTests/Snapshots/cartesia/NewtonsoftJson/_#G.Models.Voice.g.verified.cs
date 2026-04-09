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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Whether your organization owns the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_owner", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsOwner { get; set; } = default!;

        /// <summary>
        /// Whether the voice is publicly accessible.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPublic { get; set; } = default!;

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The description of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gender")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GenderPresentationJsonConverter))]
        public global::G.GenderPresentation? Gender { get; set; }

        /// <summary>
        /// The date and time the voice was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// A URL to download a preview audio file for this voice. Useful to avoid consuming credits when looking for the right voice. The URL requires the same Authorization header. Voice previews may be changed, moved, or deleted so you should avoid storing the URL permanently. This property will be null if there's no preview available. Only included when `expand[]` includes `preview_file_url`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_file_url")]
        public string? PreviewFileUrl { get; set; }

        /// <summary>
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SupportedLanguageJsonConverter))]
        public global::G.SupportedLanguage Language { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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