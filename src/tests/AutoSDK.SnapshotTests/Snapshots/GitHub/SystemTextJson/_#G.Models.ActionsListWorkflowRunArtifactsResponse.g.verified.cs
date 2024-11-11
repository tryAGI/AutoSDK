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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Artifact> Artifacts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListWorkflowRunArtifactsResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="artifacts"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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