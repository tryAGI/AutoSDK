//HintName: G.Models.UpdateAgentModelSettingsVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAgentModelSettingsVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpdateAgentModelSettingsVariant1DiscriminatorProviderTypeJsonConverter))]
        public global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType? ProviderType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="providerType"></param>
        public UpdateAgentModelSettingsVariant1Discriminator(
            global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType? providerType)
        {
            this.ProviderType = providerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        public UpdateAgentModelSettingsVariant1Discriminator()
        {
        }
    }
}