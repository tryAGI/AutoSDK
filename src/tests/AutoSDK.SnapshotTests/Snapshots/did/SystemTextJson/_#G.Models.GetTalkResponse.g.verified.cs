//HintName: G.Models.GetTalkResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTalkResponse
    {
        /// <summary>
        /// Unique identifier for the object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unique identifier of the user that submitted the talk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The URL of the source image to be animated by the driver video. Image type of .jpg | .png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceUrl { get; set; }

        /// <summary>
        /// The URL of the driver video to drive the talk, if not provided a driver video will be selected for you from the predefined DriversBank
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver_url")]
        public string? DriverUrl { get; set; }

        /// <summary>
        /// Talk creation time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The user id of the user that created the talk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// The URL of the audio file which will be used by the actor<br/>
        /// Example: https://path.to/audio.mp3
        /// </summary>
        /// <example>https://path.to/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Talk start time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// last modified time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModifiedAt { get; set; }

        /// <summary>
        /// The status of the talk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetTalkResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetTalkResponseStatus Status { get; set; }

        /// <summary>
        /// s3 uri to the resulting video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        public string? ResultUrl { get; set; }

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
        /// The configuration that used to process the talk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.GetTalkResponseConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTalkResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the object
        /// </param>
        /// <param name="userId">
        /// Unique identifier of the user that submitted the talk
        /// </param>
        /// <param name="sourceUrl">
        /// The URL of the source image to be animated by the driver video. Image type of .jpg | .png
        /// </param>
        /// <param name="createdAt">
        /// Talk creation time as iso-8601 string
        /// </param>
        /// <param name="modifiedAt">
        /// last modified time as iso-8601 string
        /// </param>
        /// <param name="status">
        /// The status of the talk
        /// </param>
        /// <param name="driverUrl">
        /// The URL of the driver video to drive the talk, if not provided a driver video will be selected for you from the predefined DriversBank
        /// </param>
        /// <param name="createdBy">
        /// The user id of the user that created the talk
        /// </param>
        /// <param name="audioUrl">
        /// The URL of the audio file which will be used by the actor<br/>
        /// Example: https://path.to/audio.mp3
        /// </param>
        /// <param name="startedAt">
        /// Talk start time as iso-8601 string
        /// </param>
        /// <param name="resultUrl">
        /// s3 uri to the resulting video
        /// </param>
        /// <param name="metadata">
        /// metadata that has been collected through the process
        /// </param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including animate details. In a case of empty value, the webhook will not be triggered
        /// </param>
        /// <param name="config">
        /// The configuration that used to process the talk
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTalkResponse(
            string id,
            string userId,
            string sourceUrl,
            string createdAt,
            string modifiedAt,
            global::G.GetTalkResponseStatus status,
            string? driverUrl,
            string? createdBy,
            string? audioUrl,
            string? startedAt,
            string? resultUrl,
            object? metadata,
            string? webhook,
            global::G.GetTalkResponseConfig? config)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
            this.DriverUrl = driverUrl;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreatedBy = createdBy;
            this.AudioUrl = audioUrl;
            this.StartedAt = startedAt;
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
            this.Status = status;
            this.ResultUrl = resultUrl;
            this.Metadata = metadata;
            this.Webhook = webhook;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTalkResponse" /> class.
        /// </summary>
        public GetTalkResponse()
        {
        }
    }
}