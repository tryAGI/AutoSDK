//HintName: G.Models.WorkspaceMetricsSummaryRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceMetricsSummaryRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ProjectIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime IntervalStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime IntervalEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_before_end")]
        public bool? StartBeforeEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMetricsSummaryRequest" /> class.
        /// </summary>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="projectIds"></param>
        /// <param name="startBeforeEnd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceMetricsSummaryRequest(
            global::System.DateTime intervalStart,
            global::System.DateTime intervalEnd,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds,
            bool? startBeforeEnd)
        {
            this.ProjectIds = projectIds;
            this.IntervalStart = intervalStart;
            this.IntervalEnd = intervalEnd;
            this.StartBeforeEnd = startBeforeEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMetricsSummaryRequest" /> class.
        /// </summary>
        public WorkspaceMetricsSummaryRequest()
        {
        }
    }
}