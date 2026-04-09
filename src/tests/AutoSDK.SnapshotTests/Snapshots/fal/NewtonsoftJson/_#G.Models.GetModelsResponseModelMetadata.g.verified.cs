//HintName: G.Models.GetModelsResponseModelMetadata.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Model metadata (optional - may be absent for endpoints without registry entries)
    /// </summary>
    public sealed partial class GetModelsResponseModelMetadata
    {
        /// <summary>
        /// Human-readable label shown on Explore/Model pages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// Model category (e.g., 'text-to-image', 'image-to-video', 'text-to-video', 'image-to-3d', 'training')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category", Required = global::Newtonsoft.Json.Required.Always)]
        public string Category { get; set; } = default!;

        /// <summary>
        /// Brief description of the model's capabilities and use cases
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 'active' or 'deprecated'. Newest models are surfaced in Explore and may be flagged as 'new/beta' in tags
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetModelsResponseModelMetadataStatusJsonConverter))]
        public global::G.GetModelsResponseModelMetadataStatus Status { get; set; } = default!;

        /// <summary>
        /// Freeform tags such as 'new', 'beta', 'pro', or 'turbo' (Explore badges)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// ISO8601 timestamp of when the model was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Whether the model is favorited by the authenticated user (null when unauthenticated)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_favorited")]
        public bool? IsFavorited { get; set; }

        /// <summary>
        /// Main thumbnail image URL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThumbnailUrl { get; set; } = default!;

        /// <summary>
        /// Animated thumbnail URL (optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_animated_url")]
        public string? ThumbnailAnimatedUrl { get; set; }

        /// <summary>
        /// Full model endpoint URL (e.g., https://fal.run/...)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelUrl { get; set; } = default!;

        /// <summary>
        /// License or GitHub URL (optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("github_url")]
        public string? GithubUrl { get; set; }

        /// <summary>
        /// License type for the model (optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetModelsResponseModelMetadataLicenseTypeJsonConverter))]
        public global::G.GetModelsResponseModelMetadataLicenseType? LicenseType { get; set; }

        /// <summary>
        /// ISO8601 timestamp of model creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date", Required = global::Newtonsoft.Json.Required.Always)]
        public string Date { get; set; } = default!;

        /// <summary>
        /// Model group information (optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group")]
        public global::G.GetModelsResponseModelMetadataGroup? Group { get; set; }

        /// <summary>
        /// Whether the model is highlighted (deprecated, always false)<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("highlighted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Highlighted { get; set; } = default!;

        /// <summary>
        /// Model kind - inference or training (optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetModelsResponseModelMetadataKindJsonConverter))]
        public global::G.GetModelsResponseModelMetadataKind? Kind { get; set; }

        /// <summary>
        /// Related training endpoint IDs (optional, only present when non-empty, for inference models)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_endpoint_ids")]
        public global::System.Collections.Generic.IList<string>? TrainingEndpointIds { get; set; }

        /// <summary>
        /// Related inference endpoint IDs (optional, only present when non-empty, for training models)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inference_endpoint_ids")]
        public global::System.Collections.Generic.IList<string>? InferenceEndpointIds { get; set; }

        /// <summary>
        /// Streaming endpoint URL (optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_url")]
        public string? StreamUrl { get; set; }

        /// <summary>
        /// Estimated duration in minutes (optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_estimate")]
        public double? DurationEstimate { get; set; }

        /// <summary>
        /// Whether the model is pinned (deprecated, always false)<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("pinned", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Pinned { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelMetadata" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Human-readable label shown on Explore/Model pages
        /// </param>
        /// <param name="category">
        /// Model category (e.g., 'text-to-image', 'image-to-video', 'text-to-video', 'image-to-3d', 'training')
        /// </param>
        /// <param name="description">
        /// Brief description of the model's capabilities and use cases
        /// </param>
        /// <param name="status">
        /// 'active' or 'deprecated'. Newest models are surfaced in Explore and may be flagged as 'new/beta' in tags
        /// </param>
        /// <param name="tags">
        /// Freeform tags such as 'new', 'beta', 'pro', or 'turbo' (Explore badges)
        /// </param>
        /// <param name="updatedAt">
        /// ISO8601 timestamp of when the model was last updated
        /// </param>
        /// <param name="thumbnailUrl">
        /// Main thumbnail image URL
        /// </param>
        /// <param name="modelUrl">
        /// Full model endpoint URL (e.g., https://fal.run/...)
        /// </param>
        /// <param name="date">
        /// ISO8601 timestamp of model creation
        /// </param>
        /// <param name="highlighted">
        /// Whether the model is highlighted (deprecated, always false)<br/>
        /// Example: false
        /// </param>
        /// <param name="pinned">
        /// Whether the model is pinned (deprecated, always false)<br/>
        /// Example: false
        /// </param>
        /// <param name="isFavorited">
        /// Whether the model is favorited by the authenticated user (null when unauthenticated)
        /// </param>
        /// <param name="thumbnailAnimatedUrl">
        /// Animated thumbnail URL (optional)
        /// </param>
        /// <param name="githubUrl">
        /// License or GitHub URL (optional)
        /// </param>
        /// <param name="licenseType">
        /// License type for the model (optional)
        /// </param>
        /// <param name="group">
        /// Model group information (optional)
        /// </param>
        /// <param name="kind">
        /// Model kind - inference or training (optional)
        /// </param>
        /// <param name="trainingEndpointIds">
        /// Related training endpoint IDs (optional, only present when non-empty, for inference models)
        /// </param>
        /// <param name="inferenceEndpointIds">
        /// Related inference endpoint IDs (optional, only present when non-empty, for training models)
        /// </param>
        /// <param name="streamUrl">
        /// Streaming endpoint URL (optional)
        /// </param>
        /// <param name="durationEstimate">
        /// Estimated duration in minutes (optional)
        /// </param>
        public GetModelsResponseModelMetadata(
            string displayName,
            string category,
            string description,
            global::G.GetModelsResponseModelMetadataStatus status,
            global::System.Collections.Generic.IList<string> tags,
            string updatedAt,
            string thumbnailUrl,
            string modelUrl,
            string date,
            bool highlighted,
            bool pinned,
            bool? isFavorited,
            string? thumbnailAnimatedUrl,
            string? githubUrl,
            global::G.GetModelsResponseModelMetadataLicenseType? licenseType,
            global::G.GetModelsResponseModelMetadataGroup? group,
            global::G.GetModelsResponseModelMetadataKind? kind,
            global::System.Collections.Generic.IList<string>? trainingEndpointIds,
            global::System.Collections.Generic.IList<string>? inferenceEndpointIds,
            string? streamUrl,
            double? durationEstimate)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Status = status;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.IsFavorited = isFavorited;
            this.ThumbnailUrl = thumbnailUrl ?? throw new global::System.ArgumentNullException(nameof(thumbnailUrl));
            this.ThumbnailAnimatedUrl = thumbnailAnimatedUrl;
            this.ModelUrl = modelUrl ?? throw new global::System.ArgumentNullException(nameof(modelUrl));
            this.GithubUrl = githubUrl;
            this.LicenseType = licenseType;
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.Group = group;
            this.Highlighted = highlighted;
            this.Kind = kind;
            this.TrainingEndpointIds = trainingEndpointIds;
            this.InferenceEndpointIds = inferenceEndpointIds;
            this.StreamUrl = streamUrl;
            this.DurationEstimate = durationEstimate;
            this.Pinned = pinned;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelMetadata" /> class.
        /// </summary>
        public GetModelsResponseModelMetadata()
        {
        }
    }
}