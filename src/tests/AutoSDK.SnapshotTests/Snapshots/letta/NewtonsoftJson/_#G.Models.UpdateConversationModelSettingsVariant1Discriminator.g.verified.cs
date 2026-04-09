//HintName: G.Models.UpdateConversationModelSettingsVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConversationModelSettingsVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpdateConversationModelSettingsVariant1DiscriminatorProviderTypeJsonConverter))]
        public global::G.UpdateConversationModelSettingsVariant1DiscriminatorProviderType? ProviderType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversationModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="providerType"></param>
        public UpdateConversationModelSettingsVariant1Discriminator(
            global::G.UpdateConversationModelSettingsVariant1DiscriminatorProviderType? providerType)
        {
            this.ProviderType = providerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversationModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        public UpdateConversationModelSettingsVariant1Discriminator()
        {
        }
    }
}