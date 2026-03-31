//HintName: G.Models.GetSceneResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSceneResponseDto
    {
        /// <summary>
        /// the organization or user id that owns the scene
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Last modified time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModifiedAt { get; set; }

        /// <summary>
        /// Unique identifier of the user that submitted the scene
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetSceneResponseDtoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetSceneResponseDtoStatus Status { get; set; }

        /// <summary>
        /// The URL of the audio file which will be used by the avatar<br/>
        /// Example: https://path.to/audio.mp3
        /// </summary>
        /// <example>https://path.to/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// The result url of the scene
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// The result url in which scene will be saved when done.<br/>
        /// Returns only when scene is in process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_url")]
        public string? PendingUrl { get; set; }

        /// <summary>
        /// Video processing start time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// Video completion time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.GetSceneResponseDtoConfig? Config { get; set; }

        /// <summary>
        /// URL for the scene subtitles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitles_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubtitlesUrl { get; set; }

        /// <summary>
        /// URL for the scene thumbnail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThumbnailUrl { get; set; }

        /// <summary>
        /// The name of the scene
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The error that failed the scene process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetSceneResponseDtoError Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Webhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSceneResponseDto" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSceneResponseDto(
            string ownerId,
            string id,
            string createdAt,
            string modifiedAt,
            string createdBy,
            string avatarId,
            global::G.GetSceneResponseDtoStatus status,
            string subtitlesUrl,
            string thumbnailUrl,
            global::G.GetSceneResponseDtoError error,
            string webhook,
            string userData,
            string? audioUrl,
            string? resultUrl,
            string? pendingUrl,
            string? startedAt,
            string? completedAt,
            global::G.GetSceneResponseDtoConfig? config,
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
        /// Initializes a new instance of the <see cref="GetSceneResponseDto" /> class.
        /// </summary>
        public GetSceneResponseDto()
        {
        }
    }
}