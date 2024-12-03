//HintName: G.Models.CustomChartSeriesCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartSeriesCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::G.CustomChartSeriesFilters? Filters { get; set; }

        /// <summary>
        /// Metrics you can chart.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CustomChartMetricJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomChartMetric Metric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_key")]
        public string? FeedbackKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartSeriesCreate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="metric">
        /// Metrics you can chart.
        /// </param>
        /// <param name="feedbackKey"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CustomChartSeriesCreate(
            string name,
            global::G.CustomChartMetric metric,
            global::G.CustomChartSeriesFilters? filters,
            string? feedbackKey)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metric = metric;
            this.Filters = filters;
            this.FeedbackKey = feedbackKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartSeriesCreate" /> class.
        /// </summary>
        public CustomChartSeriesCreate()
        {
        }
    }
}