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
        [global::Newtonsoft.Json.JsonProperty("jobs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Jobs { get; set; } = default!;

        /// <summary>
        /// Number of jobs queued in this request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("jobs_queued", Required = global::Newtonsoft.Json.Required.Always)]
        public int JobsQueued { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int OrganizationId { get; set; } = default!;

        /// <summary>
        /// Projects not yet started and not currently in-flight. Relevant when num_projects is used — call POST again until this reaches 0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects_remaining", Required = global::Newtonsoft.Json.Required.Always)]
        public int ProjectsRemaining { get; set; } = default!;

        /// <summary>
        /// Projects skipped because they already have a completed backfill
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects_skipped", Required = global::Newtonsoft.Json.Required.Always)]
        public int ProjectsSkipped { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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