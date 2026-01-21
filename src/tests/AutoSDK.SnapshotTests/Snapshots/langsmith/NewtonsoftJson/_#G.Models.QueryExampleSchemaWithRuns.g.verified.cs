//HintName: G.Models.QueryExampleSchemaWithRuns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryExampleSchemaWithRuns
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> SessionIds { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview")]
        public bool? Preview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public string? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comparative_experiment_id")]
        public global::System.Guid? ComparativeExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sort_params")]
        public global::G.SortParamsForRunsComparisonView? SortParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryExampleSchemaWithRuns" /> class.
        /// </summary>
        /// <param name="sessionIds"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="preview">
        /// Default Value: false
        /// </param>
        /// <param name="format"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="sortParams"></param>
        /// <param name="filters"></param>
        public QueryExampleSchemaWithRuns(
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds,
            int? offset,
            int? limit,
            bool? preview,
            string? format,
            global::System.Guid? comparativeExperimentId,
            global::G.SortParamsForRunsComparisonView? sortParams,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? filters)
        {
            this.SessionIds = sessionIds ?? throw new global::System.ArgumentNullException(nameof(sessionIds));
            this.Offset = offset;
            this.Limit = limit;
            this.Preview = preview;
            this.Format = format;
            this.ComparativeExperimentId = comparativeExperimentId;
            this.SortParams = sortParams;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryExampleSchemaWithRuns" /> class.
        /// </summary>
        public QueryExampleSchemaWithRuns()
        {
        }
    }
}