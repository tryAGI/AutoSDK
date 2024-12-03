//HintName: G.Models.ActionsListWorkflowRunArtifactsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsListWorkflowRunArtifactsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifacts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Artifact> Artifacts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListWorkflowRunArtifactsResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="artifacts"></param>
        public ActionsListWorkflowRunArtifactsResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.Artifact> artifacts)
        {
            this.TotalCount = totalCount;
            this.Artifacts = artifacts ?? throw new global::System.ArgumentNullException(nameof(artifacts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListWorkflowRunArtifactsResponse" /> class.
        /// </summary>
        public ActionsListWorkflowRunArtifactsResponse()
        {
        }
    }
}