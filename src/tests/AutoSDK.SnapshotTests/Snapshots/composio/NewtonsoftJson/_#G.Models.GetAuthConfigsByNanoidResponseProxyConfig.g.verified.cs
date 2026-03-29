//HintName: G.Models.GetAuthConfigsByNanoidResponseProxyConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAuthConfigsByNanoidResponseProxyConfig
    {
        /// <summary>
        /// The url of the auth proxy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proxy_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProxyUrl { get; set; } = default!;

        /// <summary>
        /// The auth key for the auth proxy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proxy_auth_key")]
        public string? ProxyAuthKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthConfigsByNanoidResponseProxyConfig" /> class.
        /// </summary>
        /// <param name="proxyUrl">
        /// The url of the auth proxy
        /// </param>
        /// <param name="proxyAuthKey">
        /// The auth key for the auth proxy
        /// </param>
        public GetAuthConfigsByNanoidResponseProxyConfig(
            string proxyUrl,
            string? proxyAuthKey)
        {
            this.ProxyUrl = proxyUrl ?? throw new global::System.ArgumentNullException(nameof(proxyUrl));
            this.ProxyAuthKey = proxyAuthKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthConfigsByNanoidResponseProxyConfig" /> class.
        /// </summary>
        public GetAuthConfigsByNanoidResponseProxyConfig()
        {
        }
    }
}