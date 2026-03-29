//HintName: G.Models.BatchImageResultItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Individual result item in a batch image generation.
    /// </summary>
    public sealed partial class BatchImageResultItem
    {
        /// <summary>
        /// The id of the generation created. None if failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The id of the image asset resulting from the generation. None if failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public global::System.Guid? AssetId { get; set; }

        /// <summary>
        /// Date the generation was submitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Status of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GenerationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GenerationStatus Status { get; set; }

        /// <summary>
        /// Current progress to completion. Between 0-1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Progress { get; set; }

        /// <summary>
        /// Error message if this item failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchImageResultItem" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Date the generation was submitted.
        /// </param>
        /// <param name="status">
        /// Status of the generation
        /// </param>
        /// <param name="progress">
        /// Current progress to completion. Between 0-1
        /// </param>
        /// <param name="id">
        /// The id of the generation created. None if failed.
        /// </param>
        /// <param name="assetId">
        /// The id of the image asset resulting from the generation. None if failed.
        /// </param>
        /// <param name="error">
        /// Error message if this item failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchImageResultItem(
            string createdAt,
            global::G.GenerationStatus status,
            double progress,
            global::System.Guid? id,
            global::System.Guid? assetId,
            string? error)
        {
            this.Id = id;
            this.AssetId = assetId;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
            this.Progress = progress;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchImageResultItem" /> class.
        /// </summary>
        public BatchImageResultItem()
        {
        }
    }
}