//HintName: G.Models.GenerationStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationStatusResponse
    {
        /// <summary>
        /// ID of the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// ID of the generated asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AssetId { get; set; } = default!;

        /// <summary>
        /// Type of generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AssetTypeJsonConverter))]
        public global::G.AssetType Type { get; set; } = default!;

        /// <summary>
        /// Status of the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GenerationStatusJsonConverter))]
        public global::G.GenerationStatus Status { get; set; } = default!;

        /// <summary>
        /// Current progress to completion. Between 0-1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress", Required = global::Newtonsoft.Json.Required.Always)]
        public double Progress { get; set; } = default!;

        /// <summary>
        /// Date the generation was submitted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Generation error if any. Value is not present unless the status of the generation is 'error' and error_message field is not present.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.GenerationError2? Error { get; set; }

        /// <summary>
        /// Error message. Value is not present unless the status of the generation is 'error'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// URL of the generated asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// URL to download the asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// URL to stream the asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("streaming_url")]
        public string? StreamingUrl { get; set; }

        /// <summary>
        /// ID of the workspace this generation belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationStatusResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the generation.
        /// </param>
        /// <param name="assetId">
        /// ID of the generated asset.
        /// </param>
        /// <param name="type">
        /// Type of generation.
        /// </param>
        /// <param name="status">
        /// Status of the generation.
        /// </param>
        /// <param name="progress">
        /// Current progress to completion. Between 0-1
        /// </param>
        /// <param name="createdAt">
        /// Date the generation was submitted.
        /// </param>
        /// <param name="error">
        /// Generation error if any. Value is not present unless the status of the generation is 'error' and error_message field is not present.
        /// </param>
        /// <param name="errorMessage">
        /// Error message. Value is not present unless the status of the generation is 'error'
        /// </param>
        /// <param name="url">
        /// URL of the generated asset.
        /// </param>
        /// <param name="downloadUrl">
        /// URL to download the asset.
        /// </param>
        /// <param name="streamingUrl">
        /// URL to stream the asset.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace this generation belongs to.
        /// </param>
        public GenerationStatusResponse(
            global::System.Guid id,
            global::System.Guid assetId,
            global::G.AssetType type,
            global::G.GenerationStatus status,
            double progress,
            string createdAt,
            global::G.GenerationError2? error,
            string? errorMessage,
            string? url,
            string? downloadUrl,
            string? streamingUrl,
            string? workspaceId)
        {
            this.Id = id;
            this.AssetId = assetId;
            this.Type = type;
            this.Status = status;
            this.Progress = progress;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Error = error;
            this.ErrorMessage = errorMessage;
            this.Url = url;
            this.DownloadUrl = downloadUrl;
            this.StreamingUrl = streamingUrl;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationStatusResponse" /> class.
        /// </summary>
        public GenerationStatusResponse()
        {
        }
    }
}