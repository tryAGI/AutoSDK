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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::G.CustomChartSeriesFilters? Filters { get; set; }

        /// <summary>
        /// Metrics you can chart. Feedback metrics are not available for organization-scoped charts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomChartMetric Metric { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_key")]
        public string? FeedbackKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartSeriesCreate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="metric">
        /// Metrics you can chart. Feedback metrics are not available for organization-scoped charts.
        /// </param>
        /// <param name="feedbackKey"></param>
        /// <param name="workspaceId"></param>
        public CustomChartSeriesCreate(
            string name,
            global::G.CustomChartMetric metric,
            global::G.CustomChartSeriesFilters? filters,
            string? feedbackKey,
            global::System.Guid? workspaceId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metric = metric;
            this.Filters = filters;
            this.FeedbackKey = feedbackKey;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartSeriesCreate" /> class.
        /// </summary>
        public CustomChartSeriesCreate()
        {
        }
    }
}