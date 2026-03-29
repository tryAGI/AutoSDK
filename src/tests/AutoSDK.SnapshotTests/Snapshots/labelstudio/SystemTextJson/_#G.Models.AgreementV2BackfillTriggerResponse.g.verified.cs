//HintName: G.Models.AgreementV2BackfillTriggerResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from POST /api/dimensions/backfill/
    /// </summary>
    public sealed partial class AgreementV2BackfillTriggerResponse
    {
        /// <summary>
        /// Queued jobs: [{job_id, rq_job_id, project_id}]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Jobs { get; set; }

        /// <summary>
        /// Number of jobs queued in this request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs_queued")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int JobsQueued { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OrganizationId { get; set; }

        /// <summary>
        /// Projects not yet started and not currently in-flight. Relevant when num_projects is used — call POST again until this reaches 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects_remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProjectsRemaining { get; set; }

        /// <summary>
        /// Projects skipped because they already have a completed backfill
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
        /// Initializes a new instance of the <see cref="AgreementV2BackfillTriggerResponse" /> class.
        /// </summary>
        /// <param name="jobs">
        /// Queued jobs: [{job_id, rq_job_id, project_id}]
        /// </param>
        /// <param name="jobsQueued">
        /// Number of jobs queued in this request
        /// </param>
        /// <param name="message"></param>
        /// <param name="organizationId"></param>
        /// <param name="projectsRemaining">
        /// Projects not yet started and not currently in-flight. Relevant when num_projects is used — call POST again until this reaches 0.
        /// </param>
        /// <param name="projectsSkipped">
        /// Projects skipped because they already have a completed backfill
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgreementV2BackfillTriggerResponse(
            global::System.Collections.Generic.IList<object> jobs,
            int jobsQueued,
            string message,
            int organizationId,
            int projectsRemaining,
            int projectsSkipped)
        {
            this.Jobs = jobs ?? throw new global::System.ArgumentNullException(nameof(jobs));
            this.JobsQueued = jobsQueued;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.OrganizationId = organizationId;
            this.ProjectsRemaining = projectsRemaining;
            this.ProjectsSkipped = projectsSkipped;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementV2BackfillTriggerResponse" /> class.
        /// </summary>
        public AgreementV2BackfillTriggerResponse()
        {
        }
    }
}