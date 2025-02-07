//HintName: G.Models.MetricOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metrics at the step number during the fine-tuning job. Use these metrics to assess if the training is going smoothly (loss should decrease, token accuracy should increase).
    /// </summary>
    public sealed partial class MetricOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_loss")]
        public double? TrainLoss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_loss")]
        public double? ValidLoss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_mean_token_accuracy")]
        public double? ValidMeanTokenAccuracy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricOut" /> class.
        /// </summary>
        /// <param name="trainLoss"></param>
        /// <param name="validLoss"></param>
        /// <param name="validMeanTokenAccuracy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricOut(
            double? trainLoss,
            double? validLoss,
            double? validMeanTokenAccuracy)
        {
            this.TrainLoss = trainLoss;
            this.ValidLoss = validLoss;
            this.ValidMeanTokenAccuracy = validMeanTokenAccuracy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricOut" /> class.
        /// </summary>
        public MetricOut()
        {
        }
    }
}