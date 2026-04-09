//HintName: G.Models.BatchVideoResultItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Individual result item in a batch video generation.
    /// </summary>
    public sealed partial class BatchVideoResultItem
    {
        /// <summary>
        /// The id of the generation created. None if failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The id of the video asset resulting from the generation. None if failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset_id")]
        public global::System.Guid? AssetId { get; set; }

        /// <summary>
        /// Date the generation was submitted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Status of the generation
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
        /// Error message if this item failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Estimated time until completion in seconds. None if unavailable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eta_sec")]
        public int? EtaSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchVideoResultItem" /> class.
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
        /// The id of the video asset resulting from the generation. None if failed.
        /// </param>
        /// <param name="error">
        /// Error message if this item failed.
        /// </param>
        /// <param name="etaSec">
        /// Estimated time until completion in seconds. None if unavailable.
        /// </param>
        public BatchVideoResultItem(
            string createdAt,
            global::G.GenerationStatus status,
            double progress,
            global::System.Guid? id,
            global::System.Guid? assetId,
            string? error,
            int? etaSec)
        {
            this.Id = id;
            this.AssetId = assetId;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
            this.Progress = progress;
            this.Error = error;
            this.EtaSec = etaSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchVideoResultItem" /> class.
        /// </summary>
        public BatchVideoResultItem()
        {
        }
    }
}