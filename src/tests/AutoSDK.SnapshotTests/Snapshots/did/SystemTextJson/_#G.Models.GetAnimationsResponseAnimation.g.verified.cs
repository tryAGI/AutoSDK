//HintName: G.Models.GetAnimationsResponseAnimation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnimationsResponseAnimation
    {
        /// <summary>
        /// Unique identifier for the object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unique identifier of the user that submitted the animation
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
        /// The URL of the driver video to drive the animation, if not provided a driver video will be selected for you from the predefined DriversBank
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver_url")]
        public string? DriverUrl { get; set; }

        /// <summary>
        /// Animation creation time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The user id of the user that created the animation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Animation start time as iso-8601 string
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
        /// The status of the animation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetAnimationsResponseAnimationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetAnimationsResponseAnimationStatus Status { get; set; }

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
        /// The error that failed the animation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.GetAnimationsResponseAnimationErrorVariant1, global::G.GetAnimationsResponseAnimationErrorVariant2, global::G.GetAnimationsResponseAnimationErrorVariant3, global::G.GetAnimationsResponseAnimationErrorVariant4, global::G.GetAnimationsResponseAnimationErrorVariant5, global::G.GetAnimationsResponseAnimationErrorVariant6>))]
        public global::G.AnyOf<global::G.GetAnimationsResponseAnimationErrorVariant1, global::G.GetAnimationsResponseAnimationErrorVariant2, global::G.GetAnimationsResponseAnimationErrorVariant3, global::G.GetAnimationsResponseAnimationErrorVariant4, global::G.GetAnimationsResponseAnimationErrorVariant5, global::G.GetAnimationsResponseAnimationErrorVariant6>? Error { get; set; }

        /// <summary>
        /// A webhook URL for sending the payload including animate details. In a case of empty value, the webhook will not be triggered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// The configuration that used to process the animation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.GetAnimationsResponseAnimationConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationsResponseAnimation" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnimationsResponseAnimation(
            string id,
            string userId,
            string sourceUrl,
            string createdAt,
            string modifiedAt,
            global::G.GetAnimationsResponseAnimationStatus status,
            string? driverUrl,
            string? createdBy,
            string? startedAt,
            string? resultUrl,
            object? metadata,
            global::G.AnyOf<global::G.GetAnimationsResponseAnimationErrorVariant1, global::G.GetAnimationsResponseAnimationErrorVariant2, global::G.GetAnimationsResponseAnimationErrorVariant3, global::G.GetAnimationsResponseAnimationErrorVariant4, global::G.GetAnimationsResponseAnimationErrorVariant5, global::G.GetAnimationsResponseAnimationErrorVariant6>? error,
            string? webhook,
            global::G.GetAnimationsResponseAnimationConfig? config)
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
        /// Initializes a new instance of the <see cref="GetAnimationsResponseAnimation" /> class.
        /// </summary>
        public GetAnimationsResponseAnimation()
        {
        }
    }
}