//HintName: G.Models.CompactionSettingsOutputModelSettingsVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompactionSettingsOutputModelSettingsVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeJsonConverter))]
        public global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType? ProviderType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionSettingsOutputModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="providerType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionSettingsOutputModelSettingsVariant1Discriminator(
            global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType? providerType)
        {
            this.ProviderType = providerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionSettingsOutputModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        public CompactionSettingsOutputModelSettingsVariant1Discriminator()
        {
        }
    }
}