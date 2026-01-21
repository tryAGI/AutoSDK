//HintName: G.Models.LegacyJobMetadataOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyJobMetadataOut
    {
        /// <summary>
        /// The approximated time (in seconds) for the fine-tuning process to complete.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expected_duration_seconds")]
        public int? ExpectedDurationSeconds { get; set; }

        /// <summary>
        /// The cost of the fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// The currency used for the fine-tuning job cost.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost_currency")]
        public string? CostCurrency { get; set; }

        /// <summary>
        /// The number of tokens consumed by one training step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("train_tokens_per_step")]
        public int? TrainTokensPerStep { get; set; }

        /// <summary>
        /// The total number of tokens used during the fine-tuning process.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("train_tokens")]
        public int? TrainTokens { get; set; }

        /// <summary>
        /// The total number of tokens in the training dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_tokens")]
        public int? DataTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("estimated_start_time")]
        public int? EstimatedStartTime { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecated")]
        public bool? Deprecated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public string Details { get; set; } = default!;

        /// <summary>
        /// The number of complete passes through the entire training dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("epochs")]
        public double? Epochs { get; set; }

        /// <summary>
        /// The number of training steps to perform. A training step refers to a single update of the model weights during the fine-tuning process. This update is typically calculated using a batch of samples from the training dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_steps")]
        public int? TrainingSteps { get; set; }

        /// <summary>
        /// Default Value: job.metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.LegacyJobMetadataOutObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyJobMetadataOut" /> class.
        /// </summary>
        /// <param name="expectedDurationSeconds">
        /// The approximated time (in seconds) for the fine-tuning process to complete.
        /// </param>
        /// <param name="cost">
        /// The cost of the fine-tuning job.
        /// </param>
        /// <param name="costCurrency">
        /// The currency used for the fine-tuning job cost.
        /// </param>
        /// <param name="trainTokensPerStep">
        /// The number of tokens consumed by one training step.
        /// </param>
        /// <param name="trainTokens">
        /// The total number of tokens used during the fine-tuning process.
        /// </param>
        /// <param name="dataTokens">
        /// The total number of tokens in the training dataset.
        /// </param>
        /// <param name="estimatedStartTime"></param>
        /// <param name="deprecated">
        /// Default Value: true
        /// </param>
        /// <param name="details"></param>
        /// <param name="epochs">
        /// The number of complete passes through the entire training dataset.
        /// </param>
        /// <param name="trainingSteps">
        /// The number of training steps to perform. A training step refers to a single update of the model weights during the fine-tuning process. This update is typically calculated using a batch of samples from the training dataset.
        /// </param>
        /// <param name="object">
        /// Default Value: job.metadata
        /// </param>
        public LegacyJobMetadataOut(
            string details,
            int? expectedDurationSeconds,
            double? cost,
            string? costCurrency,
            int? trainTokensPerStep,
            int? trainTokens,
            int? dataTokens,
            int? estimatedStartTime,
            bool? deprecated,
            double? epochs,
            int? trainingSteps,
            global::G.LegacyJobMetadataOutObject? @object)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.ExpectedDurationSeconds = expectedDurationSeconds;
            this.Cost = cost;
            this.CostCurrency = costCurrency;
            this.TrainTokensPerStep = trainTokensPerStep;
            this.TrainTokens = trainTokens;
            this.DataTokens = dataTokens;
            this.EstimatedStartTime = estimatedStartTime;
            this.Deprecated = deprecated;
            this.Epochs = epochs;
            this.TrainingSteps = trainingSteps;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyJobMetadataOut" /> class.
        /// </summary>
        public LegacyJobMetadataOut()
        {
        }
    }
}