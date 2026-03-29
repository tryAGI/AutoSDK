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
        [global::System.Text.Json.Serialization.JsonPropertyName("proxyKeyName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProxyKeyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerKeyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProxyKeyRequest" /> class.
        /// </summary>
        /// <param name="proxyKeyName"></param>
        /// <param name="providerKeyId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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