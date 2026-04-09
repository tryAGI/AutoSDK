//HintName: G.Models.UpdateAssistantDTOCredentialDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAssistantDTOCredentialDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpdateAssistantDTOCredentialDiscriminatorProviderJsonConverter))]
        public global::G.UpdateAssistantDTOCredentialDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssistantDTOCredentialDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
        public UpdateAssistantDTOCredentialDiscriminator(
            global::G.UpdateAssistantDTOCredentialDiscriminatorProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssistantDTOCredentialDiscriminator" /> class.
        /// </summary>
        public UpdateAssistantDTOCredentialDiscriminator()
        {
        }
    }
}