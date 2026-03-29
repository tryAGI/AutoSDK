//HintName: G.Models.UpdateWorkflowDTOCredentialDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateWorkflowDTOCredentialDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.UpdateWorkflowDTOCredentialDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorkflowDTOCredentialDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
        public UpdateWorkflowDTOCredentialDiscriminator(
            global::G.UpdateWorkflowDTOCredentialDiscriminatorProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorkflowDTOCredentialDiscriminator" /> class.
        /// </summary>
        public UpdateWorkflowDTOCredentialDiscriminator()
        {
        }
    }
}