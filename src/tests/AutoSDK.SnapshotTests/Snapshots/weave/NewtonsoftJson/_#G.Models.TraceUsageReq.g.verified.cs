//HintName: G.Models.TraceUsageReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to compute per-call usage for a trace, with descendant rollup.<br/>
    /// This endpoint returns usage metrics for each call in the trace, where each<br/>
    /// call's metrics include the sum of its own usage plus all descendants' usage.<br/>
    /// Use this for trace view where you want to see rolled-up metrics per call.<br/>
    /// Note: All matching calls are loaded into memory for aggregation. For very large<br/>
    /// result sets (&gt;10k calls), consider using more specific filters or pagination<br/>
    /// at the application layer.
    /// </summary>
    public sealed partial class TraceUsageReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// Filter to select calls. Typically use trace_ids to get all calls in a trace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.CallsFilter? Filter { get; set; }

        /// <summary>
        /// Additional query conditions for filtering calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public global::G.Query? Query { get; set; }

        /// <summary>
        /// If true, include cost calculations in the usage.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_costs")]
        public bool? IncludeCosts { get; set; }

        /// <summary>
        /// Maximum number of calls to process. Acts as a safety limit to prevent unbounded memory usage.<br/>
        /// Default Value: 10000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceUsageReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="filter">
        /// Filter to select calls. Typically use trace_ids to get all calls in a trace.
        /// </param>
        /// <param name="query">
        /// Additional query conditions for filtering calls.
        /// </param>
        /// <param name="includeCosts">
        /// If true, include cost calculations in the usage.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Maximum number of calls to process. Acts as a safety limit to prevent unbounded memory usage.<br/>
        /// Default Value: 10000
        /// </param>
        public TraceUsageReq(
            string projectId,
            global::G.CallsFilter? filter,
            global::G.Query? query,
            bool? includeCosts,
            int? limit)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Filter = filter;
            this.Query = query;
            this.IncludeCosts = includeCosts;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceUsageReq" /> class.
        /// </summary>
        public TraceUsageReq()
        {
        }
    }
}