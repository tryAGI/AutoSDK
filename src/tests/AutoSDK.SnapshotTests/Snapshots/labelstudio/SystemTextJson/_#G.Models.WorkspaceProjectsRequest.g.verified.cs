//HintName: G.Models.WorkspaceProjectsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceProjectsRequest
    {
        /// <summary>
        /// Project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceProjectsRequest" /> class.
        /// </summary>
        /// <param name="project">
        /// Project ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceProjectsRequest(
            int project)
        {
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceProjectsRequest" /> class.
        /// </summary>
        public WorkspaceProjectsRequest()
        {
        }
    }
}