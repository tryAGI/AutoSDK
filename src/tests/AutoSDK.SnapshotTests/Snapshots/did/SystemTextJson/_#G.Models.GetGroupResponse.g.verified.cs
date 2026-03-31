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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unique identifier of the owner that submitted the translation group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// Group creation time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The time when a draft translation group was generated as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_at")]
        public string? GeneratedAt { get; set; }

        /// <summary>
        /// The langugages that the video is translated to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TargetLanguages { get; set; }

        /// <summary>
        /// last modified time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModifiedAt { get; set; }

        /// <summary>
        /// The status of the group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetGroupResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetGroupResponseStatus Status { get; set; }

        /// <summary>
        /// The name of the group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The thumbnail url of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// The error that failed the translation process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_kind")]
        public string? ErrorKind { get; set; }

        /// <summary>
        /// Translations associated with the group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translations")]
        public global::System.Collections.Generic.IList<global::G.GetGroupResponseTranslation>? Translations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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