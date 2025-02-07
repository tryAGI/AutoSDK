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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Workflow> Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListRepoWorkflowsResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="workflows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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