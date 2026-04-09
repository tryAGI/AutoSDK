//HintName: G.Models.ConversationModelSettingsVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationModelSettingsVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConversationModelSettingsVariant1DiscriminatorProviderTypeJsonConverter))]
        public global::G.ConversationModelSettingsVariant1DiscriminatorProviderType? ProviderType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="providerType"></param>
        public ConversationModelSettingsVariant1Discriminator(
            global::G.ConversationModelSettingsVariant1DiscriminatorProviderType? providerType)
        {
            this.ProviderType = providerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        public ConversationModelSettingsVariant1Discriminator()
        {
        }
    }
}