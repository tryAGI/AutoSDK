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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Type of generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AssetType Type { get; set; }

        /// <summary>
        /// Inputs for the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Input Input { get; set; }

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
        /// Estimated time remaining in seconds until generation completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eta_sec")]
        public int? EtaSec { get; set; }

        /// <summary>
        /// Date the generation was submitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Credits consumed (debits) for this generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_cost")]
        public int? CreditCost { get; set; }

        /// <summary>
        /// Unique identifier linking all generations in a batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_generation_id")]
        public string? BatchGenerationId { get; set; }

        /// <summary>
        /// The generated asset. Value is not present unless the status of the generation is 'complete'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset")]
        public global::G.Asset? Asset { get; set; }

        /// <summary>
        /// Audio start offset in ms. Negative = prepend silence, positive = crop from start.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_start_ms")]
        public int? AudioStartMs { get; set; }

        /// <summary>
        /// Generation error if any. Value is not present unless the status of the generation is 'error' and error_message field is not present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::G.GenerationError2? Error { get; set; }

        /// <summary>
        /// Error message. Value is not present unless the status of the generation is 'error' and error field is not present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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