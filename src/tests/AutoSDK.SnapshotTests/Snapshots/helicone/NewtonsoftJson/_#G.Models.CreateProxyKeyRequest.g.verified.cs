//HintName: G.Models.CreateProxyKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProxyKeyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proxyKeyName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProxyKeyName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerKeyId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderKeyId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProxyKeyRequest" /> class.
        /// </summary>
        /// <param name="proxyKeyName"></param>
        /// <param name="providerKeyId"></param>
        public CreateProxyKeyRequest(
            string proxyKeyName,
            string providerKeyId)
        {
            this.ProxyKeyName = proxyKeyName ?? throw new global::System.ArgumentNullException(nameof(proxyKeyName));
            this.ProviderKeyId = providerKeyId ?? throw new global::System.ArgumentNullException(nameof(providerKeyId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProxyKeyRequest" /> class.
        /// </summary>
        public CreateProxyKeyRequest()
        {
        }
    }
}