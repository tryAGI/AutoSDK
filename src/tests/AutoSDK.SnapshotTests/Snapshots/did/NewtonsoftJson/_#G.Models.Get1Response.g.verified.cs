//HintName: G.Models.Get1Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Get1Response
    {
        /// <summary>
        /// the organization or user id that owns the scene
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Last modified time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModifiedAt { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the user that submitted the scene
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.Get1ResponseStatusJsonConverter))]
        public global::G.Get1ResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// The URL of the audio file which will be used by the avatar<br/>
        /// Example: https://path.to/audio.mp3
        /// </summary>
        /// <example>https://path.to/audio.mp3</example>
        [global::Newtonsoft.Json.JsonProperty("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// The result url of the scene
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// The result url in which scene will be saved when done.<br/>
        /// Returns only when scene is in process.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_url")]
        public string? PendingUrl { get; set; }

        /// <summary>
        /// Video processing start time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// Video completion time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.Get1ResponseConfig? Config { get; set; }

        /// <summary>
        /// URL for the scene subtitles.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subtitles_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubtitlesUrl { get; set; } = default!;

        /// <summary>
        /// URL for the scene thumbnail.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThumbnailUrl { get; set; } = default!;

        /// <summary>
        /// The name of the scene
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The error that failed the scene process.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Get1ResponseError Error { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook", Required = global::Newtonsoft.Json.Required.Always)]
        public string Webhook { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_data", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserData { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Get1Response" /> class.
        /// </summary>
        /// <param name="ownerId">
        /// the organization or user id that owns the scene
        /// </param>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt">
        /// Last modified time as iso-8601 string
        /// </param>
        /// <param name="createdBy">
        /// Unique identifier of the user that submitted the scene
        /// </param>
        /// <param name="avatarId"></param>
        /// <param name="status"></param>
        /// <param name="subtitlesUrl">
        /// URL for the scene subtitles.
        /// </param>
        /// <param name="thumbnailUrl">
        /// URL for the scene thumbnail.
        /// </param>
        /// <param name="error">
        /// The error that failed the scene process.
        /// </param>
        /// <param name="webhook"></param>
        /// <param name="userData"></param>
        /// <param name="audioUrl">
        /// The URL of the audio file which will be used by the avatar<br/>
        /// Example: https://path.to/audio.mp3
        /// </param>
        /// <param name="resultUrl">
        /// The result url of the scene
        /// </param>
        /// <param name="pendingUrl">
        /// The result url in which scene will be saved when done.<br/>
        /// Returns only when scene is in process.
        /// </param>
        /// <param name="startedAt">
        /// Video processing start time as iso-8601 string
        /// </param>
        /// <param name="completedAt">
        /// Video completion time as iso-8601 string
        /// </param>
        /// <param name="config"></param>
        /// <param name="name">
        /// The name of the scene
        /// </param>
        public Get1Response(
            string ownerId,
            string id,
            string createdAt,
            string modifiedAt,
            string createdBy,
            string avatarId,
            global::G.Get1ResponseStatus status,
            string subtitlesUrl,
            string thumbnailUrl,
            global::G.Get1ResponseError error,
            string webhook,
            string userData,
            string? audioUrl,
            string? resultUrl,
            string? pendingUrl,
            string? startedAt,
            string? completedAt,
            global::G.Get1ResponseConfig? config,
            string? name)
        {
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.AvatarId = avatarId ?? throw new global::System.ArgumentNullException(nameof(avatarId));
            this.Status = status;
            this.AudioUrl = audioUrl;
            this.ResultUrl = resultUrl;
            this.PendingUrl = pendingUrl;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Config = config;
            this.SubtitlesUrl = subtitlesUrl ?? throw new global::System.ArgumentNullException(nameof(subtitlesUrl));
            this.ThumbnailUrl = thumbnailUrl ?? throw new global::System.ArgumentNullException(nameof(thumbnailUrl));
            this.Name = name;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Webhook = webhook ?? throw new global::System.ArgumentNullException(nameof(webhook));
            this.UserData = userData ?? throw new global::System.ArgumentNullException(nameof(userData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get1Response" /> class.
        /// </summary>
        public Get1Response()
        {
        }
    }
}