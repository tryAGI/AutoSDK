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
        [global::Newtonsoft.Json.JsonProperty("completed_projects", Required = global::Newtonsoft.Json.Required.Always)]
        public int CompletedProjects { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_projects", Required = global::Newtonsoft.Json.Required.Always)]
        public int FailedProjects { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_projects", Required = global::Newtonsoft.Json.Required.Always)]
        public int PendingProjects { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("running_projects", Required = global::Newtonsoft.Json.Required.Always)]
        public int RunningProjects { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_entities_processed", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalEntitiesProcessed { get; set; } = default!;

        /// <summary>
        /// Total projects in organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_projects", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalProjects { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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