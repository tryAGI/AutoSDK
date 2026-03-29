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
        [global::System.Text.Json.Serialization.JsonPropertyName("timeSeriesData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelTimeSeriesData TimeSeriesData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestStatus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelRequestStatus RequestStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geographicTtft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ModelGeographicTtftItem> GeographicTtft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geographicLatency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ModelGeographicLatencyItem> GeographicLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelFeedback Feedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelCosts Costs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MetricStats Ttft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TokenMetricStatsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TokenMetricStats Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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