//HintName: G.Models.CreateAssistantDTOCredentialDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssistantDTOCredentialDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateAssistantDTOCredentialDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssistantDTOCredentialDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
        public CreateAssistantDTOCredentialDiscriminator(
            global::G.CreateAssistantDTOCredentialDiscriminatorProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssistantDTOCredentialDiscriminator" /> class.
        /// </summary>
        public CreateAssistantDTOCredentialDiscriminator()
        {
        }
    }
}