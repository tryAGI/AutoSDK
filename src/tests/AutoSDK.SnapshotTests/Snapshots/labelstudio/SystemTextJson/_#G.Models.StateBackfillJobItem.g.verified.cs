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
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int JobId { get; set; }

        /// <summary>
        /// Project ID being backfilled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProjectId { get; set; }

        /// <summary>
        /// Redis queue job ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rq_job_id")]
        public string? RqJobId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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