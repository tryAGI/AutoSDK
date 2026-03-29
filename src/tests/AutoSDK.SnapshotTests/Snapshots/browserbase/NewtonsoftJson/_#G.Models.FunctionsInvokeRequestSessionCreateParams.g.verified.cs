//HintName: G.Models.FunctionsInvokeRequestSessionCreateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionsInvokeRequestSessionCreateParams
    {
        /// <summary>
        /// The uploaded Extension ID. See [Upload Extension](/reference/api/upload-an-extension).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extensionId")]
        public string? ExtensionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("browserSettings")]
        public global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettings? BrowserSettings { get; set; }

        /// <summary>
        /// Duration in seconds after which the session will automatically end. Defaults to the Project's `defaultTimeout`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Proxy configuration. Can be true for default proxy, or an array of proxy configurations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proxies")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.BrowserbaseProxyConfig, global::G.ExternalProxyConfig, global::G.NoneProxyConfig>>, bool?>? Proxies { get; set; }

        /// <summary>
        /// [NOT IN DOCS] Supplementary proxy settings. Optional.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proxySettings")]
        public global::G.FunctionsInvokeRequestSessionCreateParamsProxySettings? ProxySettings { get; set; }

        /// <summary>
        /// Arbitrary user metadata to attach to the session. To learn more about user metadata, see [User Metadata](/features/sessions#user-metadata).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userMetadata")]
        public object? UserMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequestSessionCreateParams" /> class.
        /// </summary>
        /// <param name="extensionId">
        /// The uploaded Extension ID. See [Upload Extension](/reference/api/upload-an-extension).
        /// </param>
        /// <param name="browserSettings"></param>
        /// <param name="timeout">
        /// Duration in seconds after which the session will automatically end. Defaults to the Project's `defaultTimeout`.
        /// </param>
        /// <param name="proxies">
        /// Proxy configuration. Can be true for default proxy, or an array of proxy configurations.
        /// </param>
        /// <param name="proxySettings">
        /// [NOT IN DOCS] Supplementary proxy settings. Optional.
        /// </param>
        /// <param name="userMetadata">
        /// Arbitrary user metadata to attach to the session. To learn more about user metadata, see [User Metadata](/features/sessions#user-metadata).
        /// </param>
        public FunctionsInvokeRequestSessionCreateParams(
            string? extensionId,
            global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettings? browserSettings,
            int? timeout,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.BrowserbaseProxyConfig, global::G.ExternalProxyConfig, global::G.NoneProxyConfig>>, bool?>? proxies,
            global::G.FunctionsInvokeRequestSessionCreateParamsProxySettings? proxySettings,
            object? userMetadata)
        {
            this.ExtensionId = extensionId;
            this.BrowserSettings = browserSettings;
            this.Timeout = timeout;
            this.Proxies = proxies;
            this.ProxySettings = proxySettings;
            this.UserMetadata = userMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequestSessionCreateParams" /> class.
        /// </summary>
        public FunctionsInvokeRequestSessionCreateParams()
        {
        }
    }
}