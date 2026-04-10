//HintName: G.Models.GetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetResponse
    {
        /// <summary>
        /// The ID of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The status of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetResponseStatusJsonConverter))]
        public global::G.GetResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// An identifier of this avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetResponseObjectJsonConverter))]
        public global::G.GetResponseObject Object { get; set; }

        /// <summary>
        /// Avatar creation time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// the organization or user id that owns the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// Last modified time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModifiedAt { get; set; } = default!;

        /// <summary>
        /// The error that failed the training process.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.GetResponseError? Error { get; set; }

        /// <summary>
        /// Avatar train start time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// Avatar train complete time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// user id that created the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// The name of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// High resolution image of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// A low resolution image representing the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// A preview video of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("talking_preview_url")]
        public string? TalkingPreviewUrl { get; set; }

        /// <summary>
        /// A short gif, trimmed from the original avatar in low resolution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// A webhook URL for sending the payload. In a case of empty value, the webhook will not be triggered
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// The voice id of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// The source video url of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// The consent id used to create the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consent_id")]
        public string? ConsentId { get; set; }

        /// <summary>
        /// The face rect of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("face_rect")]
        public global::G.GetResponseFaceRect? FaceRect { get; set; }

        /// <summary>
        /// a creation notes for the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_notes")]
        public global::G.GetResponseCreationNotes? CreationNotes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the avatar
        /// </param>
        /// <param name="status">
        /// The status of the avatar
        /// </param>
        /// <param name="createdAt">
        /// Avatar creation time as iso-8601 string
        /// </param>
        /// <param name="ownerId">
        /// the organization or user id that owns the avatar
        /// </param>
        /// <param name="modifiedAt">
        /// Last modified time as iso-8601 string
        /// </param>
        /// <param name="object">
        /// An identifier of this avatar
        /// </param>
        /// <param name="error">
        /// The error that failed the training process.
        /// </param>
        /// <param name="startedAt">
        /// Avatar train start time as iso-8601 string
        /// </param>
        /// <param name="completedAt">
        /// Avatar train complete time as iso-8601 string
        /// </param>
        /// <param name="createdBy">
        /// user id that created the avatar
        /// </param>
        /// <param name="name">
        /// The name of the avatar
        /// </param>
        /// <param name="imageUrl">
        /// High resolution image of the avatar
        /// </param>
        /// <param name="thumbnailUrl">
        /// A low resolution image representing the avatar
        /// </param>
        /// <param name="talkingPreviewUrl">
        /// A preview video of the avatar
        /// </param>
        /// <param name="previewUrl">
        /// A short gif, trimmed from the original avatar in low resolution
        /// </param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload. In a case of empty value, the webhook will not be triggered
        /// </param>
        /// <param name="voiceId">
        /// The voice id of the avatar
        /// </param>
        /// <param name="sourceUrl">
        /// The source video url of the avatar
        /// </param>
        /// <param name="consentId">
        /// The consent id used to create the avatar
        /// </param>
        /// <param name="faceRect">
        /// The face rect of the avatar
        /// </param>
        /// <param name="creationNotes">
        /// a creation notes for the avatar
        /// </param>
        public GetResponse(
            string id,
            global::G.GetResponseStatus status,
            string createdAt,
            string ownerId,
            string modifiedAt,
            global::G.GetResponseObject @object,
            global::G.GetResponseError? error,
            string? startedAt,
            string? completedAt,
            string? createdBy,
            string? name,
            string? imageUrl,
            string? thumbnailUrl,
            string? talkingPreviewUrl,
            string? previewUrl,
            string? webhook,
            string? voiceId,
            string? sourceUrl,
            string? consentId,
            global::G.GetResponseFaceRect? faceRect,
            global::G.GetResponseCreationNotes? creationNotes)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Object = @object;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
            this.Error = error;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.CreatedBy = createdBy;
            this.Name = name;
            this.ImageUrl = imageUrl;
            this.ThumbnailUrl = thumbnailUrl;
            this.TalkingPreviewUrl = talkingPreviewUrl;
            this.PreviewUrl = previewUrl;
            this.Webhook = webhook;
            this.VoiceId = voiceId;
            this.SourceUrl = sourceUrl;
            this.ConsentId = consentId;
            this.FaceRect = faceRect;
            this.CreationNotes = creationNotes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetResponse" /> class.
        /// </summary>
        public GetResponse()
        {
        }
    }
}