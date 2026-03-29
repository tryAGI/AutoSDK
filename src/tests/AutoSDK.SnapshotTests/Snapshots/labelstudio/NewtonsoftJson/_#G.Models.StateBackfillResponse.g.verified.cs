//HintName: G.Models.StateBackfillResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StateBackfillResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("jobs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.StateBackfillJobItem> Jobs { get; set; } = default!;

        /// <summary>
        /// Number of jobs queued
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("jobs_queued", Required = global::Newtonsoft.Json.Required.Always)]
        public int JobsQueued { get; set; } = default!;

        /// <summary>
        /// Status message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Organization ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int OrganizationId { get; set; } = default!;

        /// <summary>
        /// Number of projects skipped because they are already completed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects_skipped", Required = global::Newtonsoft.Json.Required.Always)]
        public int ProjectsSkipped { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillResponse" /> class.
        /// </summary>
        /// <param name="jobs"></param>
        /// <param name="jobsQueued">
        /// Number of jobs queued
        /// </param>
        /// <param name="message">
        /// Status message
        /// </param>
        /// <param name="organizationId">
        /// Organization ID
        /// </param>
        /// <param name="projectsSkipped">
        /// Number of projects skipped because they are already completed
        /// </param>
        public StateBackfillResponse(
            global::System.Collections.Generic.IList<global::G.StateBackfillJobItem> jobs,
            int jobsQueued,
            string message,
            int organizationId,
            int projectsSkipped)
        {
            this.Jobs = jobs ?? throw new global::System.ArgumentNullException(nameof(jobs));
            this.JobsQueued = jobsQueued;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.OrganizationId = organizationId;
            this.ProjectsSkipped = projectsSkipped;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillResponse" /> class.
        /// </summary>
        public StateBackfillResponse()
        {
        }
    }
}