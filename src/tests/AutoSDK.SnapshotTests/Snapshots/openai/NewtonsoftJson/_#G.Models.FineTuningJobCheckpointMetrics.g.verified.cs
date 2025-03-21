//HintName: G.Models.FineTuningJobCheckpointMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metrics at the step number during the fine-tuning job.
    /// </summary>
    public sealed partial class FineTuningJobCheckpointMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_valid_loss")]
        public double? FullValidLoss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_valid_mean_token_accuracy")]
        public double? FullValidMeanTokenAccuracy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step")]
        public double? Step { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("train_loss")]
        public double? TrainLoss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("train_mean_token_accuracy")]
        public double? TrainMeanTokenAccuracy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valid_loss")]
        public double? ValidLoss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valid_mean_token_accuracy")]
        public double? ValidMeanTokenAccuracy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobCheckpointMetrics" /> class.
        /// </summary>
        /// <param name="fullValidLoss"></param>
        /// <param name="fullValidMeanTokenAccuracy"></param>
        /// <param name="step"></param>
        /// <param name="trainLoss"></param>
        /// <param name="trainMeanTokenAccuracy"></param>
        /// <param name="validLoss"></param>
        /// <param name="validMeanTokenAccuracy"></param>
        public FineTuningJobCheckpointMetrics(
            double? fullValidLoss,
            double? fullValidMeanTokenAccuracy,
            double? step,
            double? trainLoss,
            double? trainMeanTokenAccuracy,
            double? validLoss,
            double? validMeanTokenAccuracy)
        {
            this.FullValidLoss = fullValidLoss;
            this.FullValidMeanTokenAccuracy = fullValidMeanTokenAccuracy;
            this.Step = step;
            this.TrainLoss = trainLoss;
            this.TrainMeanTokenAccuracy = trainMeanTokenAccuracy;
            this.ValidLoss = validLoss;
            this.ValidMeanTokenAccuracy = validMeanTokenAccuracy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobCheckpointMetrics" /> class.
        /// </summary>
        public FineTuningJobCheckpointMetrics()
        {
        }
    }
}