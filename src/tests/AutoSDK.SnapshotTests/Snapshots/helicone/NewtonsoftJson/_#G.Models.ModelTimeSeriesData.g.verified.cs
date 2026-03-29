//HintName: G.Models.ModelTimeSeriesData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelTimeSeriesData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorRate", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TimeSeriesMetric> ErrorRate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("successRate", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TimeSeriesMetric> SuccessRate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttft", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TimeSeriesMetric> Ttft { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TimeSeriesMetric> Latency { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTimeSeriesData" /> class.
        /// </summary>
        /// <param name="errorRate"></param>
        /// <param name="successRate"></param>
        /// <param name="ttft"></param>
        /// <param name="latency"></param>
        public ModelTimeSeriesData(
            global::System.Collections.Generic.IList<global::G.TimeSeriesMetric> errorRate,
            global::System.Collections.Generic.IList<global::G.TimeSeriesMetric> successRate,
            global::System.Collections.Generic.IList<global::G.TimeSeriesMetric> ttft,
            global::System.Collections.Generic.IList<global::G.TimeSeriesMetric> latency)
        {
            this.ErrorRate = errorRate ?? throw new global::System.ArgumentNullException(nameof(errorRate));
            this.SuccessRate = successRate ?? throw new global::System.ArgumentNullException(nameof(successRate));
            this.Ttft = ttft ?? throw new global::System.ArgumentNullException(nameof(ttft));
            this.Latency = latency ?? throw new global::System.ArgumentNullException(nameof(latency));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTimeSeriesData" /> class.
        /// </summary>
        public ModelTimeSeriesData()
        {
        }
    }
}