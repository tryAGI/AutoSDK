//HintName: G.Models.CompactionSettingsInputModelSettingsVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompactionSettingsInputModelSettingsVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderTypeJsonConverter))]
        public global::G.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType? ProviderType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionSettingsInputModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="providerType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionSettingsInputModelSettingsVariant1Discriminator(
            global::G.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType? providerType)
        {
            this.ProviderType = providerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionSettingsInputModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        public CompactionSettingsInputModelSettingsVariant1Discriminator()
        {
        }
    }
}