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
        /// The permission to grant the collaborator.<br/>
        /// Default Value: write<br/>
        /// Example: write
        /// </summary>
        /// <example>write</example>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public global::G.ProjectsAddCollaboratorRequestPermission? Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsAddCollaboratorRequest" /> class.
        /// </summary>
        /// <param name="permission">
        /// The permission to grant the collaborator.<br/>
        /// Default Value: write<br/>
        /// Example: write
        /// </param>
        public ProjectsAddCollaboratorRequest(
            global::G.ProjectsAddCollaboratorRequestPermission? permission)
        {
            this.Permission = permission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsAddCollaboratorRequest" /> class.
        /// </summary>
        public ProjectsAddCollaboratorRequest()
        {
        }
    }
}