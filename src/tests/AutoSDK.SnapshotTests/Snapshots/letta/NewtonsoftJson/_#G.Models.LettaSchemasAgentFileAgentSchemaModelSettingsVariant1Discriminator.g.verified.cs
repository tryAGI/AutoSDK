//HintName: G.Models.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaSchemasAgentFileAgentSchemaModelSettingsVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_type")]
        public global::G.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType? ProviderType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasAgentFileAgentSchemaModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="providerType"></param>
        public LettaSchemasAgentFileAgentSchemaModelSettingsVariant1Discriminator(
            global::G.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType? providerType)
        {
            this.ProviderType = providerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasAgentFileAgentSchemaModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        public LettaSchemasAgentFileAgentSchemaModelSettingsVariant1Discriminator()
        {
        }
    }
}