//HintName: G.Models.AnomalyDetectionOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnomalyDetectionOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int InputTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetune_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int FinetuneTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mean", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> Mean { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sizes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Sizes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("intervals")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? Intervals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weights_x")]
        public global::System.Collections.Generic.IList<double>? WeightsX { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feature_contributions")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? FeatureContributions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("anomaly", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<bool> Anomaly { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyDetectionOutput" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="finetuneTokens"></param>
        /// <param name="mean"></param>
        /// <param name="sizes"></param>
        /// <param name="anomaly"></param>
        /// <param name="intervals"></param>
        /// <param name="weightsX"></param>
        /// <param name="featureContributions"></param>
        public AnomalyDetectionOutput(
            int inputTokens,
            int outputTokens,
            int finetuneTokens,
            global::System.Collections.Generic.IList<double> mean,
            global::System.Collections.Generic.IList<int> sizes,
            global::System.Collections.Generic.IList<bool> anomaly,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? intervals,
            global::System.Collections.Generic.IList<double>? weightsX,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? featureContributions)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.FinetuneTokens = finetuneTokens;
            this.Mean = mean ?? throw new global::System.ArgumentNullException(nameof(mean));
            this.Sizes = sizes ?? throw new global::System.ArgumentNullException(nameof(sizes));
            this.Intervals = intervals;
            this.WeightsX = weightsX;
            this.FeatureContributions = featureContributions;
            this.Anomaly = anomaly ?? throw new global::System.ArgumentNullException(nameof(anomaly));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyDetectionOutput" /> class.
        /// </summary>
        public AnomalyDetectionOutput()
        {
        }
    }
}