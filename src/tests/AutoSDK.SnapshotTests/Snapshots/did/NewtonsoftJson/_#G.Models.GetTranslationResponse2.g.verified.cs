//HintName: G.Models.GetTranslationResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTranslationResponse2
    {
        /// <summary>
        /// Unique identifier for the object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Identifier for the translation group id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GroupId { get; set; } = default!;

        /// <summary>
        /// The name of the translation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the owner that submitted the translation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// The status of the translation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetTranslationResponseStatus2JsonConverter))]
        public global::G.GetTranslationResponseStatus2 Status { get; set; } = default!;

        /// <summary>
        /// Translation creation time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// The user id that created the translation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// last modified time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModifiedAt { get; set; } = default!;

        /// <summary>
        /// The result url of the video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// The subtitle of the video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subtitles_url")]
        public string? SubtitlesUrl { get; set; }

        /// <summary>
        /// The thumbnail url of the video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// The translated transcription versions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriptions")]
        public global::System.Collections.Generic.IList<global::G.GetTranslationResponseTranscription2>? Transcriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranslationResponse2" /> class.
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
        public GetTranslationResponse2(
            string id,
            string groupId,
            string name,
            string ownerId,
            global::G.GetTranslationResponseStatus2 status,
            string createdAt,
            string modifiedAt,
            string? createdBy,
            string? resultUrl,
            string? subtitlesUrl,
            string? thumbnailUrl,
            global::System.Collections.Generic.IList<global::G.GetTranslationResponseTranscription2>? transcriptions)
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
        /// Initializes a new instance of the <see cref="GetTranslationResponse2" /> class.
        /// </summary>
        public GetTranslationResponse2()
        {
        }
    }
}