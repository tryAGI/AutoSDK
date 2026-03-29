//HintName: G.Models.CreateProxyKeyResponseVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProxyKeyResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxyKeyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProxyKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxyKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProxyKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProxyKeyResponseVariant1" /> class.
        /// </summary>
        /// <param name="proxyKeyId"></param>
        /// <param name="proxyKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProxyKeyResponseVariant1(
            string proxyKeyId,
            string proxyKey)
        {
            this.ProxyKeyId = proxyKeyId ?? throw new global::System.ArgumentNullException(nameof(proxyKeyId));
            this.ProxyKey = proxyKey ?? throw new global::System.ArgumentNullException(nameof(proxyKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProxyKeyResponseVariant1" /> class.
        /// </summary>
        public CreateProxyKeyResponseVariant1()
        {
        }
    }
}