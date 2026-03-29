//HintName: G.Models.EvalResultsQueryBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalResultsQueryBody
    {
        /// <summary>
        /// Evaluation root call IDs to include.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_call_ids")]
        public global::System.Collections.Generic.IList<string>? EvaluationCallIds { get; set; }

        /// <summary>
        /// Alias for evaluation call IDs from the Evaluation Runs API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_run_ids")]
        public global::System.Collections.Generic.IList<string>? EvaluationRunIds { get; set; }

        /// <summary>
        /// When true, only include rows present in all requested evaluations.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_intersection")]
        public bool? RequireIntersection { get; set; }

        /// <summary>
        /// When true, populate raw_data_row on each result row. Inline rows are returned as their dict value; dataset-referenced rows are returned as the ref string unless resolve_row_refs is also true.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_raw_data_rows")]
        public bool? IncludeRawDataRows { get; set; }

        /// <summary>
        /// When true (requires include_raw_data_rows=True), resolve dataset-row reference strings to actual row data via a table lookup. When false, dataset-row refs are returned as-is.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolve_row_refs")]
        public bool? ResolveRowRefs { get; set; }

        /// <summary>
        /// When true, include grouped row/trial data in `rows` and compute `total_rows` for the requested row-level view.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_rows")]
        public bool? IncludeRows { get; set; }

        /// <summary>
        /// When true, include aggregated scorer/evaluation summary data in `summary`.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_summary")]
        public bool? IncludeSummary { get; set; }

        /// <summary>
        /// Optional intersection behavior for the summary section. When null, the value of `require_intersection` is used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_require_intersection")]
        public bool? SummaryRequireIntersection { get; set; }

        /// <summary>
        /// Optional row-level page size applied after grouping and intersection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Optional row-level page offset applied after grouping and intersection.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsQueryBody" /> class.
        /// </summary>
        /// <param name="evaluationCallIds">
        /// Evaluation root call IDs to include.
        /// </param>
        /// <param name="evaluationRunIds">
        /// Alias for evaluation call IDs from the Evaluation Runs API.
        /// </param>
        /// <param name="requireIntersection">
        /// When true, only include rows present in all requested evaluations.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeRawDataRows">
        /// When true, populate raw_data_row on each result row. Inline rows are returned as their dict value; dataset-referenced rows are returned as the ref string unless resolve_row_refs is also true.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="resolveRowRefs">
        /// When true (requires include_raw_data_rows=True), resolve dataset-row reference strings to actual row data via a table lookup. When false, dataset-row refs are returned as-is.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeRows">
        /// When true, include grouped row/trial data in `rows` and compute `total_rows` for the requested row-level view.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeSummary">
        /// When true, include aggregated scorer/evaluation summary data in `summary`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="summaryRequireIntersection">
        /// Optional intersection behavior for the summary section. When null, the value of `require_intersection` is used.
        /// </param>
        /// <param name="limit">
        /// Optional row-level page size applied after grouping and intersection.
        /// </param>
        /// <param name="offset">
        /// Optional row-level page offset applied after grouping and intersection.<br/>
        /// Default Value: 0
        /// </param>
        public EvalResultsQueryBody(
            global::System.Collections.Generic.IList<string>? evaluationCallIds,
            global::System.Collections.Generic.IList<string>? evaluationRunIds,
            bool? requireIntersection,
            bool? includeRawDataRows,
            bool? resolveRowRefs,
            bool? includeRows,
            bool? includeSummary,
            bool? summaryRequireIntersection,
            int? limit,
            int? offset)
        {
            this.EvaluationCallIds = evaluationCallIds;
            this.EvaluationRunIds = evaluationRunIds;
            this.RequireIntersection = requireIntersection;
            this.IncludeRawDataRows = includeRawDataRows;
            this.ResolveRowRefs = resolveRowRefs;
            this.IncludeRows = includeRows;
            this.IncludeSummary = includeSummary;
            this.SummaryRequireIntersection = summaryRequireIntersection;
            this.Limit = limit;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsQueryBody" /> class.
        /// </summary>
        public EvalResultsQueryBody()
        {
        }
    }
}