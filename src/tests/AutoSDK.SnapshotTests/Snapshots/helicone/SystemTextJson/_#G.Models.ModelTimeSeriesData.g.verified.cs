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
        [global::System.Text.Json.Serialization.JsonPropertyName("errorRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TimeSeriesMetric> ErrorRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TimeSeriesMetric> SuccessRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TimeSeriesMetric> Ttft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TimeSeriesMetric> Latency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTimeSeriesData" /> class.
        /// </summary>
        /// <param name="errorRate"></param>
        /// <param name="successRate"></param>
        /// <param name="ttft"></param>
        /// <param name="latency"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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