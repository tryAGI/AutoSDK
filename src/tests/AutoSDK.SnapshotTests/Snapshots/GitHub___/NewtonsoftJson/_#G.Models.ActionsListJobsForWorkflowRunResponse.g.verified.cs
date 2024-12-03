//HintName: G.Models.ActionsListJobsForWorkflowRunResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsListJobsForWorkflowRunResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("jobs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Job> Jobs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListJobsForWorkflowRunResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="jobs"></param>
        public ActionsListJobsForWorkflowRunResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.Job> jobs)
        {
            this.TotalCount = totalCount;
            this.Jobs = jobs ?? throw new global::System.ArgumentNullException(nameof(jobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListJobsForWorkflowRunResponse" /> class.
        /// </summary>
        public ActionsListJobsForWorkflowRunResponse()
        {
        }
    }
}