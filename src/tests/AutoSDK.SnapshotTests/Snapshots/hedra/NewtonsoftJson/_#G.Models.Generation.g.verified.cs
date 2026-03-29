//HintName: G.Models.Generation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Generation
    {
        /// <summary>
        /// ID of the generation and associated asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Type of generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AssetType Type { get; set; } = default!;

        /// <summary>
        /// Inputs for the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Input Input { get; set; } = default!;

        /// <summary>
        /// Status of the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GenerationStatus Status { get; set; } = default!;

        /// <summary>
        /// Current progress to completion. Between 0-1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress", Required = global::Newtonsoft.Json.Required.Always)]
        public double Progress { get; set; } = default!;

        /// <summary>
        /// Estimated time remaining in seconds until generation completes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eta_sec")]
        public int? EtaSec { get; set; }

        /// <summary>
        /// Date the generation was submitted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Credits consumed (debits) for this generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credit_cost")]
        public int? CreditCost { get; set; }

        /// <summary>
        /// Unique identifier linking all generations in a batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_generation_id")]
        public string? BatchGenerationId { get; set; }

        /// <summary>
        /// The generated asset. Value is not present unless the status of the generation is 'complete'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset")]
        public global::G.Asset? Asset { get; set; }

        /// <summary>
        /// Audio start offset in ms. Negative = prepend silence, positive = crop from start.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_start_ms")]
        public int? AudioStartMs { get; set; }

        /// <summary>
        /// Generation error if any. Value is not present unless the status of the generation is 'error' and error_message field is not present.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.GenerationError2? Error { get; set; }

        /// <summary>
        /// Error message. Value is not present unless the status of the generation is 'error' and error field is not present.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the generation and associated asset.
        /// </param>
        /// <param name="type">
        /// Type of generation.
        /// </param>
        /// <param name="input">
        /// Inputs for the generation
        /// </param>
        /// <param name="status">
        /// Status of the generation
        /// </param>
        /// <param name="progress">
        /// Current progress to completion. Between 0-1
        /// </param>
        /// <param name="createdAt">
        /// Date the generation was submitted.
        /// </param>
        /// <param name="etaSec">
        /// Estimated time remaining in seconds until generation completes.
        /// </param>
        /// <param name="creditCost">
        /// Credits consumed (debits) for this generation.
        /// </param>
        /// <param name="batchGenerationId">
        /// Unique identifier linking all generations in a batch.
        /// </param>
        /// <param name="asset">
        /// The generated asset. Value is not present unless the status of the generation is 'complete'
        /// </param>
        /// <param name="audioStartMs">
        /// Audio start offset in ms. Negative = prepend silence, positive = crop from start.
        /// </param>
        /// <param name="error">
        /// Generation error if any. Value is not present unless the status of the generation is 'error' and error_message field is not present.
        /// </param>
        /// <param name="errorMessage">
        /// Error message. Value is not present unless the status of the generation is 'error' and error field is not present.
        /// </param>
        public Generation(
            global::System.Guid id,
            global::G.AssetType type,
            global::G.Input input,
            global::G.GenerationStatus status,
            double progress,
            string createdAt,
            int? etaSec,
            int? creditCost,
            string? batchGenerationId,
            global::G.Asset? asset,
            int? audioStartMs,
            global::G.GenerationError2? error,
            string? errorMessage)
        {
            this.Id = id;
            this.Type = type;
            this.Input = input;
            this.Status = status;
            this.Progress = progress;
            this.EtaSec = etaSec;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreditCost = creditCost;
            this.BatchGenerationId = batchGenerationId;
            this.Asset = asset;
            this.AudioStartMs = audioStartMs;
            this.Error = error;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        public Generation()
        {
        }
    }
}