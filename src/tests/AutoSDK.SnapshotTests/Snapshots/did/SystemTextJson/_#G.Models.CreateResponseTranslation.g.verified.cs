//HintName: G.Models.CreateResponseTranslation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResponseTranslation
    {
        /// <summary>
        /// Unique identifier for the object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Identifier for the translation group id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupId { get; set; }

        /// <summary>
        /// The name of the translation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Unique identifier of the owner that submitted the translation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// The status of the translation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateResponseTranslationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateResponseTranslationStatus Status { get; set; }

        /// <summary>
        /// Translation creation time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The user id that created the translation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// last modified time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModifiedAt { get; set; }

        /// <summary>
        /// The result url of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// The subtitle of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitles_url")]
        public string? SubtitlesUrl { get; set; }

        /// <summary>
        /// The thumbnail url of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// The translated transcription versions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptions")]
        public global::System.Collections.Generic.IList<global::G.CreateResponseTranslationTranscription>? Transcriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseTranslation" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the object
        /// </param>
        /// <param name="groupId">
        /// Identifier for the translation group id
        /// </param>
        /// <param name="name">
        /// The name of the translation
        /// </param>
        /// <param name="ownerId">
        /// Unique identifier of the owner that submitted the translation
        /// </param>
        /// <param name="status">
        /// The status of the translation
        /// </param>
        /// <param name="createdAt">
        /// Translation creation time as iso-8601 string
        /// </param>
        /// <param name="modifiedAt">
        /// last modified time as iso-8601 string
        /// </param>
        /// <param name="createdBy">
        /// The user id that created the translation
        /// </param>
        /// <param name="resultUrl">
        /// The result url of the video
        /// </param>
        /// <param name="subtitlesUrl">
        /// The subtitle of the video
        /// </param>
        /// <param name="thumbnailUrl">
        /// The thumbnail url of the video
        /// </param>
        /// <param name="transcriptions">
        /// The translated transcription versions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseTranslation(
            string id,
            string groupId,
            string name,
            string ownerId,
            global::G.CreateResponseTranslationStatus status,
            string createdAt,
            string modifiedAt,
            string? createdBy,
            string? resultUrl,
            string? subtitlesUrl,
            string? thumbnailUrl,
            global::System.Collections.Generic.IList<global::G.CreateResponseTranslationTranscription>? transcriptions)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.GroupId = groupId ?? throw new global::System.ArgumentNullException(nameof(groupId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Status = status;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreatedBy = createdBy;
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
            this.ResultUrl = resultUrl;
            this.SubtitlesUrl = subtitlesUrl;
            this.ThumbnailUrl = thumbnailUrl;
            this.Transcriptions = transcriptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseTranslation" /> class.
        /// </summary>
        public CreateResponseTranslation()
        {
        }
    }
}