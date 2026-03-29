//HintName: G.Models.LocalRunnerConnectResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalRunnerConnectResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_id")]
        public global::System.Guid? RunnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerConnectResponse" /> class.
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalRunnerConnectResponse(
            global::System.Guid? runnerId,
            string? workspaceId,
            global::System.Guid? projectId,
            string? projectName)
        {
            this.RunnerId = runnerId;
            this.WorkspaceId = workspaceId;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerConnectResponse" /> class.
        /// </summary>
        public LocalRunnerConnectResponse()
        {
        }
    }
}