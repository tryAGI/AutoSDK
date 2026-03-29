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
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborators")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PropertiesCollaboratorsItems> Collaborators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIAddWorkflowCollaboratorRequest" /> class.
        /// </summary>
        /// <param name="collaborators"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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