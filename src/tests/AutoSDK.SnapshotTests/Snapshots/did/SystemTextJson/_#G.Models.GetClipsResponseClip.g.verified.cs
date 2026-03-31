//HintName: G.Models.GetClipsResponseClip.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetClipsResponseClip
    {
        /// <summary>
        /// Unique identifier for the object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unique identifier of the owner that submitted the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// The URL of the audio file which will be used by the actor<br/>
        /// Example: https://path.to/audio.mp3
        /// </summary>
        /// <example>https://path.to/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Clip creation time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The user id that created the clip
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
        /// Clip start time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// Clip completion time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// The configuration that used to process the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.GetClipsResponseClipConfig? Config { get; set; }

        /// <summary>
        /// The status of the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetClipsResponseClipStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetClipsResponseClipStatus Status { get; set; }

        /// <summary>
        /// The result url of the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// The identity of the actor that is used in the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_id")]
        public string? PresenterId { get; set; }

        /// <summary>
        /// The identifier of the presenter's acting driver that is used in the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver_id")]
        public string? DriverId { get; set; }

        /// <summary>
        /// metadata that has been collected through the process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// A webhook URL for sending the payload including animate details. In a case of empty value, the webhook will not be triggered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// The name of the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClipsResponseClip" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the object
        /// </param>
        /// <param name="ownerId">
        /// Unique identifier of the owner that submitted the clip
        /// </param>
        /// <param name="createdAt">
        /// Clip creation time as iso-8601 string
        /// </param>
        /// <param name="modifiedAt">
        /// last modified time as iso-8601 string
        /// </param>
        /// <param name="status">
        /// The status of the clip
        /// </param>
        /// <param name="audioUrl">
        /// The URL of the audio file which will be used by the actor<br/>
        /// Example: https://path.to/audio.mp3
        /// </param>
        /// <param name="createdBy">
        /// The user id that created the clip
        /// </param>
        /// <param name="startedAt">
        /// Clip start time as iso-8601 string
        /// </param>
        /// <param name="completedAt">
        /// Clip completion time as iso-8601 string
        /// </param>
        /// <param name="config">
        /// The configuration that used to process the clip
        /// </param>
        /// <param name="resultUrl">
        /// The result url of the clip
        /// </param>
        /// <param name="presenterId">
        /// The identity of the actor that is used in the clip
        /// </param>
        /// <param name="driverId">
        /// The identifier of the presenter's acting driver that is used in the clip
        /// </param>
        /// <param name="metadata">
        /// metadata that has been collected through the process
        /// </param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including animate details. In a case of empty value, the webhook will not be triggered
        /// </param>
        /// <param name="name">
        /// The name of the clip
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetClipsResponseClip(
            string id,
            string ownerId,
            string createdAt,
            string modifiedAt,
            global::G.GetClipsResponseClipStatus status,
            string? audioUrl,
            string? createdBy,
            string? startedAt,
            string? completedAt,
            global::G.GetClipsResponseClipConfig? config,
            string? resultUrl,
            string? presenterId,
            string? driverId,
            object? metadata,
            string? webhook,
            string? name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.AudioUrl = audioUrl;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreatedBy = createdBy;
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Config = config;
            this.Status = status;
            this.ResultUrl = resultUrl;
            this.PresenterId = presenterId;
            this.DriverId = driverId;
            this.Metadata = metadata;
            this.Webhook = webhook;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClipsResponseClip" /> class.
        /// </summary>
        public GetClipsResponseClip()
        {
        }
    }
}