//HintName: G.Models.SsoProviderResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SsoProviderResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SsoProviderResponseModelProviderTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SsoProviderResponseModelProviderType ProviderType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Domains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SsoProviderResponseModel" /> class.
        /// </summary>
        /// <param name="providerType"></param>
        /// <param name="providerId"></param>
        /// <param name="domains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SsoProviderResponseModel(
            global::G.SsoProviderResponseModelProviderType providerType,
            string providerId,
            global::System.Collections.Generic.IList<string> domains)
        {
            this.ProviderType = providerType;
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.Domains = domains ?? throw new global::System.ArgumentNullException(nameof(domains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SsoProviderResponseModel" /> class.
        /// </summary>
        public SsoProviderResponseModel()
        {
        }
    }
}