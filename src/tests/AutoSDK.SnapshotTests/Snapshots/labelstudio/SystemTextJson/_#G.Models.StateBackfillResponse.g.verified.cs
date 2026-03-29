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
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.StateBackfillJobItem> Jobs { get; set; }

        /// <summary>
        /// Number of jobs queued
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs_queued")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int JobsQueued { get; set; }

        /// <summary>
        /// Status message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Organization ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OrganizationId { get; set; }

        /// <summary>
        /// Number of projects skipped because they are already completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects_skipped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProjectsSkipped { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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