//HintName: G.Models.InternalTemplateAgentCreateModelSettingsVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InternalTemplateAgentCreateModelSettingsVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_type")]
        public global::G.InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType? ProviderType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTemplateAgentCreateModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="providerType"></param>
        public InternalTemplateAgentCreateModelSettingsVariant1Discriminator(
            global::G.InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType? providerType)
        {
            this.ProviderType = providerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTemplateAgentCreateModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        public InternalTemplateAgentCreateModelSettingsVariant1Discriminator()
        {
        }
    }
}