//HintName: G.Models.OpenAPIAddWorkflowCollaboratorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIAddWorkflowCollaboratorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collaborators", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PropertiesCollaboratorsItems> Collaborators { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIAddWorkflowCollaboratorRequest" /> class.
        /// </summary>
        /// <param name="collaborators"></param>
        public OpenAPIAddWorkflowCollaboratorRequest(
            global::System.Collections.Generic.IList<global::G.PropertiesCollaboratorsItems> collaborators)
        {
            this.Collaborators = collaborators ?? throw new global::System.ArgumentNullException(nameof(collaborators));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIAddWorkflowCollaboratorRequest" /> class.
        /// </summary>
        public OpenAPIAddWorkflowCollaboratorRequest()
        {
        }
    }
}