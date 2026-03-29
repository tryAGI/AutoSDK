//HintName: G.Models.CallsUsageReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to compute aggregated usage for multiple root calls.<br/>
    /// This endpoint returns usage metrics for each requested root call, where each<br/>
    /// root's metrics include the sum of its own usage plus all descendants' usage.<br/>
    /// Note: All matching calls are loaded into memory for aggregation. For very large<br/>
    /// result sets (&gt;10k calls), consider batching root call IDs or using narrower<br/>
    /// filters at the application layer.
    /// </summary>
    public sealed partial class CallsUsageReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Root call IDs to aggregate. Each result key corresponds to one input call ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CallIds { get; set; }

        /// <summary>
        /// If true, include cost calculations in the usage.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_costs")]
        public bool? IncludeCosts { get; set; }

        /// <summary>
        /// Maximum number of calls to process across all traces. Acts as a safety limit to prevent unbounded memory usage.<br/>
        /// Default Value: 10000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallsUsageReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="callIds">
        /// Root call IDs to aggregate. Each result key corresponds to one input call ID.
        /// </param>
        /// <param name="includeCosts">
        /// If true, include cost calculations in the usage.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Maximum number of calls to process across all traces. Acts as a safety limit to prevent unbounded memory usage.<br/>
        /// Default Value: 10000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallsUsageReq(
            string projectId,
            global::System.Collections.Generic.IList<string> callIds,
            bool? includeCosts,
            int? limit)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.CallIds = callIds ?? throw new global::System.ArgumentNullException(nameof(callIds));
            this.IncludeCosts = includeCosts;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallsUsageReq" /> class.
        /// </summary>
        public CallsUsageReq()
        {
        }
    }
}