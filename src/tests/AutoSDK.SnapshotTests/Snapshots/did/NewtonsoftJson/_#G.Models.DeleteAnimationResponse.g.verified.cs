//HintName: G.Models.DeleteAnimationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteAnimationResponse
    {
        /// <summary>
        /// Unique identifier for the object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the user that submitted the animation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The URL of the source image to be animated by the driver video. Image type of .jpg | .png
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceUrl { get; set; } = default!;

        /// <summary>
        /// The URL of the driver video to drive the animation, if not provided a driver video will be selected for you from the predefined DriversBank
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("driver_url")]
        public string? DriverUrl { get; set; }

        /// <summary>
        /// Animation creation time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// The user id of the user that created the animation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Animation start time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// last modified time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModifiedAt { get; set; } = default!;

        /// <summary>
        /// The status of the animation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DeleteAnimationResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// s3 uri to the resulting video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// metadata that has been collected through the process
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The error that failed the animation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.AnyOf<global::G.DeleteAnimationResponseErrorVariant1, global::G.DeleteAnimationResponseErrorVariant2, global::G.DeleteAnimationResponseErrorVariant3, global::G.DeleteAnimationResponseErrorVariant4, global::G.DeleteAnimationResponseErrorVariant5, global::G.DeleteAnimationResponseErrorVariant6>? Error { get; set; }

        /// <summary>
        /// A webhook URL for sending the payload including animate details. In a case of empty value, the webhook will not be triggered
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// The configuration that used to process the animation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.DeleteAnimationResponseConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAnimationResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the object
        /// </param>
        /// <param name="userId">
        /// Unique identifier of the user that submitted the animation
        /// </param>
        /// <param name="sourceUrl">
        /// The URL of the source image to be animated by the driver video. Image type of .jpg | .png
        /// </param>
        /// <param name="createdAt">
        /// Animation creation time as iso-8601 string
        /// </param>
        /// <param name="modifiedAt">
        /// last modified time as iso-8601 string
        /// </param>
        /// <param name="status">
        /// The status of the animation
        /// </param>
        /// <param name="driverUrl">
        /// The URL of the driver video to drive the animation, if not provided a driver video will be selected for you from the predefined DriversBank
        /// </param>
        /// <param name="createdBy">
        /// The user id of the user that created the animation
        /// </param>
        /// <param name="startedAt">
        /// Animation start time as iso-8601 string
        /// </param>
        /// <param name="resultUrl">
        /// s3 uri to the resulting video
        /// </param>
        /// <param name="metadata">
        /// metadata that has been collected through the process
        /// </param>
        /// <param name="error">
        /// The error that failed the animation
        /// </param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including animate details. In a case of empty value, the webhook will not be triggered
        /// </param>
        /// <param name="config">
        /// The configuration that used to process the animation
        /// </param>
        public DeleteAnimationResponse(
            string id,
            string userId,
            string sourceUrl,
            string createdAt,
            string modifiedAt,
            global::G.DeleteAnimationResponseStatus status,
            string? driverUrl,
            string? createdBy,
            string? startedAt,
            string? resultUrl,
            object? metadata,
            global::G.AnyOf<global::G.DeleteAnimationResponseErrorVariant1, global::G.DeleteAnimationResponseErrorVariant2, global::G.DeleteAnimationResponseErrorVariant3, global::G.DeleteAnimationResponseErrorVariant4, global::G.DeleteAnimationResponseErrorVariant5, global::G.DeleteAnimationResponseErrorVariant6>? error,
            string? webhook,
            global::G.DeleteAnimationResponseConfig? config)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
            this.DriverUrl = driverUrl;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreatedBy = createdBy;
            this.StartedAt = startedAt;
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
            this.Status = status;
            this.ResultUrl = resultUrl;
            this.Metadata = metadata;
            this.Error = error;
            this.Webhook = webhook;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAnimationResponse" /> class.
        /// </summary>
        public DeleteAnimationResponse()
        {
        }
    }
}