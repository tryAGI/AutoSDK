//HintName: G.Models.TrainingStepMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The evaluation metrics at a given step of the training of a fine-tuned model.
    /// </summary>
    public sealed partial class TrainingStepMetrics
    {
        /// <summary>
        /// Creation timestamp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Map of names and values for each evaluation metrics.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metrics")]
        public global::System.Collections.Generic.Dictionary<string, double>? Metrics { get; set; }

        /// <summary>
        /// Step number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step_number")]
        public int? StepNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingStepMetrics" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Creation timestamp.
        /// </param>
        /// <param name="metrics">
        /// Map of names and values for each evaluation metrics.
        /// </param>
        /// <param name="stepNumber">
        /// Step number.
        /// </param>
        public TrainingStepMetrics(
            global::System.DateTime? createdAt,
            global::System.Collections.Generic.Dictionary<string, double>? metrics,
            int? stepNumber)
        {
            this.CreatedAt = createdAt;
            this.Metrics = metrics;
            this.StepNumber = stepNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingStepMetrics" /> class.
        /// </summary>
        public TrainingStepMetrics()
        {
        }
    }
}