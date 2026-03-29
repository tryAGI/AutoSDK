//HintName: G.Models.StateBackfillJobItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StateBackfillJobItem
    {
        /// <summary>
        /// Database ID of the backfill job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int JobId { get; set; } = default!;

        /// <summary>
        /// Project ID being backfilled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ProjectId { get; set; } = default!;

        /// <summary>
        /// Redis queue job ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rq_job_id")]
        public string? RqJobId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillJobItem" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Database ID of the backfill job
        /// </param>
        /// <param name="projectId">
        /// Project ID being backfilled
        /// </param>
        /// <param name="rqJobId">
        /// Redis queue job ID
        /// </param>
        public StateBackfillJobItem(
            int jobId,
            int projectId,
            string? rqJobId)
        {
            this.JobId = jobId;
            this.ProjectId = projectId;
            this.RqJobId = rqJobId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillJobItem" /> class.
        /// </summary>
        public StateBackfillJobItem()
        {
        }
    }
}