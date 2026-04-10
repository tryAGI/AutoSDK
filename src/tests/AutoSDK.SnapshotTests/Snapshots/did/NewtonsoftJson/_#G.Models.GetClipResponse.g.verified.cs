//HintName: G.Models.GetClipResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetClipResponse
    {
        /// <summary>
        /// Unique identifier for the object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the owner that submitted the clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// The URL of the audio file which will be used by the actor<br/>
        /// Example: https://path.to/audio.mp3
        /// </summary>
        /// <example>https://path.to/audio.mp3</example>
        [global::Newtonsoft.Json.JsonProperty("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Clip creation time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// The user id that created the clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// last modified time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModifiedAt { get; set; } = default!;

        /// <summary>
        /// Clip start time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// Clip completion time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// The configuration that used to process the clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.GetClipResponseConfig? Config { get; set; }

        /// <summary>
        /// The status of the clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetClipResponseStatusJsonConverter))]
        public global::G.GetClipResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// The result url of the clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// The identity of the actor that is used in the clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presenter_id")]
        public string? PresenterId { get; set; }

        /// <summary>
        /// The identifier of the presenter's acting driver that is used in the clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("driver_id")]
        public string? DriverId { get; set; }

        /// <summary>
        /// metadata that has been collected through the process
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// A webhook URL for sending the payload including animate details. In a case of empty value, the webhook will not be triggered
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// The name of the clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClipResponse" /> class.
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
        public GetClipResponse(
            string id,
            string ownerId,
            string createdAt,
            string modifiedAt,
            global::G.GetClipResponseStatus status,
            string? audioUrl,
            string? createdBy,
            string? startedAt,
            string? completedAt,
            global::G.GetClipResponseConfig? config,
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
        /// Initializes a new instance of the <see cref="GetClipResponse" /> class.
        /// </summary>
        public GetClipResponse()
        {
        }
    }
}