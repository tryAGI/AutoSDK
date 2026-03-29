//HintName: G.Models.PostAuthConfigsRequestAuthConfigVariant2ProxyConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostAuthConfigsRequestAuthConfigVariant2ProxyConfig
    {
        /// <summary>
        /// The url of the auth proxy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProxyUrl { get; set; }

        /// <summary>
        /// The auth key for the auth proxy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_auth_key")]
        public string? ProxyAuthKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequestAuthConfigVariant2ProxyConfig" /> class.
        /// </summary>
        /// <param name="proxyUrl">
        /// The url of the auth proxy
        /// </param>
        /// <param name="proxyAuthKey">
        /// The auth key for the auth proxy
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostAuthConfigsRequestAuthConfigVariant2ProxyConfig(
            string proxyUrl,
            string? proxyAuthKey)
        {
            this.ProxyUrl = proxyUrl ?? throw new global::System.ArgumentNullException(nameof(proxyUrl));
            this.ProxyAuthKey = proxyAuthKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequestAuthConfigVariant2ProxyConfig" /> class.
        /// </summary>
        public PostAuthConfigsRequestAuthConfigVariant2ProxyConfig()
        {
        }
    }
}