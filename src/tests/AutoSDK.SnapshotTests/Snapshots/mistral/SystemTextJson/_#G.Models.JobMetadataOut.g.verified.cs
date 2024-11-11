//HintName: G.Models.JobMetadataOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobMetadataOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_currency")]
        public string? CostCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_tokens")]
        public int? DataTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_start_time")]
        public int? EstimatedStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_duration_seconds")]
        public int? ExpectedDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_tokens")]
        public int? TrainTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_tokens_per_step")]
        public int? TrainTokensPerStep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobMetadataOut" /> class.
        /// </summary>
        /// <param name="cost"></param>
        /// <param name="costCurrency"></param>
        /// <param name="dataTokens"></param>
        /// <param name="estimatedStartTime"></param>
        /// <param name="expectedDurationSeconds"></param>
        /// <param name="trainTokens"></param>
        /// <param name="trainTokensPerStep"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public JobMetadataOut(
            double? cost,
            string? costCurrency,
            int? dataTokens,
            int? estimatedStartTime,
            int? expectedDurationSeconds,
            int? trainTokens,
            int? trainTokensPerStep)
        {
            this.Cost = cost;
            this.CostCurrency = costCurrency;
            this.DataTokens = dataTokens;
            this.EstimatedStartTime = estimatedStartTime;
            this.ExpectedDurationSeconds = expectedDurationSeconds;
            this.TrainTokens = trainTokens;
            this.TrainTokensPerStep = trainTokensPerStep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobMetadataOut" /> class.
        /// </summary>
        public JobMetadataOut()
        {
        }
    }
}