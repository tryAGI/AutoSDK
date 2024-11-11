//HintName: G.Models.ActionsListRepoWorkflowsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsListRepoWorkflowsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflows", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Workflow> Workflows { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListRepoWorkflowsResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="workflows"></param>
        public ActionsListRepoWorkflowsResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.Workflow> workflows)
        {
            this.TotalCount = totalCount;
            this.Workflows = workflows ?? throw new global::System.ArgumentNullException(nameof(workflows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListRepoWorkflowsResponse" /> class.
        /// </summary>
        public ActionsListRepoWorkflowsResponse()
        {
        }
    }
}