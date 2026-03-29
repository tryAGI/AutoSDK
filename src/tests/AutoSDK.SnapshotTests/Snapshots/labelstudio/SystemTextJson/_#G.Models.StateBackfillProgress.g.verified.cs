//HintName: G.Models.StateBackfillProgress.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StateBackfillProgress
    {
        /// <summary>
        /// Projects that failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_projects")]
        public int? FailedProjects { get; set; }

        /// <summary>
        /// Projects completed successfully
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful_projects")]
        public int? SuccessfulProjects { get; set; }

        /// <summary>
        /// Total entities processed so far
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_entities_processed")]
        public int? TotalEntitiesProcessed { get; set; }

        /// <summary>
        /// Total projects involved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_projects")]
        public int? TotalProjects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillProgress" /> class.
        /// </summary>
        /// <param name="failedProjects">
        /// Projects that failed
        /// </param>
        /// <param name="successfulProjects">
        /// Projects completed successfully
        /// </param>
        /// <param name="totalEntitiesProcessed">
        /// Total entities processed so far
        /// </param>
        /// <param name="totalProjects">
        /// Total projects involved
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StateBackfillProgress(
            int? failedProjects,
            int? successfulProjects,
            int? totalEntitiesProcessed,
            int? totalProjects)
        {
            this.FailedProjects = failedProjects;
            this.SuccessfulProjects = successfulProjects;
            this.TotalEntitiesProcessed = totalEntitiesProcessed;
            this.TotalProjects = totalProjects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillProgress" /> class.
        /// </summary>
        public StateBackfillProgress()
        {
        }
    }
}