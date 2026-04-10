//HintName: G.Models.GetGroupResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGroupResponse
    {
        /// <summary>
        /// Unique identifier for the object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the owner that submitted the translation group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// Group creation time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// The time when a draft translation group was generated as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_at")]
        public string? GeneratedAt { get; set; }

        /// <summary>
        /// The langugages that the video is translated to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_languages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TargetLanguages { get; set; } = default!;

        /// <summary>
        /// last modified time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModifiedAt { get; set; } = default!;

        /// <summary>
        /// The status of the group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetGroupResponseStatusJsonConverter))]
        public global::G.GetGroupResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// The name of the group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The thumbnail url of the video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// The error that failed the translation process.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_kind")]
        public string? ErrorKind { get; set; }

        /// <summary>
        /// Translations associated with the group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translations")]
        public global::System.Collections.Generic.IList<global::G.GetGroupResponseTranslation>? Translations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGroupResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the object
        /// </param>
        /// <param name="ownerId">
        /// Unique identifier of the owner that submitted the translation group
        /// </param>
        /// <param name="createdAt">
        /// Group creation time as iso-8601 string
        /// </param>
        /// <param name="targetLanguages">
        /// The langugages that the video is translated to
        /// </param>
        /// <param name="modifiedAt">
        /// last modified time as iso-8601 string
        /// </param>
        /// <param name="status">
        /// The status of the group
        /// </param>
        /// <param name="name">
        /// The name of the group
        /// </param>
        /// <param name="generatedAt">
        /// The time when a draft translation group was generated as iso-8601 string
        /// </param>
        /// <param name="thumbnailUrl">
        /// The thumbnail url of the video
        /// </param>
        /// <param name="errorKind">
        /// The error that failed the translation process.
        /// </param>
        /// <param name="translations">
        /// Translations associated with the group
        /// </param>
        public GetGroupResponse(
            string id,
            string ownerId,
            string createdAt,
            global::System.Collections.Generic.IList<string> targetLanguages,
            string modifiedAt,
            global::G.GetGroupResponseStatus status,
            string name,
            string? generatedAt,
            string? thumbnailUrl,
            string? errorKind,
            global::System.Collections.Generic.IList<global::G.GetGroupResponseTranslation>? translations)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.GeneratedAt = generatedAt;
            this.TargetLanguages = targetLanguages ?? throw new global::System.ArgumentNullException(nameof(targetLanguages));
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
            this.Status = status;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ThumbnailUrl = thumbnailUrl;
            this.ErrorKind = errorKind;
            this.Translations = translations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGroupResponse" /> class.
        /// </summary>
        public GetGroupResponse()
        {
        }
    }
}