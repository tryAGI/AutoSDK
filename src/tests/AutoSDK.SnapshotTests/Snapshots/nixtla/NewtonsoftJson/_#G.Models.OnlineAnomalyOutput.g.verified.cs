//HintName: G.Models.OnlineAnomalyOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OnlineAnomalyOutput
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
        [global::Newtonsoft.Json.JsonProperty("idxs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Idxs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("anomaly", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<bool> Anomaly { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("anomaly_score", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> AnomalyScore { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accumulated_anomaly_score")]
        public global::System.Collections.Generic.IList<double>? AccumulatedAnomalyScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("intervals")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? Intervals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineAnomalyOutput" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="finetuneTokens"></param>
        /// <param name="mean"></param>
        /// <param name="sizes"></param>
        /// <param name="idxs"></param>
        /// <param name="anomaly"></param>
        /// <param name="anomalyScore"></param>
        /// <param name="accumulatedAnomalyScore"></param>
        /// <param name="intervals"></param>
        public OnlineAnomalyOutput(
            int inputTokens,
            int outputTokens,
            int finetuneTokens,
            global::System.Collections.Generic.IList<double> mean,
            global::System.Collections.Generic.IList<int> sizes,
            global::System.Collections.Generic.IList<int> idxs,
            global::System.Collections.Generic.IList<bool> anomaly,
            global::System.Collections.Generic.IList<double> anomalyScore,
            global::System.Collections.Generic.IList<double>? accumulatedAnomalyScore,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? intervals)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.FinetuneTokens = finetuneTokens;
            this.Mean = mean ?? throw new global::System.ArgumentNullException(nameof(mean));
            this.Sizes = sizes ?? throw new global::System.ArgumentNullException(nameof(sizes));
            this.Idxs = idxs ?? throw new global::System.ArgumentNullException(nameof(idxs));
            this.Anomaly = anomaly ?? throw new global::System.ArgumentNullException(nameof(anomaly));
            this.AnomalyScore = anomalyScore ?? throw new global::System.ArgumentNullException(nameof(anomalyScore));
            this.AccumulatedAnomalyScore = accumulatedAnomalyScore;
            this.Intervals = intervals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineAnomalyOutput" /> class.
        /// </summary>
        public OnlineAnomalyOutput()
        {
        }
    }
}