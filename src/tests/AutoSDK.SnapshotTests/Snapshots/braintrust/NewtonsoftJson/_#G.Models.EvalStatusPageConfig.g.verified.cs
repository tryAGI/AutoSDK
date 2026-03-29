//HintName: G.Models.EvalStatusPageConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for what data to display
    /// </summary>
    public sealed partial class EvalStatusPageConfig
    {
        /// <summary>
        /// The score columns to display on the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_columns")]
        public global::System.Collections.Generic.IList<string>? ScoreColumns { get; set; }

        /// <summary>
        /// The metric columns to display on the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric_columns")]
        public global::System.Collections.Generic.IList<string>? MetricColumns { get; set; }

        /// <summary>
        /// The metadata field to use for grouping experiments (model)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("grouping_field")]
        public string? GroupingField { get; set; }

        /// <summary>
        /// BTQL filter to apply to experiment data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Field to sort results by (format: 'score:&lt;name&gt;' or 'metric:&lt;name&gt;')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sort_by")]
        public string? SortBy { get; set; }

        /// <summary>
        /// Sort order (ascending or descending)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sort_order")]
        public global::G.EvalStatusPageConfigSortOrder? SortOrder { get; set; }

        /// <summary>
        /// The API key used for fetching experiment data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalStatusPageConfig" /> class.
        /// </summary>
        /// <param name="scoreColumns">
        /// The score columns to display on the page
        /// </param>
        /// <param name="metricColumns">
        /// The metric columns to display on the page
        /// </param>
        /// <param name="groupingField">
        /// The metadata field to use for grouping experiments (model)
        /// </param>
        /// <param name="filter">
        /// BTQL filter to apply to experiment data
        /// </param>
        /// <param name="sortBy">
        /// Field to sort results by (format: 'score:&lt;name&gt;' or 'metric:&lt;name&gt;')
        /// </param>
        /// <param name="sortOrder">
        /// Sort order (ascending or descending)
        /// </param>
        /// <param name="apiKey">
        /// The API key used for fetching experiment data
        /// </param>
        public EvalStatusPageConfig(
            global::System.Collections.Generic.IList<string>? scoreColumns,
            global::System.Collections.Generic.IList<string>? metricColumns,
            string? groupingField,
            string? filter,
            string? sortBy,
            global::G.EvalStatusPageConfigSortOrder? sortOrder,
            string? apiKey)
        {
            this.ScoreColumns = scoreColumns;
            this.MetricColumns = metricColumns;
            this.GroupingField = groupingField;
            this.Filter = filter;
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalStatusPageConfig" /> class.
        /// </summary>
        public EvalStatusPageConfig()
        {
        }
    }
}