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
        [global::Newtonsoft.Json.JsonProperty("provider_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SsoProviderResponseModelProviderType ProviderType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domains", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Domains { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SsoProviderResponseModel" /> class.
        /// </summary>
        /// <param name="providerType"></param>
        /// <param name="providerId"></param>
        /// <param name="domains"></param>
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