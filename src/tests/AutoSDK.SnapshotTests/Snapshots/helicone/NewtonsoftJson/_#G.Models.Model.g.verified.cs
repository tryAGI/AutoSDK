//HintName: G.Models.Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeSeriesData", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelTimeSeriesData TimeSeriesData { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestStatus", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelRequestStatus RequestStatus { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("geographicTtft", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelGeographicTtftItem> GeographicTtft { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("geographicLatency", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelGeographicLatencyItem> GeographicLatency { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelFeedback Feedback { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("costs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelCosts Costs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttft", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MetricStats Ttft { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TokenMetricStats Latency { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model1 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="timeSeriesData"></param>
        /// <param name="requestStatus"></param>
        /// <param name="geographicTtft"></param>
        /// <param name="geographicLatency"></param>
        /// <param name="feedback"></param>
        /// <param name="costs"></param>
        /// <param name="ttft"></param>
        /// <param name="latency"></param>
        /// <param name="provider"></param>
        /// <param name="model1"></param>
        public Model(
            global::G.ModelTimeSeriesData timeSeriesData,
            global::G.ModelRequestStatus requestStatus,
            global::System.Collections.Generic.IList<global::G.ModelGeographicTtftItem> geographicTtft,
            global::System.Collections.Generic.IList<global::G.ModelGeographicLatencyItem> geographicLatency,
            global::G.ModelFeedback feedback,
            global::G.ModelCosts costs,
            global::G.MetricStats ttft,
            global::G.TokenMetricStats latency,
            string provider,
            string model1)
        {
            this.TimeSeriesData = timeSeriesData ?? throw new global::System.ArgumentNullException(nameof(timeSeriesData));
            this.RequestStatus = requestStatus ?? throw new global::System.ArgumentNullException(nameof(requestStatus));
            this.GeographicTtft = geographicTtft ?? throw new global::System.ArgumentNullException(nameof(geographicTtft));
            this.GeographicLatency = geographicLatency ?? throw new global::System.ArgumentNullException(nameof(geographicLatency));
            this.Feedback = feedback ?? throw new global::System.ArgumentNullException(nameof(feedback));
            this.Costs = costs ?? throw new global::System.ArgumentNullException(nameof(costs));
            this.Ttft = ttft ?? throw new global::System.ArgumentNullException(nameof(ttft));
            this.Latency = latency;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Model1 = model1 ?? throw new global::System.ArgumentNullException(nameof(model1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }
    }
}