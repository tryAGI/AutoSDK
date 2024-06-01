//HintName: G.Models.ProjectsAddCollaboratorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsAddCollaboratorRequest
    {
        /// <summary>
        /// The permission to grant the collaborator.
        /// <br/>Default Value: write
        /// <br/>Example: write
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public ProjectsAddCollaboratorRequestPermission? Permission { get; set; } = ProjectsAddCollaboratorRequestPermission.Write;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}