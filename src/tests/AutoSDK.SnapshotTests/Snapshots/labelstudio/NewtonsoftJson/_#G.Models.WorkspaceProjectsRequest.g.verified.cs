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
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public int Project { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceProjectsRequest" /> class.
        /// </summary>
        /// <param name="project">
        /// Project ID
        /// </param>
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