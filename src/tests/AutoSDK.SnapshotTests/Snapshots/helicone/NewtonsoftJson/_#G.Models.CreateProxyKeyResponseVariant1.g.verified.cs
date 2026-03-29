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
        [global::Newtonsoft.Json.JsonProperty("proxyKeyId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProxyKeyId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proxyKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProxyKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProxyKeyResponseVariant1" /> class.
        /// </summary>
        /// <param name="proxyKeyId"></param>
        /// <param name="proxyKey"></param>
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