//HintName: G.Models.StateBackfillOrgStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StateBackfillOrgStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletedProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PendingProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunningProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_entities_processed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalEntitiesProcessed { get; set; }

        /// <summary>
        /// Total projects in organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalProjects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillOrgStatus" /> class.
        /// </summary>
        /// <param name="completedProjects"></param>
        /// <param name="failedProjects"></param>
        /// <param name="pendingProjects"></param>
        /// <param name="runningProjects"></param>
        /// <param name="totalEntitiesProcessed"></param>
        /// <param name="totalProjects">
        /// Total projects in organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StateBackfillOrgStatus(
            int completedProjects,
            int failedProjects,
            int pendingProjects,
            int runningProjects,
            int totalEntitiesProcessed,
            int totalProjects)
        {
            this.CompletedProjects = completedProjects;
            this.FailedProjects = failedProjects;
            this.PendingProjects = pendingProjects;
            this.RunningProjects = runningProjects;
            this.TotalEntitiesProcessed = totalEntitiesProcessed;
            this.TotalProjects = totalProjects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillOrgStatus" /> class.
        /// </summary>
        public StateBackfillOrgStatus()
        {
        }
    }
}